using System;

class CheckingAccount : BankAccount
    {
      /*CalculateInterest()
•	Calculate 0.5% interest per year and update the Balance (Balance = Balance + interest)
*/
public override void CalculateInterest() {
      Balance = Balance + (Balance*(0.5M/100));
      Console.WriteLine("Balance: "+Balance);
}

/*Withdraw() method
•	Call the base method. No further changes required.*/
public override void Withdraw(decimal amount) {
    base.Withdraw(amount);
}     
    }