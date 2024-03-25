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

![1](https://github.com/Siriratda/03376836-OOP-2566-Lab-04/assets/144195995/cda7b8d3-5fd2-409b-9450-51cc10b67fd7)

5. Run project โดยการใช้คำสั่ง

```
dotnet run  --project  Lab04_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![1 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-04/assets/144195995/46d90bf5-a7a2-4f8c-b8f9-ab85880bca84)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรม Erorr ไม่สามารถรันได้เพราะไม่ได้กำหนดค่าตัวแปร var1,var4
