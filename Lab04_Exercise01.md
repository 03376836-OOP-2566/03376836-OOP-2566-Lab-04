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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-04/assets/144195708/1d32c75d-0a2d-43ad-8405-f7a915b6e08a)

5. Run project โดยการใช้คำสั่ง

```
dotnet run  --project  Lab04_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
   ![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-04/assets/144195708/f8017373-ad88-495f-9d62-ed3be9f6e3ea)



7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมเกิดการ Error ไม่สามารถ Run อะไรได้เลยเพราะไม่ได้กำหนดค่าตัวแปร

