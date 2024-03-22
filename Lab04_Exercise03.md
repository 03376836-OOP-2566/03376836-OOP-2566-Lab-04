# Lab 4 Exercise 3

## การประกาศตัวแปรคราวละหลายตัว


1. สร้าง console application project

```
dotnet new console --name Lab04_Ex03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/92b86285-fa06-4e3c-b403-799e009a42e3)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/375c89c0-8608-43e7-b62e-d92b0ff097b1)


3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex03
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/33eefa59-e2bd-4bea-81bf-6619d7f7345a)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/812b4f8a-8b19-41b4-8179-c17f2fc94d1b)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/aa5f480a-f387-46df-add2-7dc0c624bd4a)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/3fd1b50e-4b95-4eab-acba-834e5d3485ac)


7. อธิบายสิ่งที่พบในการทดลอง

