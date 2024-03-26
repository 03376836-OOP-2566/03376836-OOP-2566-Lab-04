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

5. Run project โดยการใช้คำสั่ง

```
dotnet run  --project  Lab04_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-04/assets/144195611/ea82dd78-cc58-4307-833c-4ea7c2bb6b61)


7. อธิบายสิ่งที่พบในการทดลอง
- ข้อผิดพลาดเนื่องจากการใช้งานตัวแปรที่ไม่ได้ถูกกำหนดค่าไม่สามารถใช้ได้โดยไม่ผ่านการกำหนดค่าเริ่มต้นก่อนใช้งานกำหนดค่าเริ่มต้นให้กับตัวแปรก่อนที่จะใช้งานหรือใช้ค่า defaultหรือใช้ตัวแปรชนิด nullable เพื่อรองรับค่า null 
