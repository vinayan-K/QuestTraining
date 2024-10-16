## Inheritance in C#

Inheritance is one of the key features of OOPs, and C# language is a modern  object-oriented programming language.Acquiring (taking) the properties of one class into another is called inheritance. Code reusability is one of the key features of OOPs, and it is achieved via inheritance. Using inheritance, one or more classes can derive from an existing class. The existing class is called a base class, and the inherited class is called a derived or inherited class.
The inheritance concept is based on a base class and its derived classes. Let us see the definition of base and derived classes.

-   Base class - the class from which features are to be inherited into another class.
-   Derived class - the class that is inherited from the base class.

The following are the types of inheritance in C#.
### Single inheritance in C#

It is the type of inheritance in which there is one base class and one derived class.
Example:

    public class Accountcreditinfo //base class
    {
        public string Credit()
        {
            return "balance is credited";
        }
    }
    public class debitinfo : Accountcreditinfo //derived class
    {
        public string debit()
        {
            Credit();                       ////derived class method
            return "balance is debited";
        }
    }
### Hierarchical inheritance in C#

This is the type of inheritance in which there are multiple classes derived from one base class. This type of inheritance is used when there is a requirement of one class feature that is needed in multiple classes.
Example:

    class A  //base class
    {
        public string msg()
        {
            return "this is A class Method";
        }
    }
    class B : A
    {
        public string info()
        {
            msg();
            return "this is B class Method";
        }
        class C : A
        {
            public string getinfo()
            {
                msg();
                return "this is B class Method";
            }
        }
    }

### Multilevel inheritance in C#

When one class is derived from another, this type of inheritance is called multilevel inheritance.
Example:

    public class Person
    {
        public string persondet()
        {
            return "this is the person class";
        }
    }
    public class Bird : Person
    {
        public string birddet()
        {
            persondet();
            return "this is the birddet Class";
        }
    }
    public class Animal : Bird
    {
        public string animaldet()
        {
            persondet();
            birddet();
            return "this is the Animal Class";
        }
    }

### Multiple inheritances using Interfaces

C# does not support multiple inheritances of classes. To overcome this problem, we can use interfaces. We will see more about interfaces in my next article in detail.
Example:

    public interface IA //ineterface  1
    {
        string setImgs(string a);
    }
    public interface IB  //Interface 2
    {
        int getAmount(int Amt);
    }
    public class ICar : IA, IB //implementatin
    {
        public int getAmount(int Amt)
        {
            return 100;
        }
        public string setImgs(string a)
        {
            return "this is the car";
        }
    }

