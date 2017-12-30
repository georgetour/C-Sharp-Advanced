# Nullable Types

## Value Types

- Can't be null

- bool hasAccess = true; //or false

Sometimes though you might need a null value. If you are working with a database you may have a datetime that not all customers
give their birthdate.

Example
	We have a table called Customers and a column Birthday.
	Customers.Birthday(datetime NULL)

If we try to create a DateTime with null value you will see you get an error as shown in **nullable_error_datetime.jpg**

## Syntax

Nullable<DateTime> date = null;

//Shorter version

DateTime? birthday = null;

### 1. GetValueOrDefault()

Retrieves a value or default if it hasn't any. Since we have set the date to null it returns the default.

Console.WriteLine(date.GetValueOrDefault());

### 2. HasValue

Checks if has any value. If null it returns False.

Console.WriteLine(date.HasValue);

### 3. Value

Throws an exception if null since it must return a value.

Console.WriteLine(date.Value);

### 4. Refering to a null DateTime

DateTime? date = new DateTime(2017,1,1);
DateTime date2 = date.GetValueOrDefault(); //It will return the date 2017


## 5. Null Coalescing Operator

Instead of writing:

<pre>

DateTime? date2 = date;
if (date != null)
    date2 = date.GetValueOrDefault();
else
    date2 = DateTime.Today;
</pre>
We can write:

<pre>
DateTime date3 = date ?? DateTime.Today; //if date has a value give it to date3 else date3 = Datetime.Today

Console.WriteLine(date3);

</pre>

Looks similar with ternary operator
<pre>
DateTime date4 = date( != null) ? date.GetValueOrDefault() : DateTime.Today;
</pre>
