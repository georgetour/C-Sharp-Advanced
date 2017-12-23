# Delegates
Delegate is an object that knows how to call a method (or a group of methods). 
A reference to a function.
Imagine it like a pointer to a method or a group of methods that have same parameter.

1. Why we need that?

- For designing extensible and flexible applications(like a framework).
- Alternatively you can use interfaces


Example

		public delegate void PhotoFilterHandler(Photo photo);

        //This code doesn't know what filter will be applied
		//Only the client knows which in our case is Program.cs
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
			
            filterHandler(photo);

            photo.Save();

        }
		
2. With the above a developer can apply what he wants. Maybe he wants to apply only brightness or maybe he wants 
only contrast.

3. With delegates you don't have to recompile and redeploy again. We can say a delegate is a pointer to a method with a signature.

4. Instead of creating our own delegates .NET comes with :

- ** Action **
Action can point to a method that takes up to 16 parameters as you can see in Action_overloads.jpg.
- ** Func **
The difference between Func and Action is that Func point to a method that returns  value.

5. Interfaces vs Delegates

Use a delegate when :
- An eventing design pattern is used
- The caller doesn't need to access other properties or methods onthe object implementing the method(like the framework example
where another developer needs to use another filter)

Check Delegates_Simple_Example project for simple explanation



