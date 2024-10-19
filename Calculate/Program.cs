// See https://aka.ms/new-console-template for more information
using Calculate;
using Calculate.Model;

Console.WriteLine("Hello, World!");


var temp = new Calculate_ModelClass();
int a =10;
int b =20;

Console.WriteLine( "Addition: {0} ", temp.Add(10,20));


LinqPerformanceIssue123 linq = new LinqPerformanceIssue123();
Console.WriteLine("Sum of even number : {0}", linq.GetSumOfEvenNumbers(new List<int> { 10,40,5}));