# Lab 4 Exercise 4

## การใช้งานตัวแปร


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex04
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int var1 = 10;
int var2 = var1;
var var3 = var1 + var2;

System.Console.WriteLine($"Value of var1 = {var1}");
System.Console.WriteLine($"Value of var2 = {var2}");
System.Console.WriteLine($"Value of var3 = {var3}");
System.Console.WriteLine($"Type of var1 = {var1.GetType()}");
System.Console.WriteLine($"Type of var2 = {var2.GetType()}");
System.Console.WriteLine($"Type of var3 = {var3.GetType()}");
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex04
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-04/assets/144195611/a5174769-0a15-42f7-ba2c-18afb56c9da2)

7. อธิบายสิ่งที่พบในการทดลอง
- มีการใช้var ระบุค่าตัวแปร และให้ คำนวณทางคณิตศาสตร์ รหว่างตัวแปร 
