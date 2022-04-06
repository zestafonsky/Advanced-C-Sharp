# Advanced C#

Questions for the self-check:

What is the difference between reference and value types? 

What is boxing and unboxing? 

What is a class? What is an interface? 

What is the difference between class and structure? 

What is a generic type? What is Covariance and Contravariance? 

What is delegate? 

What is event? 

What is the difference between delegate and event? 

# Task 1:

Create a class FileSystemVisitor, which allows you to traverse a tree of folders on the filesystem from the pre-defined folder. 

Note: Please discuss with the mentor which presentation layer you will use before implementation (console or desktop application). 

FileSystemVisitor class should implement the following functionality: 

Return all found files and folders in the form of a linear sequence, for which implement your own iterator (using the yield operator if possible). 

Provide the ability to set an algorithm for filtering found files and folders at the time of creating an instance of FileSystemVisitor (via a special overloaded constructor). The algorithm must be specified as a delegate/lambda. 

# Task 2: 

For solution from Task 1 add the following functionality: 

Generate notifications (via the ‘event’ mechanism) about the stages of their work. In particular, the following events must be implemented (event names can be anything, it is important to follow the naming convention): 

Start and Finish (for the beginning and end of the search). 

FileFound / DirectoryFound for all found files and folders before filtering, and FilteredFileFound / FilteredDirectoryFound for filtered files and folders. These events should allow (by setting special flags in the parameter): 

Abort search 

Exclude files/folders from the final list 

# Task 3 (optional): 

Write unit tests that will show different modes of work of FileSystemVisitor from Task 1.  

Discuss with your mentor whether you need to use Mock. 

All unit tests should pass successfully. 
