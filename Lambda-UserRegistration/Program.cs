﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration using Regex.\n");
            while (true)
            {
                Console.WriteLine("\nPlease select any one from below :\n" +
                "Press 1: To Register your First Name.\n" +
                "Press 2: To Register your Last Name \n" +
                "Press 3: To enter your Email ID .\n" +
                "Press 4: to enter your Mobile Number.\n" +
                "Press 5: To set your password (minimum 8 characters).\n" +
                "Press 6: To set password having 8 minimum character and atleast 1 upper case in it .\n" +
                "Press 7: To set password having 8 min char and atleast 1 upper case and 1 numeric in it.\n" +
                "Press 8: to set password with having exactly 1 special character.\n" +
                "Press 9: For list of email samples validation.\n ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserDetails.FirstName();
                        break;
                    case 2:
                        UserDetails.LastName();
                        break;
                    case 3:
                        UserDetails.EmailID();
                        break;
                    case 4:
                        UserDetails.MobileNumber();
                        break;
                    case 5:
                        UserDetails.PassMin8Char();
                        break;
                    case 6:
                        UserDetails.PassMin8CharAnd1UpperCase();
                        break;
                    case 7:
                        UserDetails.UpperCase1AndNumeric1();
                        break;
                    case 8:
                        UserDetails.SpecialCharacter1();
                        break;
                    case 9:
                        UserDetails.EmailSample();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
        }
    }
}
