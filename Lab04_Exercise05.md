# Lab 4 Exercise 5

## nullable type



1. สร้าง console application project

```
dotnet new console --name Lab04_Ex05
```
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

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab04_Ex05
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="798" alt="Screenshot 2024-03-24 141532" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/4b476f37-eadd-4d50-b0e9-91b27cec7f64">

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="796" alt="Screenshot 2024-03-24 141730" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-04/assets/144196049/4fd50239-8ed3-4f33-b11d-479eb737dd7a">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดงผล a does not have a value เพราะเรากำหนดให้ค่า a = null ถ้า a = 10 โปรแกรมจะแสดงผล a = 10 แทน เหมือนของ b = 10 ตามลำดับ int? สามารถเก็บค่า null ได้หรือเก็บค่าจำนวนเต็มได้

### ศึกษาเพิ่มเติม

https://www.loginradius.com/blog/engineering/nullable-csharp/
