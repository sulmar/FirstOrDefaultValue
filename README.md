# FirstOrDefaultValue
In .NET 6 FirstOrDefault(), LastOrDefault() SingleOrDefault() now let's specify the default value. 

Inspired by .NET 6 I created the same for older version of .NET 5.

~~~ csharp
var arr = Enumerable.Range(0, 10);

var c1 = arr.FirstOrDefault(x => x > 11) == 0;

var c2 = arr.FirstOrDefault(x => x > 11, -1) == -1;

var c3 = arr.SingleOrDefault(x => x > 11, -1) == -1;

var c4 = arr.LastOrDefault(x => x > 11, -1) == -1;
~~~
