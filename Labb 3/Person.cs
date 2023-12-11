using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    public class Person
    {
        // Properties
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Hair Hair { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Eyecolor { get; private set; }

        //Constructor
        public Person(String name, Gender gender,Hair hair, DateTime birthday, string eyecolors)
        {
            Name = name;
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            Eyecolor = eyecolors;
        }
        public override string ToString()
        {
            return $"Name: {Name}" +
                $"\nGender: {Gender}" +
                $"\nHair: {Hair.haircolor} and {Hair.Hairlenght}" +
                $"\nBirthday: {Birthday: yyyy/MM/dd}" +
                $"\nEyecolor: {Eyecolor}";
        }
    }
}
