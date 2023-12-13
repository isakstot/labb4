namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            List<string> Persons = new List<string>();
            while (!exit)
            {
                Console.WriteLine("Menu options...");
                string menuInput = Console.ReadLine();
                //add validation
                switch (menuInput)
                {
                    //exit
                    case "0":
                        exit = true;
                        break;
                    //add new person
                    case "1":
                        break;
                    //print all persons
                    case "2":
                        break;

                    default:
                        //invalid input message
                        break;
                }
            }
            Gender gender = Gender.Male;
            Hair hairCM = new Hair { Color = "Brown", LenghtCM = 15 };
            DateTime birthday = new DateTime(2004, 06, 28);
            string eyeColor = "Green";

            Person examplePerson = new Person(gender, hairCM, birthday, eyeColor);
            Console.WriteLine(examplePerson.ToString());
        }
    }
}