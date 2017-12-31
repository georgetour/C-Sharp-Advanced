# Dynamic

Dynamic is a feature was added after .NET 4. It makes C# run dynamically like javascript, php, ruby.
That means we have a type resolution at run time and not at compile time. In static languages like C#
when we compile the application, if we try to access a method that is not defined in an object we get
immediately feedback from the compiler and doesn't let us continue.

## Why to use it?

- They use it only if you want to write MS Office libraries
- Calling javascript method from Silverlight
- COM interop
- Maybe reading Xml, Json without creating custom classes

## Syntax

<pre>
dynamic excelObject = "george";
excelObject.Optimize();
</pre>

We won't get a compile error/feedback since now it will run dynamically at run time and not at compile time.


## Magic happens

In .NET  we have the CLR(Common Language Runtime) which is a virtual machine that gets our compiled code which is Intermediate Language(IL)
and converts that into machine code at runtime. IN .NET 4 they added DLR(Dynamic Language Runtime) so DLR sits on top of CLR and gives dynamic languages capabilities to C#.

## Assigning different type values

<pre>
dynamic name = "george";
name = 10;
</pre>

Since its dynamic it's perfectly fine but with static types we would get an error.
