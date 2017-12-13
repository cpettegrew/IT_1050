---
uti: com.xamarin.workbook
id: 26ae63ba-bcb0-4dfc-a097-2589918e0682
title: Lab3
platforms:
- MacMobile
---

```csharp
public class Program{

    public class Instructor{
        private string Name = "untitled";
        private string CourseName = "unknown";

        public Instructor(string name, string courseName){
            this.Name = name;
            this.CourseName = courseName;
        }

        pubic void SetStudentGrade(Student student, int grade){
            student.SetGrade(grade);
        }

        public void Print(){
            System.Console.WriteLine(Name);
            System.Console.WriteLine(CourseName);
        }
    }

    public class Student{
        private string Name = "untitled";
        private int Grade = 0;
        private string Teacher = "unknown";

        public Student(string name, string teacher){
            this.Name = name;
            this.Teacher = teacher;
        }

        public void SetGrade(int newGrade){
            this.Grade = newGrade;
        }

        public void Print(){
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Grade);
            System.Console.WriteLine(Teacher);
        }

    }

    public class main(string[] args){
        Instructor John = new Instructor(John, English);
        Instructor Mike = new Instructor(Mike, Math);
        Student Jane = new Student(Jane, John);
        Student Joe = new Student(Joe, John);
        Student Melissa = new Student(Melissa, Mike);
        Student Matt = new Student(Matt, Mike);

        John.SetStudentGrade(Jane, 95);
        John.SetStudentGrade(Joe, 85);
        Mike.SetStudentGrade(Melissa, 90);
        Mike.SetStudentGrade(Matt, 92);

        Jane.Print();
        John.Print();
        Melissa.Print();
        Matt.Print();
    }

}
```