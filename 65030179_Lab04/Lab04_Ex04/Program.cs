int var1 = 10;
int var2 = var1;
var var3 = var1 + var2;

System.Console.WriteLine($"Value of var1 = {var1}");
System.Console.WriteLine($"Value of var2 = {var2}");
System.Console.WriteLine($"Value of var3 = {var3}");
System.Console.WriteLine($"Type of var1 = {var1.GetType()}");
System.Console.WriteLine($"Type of var2 = {var2.GetType()}");
System.Console.WriteLine($"Type of var3 = {var3.GetType()}");