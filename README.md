#Strategy pattern
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

#Observer pattern
Defines a one-to-many dependecy between objects so that when one object change state, all of its dependents are notified and updated automatically.
>Strive for loosely coupled designs between objects that interact (Luchar por diseños débilmente acoplados entre los objetos que interactúan)

