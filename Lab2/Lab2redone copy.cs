---
uti: com.xamarin.workbook
id: cc4e29fd-7dc9-4864-9a47-ed8992b6e739
title: Lab2redone
platforms:
- MacMobile
---

```csharp
class Program{

    public class Person
{
public int Age;
public string FirstName;
public string LastName;
public Person Spouse;

    public static double Count;
    public static double SumOfAllAges;

    public string GetFullName()
    {
        return.this.FirstName +" " + this.LastName;
    }
    
    public void PrintNameAndAge ()
    {
        System.Console.WriteLine(this.GetFullName());
        System.Console.WriteLine(this.Age);
    }
    public void GatherNameAndAge()
    {
        Console.WriteLine("What is your first name?")
        Console.ReadLine(FirstName);

        Console.WriteLine("What is your last name?")
         Console.ReadLine(LastName);

        Console.WriteLine("How old are you?")
        int.Parse(System.Console.ReadLine(Age));

        Person.Count++;
        Person.SumOfAllAges += this.Age;
    }
        public void CreateSpouse()
    {
        Console.WriteLine("Are you Married? (y/n) :")if(System.Console.ReadLine().ToLower().StartsWith("y")){
            this.Spouse = new Person();
            this.Spouse.AskUserForNameAndAge();
            this.Spouse.Spouse = this;
        }
    }

}

    static void Main( string[] args){
        Person p1 = new Person;
        p1.GatherNameAndAge();
        p1.CreateSpouse(); 

        Person p2 = new Person();
        p2.GatherNameAndAge();
        p2.CreateSpouse();

        System.Console.WriteLine("Average Age:" + Person.AverageAge());
        System.Console.ReadKey();
    }

}
```