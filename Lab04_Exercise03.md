# Lab 4 Exercise 3

## การประกาศตัวแปรคราวละหลายตัว


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex03
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int var1 = 10;
int var2 = 20, var3 = 33, var4, var5 = -55;
string var6 = "Hello World", float var7 = 10.7, long var8 = 1e8;

System.Console.WriteLine(var1);
System.Console.WriteLine(var2);
System.Console.WriteLine(var3);
System.Console.WriteLine(var4);
System.Console.WriteLine(var5);
System.Console.WriteLine(var6);
System.Console.WriteLine(var7);
System.Console.WriteLine(var8);
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex03
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="688" alt="Screenshot 2024-03-24 013807" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-04/assets/144195963/4a1160b1-238d-42f0-bfc4-b47f0018ef90">


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="707" alt="Screenshot 2024-03-24 013941" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-04/assets/144195963/fffeaae6-ad60-42d1-9f17-5935acce4264">


7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมไม่สามารถ Run ได้และทำการแจ้งเตือนความผิดพลาด เช่นมี syntax error หรือ identifier expected ให้กลับไปตรวจสอบcode อีกครั้ง
