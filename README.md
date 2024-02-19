# Relationships In OOP

Object oriented programming generally support 4 types of relationships that are: ***inheritance*** , ***association***, ***composition*** and ***aggregation***. All these relationship is based on ***"is a"*** relationship, ***"has a"*** relationship and ***"part of"*** relationship.

**Inheritance:**<br>
Inheritance is “IS-A” type of relationship. “IS-A” relationship is a totally based on Inheritance, which can be of two types Class Inheritance or Interface Inheritance. Inheritance is a parent-child relationship where we create a new class by using existing class code. It is just like saying that “A is type of B”. For example is “Apple is a fruit”, “Ferrari is a car”.

![Inheritance Relationship](https://github.com/Muhammad-Ohee/Relationships-In-OOP/assets/87231565/a03b69cb-f398-44b5-94d1-6dab65b17b3f)

**Composition:**<br>

Composition is a "part-of" relationship. Simply composition means mean use of instance variables that are references to other objects. In composition relationship both entities are interdependent of each other for example “engine is part of car”, “heart is part of body”.

Let us take an example of car and engine. Engine is a part of each car and both are dependent on each other.

![Composition Relationship](https://github.com/Muhammad-Ohee/Relationships-In-OOP/assets/87231565/c7c27f16-ae9e-4214-97fc-a2da847ba05c)

**Association:**<br>

Association is a “has-a” type relationship. Association establish the relationship b/w two classes using through their objects. Association relationship can be one to one, One to many, many to one and many to many. For example suppose we have two classes then these two classes are said to be “has-a” relationship if both of these entities share each other’s object for some work and at the same time they can exists without each others dependency or both have their own life time.

![Association Relationship](https://github.com/Muhammad-Ohee/Relationships-In-OOP/assets/87231565/3529db12-9154-4e17-a571-b7a9dc066d2a)

**Aggregation:**<br>

Aggregation is based is on "has-a" relationship. Aggregation is a special form of association. In association there is not any classes (entity) work as owner but in aggregation one entity work as owner. In aggregation both entities meet for some work and then get separated. Aggregation is a one way association.
