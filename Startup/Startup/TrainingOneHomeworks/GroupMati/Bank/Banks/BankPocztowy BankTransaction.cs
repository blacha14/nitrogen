using System;
using Startup.TrainingOneHomeworks.Mati;
namespace Startup.TrainingOneHomeworks.GroupMati.Banks
{
public sealed class BankPocztowy TransactionBank : BankTransaction
{
public BankPocztowy TransactionBank() : base("BankPocztowy  Bank")
{
}
public void DescriptionTransaction()
{
base.DescriptionTransaction();
}
public string GetBankName(string name)
{
return BankName;
}
public override void IncommingTransaction()
{
throw new NotImplementedException();
}
public override void OutCommingTransaction()
{
throw new NotImplementedException();
}
}
}
