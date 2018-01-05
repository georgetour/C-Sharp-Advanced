# Asynchronous Programming Async/Await

## Synchronous Program Execution

- Program is executed line by line, one at a time
- When a function is called, program execution has to wait until function returns

For example if we have a function that has to do with a database or a website we iwill have some seconds delay.

## Asynchronous Program Execution

When a function is called, rpogram execution continues to the next line,
without waiting for the function to complete.

It makes the application run more smoothly.Also your is full responsive without having to wait. Some real world example are:

- Windows Media Player
- Web Browser

## Use it when

- Accesing the Web
- Working with files and databases
- Working with images

## How

Traditional approaches:
- Multi - threading
- Callbacks

New approaches since NET 4.5

- Async/Await

As we see in Asynchronous_Programming project when we press the button since we have a delay we can't move the main window/resize etc.

## Syntax

First we write the async keyword and then we have to declare a Task. A Task comes in two forms as shown in **async_task.jpg**. A Task is an object that encapsulates the state of an asynchronous operation. If the method is void you should use the non-generic method of Task. If it returns something you should use the generic method.** Also the methods that are inside the method you run must be Async**.

By using the keyword **await** we inform the compiler that this operation should be costly and it might take some time. We should use it along with the async method as shown below.
<pre>
public async Task DownloadHtmlAsync(string url)
{
    var webClient = new WebClient();
    var html = await webClient.DownloadStringTaskAsync(url);//Download as string the url

    try
    {
        using (var streamWriter = new StreamWriter(@"C:/Users/Giant/Documents/Visual Studio 2015/Projects/C-Sharp-Advanced/Chapter 10 Asynchronous Programming/result.html"))
        {
            await streamWriter.WriteAsync(html);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
}
</pre>

We don't have to await an asynchronous operation but you can do some work in between that is not dependent on the result of that asynchronous operation.

<pre>
private async void button1_Click(object sender, RoutedEventArgs e)
{
    var getHtmlTask = GetHtmlAsync("https://msdn.microsoft.com/en-us/");

    //Do something while await method runs
    MessageBox.Show("I m running while the await method is executed");

    var html = await getHtmlTask;
    MessageBox.Show(html.Substring(0,10));

}


public async Task<string> GetHtmlAsync(string url)
{
    var webClient = new WebClient();

    return await webClient.DownloadStringTaskAsync(url);
}
</pre>

## Using Asynchronous Operation

Check the project Asynchronous_Operation.

## Web apllications with ASP.NET MVC

In those applications the UI is not in the same process. It's on the client's machine on the browser. Async model also improves web applications. When a request comes to the server a thread is allocated to handle that request. Each server/hosting etc can handle specific threads. If we have a blocking operation that thread is going to be busy. The server will be unresponsive if all its threads are used. We could add more servers to fix this but that's not a solution(scaling out). Using the asynchronous model when the thread has a blocking operation the control immediately returns to the thread and continues with the next ones(scale up).
