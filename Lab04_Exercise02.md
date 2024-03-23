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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-04/assets/144195555/24f5625e-9800-4745-9b32-da751be8eed3)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-04/assets/144195555/b6c9b1f0-8b7f-4a2c-aa92-715a2834616e)


7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมสามารถ Run ได้เพราะได้กำหนดค่าตัวแปรให้ var1 - var4
### โปรแกรมจะแสดง ผล เป็น 10,20,33,Hello World ตามลำดับ 
