using System;

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
            string[] BookCategories = new string[100];
            int[] BorrowCount = new int[100];
            int LastBookIndex = -1;

            //seed data 
            BookTitles[0] = "Math";
            BookISBNs[0] = "A101";
            BookAvailability[0] = true;
            BorrowerNames[0] = "";
            BookAuthors[0] = "Ali";
            BookCategories[0] = "Science";
            BorrowCount[0] = 2;
            LastBookIndex++;

            BookTitles[1] = "ComputerNetworks";
            BookISBNs[1] = "A202";
            BookAvailability[1] = false;
            BorrowerNames[1] = "Fatma";
            BookAuthors[1] = "Ahmed";
            BookCategories[1] = "Computer Science";
            BorrowCount[1] = 5; 
            LastBookIndex++;

            BookTitles[2] = "Chemistry";
            BookISBNs[2] = "A303";
            BookAvailability[2] = false;
            BorrowerNames[2] = "Sara";
            BookAuthors[2] = "Mohammed";
            BookCategories[2] = "Science";
            BorrowCount[2] = 3;
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
                        LastBookIndex++;
                        Console.WriteLine("Enter the book title: ");
                        BookTitles[LastBookIndex] = Console.ReadLine();

                        Console.WriteLine("Enter the book author: ");
                        BookAuthors[LastBookIndex]= Console.ReadLine();

                        Console.WriteLine("Enter the book ISBN");
                        BookISBNs[LastBookIndex]= Console.ReadLine();

                        BookAvailability[LastBookIndex]= true;
                        BorrowerNames[LastBookIndex] = "";


                        Console.WriteLine("New Book Added successfully!");

                        break;

                    case 2:
                        Console.WriteLine("Enter the book title or ISBN: ");
                        string ISBNorTitle= Console.ReadLine();
                        
                        bool BookFound= false;

                        for(int i = 0; i <= LastBookIndex; i++)
                        {
                            if (ISBNorTitle == BookTitles[i] || ISBNorTitle == BookISBNs[i])
                            {
                                BookFound = true;

                                if (BookAvailability[i] == true)
                                {
                                    Console.WriteLine("Borrower name:");
                                    BookAvailability[i] = false;
                                    BorrowerNames[i] = Console.ReadLine();
                                    Console.WriteLine("Book borrowed successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Book borrowed alraedy");
                                }
                                break;
                            }
                            
                        }

                        if (BookFound == false) //if (!BookFound) 
                        {
                            Console.WriteLine("Sorry the book is not found");
                        }
                        break;


                    case 3:
                        Console.WriteLine("Enter the book ISBN: ");
                        string bookISBN = Console.ReadLine();

                        bool bookFound = false;
                        for (int i = 0; i <= LastBookIndex; i++)
                        {
                            if (bookISBN == BookISBNs[i])
                            {
                                BookFound = true;
                                BorrowerNames[i] = ""; 
                                BookAvailability[i] = true;
                                Console.WriteLine("Book returned successfully!");
                            
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
                        for (int i = 0; i <= LastBookIndex; i++)
                        {
                            if (ISBN_Title == BookTitles[i] || ISBN_Title == BookISBNs[i])
                            {
                                BookisFound = true;
                                Console.WriteLine("Book Title: " + BookTitles[i] + "Book Authors: " + BookAuthors[i] + "Book ISBN: " + BookISBNs[i] + "Book Availability: " + BookAvailability[i] + "Borrower Names: " + BorrowerNames[i]);
                                break;
                            }
                        }

                        if (BookisFound == false)
                        {
                            Console.WriteLine("Sorry the book is not found");
                        }
                             break;


                    case 5:
                        Console.WriteLine("The available books: ");

                        for (int i = 0; i <= LastBookIndex; i++)
                        {
                            if (BookAvailability[i] == true)
                            {
                                Console.WriteLine("Title: " + BookTitles[i] + "Author: " + BookAuthors[i] + "ISBN: " + BookISBNs[i]);
                                break;
                            }
                        }

                            break;


                    case 6:
                        Console.WriteLine("Enter first borrower name");
                        string FirstBorrowerName = Console.ReadLine();

                        Console.WriteLine("Enter second borrower name");
                        string SecondBorrowerName = Console.ReadLine();

                        bool FirstBorrower_found = false;
                        int FirstBorrowerIndex = 0;

                        for(int i = 0; i <= LastBookIndex; i++)
                        {
                            if(FirstBorrowerName == BorrowerNames[i])
                            {
                                FirstBorrowerIndex = i;
                                FirstBorrower_found = true;
                                break;
                            }
                            
                        }

                        if (FirstBorrower_found == false)
                        {
                            Console.WriteLine("First borrower name is not found");
                        }
                        else //current borrower name found and proceed to find new borrower name
                        {
                            bool SecondBorrower_found = false;
                            int SecondBorrowerIndex = 0;

                            for (int i = 0; i <= LastBookIndex; i++)
                            {
                                if (SecondBorrowerName == BorrowerNames[i])
                                {
                                    SecondBorrowerIndex = i;
                                    SecondBorrower_found = true;
                                    break;
                                }

                            }

                            if (SecondBorrower_found == false)
                            {
                                Console.WriteLine("Second borrower name is not found");
                            }
                            else //new borrower name found and proceed to transfer book
                            {
                                string temp = "";
                                temp = BorrowerNames[FirstBorrowerIndex];
                                BorrowerNames[FirstBorrowerIndex] = BorrowerNames[SecondBorrowerIndex];
                                BorrowerNames[SecondBorrowerIndex] = temp;

                                Console.WriteLine("Book Transfered  successfully!");

                            }

                        }

                        break;


                    case 7:
                        Exit = true;
                        break;


                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }

                Console.WriteLine("Thank you for using the Library Management System, Press any key to continue");
                Console.ReadLine();
                Console.Clear();
 
            }











        















































        }
    }
}
