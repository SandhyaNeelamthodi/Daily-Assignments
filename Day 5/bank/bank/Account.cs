using System;

namespace bank
{
    public class Account
    {
        public int Id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 15)
                    throw new ApplicationException("Name is too big");
                _name = value;
            }
        }
          
            
        private double amount;
        private double _balance;
        public double Balance
        {
            get { return _balance;
            }

        }

        public void createaccount(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            _balance = balance;
            Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY");

        }
        public void displayinfo()
        {
            Console.WriteLine("account details");
            Console.WriteLine("account id:" + Id);
            Console.WriteLine("account name:"+Name);
            Console.WriteLine("account balance: "+_balance);
        }
        public void deposit(double dep)
        {
            _balance += dep;
            Console.WriteLine("Current balance:{0}", _balance);
        }
        public void withdraw(double amount)
        {
            if (Balance - amount < 500)
            {
                Console.WriteLine("No minimum balance");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine("Current balance:{0}",_balance);
            }
             

        }

        public void Currentbalance()
        {
            
            
            Console.WriteLine("Current balance:"+_balance);
        }
    }
}