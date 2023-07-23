using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankApplicationProject
{
    public class Role
    {
        
        public int Role_id { get; set; }
        public string Role_Name { get; set; }
    }
    
    
    public class Bank
    {
        //user_id
        public int User_id { get; set; }
        public int Account_no { get; set; }
        public int Balance { get; set; }
        public int Amount { get; set; }
        public string Password { get; set; }
        public int PayeeAccNo { get; set; }
        public string PayeeName { get; set; }
    }
   
    public class Bank_CRUD
    {
        private List<Bank> banks;
        
        User_CRUD user = new User_CRUD();
        public Bank_CRUD()
        {
            banks = new List<Bank>();
            
        }
        public void CreditAmount(int userid, int balance , int amount)
        {
            //User_CRUD user = new User_CRUD();
            List<User_Details> users = user.GetUser_Details();

            foreach (User_Details item in users)
            {
                if (item.User_id == userid)
                {
                   balance = balance + amount;
                    Console.WriteLine($"Credited amount={amount}-- \nNew account Balance={balance}");
                }
            }

        }
        public void DebitAmount(int userid, int balance, int amount)
        {
            //User_CRUD user = new User_CRUD();
            List<User_Details> users = user.GetUser_Details();
            foreach (User_Details user_details in users)
            {
                if(user_details.User_id == userid)
                {
                    if(amount>balance)
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        balance -= amount;
                        if(balance==0)
                        {
                            Console.WriteLine("Zero Balance");
                        }
                        else if(balance<2000)
                        {
                            Console.WriteLine("Low Balance");
                        }
                    }
                }
                Console.WriteLine($"Credited amount={amount}-- \nNew account Balance={balance}");
            }
        }
        public void ViewAmount(int userid, int balance)
        {
            List <User_Details> users = user.GetUser_Details();
            foreach(User_Details user_details in users)
            {
                if(user_details.User_id == userid)
                {
                    Console.WriteLine($"Account Balance is = {balance}");
                }
            }
        }
        public void AddPayee(int userid, string payeeName, int payeAccNum)
        {
            List<User_Details> users = user.GetUser_Details();
            foreach (User_Details user_details in users)
            {
                if (user_details.User_id == userid)
                {
                    Console.WriteLine($"Add Payee Name: {payeeName} \n Add Payee Account Number: {payeAccNum}");
                }
            }
        }
        public void RemovePayee(int userid , int payeeAccNum)
        {
            List<User_Details> users = user.GetUser_Details();
            Bank bank = new Bank();
            foreach (User_Details user_details in users)
            {
                if (user_details.User_id == userid)
                {
                    if(bank.PayeeAccNo == payeeAccNum)
                    {
                        users.Remove(user_details);
                    }
                }
            }
        }
        public void FundTransfer(int userid, int amount, int payeeAccNum)
        {
            List<User_Details> users = user.GetUser_Details();
            Bank bank = new Bank();
            foreach (User_Details user_details in users)
            {
                if(user_details.User_id == userid)
                {
                    if(bank.Balance > amount)
                    {
                        Console.WriteLine("Insufficient Balance to trasfer funds");
                    
                    }
                    bank.Balance -= amount;
                    Console.WriteLine($"Fund successful trasfer from Account{bank.Account_no} to payee account {payeeAccNum}");
                }
            }    
        }
    }
    
}
