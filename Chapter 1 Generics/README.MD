# Generics

### 1. Generics are classes that have a type parameter.
Generics were introduced after .NET v1. If you wanted to store books in a list the below class wouldn't work.
We would have to create another class which we will had Add books. For every type we would have to create a seperate list.
 
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
### 2. Why we need them?

	Without generics we will have the following problems :
    - Problem in simple data manipulation (insert, update, delete) of conditioned rows.
    - The chances of column mismatch is high.
    - A lot of boxing and unboxing
    - No type-safety
	 

### 3. With generics we create a class once and use it multiple times.
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
	
### 4. In general you don't have to create generics classes or methods. You just have to use them.
The Generic List is part of the .NET framework.
They are in Systems.Collections.Generic.

### 5. We have also Dictionaries 
A Dictionary is a data type that stores and retrieves objects. It's a very fast and efficient way of storing objects.

Check the project Generics.


### 6. We can create a generic method in a non generic class. That works perfectly fine as you see in out project.
A great example can be found at https://www.dotnetperls.com/generic .

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

Check generic_property.jpg to see that we get the property of the class Product.

Another great explanation https://stackoverflow.com/questions/2642598/generics-vs-inheritance-when-no-collection-classes-are-involved
