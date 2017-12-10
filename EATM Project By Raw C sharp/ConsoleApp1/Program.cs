using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Banking();
            Console.ReadLine();
        }
       
        public static void Banking()
        {

            Console.WriteLine("\t***************** WELCOME TO ATM BANKING-DEVELOPED BY TANVIR *****************\n");
            
            //**************************ACCOUNT NUMBER, BALANCE AND PIN SETUP************************

            var AccountNumber = new List<int>() { 255, 983, 456 };

            var PinNumber = new List<int>() { 7978, 0101, 5050 };

            var Balance = new List<int>() { 10000, 40000, 2000 };

         
            //*************USER INPUT FOR ACCOUNT NUMBER & PIN**************

            Console.Write("Please Enter your Account Number: ");

            var CardInput = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Your pin: ");

            var PinInput = int.Parse(Console.ReadLine());

            //*************************ACCOUNT, PIN NUMBER CHECK & CHOICE SELECTION FOR TRANSACTION*******************

            if ((CardInput == AccountNumber[0] && PinInput == PinNumber[0]) || (CardInput == AccountNumber[1] && PinInput == PinNumber[1]) || (CardInput == AccountNumber[2] && PinInput == PinNumber[2]))
            {
                for (int i = 0; i < 3; i++) //****************LOOP FOR UPTO THREE TIME TRANSACTION PROCESS**************
                {

                    Console.WriteLine("Please Choose Your Transaction: ");

                    Console.WriteLine("\t1. Withdraw Money\n\t2. Balance Check\n\t3. Exit");

                    Console.Write("Enter Your Choice Now: ");

                    var choice = int.Parse(Console.ReadLine());

                    // ***************WITHDRW MONEY CODE***********

                    if (choice == 1)
                    {
                        Console.Write("Enter Your Amount: ");

                        var withdraw = int.Parse(Console.ReadLine());

                        // ****FIRST ACCOUNT WITHDRAW MONEY************

                        if (CardInput == AccountNumber[0] && PinInput == PinNumber[0])
                        {
                            var Balance1 = Balance[0];

                            var CurrentBalance1 = Balance[0] - withdraw;

                            Balance[0] = CurrentBalance1;

                            if (CurrentBalance1 > 20)
                            {
                                Console.WriteLine("Success Withdraw. New Balance is: " + CurrentBalance1);

                                Console.Write("Do you Want to Quit? Yes OR No: ");

                                var quit1 = Console.ReadLine();

                                if (quit1 == "yes")
                                {
                                    Environment.Exit(0);
                                }
                                else if (quit1 == "no")
                                {
                                      Console.WriteLine("OK.Try Again From Scratch");
                                     
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Wrong Choice");


                                    Console.WriteLine("Try Again From Scratch");

                                }
                            }

                            else
                            {
                                Console.WriteLine("Sorry Not Enough Balance!\nYour Balance is: " + Balance1);

                                Console.Write("Do you Want to Quit? Yes OR No: ");

                                var quit1 = Console.ReadLine();

                                if (quit1 == "yes")
                                {
                                    Environment.Exit(0);
                                }
                                else if (quit1 == "no")
                                {
                                    Console.WriteLine("OK.Try Again From Scratch");
                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Choice");

                                    Console.WriteLine("Try Again from Scratch");
                                }
                            }
                        }

                        //**************SECOND ACCOUNT MONEY WITHDRAW CODE*****************

                        else if (CardInput == AccountNumber[1] && PinInput == PinNumber[1])
                        {
                            var Balance2 = Balance[1];

                            var CurrentBalance2 = Balance[1] - withdraw;

                            Balance[1] = CurrentBalance2;

                            if (CurrentBalance2 > 20)
                            {
                                Console.WriteLine("Success Withdraw.New Balance is: " + CurrentBalance2);

                                Console.Write("Do you Want to Quit? Yes OR No: ");

                                var quit1 = Console.ReadLine();

                                if (quit1 == "yes")
                                {
                                    Environment.Exit(0);
                                }
                                else if (quit1 == "no")
                                {
                                    Console.WriteLine("OK.Try Again From Scratch");
                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Choice");

                                    Console.Write("Try Again From Scratch");
                                }
                            }

                            else
                            {
                                Console.WriteLine("Sorry Not Enough Balance!\nYour Balance is: " + Balance2);

                                Console.Write("Do you Want to Quit? Yes OR No: ");

                                var quit1 = Console.ReadLine();

                                if (quit1 == "yes")
                                {
                                    Environment.Exit(0);
                                }
                                else if (quit1 == "no")
                                {
                                    Console.WriteLine("OK.Try Again From Scratch");
                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Choice");

                                    Console.WriteLine("Try Again from Scratch");
                                }
                            }
                        }

                        //****************** THIRD ACCOUNT MONEY WTHDRAW CODE ************************************

                        else if (CardInput == AccountNumber[2] && PinInput == PinNumber[2])
                        {
                            var Balance3 = Balance[2];

                            var CurrentBalance3 = Balance[2] - withdraw;

                            Balance[2] = CurrentBalance3;

                            if (CurrentBalance3 > 20)
                            {
                                Console.WriteLine("Success Withdraw.New Balance is: " + CurrentBalance3);

                                Console.Write("Do you Want to Quit? Yes OR No: ");

                                var quit1 = Console.ReadLine();

                                if (quit1 == "yes")
                                {
                                    Environment.Exit(0);
                                }
                                else if (quit1 == "no")
                                {
                                    Console.WriteLine("OK.Try Again From Scratch");
                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Choice");

                                    Console.WriteLine("Try Again From Scratch");
                                }
                            }

                            else
                            {
                                Console.WriteLine("Sorry Not Enough Balance!\nYour Balance is: " + Balance3);

                                Console.Write("Do you Want to Quit? Yes OR No: ");

                                var quit1 = Console.ReadLine();

                                if (quit1 == "yes")
                                {
                                    Environment.Exit(0);
                                }
                                else if (quit1 == "no")
                                {
                                    Console.WriteLine("OK.Try Again From Scratch");
                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Choice");

                                    Console.WriteLine("Try Again from Scratch");
                                }

                            }
                        }



                    }

                    // **********ONLY BALANCE CHECK CODE*******************

                    else if (choice == 2)
                    {
                        // **********ONLY BALANCE CHECK CODE FOR ACCOUNT ONE*******************

                        if (CardInput == AccountNumber[0] && PinInput == PinNumber[0])
                        {
                            Console.WriteLine("Your Balance is:" + Balance[0]);

                            Console.Write("Do you Want to Quit? Yes OR No: ");

                            var quit1 = Console.ReadLine();

                            if (quit1 == "yes")
                            {
                                Environment.Exit(0);
                            }
                            else if (quit1 == "no")
                            {
                                Console.WriteLine("OK.Try Again From Scratch");
                            }
                            else
                            {
                                Console.Write("Sorry Wrong Choice");

                                Console.WriteLine("Try Again from Scratch");
                            }
                        }

                        // **********ONLY BALANCE CHECK CODE FOR ACCOUNT TWO*******************

                        else if (CardInput == AccountNumber[1] && PinInput == PinNumber[1])
                        {
                            Console.WriteLine("Your Balance is: " + Balance[1]);

                            Console.Write("Do you Want to Quit? Yes OR No: ");

                            var quit1 = Console.ReadLine();

                            if (quit1 == "yes")
                            {
                                Environment.Exit(0);
                            }
                            else if (quit1 == "no")
                            {
                                Console.WriteLine("OK.Try Again From Scratch");
                            }
                            else
                            {
                                Console.WriteLine("Sorry Wrong Choice");

                                Console.WriteLine("Try Again from Scratch");
                            }
                        }

                        // **********ONLY BALANCE CHECK CODE FOR ACCOUNT THREE*******************

                        else if (CardInput == AccountNumber[2] && PinInput == PinNumber[2])
                        {
                            Console.WriteLine("Your Balance is:" + Balance[2]);

                            Console.Write("Do you Want to Quit? Yes OR No: ");

                            var quit1 = Console.ReadLine();

                            if (quit1 == "yes")
                            {
                                Environment.Exit(0);
                            }
                            else if (quit1 == "no")
                            {
                                Console.WriteLine("OK.Try Again From Scratch");
                            }
                            else
                            {
                                Console.WriteLine("Sorry Wrong Choice");

                                Console.WriteLine("Try Again from Scratch");
                            }
                        }
                    }

                    // **********EXIT CODE*******************

                    else if (choice == 3)
                    {
                        Environment.Exit(0);

                    }

                    // ********** CHOICE NOT MATCHED, CODE*******************

                    else
                    {

                        Console.WriteLine("Sorry!! Wrong Choice!");

                        Console.Write("Try Again From Scratch");
                
                    }
                }    
            }
            // ********** ACCOUNT NUMBER OR PIN NOT MATCHED *******************
            else
            {
                Console.WriteLine("Sorry Your Account Or Password is not Right !\nTry Again:");
            }
            

            // ********** THREE TIMES TRIED FOR THE USER. BUT FAILED *******************

            Console.WriteLine("Sorry Timed out.You Already Tried for Three Times !!");
        }

    }
}

