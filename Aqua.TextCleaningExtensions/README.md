# Aqua.TextCleaningExtensions
Aqua Text cleaning Extensions Package is an Open Source and Free Software package consists of a set of utilities that facilitate the job of the developer and save his time while cleaning text. Every developer could be a beneficiary of this library; however, those who deal with database and integration applications are likely the most potential beneficiaries.


# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# List of Features and Methods
1. [IsNullOrEmpty](#IsNullOrEmpty)
2. [IsNullOrWhiteSpace](#IsNullOrWhiteSpace)
3. [RemoveWideSpaces](#RemoveWideSpaces)
4. [ReplaceTabsWithSpaces](#ReplaceTabsWithSpaces)
5. [NewLinesToWhiteSpaces](#NewLinesToWhiteSpaces)
6. [ToCleanText](#ToCleanText)

# Features and Methods
### IsNullOrEmpty
IsNullOrEmpty is an extension method, equivalent for the traditional ``` string.IsNullOrEmpty() ``` static method. Returns true if the string examined is null or empty, otherwise returns false.

```C#
//using Aqua.TextCleaningExtensions;

string input;
bool output;

input = null;
output = input.IsNullOrEmpty();  // output = true

input = "";
output = input.IsNullOrEmpty();  // output = true

input = " ";
output = input.IsNullOrEmpty();  // output = false

input = "lorem ipsum dolor";
output = input.IsNullOrEmpty();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsNullOrWhiteSpace
IsNullOrEmpty is an extension method, equivalent for the traditional ``` string.IsNullOrWhiteSpace() ``` static method. Returns true if the string examined is null or empty, otherwise returns false.

```C#
//using Aqua.TextCleaningExtensions;

string input;
bool output;

input = null;
output = input.IsNullOrWhiteSpace();  // output = true

input = "";
output = input.IsNullOrWhiteSpace();  // output = true

input = " ";
output = input.IsNullOrWhiteSpace();  // output = false

input = "lorem ipsum dolor";
output = input.IsNullOrWhiteSpace();  // output = false

```
### RemoveWideSpaces
```C#
//using Aqua.TextCleaningExtensions;

string input;
string output;

input = null;
output = input.RemoveWideSpaces();  // output = null

input = "";
output = input.RemoveWideSpaces();  // output = ""

input = " ";
output = input.RemoveWideSpaces();  // output = ""

input = "lorem ipsum";
output = input.RemoveWideSpaces();  // output = "lorem ipsum"

input = "  lorem ipsum      lorem ipsum  ";
output = input.RemoveWideSpaces();  // output = "lorem ipsum lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceTabsWithSpaces
```C#
//using Aqua.TextCleaningExtensions;

string input;
string output;

input = null;
output = input.ReplaceTabsWithSpaces();  // output = null

input = "";
output = input.ReplaceTabsWithSpaces();  // output = ""

input = " ";
output = input.ReplaceTabsWithSpaces();  // output = ""

input = "lorem              ipsum";      //4 tabs were here
output = input.ReplaceTabsWithSpaces();  // output = "lorem ipsum"

input = "   lorem               ipsum "; //6 tabs were here
output = input.ReplaceTabsWithSpaces();  // output = "lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### NewLinesToWhiteSpaces
```C#
//using Aqua.TextCleaningExtensions;

string input;
string output;

input = null;
output = input.NewLinesToWhiteSpaces();  // output = null

input = "";
output = input.NewLinesToWhiteSpaces();  // output = ""

input = " ";
output = input.NewLinesToWhiteSpaces();  // output = ""

input = "lorem\nipsum";
output = input.NewLinesToWhiteSpaces();  // output = "lorem ipsum"

input = "\nlorem\n\n      ipsum\ndolor";
output = input.NewLinesToWhiteSpaces();  // output = "lorem ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToCleanText
```C#
//using Aqua.TextCleaningExtensions;

string input;
string output;

input = null;
output = input.ToCleanText();  // output = null

input = "";
output = input.ToCleanText();  // output = ""

input = " ";
output = input.ToCleanText();  // output = ""

input = "   lorem     ipsum      ";
output = input.ToCleanString();  // output = "lorem ipsum"

input = " lorem\n     ipsum\n";  // there is mix of \n \t and spaces
output = input.ToCleanText();  // output = "lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

# Build and Test
TODO: Describe and show how to build your code and run the tests. 



# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)

