using System;
using System.ComponentModel.DataAnnotations;
using static System.Console;

Employee manager = new Manager("Ted", "Pit", "Ptr", 25, "Высшее", 4000, "Продукты питания");
Employee[] emplayees =
{
    new Employee("Tom", "Soyer", "Ptr", 30, "Среднее", 3000),
    manager,
    new Scientist("Jim", "Beam", "Ptr", 30, "Высшее", 4500, "История")
};
foreach (Employee empl in emplayees)
{
    WriteLine(empl.ToString() + "\n"); 
}

WriteLine("\n\tПримечание: \nПервая часть задания (\" Написать программу с тремя классами. Человек, работник, менеджер. " +
    "Каждому классу добавить свои поля. Написать пару тестов. \" Прикреплена к предыдущему ДЗ");

public abstract class Human

{
    internal string firstName;
    internal string lastName;
    internal string ptrName;
    internal int age;

    public Human()
    {
        Write("Введите фамилию: ");
        lastName = ReadLine();
        Write("Введите имя: ");
        firstName = ReadLine();
        Write("Введите отчество: ");
        ptrName = ReadLine();
        Write("Введите возраст: ");
        age = Convert.ToInt32(ReadLine());
    }

    public Human(string lName, string fName)
    {
        firstName = fName;
        lastName = lName;
    }

    public Human(string lName, string fName, string pName)
    {
        firstName = fName;
        lastName = lName;
        ptrName = pName;
    }
    public Human(string lName, string fName, string pName, int ag)
    {
        firstName = fName;
        lastName = lName;
        ptrName = pName;
        age = ag;
    }
    public virtual string ToString()
    {
        return $"\"Человек. ФИО: {lastName} {firstName} {ptrName} \nвозраст: {age}\n";
    }
}

public class Employee : Human
{
    internal string _educated;
    internal double _salary;
    //int age = DateTime.Now.Year - birthDate.Year;

    public Employee()
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.ptrName = ptrName;
        this.age = age;
        Write("Введите образование: ");
        _educated = ReadLine();
        Write("Введите зарплату: ");
        _salary = Convert.ToDouble(ReadLine());
    }
    public Employee(string lName, string fName) : base(lName, fName)
    {

    }
    public Employee(string lName, string fName, string pName) : base(lName, fName, pName)
    {

    }
    public Employee(string lName, string fName, string pName, int age) : base(lName, fName, pName, age)
    {

    }
    public Employee(string lName, string fName, string pName, int age, double salary) : base(lName, fName, pName, age)
    {

        _salary = salary;
    }
    public Employee(string lName, string fName, string pName, int age, string educat, double salary) : base(lName, fName, pName, age)
    {

        _salary = salary;
        _educated = educat;
    }

    public override string ToString()

    {
        return $"Сотрудник. ФИО: {lastName} {firstName} {ptrName} \nВозраст: {age} \nОбразование: {_educated} \nЗарплата: {_salary}";
    }
}

class Manager : Employee
{
    string _fieldActivity;
    public Manager(string lName, string fName, string pName, int age, string educat, double salary, string activity) : base(lName, fName, pName, age, educat, salary)
    {
        _fieldActivity = activity;
    }
    public override string ToString()
    {
        WriteLine(base.ToString());
        return $"Менеджер. Сфера деятельности: {_fieldActivity}\n";
    }

}

class Scientist : Employee
{
    string _scientificDirection;
    public Scientist(string lName, string fName, string pName, int age, string educat, double salary, string direction) : base(lName, fName, pName, age, educat, salary)
    {
        _scientificDirection = direction;
    }

    public override string ToString()
    {
        WriteLine(base.ToString());
        return $"Учёный. Научное направление: {_scientificDirection}\n";
    }
}