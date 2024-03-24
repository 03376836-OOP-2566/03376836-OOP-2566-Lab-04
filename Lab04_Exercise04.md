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
<img width="799" alt="Screenshot 2024-03-24 141104" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/9a30c4c6-d772-47e1-a777-2e5ace3f53ec">

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-24 141228" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/57229a0a-072c-46a4-ac4c-3476979610ed">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมรับค่าเข้ามา var1 = 10 ให้ var2 = var1 และ var3 = var1 + var2 จะแสดงผลเป็น 10,10,20 ตามลำดับ และให้แสดงผล Type โดยใช้ GetType แสดงผลเป็น System.Int32 เพราะทั้งสามเป็นเลขจำนวนเต็ม
