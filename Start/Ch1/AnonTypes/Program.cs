// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new { 
    Name = "Mike Mousavi",
    Age = 45,
    Address = new {
        Street = "123 High St",
        City = "Anytown"
    }
};
// Console.WriteLine($"{myobj.Name}, {myobj.Address.Street}");
// Console.WriteLine($"{myobj}");

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
// var myobj2 = myobj with {Name = "Jane Doe"};
// Console.WriteLine($"{myobj2.Name}, {myobj2.Address.Street}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");