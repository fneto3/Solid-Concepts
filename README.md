# Solid Principles!

I create this project to use on a Tech Talk about Solid, it's a simple Hello World. The concept here is simple, i need a Class that format some message to print on Console and i need other Class that Log the time that this happened on a Memory Cache.

## Installation

- Visual Studio Community 2019 (or other versions)
- .Net Core 3.1

# Usage

Open solution `SolidConcepts.sln` and run!

You can find more informations about SOLID here [SOLID Pattern, you'll want to use!](https://www.linkedin.com/pulse/solid-pattern-youll-want-use-fernando-jose-oliveira-lima-neto/)

# About Solid Principles

## Single Responsibility

Each class, interface, structure and methods, have to do only what is supposed to do, the class can’t be generic and do many things, they have one responsibility and need to do that.

##### Message Class 
This class print the message in a specific format, respecting the contrat `IMessage`, this class have the Single Responsibility that is print the message.

##### Log Message Class 
This class print the message in a specific format and log on cache the time, respecting the contrat `IMessage`, this class have the Single Responsibility that is print the message and Log.

Both class can do another things, like generate a report with the message, identify the user that call the function, or another thing, if we do this, we will not be respecting the principle.

## Open Closed Principle
This concept say that a module is open for extension and closed for modification, this concept means that we can improve a class, but we cannot make any changes on base to improve them, except when exist a bug on this class.

We can see this at this project, we create a class to print the message called Message, but we need to improve this with log, then we created the LogMessage class, that is based on Message but include the Logs. With this, we create a extension of our feature without modifying the base class.

## Liskov Substitution

Derived classes must be replaceable with their base classes. 

What this means?

If you have a base class, the class that implements this base class must respect the definition of a base class, for example, when you use the object Message and LogMessage both receive a message input and the output is the same, the message in a specific format.

## Interface Segregation

Any child class should not be forced to use an interface which is not relevant to it.

I need to do some logs on Cache, i can put this on IMessage, but the class Message is responsible only to Print the message, so i created ICache interface to do this.

## Dependency Inversion

We should never write coupled code, because systems will grow, and maintain this code is very difficult.

So we can create Interfaces for the features, respecting the principles, so we can extend the software and features.