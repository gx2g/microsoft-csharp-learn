/*
Formating Literal Strings in C#
*/

Console.WriteLine("this is \"crazy\"");

// The problem is the sequence \s. The \r doesn't produce an error because it's a valid escape sequence for a carriage return. 
// However, you don't want to use a carriage return in this context. to solve this use \\ double backlashes. 
Console.WriteLine("C:\\source\\repos");


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");


// Verbatim string literal
// A verbatim string literal will keep all whitespace and characters without the need to 
// escape the backslash. To create a verbatim string, use the @ directive before the literal string.

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// Unicode escape chararctors. 

// You can also add encoded characters in literal strings using the \u escape sequence, 
// then a four-character code representing some character in Unicode (UTF-16).

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

/*

There are several caveats here. First, some consoles like the Windows Command Prompt will not display 
all Unicode characters. It will replace those characters with question mark characters instead. 
Also, the examples used here are UTF-16. Some characters require UTF-32 and therefore require a 
different escape sequence. This is a complicated subject, and this module is only aiming at showing 
you what is possible. Depending on your need, you may need to spend quite a bit of time learning and 
working with Unicode characters in your applications.

*/

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

/*

Use character escape sequences when you need to insert a special character into a literal string, 
like a tab \t, new line \n, or a double quotation mark \".
Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash 
characters in a string.
Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
Unicode characters may not print correctly depending on the application.

*/

// Combine strings using string concatenation

string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

/*
String concatenation allows you to combine smaller literal and variable strings into a single string.
Avoid creating intermediate variables if adding them doesn't increase readability.
*/

// Combine strings using string interpolation

string message = $"{greeting} {firstName}!";

// Use string interpolation to combine a literal string and a variable value

string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

// practice avoiding intermediate variables

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

// Combine verbatim literals and string interpolation

string projectName = "First-Project";
Console.WriteLine($@"C:\output\{projectName}\Data");

/*

String interpolation provides an improvement over string concatenation by reducing the number of characters 
required in some situations.

You can combine string interpolation and verbatim literals by combining the symbols for each and using 
that as a prefix for the string template.


*/


string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");