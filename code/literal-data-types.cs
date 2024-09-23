// Exercise - Print different literal data types


// Character literals, note single quotes creates a char literal, double quotes creates string data type
Console.WriteLine('b');

// Int literals meaning no fractions but whole numbers. 
Console.WriteLine(123);

// floating point literals
// float, double and decimal supports varying degrees of precision'
/*
float   ~6-9 digits
double  ~15-17 digits
decimal 28-29 digits
*/
Console.WriteLine(3.14159);

// Declare Variables
// A literal is literally a hard-coded value

string firstName;

/*

Variable names can contain alphanumeric characters and the underscore character. Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
Variable names must begin with an alphabetical letter or an underscore, not a number.
Variable names are case-sensitive, meaning that string Value; and string value; are two different variables.
Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.


*/

char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;



// Setting and getting values from a variable

string firstPlacePlayer;
firstPorson = "Bob";

// Assigning a value is also referred to as "setting the variable", or simply, a "set" operation

// Assignment is right to left

// Note C# enforces data-types meaning if you asign one data-type you can't change it for another. 
// implicitly conversion fails if you try it. 

// Retrieve a value you stored in the variable

Console.WriteLine(firstPlacePlayer);

// Retrieving a value from a variable is also referred to as "getting the variable", or simply, a "get" operation.

// Reassigning the value of a Variable

firstPlacePlayer = "Sam";
Console.WriteLine(firstPlacePlayer);

// initialize the variable also known as set a variable

string firstPlacePlayer = "Jim";
Console.WriteLine(firstPlacePlayer);

/*

You must assign (set) a value to a variable before you can retrieve (get) a value from a variable.
You can initialize a variable by assigning a value to the variable at the point of declaration.
Assignment happens from right to left.
You use a single equals character as the assignment operator.
To retrieve the value from the variable, you merely use the variable's name.


*/

// Declare implicitly typed local variables

var message = "hey there";

/* 
var keyword tells the C# compiler that the data type is implied by the assigned value. 
After the type is implied, the variable acts the same as if the actual data type had been 
used to declare it. The var keyword is used to save on keystrokes when types are lengthy 
or when the type is obvious from the context.

Other programming languages use the var keyword differently. In C#, variables are assigned a 
type by the compiler regardless of whether you use the actual data type name or allow the compiler 
to imply the data type. In other words, the type is locked in at the time of declaration and 
therefore will never be able to hold values of a different data type.


you must assign,  If you try to use the var keyword without initializing the variable, you'll 
receive an error when you attempt to compile your code.
*/