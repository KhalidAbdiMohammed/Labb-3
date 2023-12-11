namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string name = "Khalid Abdi Mohammed";
            Gender gender = Gender.Man;
            Hair hair = new Hair { haircolor = "Black", Hairlenght = "Short hair at least 4cm" };
            DateTime birthday = new DateTime(2000, 08, 08);
            string eyecolor = "brown";

            Person person = new Person(name, gender, hair, birthday, eyecolor);

            // Skriva ut data om personen till konsolen
            Console.WriteLine(person.ToString());

            Console.ReadKey();
        }
    }
}