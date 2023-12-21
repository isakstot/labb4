using System.Numerics;

namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add new person\n" +
                                  "2. List all added people\n"+
                                  "0. Exit the program");

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
                        Console.WriteLine("\nList of people stored:");
                        ListPersons(people);
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
                Console.WriteLine("");
            }
        }

        static string GetValidStringInput()
        {
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input, value can not be empty");
                }
                else
                {
                    return input;
                }
            } while (true);
        }

        static int GetValidIntInput()
        {
            //remake to use do while loop
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input, value can not be empty");
                }
                else if (int.TryParse(input, out int result))
                {
                    return int.Parse(input);
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter an integer");
                }
            } while (true);
        }

        static DateTime GetValidDateTimeInput(string errorMessage)
        { 
            do
            {
                string input = Console.ReadLine();
                if (DateTime.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return DateTime.Parse(input);
                }
                //check if input is a valid date in yyyyMMdd format, use the standard culture
                else if (DateTime.TryParseExact(input, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime result2))
                {
                    //add dashes to the date, so it can be parsed to a DateTime object
                    input = input.Insert(4, "-");
                    input = input.Insert(7, "-");
                    return DateTime.Parse(input);
                }
                else
                {
                    //if input is not a valid date in either format, ask for a new input
                    Console.WriteLine("Invalid input. " + errorMessage);
                }
            } while (true);
        }

        static Gender GetValidEnumInput(string errorMessage)
        {
            do
            {
                string input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Gender result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. " + errorMessage);
                }
            } while (true);
        }

        static void AddPerson(List<Person> peopleList)
        {
            Console.WriteLine("Enter the first name of the person:");
            string firstName = GetValidStringInput();

            Console.WriteLine("Enter the last name of the person");
            string lastName = GetValidStringInput();
            
            Console.WriteLine("Enter the gender of the person - Male, Female, Nonbinary or Other");
            Gender gender = GetValidEnumInput("Choose \"Male\", \"Female\", \"Nonbinary\", \"Other\"");

            Console.WriteLine("Enter the hair color of the person:");
            string hairColor = GetValidStringInput();
            
            Console.WriteLine("Enter the hair lenght of the person (cm):");
            int hairLenght = GetValidIntInput();
            Hair hair = new Hair { Color = hairColor, LenghtCM = hairLenght };

            Console.WriteLine("Enter the birth date of the person (yyyy-MM-dd)");
            DateTime birthday = GetValidDateTimeInput("Date must be formated like: (yyyy-MM-dd) or yyyyMMdd");
        
            Console.WriteLine("Enter the eye color of the person:");
            string eyeColor = GetValidStringInput();
        
            //create a person
            Person newPerson = new Person(firstName, lastName, gender, hair, birthday, eyeColor);
        
            //add person to the list
            peopleList.Add(newPerson);

            return;
        }

        static void ListPersons(List<Person> peopleList)
        {
            foreach (Person person in peopleList)
            {
                Console.WriteLine("");
                Console.WriteLine(person.ToString());
            }
        }
    }
}