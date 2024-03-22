# Lab 4 Exercise 4

## การใช้งานตัวแปร


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/a9da170d-0707-47cd-9dbc-79aba58977be)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/09938158-625b-42d0-a6e2-ddef81e70694)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex04
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/5f5fefe3-06cf-4332-b1f6-48f6a19b591c)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/0efa9351-2c04-4ebd-8460-53d21348d65a)


7. อธิบายสิ่งที่พบในการทดลอง
   
โค้ดที่ให้มานั้นมีการกำหนดค่าให้กับตัวแปร var1 และ var2 โดยให้ var2 เท่ากับค่าของ var1 และกำหนดค่าให้กับตัวแปร var3 
โดยทำการบวกค่าของ var1 กับ var2 ซึ่งได้ผลลัพธ์เป็น 20 เนื่องจาก var1 มีค่าเป็น 10 และ var2 มีค่าเท่ากับ var1 ดังนั้น var3 
จะมีค่าเป็นผลบวกของ var1 และ var2 ที่เท่ากับ 20
Value of var1 = 10
Value of var2 = 10
Value of var3 = 20
Type of var1 = System.Int32
Type of var2 = System.Int32
Type of var3 = System.Int32
จากการพิมพ์ค่าและประเภทของแต่ละตัวแปร
    var1 และ var2 มีค่าเท่ากับ 10 เนื่องจาก var2 ได้รับค่าจาก var1
    var3 มีค่าเท่ากับผลบวกของ var1 และ var2 ซึ่งเป็น 20
	ประเภทของ var1, var2, และ var3 เป็นประเภท System.Int32 ทั้งหมด
เนื่องจากการกำหนดค่าเริ่มต้นของตัวแปรที่เป็นชนิดข้อมูลจำนวนเต็มใน C# จะเป็น int โดยค่า int ใน C# จะเป็นประเภท System.Int32
จากโค้ดที่แสดงผลออกมาจะเห็นว่าโปรแกรมทำงานปกติ และ มีการแสดงผลออกมาตามคำสั่งที่ป้อนเข้าไป 
