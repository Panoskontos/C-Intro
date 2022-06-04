// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(3 + 3);

// int x = 5;
// Console.WriteLine("I got " + x + " on it");

string f = "Panos";
string l = "Sneako";


int myint = 11;
double myfloat = myint;

Console.WriteLine(f + l);
Console.WriteLine(myfloat.GetType());

// int myNum = 5;
// double myDoubleNum = 5.99D;
// char myLetter = 'D';
// bool myBool = true;
// string myText = "Hello";

double d = 9.2345;
Console.WriteLine(d);
// int i = (int)d;
// Console.WriteLine(i);


// User Input
// Console.WriteLine("Enter your name");
// string Name = Console.ReadLine();
// Console.WriteLine("This mofo name is " + Name.ToUpper());

// Console.WriteLine("Enter your age");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("This mofo age is " + Math.Max(age,30));


// Booleans
int x = '6';
int y = 8;
Console.WriteLine(x == y);

// if Statement
if (y == 6)
{
    Console.WriteLine("God damn!");
}
else if (y == 7)
{
    Console.WriteLine("Lord knows");
}
else
{
    Console.WriteLine("It's just a game");
}


// While Loop

int res = 0;
while (res < 5) 
{
  Console.WriteLine(res);
  res++;
}

// For Loop
for (int i = 10; i > 5; i--) 
{
  Console.WriteLine(i);
}

// Array
string[] cars = {"Hello","World","Lord","Knows"};
foreach (string j in cars){
    Console.WriteLine(j);
}

int[] nums = {1,2,3,4,5};
Console.WriteLine(nums);




// Class, Dont work for some reason
class Car
{
    string color = "Blue";
    int km = 11234;

     static void Main(string[] args)
  {
    Car c = new Car();
    Console.WriteLine(c.color);
  }
}



