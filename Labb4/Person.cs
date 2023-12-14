using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    public class Person
    {
        public Gender TheGender { get; private set; }
        public Hair TheHair { get; private set; }
        public DateTime Birthday { get; private set; }
        public string EyeColor { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName, Gender gender, Hair hair, DateTime birthday, string eyeColor)
        {
            TheGender = gender;
            TheHair = hair;
            Birthday = birthday;
            EyeColor = eyeColor;
            FirstName = firstName;
            LastName = lastName;
        }


        public override string ToString()
        {
            return
                $"First name: {FirstName}\n" +
                $"Last name: {LastName}\n" +
                $"Gender: {TheGender}\n" +
                $"Hair color: {TheHair.Color}\n" +
                $"Hair lenght: {TheHair.LenghtCM} (cm)\n" +
                $"Date of birth: {Birthday:yyyy:MM:dd} (yyyy:MM:dd)\n" +
                $"Eye color: {EyeColor}";
        }
    }
}
