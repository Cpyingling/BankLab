using System;

class SavingsAccount : BankAccount
    {

      /*•	CalculateInterest()
o	Calculate 5% interest per year and update the Balance (Balance = Balance + interest)
*/
 public override void CalculateInterest() {
      Balance = Balance + (Balance*(0.5M/100));
      Console.WriteLine("Balance: "+Balance);

}
/*•	Withdraw() method
o	If Balance is < 2000, write to console an error message “Insufficient balance”
o	Else call the Withdraw method of the base class*/
  public override void Withdraw(decimal amount) {
  if (Balance < 2000) {
    Console.WriteLine("Insufficient Funds");
  } else {
    base.Withdraw(amount);
  }
}

      
    }