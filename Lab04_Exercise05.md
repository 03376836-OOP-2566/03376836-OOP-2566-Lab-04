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

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-04/assets/144195611/8bc4d0b4-1968-4fa2-ae2b-e5c89ac592e1)


7. อธิบายสิ่งที่พบในการทดลอง
- มีการใช้งาน  null type int? เพื่อให้ตัวแปรสามารถเก็บค่า null และมีการตรวจสอบ a ,b มีค่าหรือไม่ด้วย
### ศึกษาเพิ่มเติม

https://www.loginradius.com/blog/engineering/nullable-csharp/
