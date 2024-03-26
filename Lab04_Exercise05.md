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
   ![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-04/assets/144195708/87e280da-5c91-455f-aabf-b50d0e168dd6)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab04_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-04/assets/144195708/a76c7ee8-06c3-4332-abf4-81a301e90470)

7. อธิบายสิ่งที่พบในการทดลอง
8. โปรแกรมแสดงผล a does not have a value เพราะเรากำหนดให้ค่า a = null ถ้า a = 10 โปรแกรมจะแสดงผล

a = 10 แทน เหมือนของ b = 10 ตามลำดับ int? สามารถเก็บค่า null ได้

### ศึกษาเพิ่มเติม

https://www.loginradius.com/blog/engineering/nullable-csharp/
