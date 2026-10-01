using System;
using System.Collections.Generic;






var students = new List<Student>
{
    new() { Id = 1, FirstName = "Ali", LastName = "Karimov", Age = 20, Gender = Gender.Male, Status = Status.Active, DateOfStart = new(2024, 9, 1), DateOfFinish = new(2028, 6, 30) },
    new() { Id = 2, FirstName = "Aisha", LastName = "Nurova", Age = 19, Gender = Gender.Female, Status = Status.Active, DateOfStart = new(2025, 9, 1), DateOfFinish = new(2029, 6, 30) },
    new() { Id = 3, FirstName = "Timur", LastName = "Sadykov", Age = 22, Gender = Gender.Male, Status = Status.InActive, DateOfStart = new(2022, 9, 1), DateOfFinish = new(2026, 6, 30) },
    new() { Id = 4, FirstName = "Dilnoza", LastName = "Rahimova", Age = 21, Gender = Gender.Female, Status = Status.Active, DateOfStart = new(2023, 9, 1), DateOfFinish = new(2027, 6, 30) },
    new() { Id = 5, FirstName = "Omar", LastName = "Yusupov", Age = 23, Gender = Gender.Male, Status = Status.InActive, DateOfStart = new(2021, 9, 1), DateOfFinish = new(2025, 6, 30) },
    new() { Id = 6, FirstName = "Madina", LastName = "Aliyeva", Age = 18, Gender = Gender.Female, Status = Status.Active, DateOfStart = new(2025, 9, 1), DateOfFinish = new(2029, 6, 30) },
    new() { Id = 7, FirstName = "Jasur", LastName = "Tursunov", Age = 20, Gender = Gender.Male, Status = Status.Active, DateOfStart = new(2024, 9, 1), DateOfFinish = new(2028, 6, 30) },
};

// Task1
// var GenderStudentMale=students.Where(s => s.Gender == Gender.Male).ToList();
// foreach(var Males in GenderStudentMale)
// {
//     System.Console.WriteLine($"Id : {Males.Id} FirstName:{Males.FirstName} Lastname : {Males.LastName}     ");
// }


// Task2
// var StudentWhereIsActive=students.Where(s=>s.Status==Status.InActive);
// foreach(var Males in StudentWhereIsActive)
// {
//     System.Console.WriteLine($"Id : {Males.Id} Fullname:{Males.FirstName}  {Males.LastName}     ");
// }

// Task3
// var StudentWhereAgeOldOf20=students.Where(s=>s.Age>20);
// foreach(var Males in StudentWhereAgeOldOf20)
// {
//     System.Console.WriteLine($"Id : {Males.Id} Fullname:{Males.FirstName}  {Males.LastName}     ");
// }

// Task4
// var AgeOfsTudent=students.Where(s=>s.Age>20 );
// var Actives=AgeOfsTudent.Where(x=>x.Status==Status.Active);
// foreach(var Males in Actives)
// {
//     System.Console.WriteLine($"Id : {Males.Id} Fullname:{Males.FirstName}  {Males.LastName}  {Males.Age}   ");
// }


// Task5
// var ActiveStudents = students
//     .Where(s => s.Status == Status.Active && s.DateOfStart.Year >= 2024)
//     .ToList();

// foreach (var student in recentActiveStudents)
// {
//     Console.WriteLine($"Id : {student.Id} | Fullname: {student.FirstName} {student.LastName} | Start Date: {student.DateOfStart:yyyy-MM-dd}");
// }
// task 6
// double avaregAge = students
//     .Where(s => s.Status == Status.Active)
//     .Average(s => s.Age);

// Console.WriteLine($"Average Age of Active Students: {avgAge:F1}");












public enum Gender { Male, Female }
public enum Status { Active, InActive }

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Status Status { get; set; }
    public DateTime DateOfStart { get; set; }
    public DateTime DateOfFinish { get; set; }
}




