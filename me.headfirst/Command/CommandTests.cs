using System;
using System.Collections.Generic;
using me.headfirst.Command.First;
using me.headfirst.Command.First.Commands;
using me.headfirst.Command.First.Devices;
using me.headfirst.Command.Second;
using me.headfirst.Command.Second.CommandFactory;
using me.headfirst.Command.Third;
using NUnit.Framework;
using ICommand = me.headfirst.Command.First.ICommand;

namespace me.headfirst.Command
{
    public class CommandTests
    {
        [Test]
        public void SimpleRemoteControlTest()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light("Garage");
            var lightOnCommand = new LightOnCommand(light);

            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
        }

        [Test]
        public void RemoteControlTest()
        {
            var remote = new RemoteControl();

            //Devices
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Stereo stereo = new Stereo("Living Room");

            //Commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            StereoOnWithCDCommand stereoOnWithCd = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            //Remote slots
            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, stereoOnWithCd, stereoOff);

            remote.OnButtonWasPushed(0);
            remote.UndoButtonWasPushed();
        }

        [Test]
        public void CeilingFanRemoteTest()
        {
            var remote = new RemoteControl();

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            var highCommand = new CeilingFanHighCommand(ceilingFan);
            var mediumCommand = new CeilingFanMediumCommand(ceilingFan);
            var lowCommand = new CeilingFanLowCommand(ceilingFan);
            var offCommand = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, highCommand, offCommand);
            remote.SetCommand(1, mediumCommand, offCommand);
            remote.SetCommand(2, lowCommand, offCommand);

            remote.OnButtonWasPushed(0);
            Assert.AreEqual(ceilingFan.GetSpeed(), CeilingFan.HIGH);
            remote.OffButtonWasPushed(0);
            Assert.AreEqual(ceilingFan.GetSpeed(), CeilingFan.OFF);
            remote.UndoButtonWasPushed();
            Assert.AreEqual(ceilingFan.GetSpeed(), CeilingFan.HIGH);
        }

        [Test]
        public void MacroCommandTest()
        {
            var remote = new RemoteControl();

            //Devices
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Stereo stereo = new Stereo("Living Room");

            //Commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            StereoOnWithCDCommand stereoOnWithCd = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            //Macro commands
            var welcomeCommands = new List<ICommand> { livingRoomLightOn, kitchenLightOn, stereoOnWithCd };
            var goOutCommands = new List<ICommand> { livingRoomLightOff, kitchenLightOff, stereoOff };
            MacroCommand welcomeMacro = new MacroCommand(welcomeCommands);
            MacroCommand goOutMacro = new MacroCommand(goOutCommands);
            remote.SetCommand(0, welcomeMacro, goOutMacro);

            remote.OnButtonWasPushed(0);
        }

        [Test]
        public void CommandFactoryTest()
        {
            var factory = new CommandFactory();
            factory.Register("Foo", () => new Foo().DoSomething());
            factory.Register("Bar", () => new Bar().DoSomething());
            factory.Execute("Foo");
        }

        [Test]
        public void ComandTest()
        {
            var factory = new CommandFactory2();
            factory.Register("A", new Lazy<CommandWithUndo>(
                () =>
                {
                    var a = new A();
                    return new CommandWithUndo(a.DoA, a.UndoA);
                }));

            factory.Register("B", new Lazy<CommandWithUndo>(
                () =>
                {
                    var b = new B();
                    return new CommandWithUndo(b.DoB, b.DoB);
                }));

            factory.Register("C", new Lazy<CommandWithUndo>(
                () => new CommandWithUndo(DoStuff, UndoStuff)));

            factory.Execute("C");
            factory.Undo("C");
        }

        /// <summary>
        /// //This is the class that creates and executes the command object.
        /// </summary>
        [Test]
        public void CommandClientTest()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver)
            {
                Parameter = "Dot Net Tricks !!"
            };
            invoker.Command = command;
            invoker.ExecuteCommand();
        }

        private static void DoStuff()
        {
            Console.WriteLine("Do Stuff");
        }

        private static void UndoStuff()
        {
            Console.WriteLine("Undo Stuff");
        }
    }
}
