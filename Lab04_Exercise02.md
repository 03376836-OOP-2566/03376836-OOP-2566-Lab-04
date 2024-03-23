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
<img width="797" alt="Screenshot 2024-03-24 023209" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/59559c6a-98ff-47dc-ad17-802bffebab99">

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-24 023357" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/bc7a83b0-778f-42bc-b3ae-ed8aaaa2f871">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมสามารถ Run ได้เพราะได้กำหนดค่าตัวแปรให้ var1 - var4
ซึ่งโปรแกรมจะแสดงผลเป็น 10,20,33 และ Hello World ตามลำดับ
