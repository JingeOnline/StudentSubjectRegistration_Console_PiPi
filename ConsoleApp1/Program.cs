// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp1;
using System.Diagnostics;
using System.Runtime.InteropServices;

//int number1 = 5;
//int number2 = number1;

//number1 = 6;
//Console.WriteLine(number2);







List<int> list1 = new List<int>() { 1,2};
List<int> list2 = list1;

list1 = new List<int>() { 5, 5 };
list2.ForEach(x => Console.WriteLine(x));
Console.WriteLine();




List<int> list3=new List<int> { 1,1,1};
change(list3);
list3.ForEach(x => Console.WriteLine(x));

void change(List<int> list)
{
    list.Add(2);
}


Console.WriteLine();
List<string> list6 = new List<string>() { "A", "B" };
List<string> list7 = list6;

list6 = new List<string>() { "C", "D" };
list7.ForEach(x => Console.WriteLine(x));
Console.WriteLine();


Student s1 = new Student() { name="Adam", age=11 };
Student s2 = s1;
s1 = new Student { name = "Mike", age = 22 };
Console.WriteLine(s2.name +" "+s2.age);