Creational design patterns:

1.      **Singleton** – ensures that only one instance
of a class can be created and that there is a global access point to it. The
object is created only if/when it is needed. This can be achieved by:

  -         
Making the constructor private and adding a private
static constructor

  -         
Making private static read-only object that is
instantiated inside the class using the private constructor

  -         
Adding public static property that accesses the
private static read-only object

Singleton is not thread-safe –
different threads may try to instantiate the class simultaneously.

Lazy instantiation – the singleton
has to be instantiated when it will be used, not before that, and certainly not
after that J

The instantiation will be triggered
by the first reference to the static member.

2.      **Factory Method Pattern** – a way of
creating new objects of the class. It is
used when a class has different subclasses and one of them has to be
instantiated, depending on some conditions. The factory method instantiates the
parent class, and its subclasses decide which class to instantiate. The factory
also encapsulates the logic of creating the objects.

3.      **Abstract Factory Pattern** – a
factory interface / abstract factory which declares operations that create
abstract products without knowing their concrete classes. It provides
abstraction in object creation and makes it very easy to change one class that inherits the abstract product with another. In the example I have given, with the help of the abstract factory pattern, two different classes, inheriting the parent FirstSecondParent class are created, without being explicitly named. Thus, it is easy to change or add new classes, inheriting the FirstSecondParent and create instances of them.
