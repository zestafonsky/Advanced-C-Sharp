# Advanced C#

In this module, you will take a deeper look at the fundamental .NET concepts like: Value vs Ref types, nullable types, boxing and unboxing, extension methods, delegate and events and generics concepts like covariation and contravariance. By the end of this topic, you will create a solution to consolidate theoretical knowledge.

### Questions for the self-check:

1. What is the difference between reference and value types? 

2. What is boxing and unboxing? 

3. What is a class? What is an interface? 

4. What is the difference between class and structure? 

5. What is a generic type? What is Covariance and Contravariance? 

6. What is delegate? 

7. What is event? 

8. What is the difference between delegate and event? 

### Task 1:

Create a class FileSystemVisitor, which allows you to traverse a tree of folders on the filesystem from the pre-defined folder. 

> Decide by yourself which presentation layer you will use before implementation (console or desktop application). 

FileSystemVisitor class should implement the following functionality: 

* Return all found files and folders in the form of a linear sequence, for which implement your own iterator (using the yield operator if possible). 

* Provide the ability to set an algorithm for filtering found files and folders at the time of creating an instance of FileSystemVisitor (via a special overloaded constructor). 

The algorithm must be specified as a delegate/lambda. 

### Task 2: 

For solution from Task 1 add the following functionality: 

* Generate notifications (via the ‘event’ mechanism) about the stages of their work. 

In particular, the following events must be implemented (event names can be anything, it is important to follow the naming convention): 

* Start and Finish (for the beginning and end of the search). 

FileFound / DirectoryFound for all found files and folders before filtering, and FilteredFileFound / FilteredDirectoryFound for filtered files and folders. 

These events should allow (by setting special flags in the parameter): 

* Abort search 

* Exclude files/folders from the final list 

### Task 3 (optional): 

Write unit tests that will show different modes of work of FileSystemVisitor from Task 1.  

> Decide whether you need to use Mock. 

All unit tests should pass successfully.

## Self-study Materials

### 1. Value vs Ref types:

* [Value types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)
* [Built-in reference types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types)

 

### 2. Nullable types, Boxing and Unboxing:

* [Nullable value types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types) 
* [Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#boxing-and-unboxing)

 

### 3. OOP Fundamentals via C#:

* [Object-Oriented programming (C#)](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)
* [Inheritance in C# and .NET](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/inheritance) 
* [Overview of classes, structs, and records in C#](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented)
* [Object Class](https://docs.microsoft.com/en-us/dotnet/api/system.object)
* [Choosing Between Class and Struct](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct)


### 4. Extension Methods overview:

* [Extension Methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)

* [How to implement and call a custom extension method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method)

* [How to create a new method for an enumeration](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-create-a-new-method-for-an-enumeration)
 
### 5. Interfaces and generic:

* [C#: Interfaces and Generics](https://www.linkedin.com/learning/c-sharp-interfaces-and-generics-14335425/learning-c-sharp-interfaces-and-generics?u=2113185) 

* [Covariance and contravariance in generics](https://docs.microsoft.com/en-us/dotnet/standard/generics/covariance-and-contravariance)

* [Covariance and Contravariance (C#)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance)


### 6. C#: Delegates, Events and Lambdas


* [Delegates (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates)
* [Delegates and lambdas](https://docs.microsoft.com/en-us/dotnet/standard/delegates-lambdas)
* [Events (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events)
* [C#: Delegates, Events and Lambdas](https://www.linkedin.com/learning/c-sharp-delegates-events-and-lambdas)
* [Lambda expressions (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)
* [Yield Return/Back statement)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield)

### 7. Additional: 


* [Reference Types vs Value Types ](https://github.com/sidristij/dotnetbook/blob/master/book/en/ReferenceTypesVsValueTypes.md)
 
* [Generic in C#](https://www.linkedin.com/learning/using-generics-in-c-sharp/using-generics-to-make-your-code-safer-and-more-valuable?u=2113185)
 

New/Cool things in C# (The history of C#) 
* [Null Parameter Checks in C# 10 and .NET 6 In 10 Minutes or Less](https://www.youtube.com/watch?v=230zlnKkl3A)
* [The history of C#](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history)
