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

<img width="697" alt="Screenshot 2024-03-24 012756" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-04/assets/144195963/0cd5e0db-dac7-4b36-ac1a-1e0a55aa3e8c">


5. Run project โดยการใช้คำสั่ง

```
dotnet run  --project  Lab04_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="671" alt="Screenshot 2024-03-24 012941" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-04/assets/144195963/96b9c5e2-7959-40ec-948e-6ffca5572aa4">


7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมเกิดการ Error ไม่สามารถ Run ได้เพราะไม่ได้ทำการกำหนดค่าตัวแปร var1 - var4
