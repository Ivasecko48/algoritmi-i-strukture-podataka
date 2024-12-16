public interface IAccount
{
 string Name { get; set; }
 decimal Balance { get; set; }
}

public class Account : IAccount
{
 public string Name { get; set; }
 public virtual decimal Balance { get; set; }
 public Account() { }
 public Account(string name, decimal balance)
 {
 Name = name;
 Balance = balance;
 }
 public override string ToString()
 {
 return Name + ":" + Balance;
 }
}