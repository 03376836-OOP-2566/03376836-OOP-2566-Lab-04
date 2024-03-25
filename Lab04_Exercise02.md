# Lab 4 Exercise 2

## การกำหนดค่าเริ่มต้นให้ตัวแปร


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex02
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int var1 = 10;
int var2 = 20 ;
float var3 = 33.0f;
string var4 = "Hello World";

System.Console.WriteLine(var1);
System.Console.WriteLine(var2);
System.Console.WriteLine(var3);
System.Console.WriteLine(var4);
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex02
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![2](https://github.com/Siriratda/03376836-OOP-2566-Lab-04/assets/144195995/0749c518-5f95-4adc-87eb-b4b539108578)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![2 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-04/assets/144195995/06f3638e-329e-4c13-9302-1a3a0455b7a5)

7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมสามารถรันได้เพราะได้กำหนดค่าตัวแปรให้ var1 - var4
โปรแกรมแสดงผลเป็น 10,20,33,Hello World 
