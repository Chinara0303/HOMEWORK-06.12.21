using System;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Greet();


            Teacher teacher1 = new Teacher();
            //teacher1.Greet();
            teacher1.Explain();
            
            teacher1.SetAge(32);


            Student student1 = new Student();
            //student1.Greet();
            student1.Study();
            student1.SetAge(21);
            student1.ShowAge();
           











        }
    }
}
