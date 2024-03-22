# Lab 4 Exercise 1

## การประกาศตัวแปร


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex01
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/7d888d18-fe9a-4143-af23-a1100a1d60e0)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/c618173a-b29e-43a8-96b9-5456d95cc518)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex01
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/72286da1-9cb4-4ec9-bc46-4e7e5af4e17d)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/fca32635-9c2e-47e0-9427-446c14cad5b8)
5. Run project โดยการใช้คำสั่ง

```
dotnet run  --project  Lab04_Ex01
```


6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/4b6d500d-962b-4ecb-9cb0-e1bc3f10e79e)

7. อธิบายสิ่งที่พบในการทดลอง
โค้ดที่ให้มาส่งผลให้ไม่มีการแสดงผลทางหน้าจอหรือไม่มีการทำงานของโปรแกรม เพราะตัวโค้ดไม่ได้มีการใส่ตัวแปลให้กับโค้ดของตัว C# ทำให้ตัว VS code ขึ้นภาพสีแดง
ว่ายังมีการเขียนคำสั่งที่ผิดพลาดอยู่และเมื่อทำ Run ข้อมูลก็จะเห็นว่า โปรแกรมไม่ทำงาน เพาะไม่มีการเพิ่มตัวแปลเข้าไปในคำสั่ง
มีการประกาศตัวแปรแต่ไม่ได้กำหนดค่าให้กับตัวแปรเหล่านั้น  แต่ถ้าแก้ใหม่ ทำการกำหนดตัวแปลให้กับคำสั่ง โดย
การกำหนดค่าเรียบร้อยแล้ว โปรแกรมจะแสดงผลลัพธ์ที่เรียกว่า "ค่าเริ่มต้น" หรือ "default value" สำหรับแต่ละประเภทของตัวแปร นั่น

    สำหรับ int (จำนวนเต็ม) และ float (จำนวนทศนิยม) จะแสดงค่าเริ่มต้นของตัวแปรซึ่งเป็น 0
    สำหรับ string (สตริง) จะแสดงเป็นค่า null หรือชนิดข้อมูลว่าง
    หากไม่ได้กำหนดค่าเริ่มต้นให้กับตัวแปร var4 ซึ่งเป็นประเภทข้อมูล string ตัวแปรนี้จะแสดงผลเป็น null

