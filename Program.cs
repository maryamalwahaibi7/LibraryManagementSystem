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
            BorrowerNames[0] = "";
            BookAuthors[0] = "Ali";
            LastBookIndex++;

            BookTitles[1] = "ComputerNetworks";
            BookISBNs[1] = "A202";
            BookAvailability[1] = false;
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
                        Console.WriteLine("Enter the book title: ");
                        BookTitles[LastBookIndex + 1] = Console.ReadLine();

                        Console.WriteLine("Enter the book author: ");
                        BookAuthors[LastBookIndex + 1]= Console.ReadLine();

                        Console.WriteLine("Enter the book ISBN");
                        BookISBNs[LastBookIndex + 1]= Console.ReadLine();

                        BookAvailability[LastBookIndex + 1]= true;

                        Console.WriteLine("New Book Added successfully!");
                        LastBookIndex++;

                        break;

                    case 2:
                        Console.WriteLine("Enter the book title or ISBN: ");
                        string ISBNorTitle= Console.ReadLine();
                        
                        bool BookFound= false;

                        for(int i = 0; i<100; i++)
                        {
                            if (ISBNorTitle == BookTitles[i] || ISBNorTitle == BookISBNs[i])
                            {
                                BookFound = true;

                                if (BookAvailability[i] == true)
                                {
                                    BookAvailability[i] = false;
                                }
                                else
                                {
                                    Console.WriteLine("Book borrowed alraedy");
                                }
                                break;
                            }
                            
                        }

                        if (BookFound == false)
                        {
                            Console.WriteLine("Sorry the book is not found");
                        }
                        else
                        {
                            Console.WriteLine("Enter your name: ");
                            string BorrowedName = Console.ReadLine();
                            Console.WriteLine("Book borrowed successfully!");
                        }
                        
                        break;


                    case 3:
                        Console.WriteLine("Enter the book ISBN: ");
                        string bookISBN = Console.ReadLine();

                        bool bookFound = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (bookISBN == BookISBNs[i])
                            {
                                BookFound = true;

                                if (BookAvailability[i] == false)
                                {
                                    Console.WriteLine("Enter borrowed name: ");
                                    string BName = Console.ReadLine();
                                    BookAvailability[i] = true;
                                    Console.WriteLine("Book returned successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Book alraedy available");
                                }
                                break;
                            }
                        }
                        if (bookFound == false)
                        {
                            Console.WriteLine("Sorry the book is not found");
                        }
                        
                        break ;


                    case 4:

                        Console.WriteLine("Enter the book title or ISBN: ");
                        string ISBN_Title = Console.ReadLine();

                        bool BookisFound = false;

                        bool currentBookAvailability = false;
                        string currentBorrowerNames = "";
                        string currentBookAuthors = "";

                        for (int i = 0; i < 100; i++)
                        {
                            if (ISBN_Title == BookTitles[i] || ISBN_Title == BookISBNs[i])
                            {
                                currentBookAvailability = BookAvailability[i];
                                currentBorrowerNames = BorrowerNames[i];
                                currentBookAuthors = BookAuthors[i];

                                BookisFound = true;
                                break;
                            }
                        }

                        if (BookisFound == false)
                        {
                            Console.WriteLine("Sorry the book is not found");
                        }
                        else
                        {
                            Console.WriteLine("Book Availability: " + currentBookAvailability);
                            Console.WriteLine("Borrower Names: " + currentBorrowerNames);
                            Console.WriteLine("Book Authors: " + currentBookAuthors);
                        }
                             break;


                    case 5:
                        bool Book_Found = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (BookAvailability[i] == true)
                            {
                                Console.WriteLine("The available books: " + BookTitles[i]); 
                                Book_Found = true;
                                break;
                            }
                        }

                        if (Book_Found == false)
                        {
                            Console.WriteLine("Sorry the book is not found");
                        }


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
