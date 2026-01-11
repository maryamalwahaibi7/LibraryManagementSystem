namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System Storage
            string[] BookTitles = new string[100];
            string[] BookISBNs = new string[100];
            bool[] BookAvailability = new bool[100];
            string[] BorrowerNames = new string[100];
            string[] BookAuthors = new string[100];
            int LastBookIndex = -1;

            //seed data 
            BookTitles[0] = "Math";
            BookISBNs[0] = "A101";
            BookAvailability[0] = true;
            BorrowerNames[0] = "Sara";
            BookAuthors[0] = "Ali";
            LastBookIndex++;

            BookTitles[1] = "ComputerNetworks";
            BookISBNs[1] = "A202";
            BookAvailability[1] = true;
            BorrowerNames[1] = "Fatma";
            BookAuthors[1] = "Ahmed";
            LastBookIndex++;

            bool Exit = false;

            while (true)
            {
                Console.WriteLine("Welcome to the Library Management System");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book ");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. List All Available Books");
                Console.WriteLine("6. Transfer Book ");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please select an option: ");
                int option = int.Parse(Console.ReadLine());


                switch(option)
                {
                    case 1:
                        break;


                    case 2:
                        break;


                    case 3:
                        break;


                    case 4:
                        break;


                    case 5:
                        break;


                    case 6:
                        break;


                    case 7:
                        Exit = true;
                        break;


                    default:
                        break;

                }

                if (Exit == true)
                {
                    break;
                }

                Console.WriteLine("Thank you for using the Library Management System, Press any key to continue");
                Console.ReadLine();
                Console.Clear();

            }











        















































        }
    }
}
