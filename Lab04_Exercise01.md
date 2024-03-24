# Lab 4 Exercise 1

## การประกาศตัวแปร


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex01
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int var1;
int var2;
float var3;
string var4;

System.Console.WriteLine(var1);
System.Console.WriteLine(var2);
System.Console.WriteLine(var3);
System.Console.WriteLine(var4);
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex01
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="798" alt="Screenshot 2024-03-24 022537" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/389be0ba-8845-4083-b050-b89fdeba9ccf">

5. Run project โดยการใช้คำสั่ง

```
dotnet run  --project  Lab04_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-24 022720" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/c31281b0-4d57-4ec3-aaef-70712f8ea766">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมเกิดการ Error ไม่สามารถ Run อะไรได้เลยเพราะไม่ได้กำหนดค่าตัวแปร var1 - var4

