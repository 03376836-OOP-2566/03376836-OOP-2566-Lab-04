# Lab 4 Exercise 5

## nullable type



1. สร้าง console application project

```
dotnet new console --name Lab04_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/d7d076d2-6695-4c40-b21a-4c4788ade1bd)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int? a = null;
int? b = 10;

if (a.HasValue)
{
    Console.WriteLine($"a is {b.Value}");
}
else
{
    Console.WriteLine("a does not have a value");
}
if (b.HasValue)
{
    Console.WriteLine($"b is {b.Value}");
}
else
{
    Console.WriteLine("b does not have a value");
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/46dac2e4-590d-4c44-a345-34dc9a28a312)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex05
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/870b5d4f-2f49-47b4-810a-04c62781ad61)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-04/assets/144197034/9883223c-0365-4b4b-87d7-c6cf41bc56a7)


7. อธิบายสิ่งที่พบในการทดลอง

### ศึกษาเพิ่มเติม

https://www.loginradius.com/blog/engineering/nullable-csharp/
