#Head First Design Patterns

##Strategy pattern
Defines a family of algorithms, encapsulates each algorithm, and makes the algorithms interchangeable within that family.
####HAS-A can be better than IS-A
Each duck has a FlyBehavior/ QuackBehavior, this is composition. Instead of inheriting their behavior, the ducks get their behavior by being composed.
>Favor composition over inheritance (favorecer la composición sobre la herencia)

1. OO Basics
	* Abstraction
	* Encapsulation
	* Polymorphism
	* Inheritance
2. OO Principles
	* Encapsulate what varies
	* Favor composition over inheritance
	* Program to interfaces, not implementations

##Observer pattern
Defines a one-to-many dependecy between objects so that when one object change state, all of its dependents are notified and updated automatically.
>Strive for loosely coupled designs between objects that interact (Luchar por diseños débilmente acoplados entre los objetos que interactúan)

##Decorator pattern
Attaches additional responsabilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
>Classes should be open for extension, but closed for modification. Allow classes to be easily extended to incorporate new behavior without modifying existing code.

##Factory method pattern
Defines an interface for creating an object, but lets subclasses decide wich class to instantiate. Factory method lets a class defer instantiation to subclasses.

All factory patterns encapsulate object creation.

Simple factory method. Not a pattern.
Factory method. Handles object creation and encapsulates it in a subclass.
    
    abstract Product FactoryMethod (string type)

Factory method pattern. Encapsulates object creation by letting subclasses decide what objects to create.
>Depend upon abstractions. Do not depend upon concrete classes.

##Singleton pattern
Ensures a class has only one instance, and provides a global point of access to it.

##Command pattern
Encapsulates a request as an object, thereby letting your parameterize other objects with different request, queue or log request.

##Adapter pattern
Converts the interface of a class into another interface the client expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.