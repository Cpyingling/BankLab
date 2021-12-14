 using System;
 
 //1.	Make BankAccount into an Abstract class
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }

//Implement Constructor chaining for BankAccount() constructors
        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(decimal balance): this()
        {
            Balance = balance;
        }

/*Deposit()
o	Remove the line  throw new NotImplementedException();
o	Takes 1 input parameter “amount” of type decimal
o	Adds amount to Balance
o	Write to console current balance*/
        public void Deposit(decimal amount)
        {
          Balance = Balance + amount;
          Console.WriteLine("Current Balance: " +Balance);
            //throw new NotImplementedException();
        }

/*•	Withdraw()
o	Remove the line  throw new NotImplementedException();
o	Takes 1 input parameter “amount” of type decimal
	If Balance is > amount, then subtract amount from Balance 
	Else write an error to console
o	Write to console current balance
o	Make this a virtual method*/
        public virtual void Withdraw(decimal amount)
        {
          if (Balance > amount) {
            Balance = Balance - amount;
          } else {
            Console.WriteLine("Not enough available balance!");
          }
            //throw new NotImplementedException();
        }

        /*	CalculateInterest()
o	Make this an abstract method*/
        public abstract void CalculateInterest();

    }