# ReflectionExample
Reflection is a feature that allows you to inspect and use the metadata of classes and assemblies.
This is useful where need to work with types whose details are not know at runtime.

I did two examples.
The first example I load assembly SimplSharpProgrammingInterfaces.dll to get list of classes in that assembly
and then list the properties and methods for that class.

The second example displays how I usually use reflection to grab dynamically generated objects that I send to a function
that uses reflection to get the properties and the values for those properties for displaying to user in a datatable.

Reflection can add overhead and complexity to program so should be used carefully.
