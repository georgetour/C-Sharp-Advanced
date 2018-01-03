# Exception Handling

We should avoid to leave our site/app to throw Exception errors. To handled exteptions we use try catch blocks.

## Stack trace

A stack trace is when we hae an exception the order of methods that were called util the error was thrown.

### Example
Let's say we have :

<pre>public int Divide(int divindend, int divisor)
{
      return divindend / divisor;
}
</pre>

And we try to diivide with 0 like this

<pre>
Calculator calculator = new Calculator();

var result = calculator.Divide(6 , 0);

Console.WriteLine(result);
</pre>

We will get System.DivideByZeroException.

## try/catch

To handle the exception we use try/catch blocks. We put the code that may throw an Exception inside the try block. When an exception happens the catch block is executed. With catch block we have two choices. We can recover from the error and prevent the application from crashing or
we can rethrow the error which means send the error back to the caller of this code.


If we use the below try/catch blocks we will see that the application didn't crash an gives the user a more friendly warning as shown in **handle_error.jpg**
<pre>
static void Main(string[] args)
{

      try
      {
            Calculator calculator = new Calculator();
            var result = calculator.Divide(6, 0);
      }
      catch (Exception)
      {

            Console.WriteLine("Sorry an error occured");
      }


}
</pre>

In catch block we have a parameter Exception which is the parent of all exceptions in .NET. We can give it an argument so we access the actual exception as you see in **catch_error.jpg**

## Multiple exception Handling

In an exception we can have multiple catch blocks. We start by the most specific to most generic one. The most generic one means the top level of the hierarchy the top parent is System.Exception as we can see the hierarchy in **object_browser.jpg**

Example
<pre>
static void Main(string[] args)
{

      try
      {
          Calculator calculator = new Calculator();
          var result = calculator.Divide(6, 0);
      }
          catch(DivideByZeroException ex)
      {
          Console.WriteLine("You cannot divide by zero");
      }
          catch (Exception ex)
      {

          Console.WriteLine("Sorry an error occured");
      }


}
</pre>

## finally keyword

In .NET we have classes that access unmanaged resources. Those are resources that are not managed by CLR and we must clean them ourselves. So thre is not garbage collection applied to them. Examples are file hnadles, databases connections, network connections, graphic handles.
Any class that uses unmanaged resources is expected to implement an Interface called IDisposable.

## IDispoasable and Dispose

As shown in **IDisposable.jpg** we have an interface that has a method Dispose()that we use to clean  unmanaged resources.

So we use the finally block to call the Dispose method.

**Make sure you dispose any unmanaged resources you use.**

Example
<pre>
StreamReader streamReader = null;

try
{
    streamReader = new StreamReader("@e:/lorem_ipsum.txt");
    var content = streamReader.ReadToEnd();
}
catch (Exception)
{
    Console.WriteLine("Sorry an error occured");
}
//If something goes wrong close the streaming
finally
{
    if(streamReader != null)
    streamReader.Dispose();
}
</pre>

## using keyword and automatically disposing

When we use the using statement the compiler will create a finally block under the hood that will automatically create a finally block and dispose the unmanaged resource.

In C# we can write the above like this :

<pre>
try
{
    using (var streamReader2 = new StreamReader("@e:/lorem_ipsum.txt"))
    {
        var content = streamReader2.ReadToEnd();
    }
}
catch (Exception)
{
    Console.WriteLine("Sorry an error occured");
}
</pre>

## Custom exceptions

<pre>
public class YouTubeAPI
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            //Access Youtube Web Service
            //Read the data
            //Create a list of Video objects
        }
        catch (Exception)
        {

            throw;
        }
        return new List<Video>();
    }

}
</pre>

In the above example we might get some lower layer exceptions like problem with network connection, parsing etc. We don't want to expose them in the higher layers.

Example of custom exception

<pre>
public class YoutubeCustomException : Exception
{

    //With base keyword we can acccess methods and properties directly from the parent class
    public YoutubeCustomException(string message, Exception innerException)
        :base(message,innerException)
    {

    }
}
</pre>

Then we throw our custom Exception

<pre>
public class YouTubeAPI
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            //Access Youtube Web Service
            //Read the data
            //Create a list of Video objects
        }
        catch (Exception ex)
        {
            //Throwing custom exception we created
            throw new YoutubeCustomException("Problem with youtube network connection", ex);
        }
        return new List<Video>();
    }

}
</pre>

As we see to throw an exception we use the **keyword throw.**
We can manually simulate how an exception would work by throwing an exceptions
in try block.

<pre>
public class YouTubeAPI
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            //Access Youtube Web Service
            //Read the data
            //Create a list of Video objects
            throw new Exception("Manually simulation");
        }
        catch (Exception ex)
        {
            //Throwing custom exception we created
            throw new YoutubeCustomException("Problem with youtube network connection", ex);
        }
        return new List<Video>();
    }

}
</pre>
