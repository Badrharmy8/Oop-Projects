using System;
using System.Globalization;

class Course
{
    int i = 0;
    List<int> c_id = new List<int>();
    public void setC_id(List <int> c_id)
    {
        this.c_id.Add(c_id.ElementAt(i));
    }
    public int getC_id()
    {
        return this.c_id.ElementAt(i);
    }
    public List<String> c_name = new List<string>();
    public List<int> totalDegree = new List<int>();
    public List<string> lec_name = new List<string>();
    public List<double> hours = new List<double>();
    public void addC(Course course)
    {
        setC_id(c_id);
        course.c_name = c_name;
        course.lec_name = lec_name;
        course.totalDegree = totalDegree;
        course.hours = hours;
     
    }
    public void diplayC(int n)
    {
        Console.WriteLine("Course Id : " + getC_id());
        Console.WriteLine("Course Name : " + this.c_name.ElementAt(n));
        Console.WriteLine("Course Lecturer : " + this.lec_name.ElementAt(n));
        Console.WriteLine("Course Total Degree : " + this.totalDegree.ElementAt(n));
        Console.WriteLine("Number Of Hours  : " + this.hours.ElementAt(n));
    }
}
class Student
{
    int id;
    public void setId(int id)
    {
        this.id = id;
    }
    public int getId()
    {
        return this.id;
    }
    public string name;
    public int age;
    public string address;
    string phone;
    public void setPhone(string phone)
    {
        if(phone.Length == 11)
        {
            this.phone = phone;
        }
        else
        {
            Console.WriteLine("Invalid Phone Number");
        }
    }
    public string getPhone()
    {
        return this.phone;
    }
    public int numOfCourses;
    public Course course;
    public void add(Student student)
    {
        student.setId(id);
        student.name = name;
        student.age = age;
        student.address = address;
        student.setPhone(phone);
        student.numOfCourses = numOfCourses;
        course.addC(course);
    }
    public void display()
    {
        Console.WriteLine("Student Id : " + getId());
        Console.WriteLine("Student Name : " + this.name);
        Console.WriteLine("Student Age: " + this.age);
        Console.WriteLine("Student Address : " + this.address);
        Console.WriteLine("Student Phone Number : " + getPhone());
        Console.WriteLine("Number Of Courses That Student Recorded : " + this.numOfCourses);
        for(int  j = 0; j < numOfCourses; j++)
        {
            course.diplayC(j);
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.setId(36592);
        student.name = "Mona Ahmed Elsayed";
        student.age = 22;
        student.address = "Mansoura";
        student.setPhone("01523666557");
        student.numOfCourses = 3;
        Course course = new Course();
        course.setC_id([196 , 197 , 198]);
        course.c_name = ["Math", "Web" , "Data Structure"];
        course.lec_name = ["Dr.Ahmed", "Dr.Ali" , "Dr.Sara"];
        course.totalDegree = [150, 100 , 200];
        course.hours = [100, 80 , 150];
        student.course = course;
        student.add(student);
        student.display();
    }
}