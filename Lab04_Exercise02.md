# Lab 4 Exercise 2

## การกำหนดค่าเริ่มต้นให้ตัวแปร


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/c83aa1f3-7820-42dc-9dc4-83715cfb6efc)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/c35a8dd4-d2c7-465c-9168-622d7b79a9d6)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex02
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/4e08895e-aa02-4e85-a864-86f6a522c092)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/654bc6e3-853a-4bf7-8756-dea8ba3051ec)


7. อธิบายสิ่งที่พบในการทดลอง
   
โดยในโค้ดมีการกำหนดค่าให้กับตัวแปลเป็นที่เรียบร้อย และตัวแปลทำการแสดงผลออกมาเป็นดังภาพ เรียงลำดับลงมาตามการใช้แต่ละคำสั่ง
10
20
33.0
Hello World
ค่าของตัวแปร var1 คือ 10, var2 คือ 20, var3 คือ 33.0, และ var4 คือ "Hello World" 
ตามลำดับ ทำให้ได้ผลลัพธ์ดังกล่าวที่แสดงบนหน้าจอแสดงผลลัพธ์ของโปรแกรม
และแสดงให้เห็นว่าโปรแกรมทำงานตามปกติคำสั่งที่ใช้งานไม่มีปัญหาใดๆ  และมีการแสดงผลทางหน้าจอออกมาตามคำสั่งที่ได้ป้อนเข้าไปออกมาอย่างถูกต้อง

