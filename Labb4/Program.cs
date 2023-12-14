using System.Numerics;

namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            List<Person> people = new List<Person>();
            while (!exit)
            {
                Console.WriteLine("Press 1 to add new person\n" +
                                  "Press 2 to list the added people\n"+
                                  "Press 0 to exit the program");
                string menuInput = Console.ReadLine();
                
                switch (menuInput)
                {
                    //exit
                    case "0":
                        exit = true;
                        break;
                    //add new person
                    case "1":
                        AddPerson(people);
                        break;
                    //print all people
                    case "2":
                        PrintAllPeople(people);
                        break;

                    default:
                        //invalid input message
                        break;
                }
            }
        }

        static string TakeValidStringInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input, please try again");
                return TakeValidStringInput();
            }
            else {
                return input;
            }
        }

        static void AddPerson(List<Person> PeopleList)
        {
            Console.WriteLine("Enter the first name of the person:");
            string firstName = TakeValidStringInput();
            Console.WriteLine("Enter the last of the person");
            string lastName = TakeValidStringInput();
            //validate input
            Console.WriteLine("Enter the gender of the person - Male, Female, Nonbinary or other");
            Enum.TryParse(Console.ReadLine(), out Gender gender);
            //validate input
            Console.WriteLine("Enter the hair color of the person:");
            string hairColor = TakeValidStringInput();
            //validate input
            Console.WriteLine("Enter the hair lenght of the person (cm):");
            int hairLenght = int.Parse(Console.ReadLine());
            //validate input
            Hair hair = new Hair { Color = hairColor, LenghtCM = hairLenght };

            Console.WriteLine("Enter the birth year of the person");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the birth month of the person");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the birth day of the person");
            int day = int.Parse(Console.ReadLine());
            DateTime birthday = new DateTime(year, month, day);
            //validate input
            Console.WriteLine("Enter the eye color of the person:");
            string eyeColor = Console.ReadLine();
            //validate input
            Person newPerson = new Person(firstName, lastName, gender, hair, birthday, eyeColor);
            //add to people list
            PeopleList.Add(newPerson);

            return;
        }

        static void PrintAllPeople(List<Person> peopleList)
        {
            foreach (Person person in peopleList)
            {
                Console.WriteLine("\nList of people stored:");
                Console.WriteLine(person.ToString());
                Console.WriteLine("");
            }
        }
    }
}