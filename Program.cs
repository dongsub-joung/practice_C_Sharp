using System;
using System.ComponentModel;

class Human
{
    protected int age;
    protected int sex;
    protected String name;

    public Human(int age, int sex, String name){
        this.age = age;
        this.sex = sex;
        this.name = name;
    }

    public void saying()
    {
        Console.WriteLine("I'm human");
    }
}

class White : Human
{
    public White(int age, int sex, string name) : base(age, sex, name)
    {
        this.age = age;
        this.sex = sex;
        this.name = name;
    }

    public void intro()
    {
        Console.WriteLine("white");
    }
}
class Black : Human
{
    public Black(int age, int sex, string name) : base(age, sex, name)
    {
        this.age = age;
        this.sex = sex;
        this.name = name;
    }
    public void intro()
    {
        Console.WriteLine("black");
    }
}
class Yellow : Human
{
    public Yellow(int age, int sex, string name) : base(age, sex, name)
    {
        this.age = age;
        this.sex = sex;
        this.name = name;
    }

    public void intro()
    {
        Console.WriteLine("yellow");
    }
}

class Program
{
    public static void Main()
    {
        Human human = new Human(2,1,"a");

        White w = new White(10, 0, "b");
        
        human.saying();

        w.intro();

        // Whatever
        GC.Collect();
    }
}