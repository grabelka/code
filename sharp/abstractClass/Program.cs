using System;
using System.Collections.Generic;

namespace kpi
{
    public abstract class Kpishnik
    {
        public string name;
        public string role;
        public virtual void Voice()
        {
            Console.WriteLine("I am KPIshnik");
        }
    }
    public class Teacher : Kpishnik
    {
        private int salary;
        public Teacher(int salary, string name)
        {
            role = "Teacher";
            this.salary = salary;
            this.name = name;
        }
        public override void Voice()
        {
            Console.Write(ToString());
            Console.WriteLine($"said: Fuck my life. {salary} UAH is realy a little money.");
        }
        virtual public void Teach()
        {
            Console.Write(ToString());
            Console.WriteLine("said: AHAHAHAHA, dude! We are in KPI. Do you realy think I will teach you guys?");
        }
        public override string ToString()
        {
            return $"{role} {name} with salary {salary} UAH ";
        }
    }
    public class GoodTeacher : Teacher
    {
        public GoodTeacher(int salary, string name): base(salary, name)
        {}
        public override void Teach()
        {
            Console.Write(ToString());
            Console.WriteLine("said: I'll fuck yours stupid heads LOL.");
        }
    }
    public class BorringTeacher : Teacher
    {
        public BorringTeacher(int salary, string name): base(salary, name)
        {}
        public override void Teach()
        {
            Console.Write(ToString());
            Console.WriteLine("said: BLAH, BLAH, BLAH...");
        }
    }
    public class ParanoidTeacher : Teacher
    {
        public ParanoidTeacher(int salary, string name): base(salary, name)
        {}
        public override void Teach()
        {
            Console.Write(ToString());
            Console.WriteLine("said: You, dudes, should throw away yours microwave ovens and turn off Wi-Fi!");
        }
    }
    public class Student : Kpishnik
    {
        readonly int group;
        public Student(int group, string name)
        {
            role = "Student";
            this.group = group;
            this.name = name;
        }
        public override void Voice()
        {
            Console.Write(ToString());
            Console.WriteLine("said: I am a Student of KPI");
        }
        public void Drink()
        {
            Console.Write(ToString());
            Console.WriteLine("said: Oh shit, I'm wasted.");
        }
        public void Learn(string lesson)
        {
            Console.Write(ToString());
            Console.WriteLine($"said: FUUUUCK, {lesson} is so bored");
        }
        public override string ToString()
        {
            return $"{role} of group KP-0{group} {name} ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            // Console.Write("Print a name: \t");
            // string name = Console.ReadLine();
            // Console.Write("Print a group: \t");
            // int group = Convert.ToInt32(Console.ReadLine());
            // Student s1 = new Student(group, name);
            if (key.Key == ConsoleKey.T)
            {
                Console.WriteLine("eachers");
                List<Teacher> teachers = new List<Teacher>();
                bool cont = true;
                while(cont)
                {
                    Console.Write("Print a name: \t");
                    string name = Console.ReadLine();
                    Console.Write("Print a salary: \t");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    Teacher t1 = new BorringTeacher(salary, name);
                    teachers.Add(t1);
                    System.Threading.Thread.Sleep(1000);
                    key = Console.ReadKey();
                    if(key.Key == ConsoleKey.Escape) cont = false;
                }
                Console.WriteLine("yYour teachers:");
                foreach (Teacher t in teachers)
                {
                    Console.WriteLine(t.ToString());
                }
            }
        }
    }
}
