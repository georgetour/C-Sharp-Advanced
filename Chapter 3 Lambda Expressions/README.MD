# Lambda Expressions
Lambda expressions are just anonymous methods. They have :

- No access modifier(public/private)
- No name
- No return statement

A lambda expression must be assigned to a delegate.
The syntax is first the arguments then the lambda operator then the expression.

1. Syntax

 - No arguments
 // () => ...
 
 - One argument
 // x => ...
 
 - Multiple arguments
 // (x, y, z) => ...

2. Example

	delegate int del(int i);  
	static void Main(string[] args)  
	{  
		del square = x => x * x;  
		int j = square(5); //j = 25  
	} 


or if we use the built in .NET delegates

	static void Main(string[] args)  
	{  
		Func<int, int> square = number => number * number;
		int j = square(5); //j = 25  
	} 

3. Scope 
As shown in scope_lamba_expressions.jpg .

4. Examples with projects

- LambdaExpressions
- LambdaExpressionsPractical

5. Predicate methods
A predicate method is a method that checks for a condition and returns true if a condition is satisfied.

Example
		
		static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
		

6. List find methods
All find methods for List accept a predicate as shown in list_find_predicates.jpg.

7.Reading a lambda expression

var books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(book => book.Price < 10);
							 //book goes to book.Price is less than 10





