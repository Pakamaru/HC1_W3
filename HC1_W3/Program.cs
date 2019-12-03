using System;

namespace HC1_W3
{
    struct Student
    {
        public string Naam { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Naam = "Jan";
            VeranderNaam(s);
            Console.WriteLine(s.Naam);
        }

        public static void VeranderNaam(Student student)
        {
            student.Naam = "Bob";
        }
    }
}
