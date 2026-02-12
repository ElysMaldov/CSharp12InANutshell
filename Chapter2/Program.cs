// Namespacing
// int x = 12 * 30;
// System.Console.WriteLine(x);

// Use using to remove refering to namespaces
// using System; // But using System is not necessary anymore

// int x = 12 * 30;
// Console.WriteLine(x);

Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));


int FeetToInches(int feet)
{
  int inches = feet * 12;
  return inches;
}

