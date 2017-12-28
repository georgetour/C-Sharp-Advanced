# LINQ

- Stands for Language Integrated Query
- Gives you the ability to query objects

LINQ is one of the strong advantages of the C# language. You can run queries to almsot anything in .NET framework
and get rich data from it.

## 1. Query 

- Objects in memory, eg collections(LINQ to Objects)
- Databases(LINQ to Entities)
- XML (LINQ to XML)
- ADO.NET Data Sets(LINQ to Data Sets)

## 2. Where()

As shown in where_extension_method.jpg it takes first parameter that will set some condition and if the condition is true
returns the result.

## 3. Usage

To use it we need to create a lambda exression which as we can see in Chapter Lambda Expressions a lamda expression is 
an anonymous predicate method.

Example

<pre>var cheapBooksLINQ = books.Where(b => b.Price < 10); </pre>

## 4. OrderBy()

With OrderBy we sort a list according to what we want Price, Title etc

books.OrderBy(b => b.Title);

## 5. Chaining LINQ methods

//Instead of writing
<pre>var cheapBooksLINQ = books.Where(b => b.Price < 10)); //b is books with books price < 10

books.OrderBy(b => b.Title);</pre>
 
//We write
var cheapBooksLINQ = books.Where(b => b.Price < 10).OrderBy(b => b.Title);

## 6. Select()

With Select we project or transformate the iteration we have to another object or maybe we want to 
select one of its properties as string. As we see in select_extension_method.jpg we will show only the books Titles
since we selected them and var cheapBooksLINQ has become an IEnumerable<string>.

Example

<pre> var cheapBooksLINQ = books.Where(b => b.Price < 10).OrderBy(b => b.Price).Select(b => b.Title); 

            Console.WriteLine();
            Console.WriteLine("***BOOKS UNDER 10$ with LINQ***");

            foreach (var cheapBook in cheapBooksLINQ)
            {
                Console.WriteLine("Book Title :" + cheapBook);
                
            }</pre>
			
## 7.LINQ Extension Methods syntax

<pre> var cheapBooksLINQ = books
<<<<<<< HEAD
							.Where(b => b.Price < 10)
							.OrderBy(b => b.Price)
							.Select(b => b.Title);</pre>
=======
			      .Where(b => b.Price < 10)
			      .OrderBy(b => b.Price)
			      .Select(b => b.Title); </pre>
>>>>>>> c26fd8477b6a6d72ec3597dbbe05976dabe697eb
							   
##8. LINQ Query Operators Syntax

<pre>var cheaperBooksLINQ = from b in books
                            where b.Price < 10
                            orderby b.Price
                            select b;</pre>


 
 
 
