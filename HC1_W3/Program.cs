using System;

namespace HC1_W3
{
    abstract class Persoon
    {
        public string Naam { get; set; }

        public int Leeftijd { get; set; }
    }

    class Student : Persoon
    {

    }

    class Docent : Persoon
    {
        public string Functie { get; set; }
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
