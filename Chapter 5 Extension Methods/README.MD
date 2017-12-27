# Extension Methods

 - They allow us to add methods to an existing class **without** 
 -- Changing its source code 
 -- Creating a new class that inherits from it 
 
 
1. Why to use

If we had :
<pre>
 namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string post = "This is supposed to be a very long text This is supposed to be a very long text This is supposed to be a very long text This is supposed to be a very long text This is supposed to be a very long textThis is supposed to be a very long text  ";

        }
    }
 
}
</pre>
And we wanted to inherit from String class we couldn't as you see in Visual Studio. This is where extension methods comes.

**To create an extension method you need to create a static class.**

2. Name convension

You add write the class you want to extend and then Extensions. Below we want to extend the String class.

Example
<pre>
	public static class StringExtensions
    {
		
    }
</pre>
3. The method

Should always be static and first parameter is this TypeYouareExtending name.

Example 
<pre>
  public static class StringExtensions
    {
        public static string Shorten()
        {

        }

    }
</pre>	
4. Extension methods namespace and icon

Extension methods should be in same namespace so they can be used. Also you can see in extension_methods_icon.jpg 
that they have different icon.

5. Usage

Microsoft suggests to use exntesion methods **only if really needed**. Better change the source code of the original 
class else create a new type that derives from that class and add your new method here. Most of the times we will use them 
not create them custom.




  


