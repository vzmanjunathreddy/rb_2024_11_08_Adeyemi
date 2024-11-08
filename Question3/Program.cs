// See https://aka.ms/new-console-template for more information
using Question3;

Console.WriteLine("Hello, World!");


var courses = new List<Course>() 
{ 
    new Course { Id = Guid.NewGuid() , Credits = 1 , Name = "English"},
        new Course { Id = Guid.NewGuid() , Credits = 5, Name = "Maths"}
};

var students = new List<Student>()
{
    new Student { Id = Guid.NewGuid() , Age = 3, Name = "Adeyemi", Gpa = 299, Courses = new List<Course>() { } }
};