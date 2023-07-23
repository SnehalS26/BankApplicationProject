using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            int current_id = 0;
            User_CRUD user_CRUD = new User_CRUD();
            int option = 0;
           
                User_Details user = new User_Details();
                //Role role = new Role();
                Console.WriteLine("Login");
                Console.WriteLine("Enter User Id");
                user.User_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Password");
                user.User_Password = Console.ReadLine();
                int result = user_CRUD.Login(user.User_id , user.User_Password);
                current_id = user.User_id;
            do
            {
                if (result == 0)
                {
                    Console.WriteLine("Invalid Entry");
                }

                else if (result == 1)
                {
                    Console.WriteLine("Welcome admin");
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Display Users");
                    Console.WriteLine("3. Logout");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            User_Details user1 = new User_Details();
                            Bank bank = new Bank();
                            Console.WriteLine("Enter User id:");
                            user1.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Username");
                            user1.User_Name = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            user1.User_Password = Console.ReadLine();
                            Console.WriteLine("User Account No");
                            bank.Account_no = Convert.ToInt32(Console.ReadLine());
                            user_CRUD.AddUser(user1);
                            break;
                        //case 2:
                        //    List<User_Details> list = user_CRUD.GetUser_Details();
                        //    foreach (User_Details item in list)
                        //    {
                        //        Console.WriteLine($"{item.User_id} --> {item.User_Name} --> {item.User_Password}");
                        //    }
                        //    break;
                    }
                }
                else if (result == 2)
                {
                    Console.WriteLine("Welcome User");
                    Console.WriteLine("1. Credit");
                    Console.WriteLine("2. Debit");
                    Console.WriteLine("3.View Balance");
                    Console.WriteLine("4.Add Payee");
                    Console.WriteLine("5. Fund Transfer");
                    Console.WriteLine("6. Remove Payee");
                    int op1 = Convert.ToInt32(Console.ReadLine());
                    switch (op1)
                    {
                        case 1:
                            //Credit
                            Bank b1 = new Bank();
                            //Bank_CRUD bank = new Bank_CRUD();
                            Console.WriteLine("Enter user id");
                            b1.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Balance");
                            b1.Balance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            b1.Amount = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2: //debit
                            Bank bank = new Bank();
                            Console.WriteLine("Enter user id");
                            bank.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Balance");
                            bank.Balance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            bank.Amount = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3: //view
                            Bank bank1 = new Bank();
                            Console.WriteLine("Enter user id");
                            bank1.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Balance");
                            bank1.Balance = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 4: //add payee
                            Bank bank2 = new Bank();
                            Console.WriteLine("Enter user id");
                            bank2.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Payee NAme");
                            bank2.PayeeName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter Payee Account Number");
                            bank2.PayeeAccNo = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 5: //fund
                            Bank bank3 = new Bank();
                            Console.WriteLine("Enter user id");
                            bank3.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            bank3.Amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Payee Number");
                            bank3.PayeeAccNo = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6: //remove
                            Bank bank4 = new Bank();
                            Console.WriteLine("Enter user id");
                            bank4.User_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Payee Account Number");
                            bank4.PayeeAccNo= Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while(option == 1);
        }
    }
}
