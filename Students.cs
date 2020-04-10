using System;

public class Students : Person
{
    public Students(string name, int age, string studentsid, string email) : base(name, age)
    {
        Name = name;
        Age = age;
        StudentsId = studentsid;
        Email = email;
    }
    public string StudentsId {get; set;}
    public string Email {get; set;}
}