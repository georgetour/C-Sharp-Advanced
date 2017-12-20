# Generics

### 1. Generics are classes that have a **type parameter** .
They simply don't care for types since you declare them when you instantiating them.
Generics were introduced after .NET v1. If you wanted to store books in a list the below class wouldn't work.
We would have to create another class which we will had Add books. ** For every type we would have to create a seperate class. **

Simple examples for generics https://www.youtube.com/watch?v=ZrjCG0Fu5Ew

#### Without generics 

	 public class BookList
	 {
		public void Add(int number)
		{
			throw New NotImplementedException();
		}
		
		public Book this[int index]
		{
			get {throw New NotImplementedException();}
		}
	 
	 }

	 
	 public class List
	 {
		public void Add(int number)
		{
			throw New NotImplementedException();
		}
		
		public int this[int index]
		{
			get {throw New NotImplementedException();}
		}
	 }
	 
	 class Program
    {

        static void Main(string[] args)
        {
            //The problem here is we have two different types of Lists
            var number = new List();
            number.Add(19);

            var books= new Book();
            books.Add(book);
        }
    }
	
#### With generics with pass any type we want as parameter in instantiation

	public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this [int index]
        {
            get { throw new NotImplementedException(); }
        } 
    }
	
	class Program
    {

        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(100);

            var books = new GenericList<Book>();
            books.Add(book);
        }
    }
	
	 
### 2. Why we need them?

	Another great explanation https://stackoverflow.com/questions/2642598/generics-vs-inheritance-when-no-collection-classes-are-involved

	**Loose coupling**

	Without generics we will have the following problems :
    - Problem in simple data manipulation (insert, update, delete) of conditioned rows.
    - The chances of column mismatch is high.
    - A lot of boxing and unboxing
    - No type-safety
	 

### 3. Reusability and Example
With generics we create a class once and use it multiple times
We usually call them T as for template or type and the syntax is as below.	 

Example 

	public class GenericList<T>
	{
		public void Add(T value)
		{
		
		}
		
		public T this[int index]
		{
			get {throw New NotImplementedException();}
		}
	
	}
	
### 4. Generic List
In general you don't have to create generics classes or methods. You just have to use them.
The Generic List is part of the .NET framework.
They are in Systems.Collections.Generic.

### 5. Dictionaries 
A Dictionary is a data type that stores and retrieves objects. It's a very fast and efficient way of storing objects.
We can say a Dictionary is a list of keys and their values.

Check the project GenericsV2 and http://csharp.net-informations.com/collection/dictionary.htm 

### 6. Generic methods 
You can create them in a non generic class with no problem.
That works perfectly fine as you see in our project.

Check the project GenericMethods.


### 7. Constraints and where keyword
If we want to examine an in a generic list to determine whether it is valid or to compare it with some 
other the compiler must be sure that we have similar objects.


Syntax

		public T Max<T>(T a, T b) where T : IComparable
        {
            //We have an error since the compiler doesn't know about a and b. They are both objects
            //return a > b ? a : b;

            return a.CompareTo(b) > 0 ? a : b;
        }
		
### 8. Types of constraints

where T : IComparable

where T : class

where T :struct

where T : NameOfClass

where T : new() //an object that has default constructor

As https://www.dotnetperls.com/generic says generic constraints are rarely used.

Check generic_property.jpg to see that we get the property of the class Product.


