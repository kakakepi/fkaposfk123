namespace Lab8
{
    internal class Program
    {
        static void Task1()
        {
            BankAccount bankAcc1 = new BankAccount(9281374.091878912374m, TypeOfBankAccount.Сберегательный);
            Console.WriteLine(bankAcc1.GetAccountBalance());
            Console.WriteLine(bankAcc1.GetAccountData());
            Console.WriteLine(bankAcc1.GetAccountNumber());
        }
        static void Task2()
        {
            BankAccount bankAcc1 = new BankAccount(9281374.091878912374m, TypeOfBankAccount.Сберегательный);
            BankAccount bankAcc2 = new BankAccount(2374978912497.5582198591258214m, TypeOfBankAccount.Сберегательный);
            bankAcc2.TakeMoney(87234.535566m);
            bankAcc1.MoneyTransfer(bankAcc2, 1294714.38257823m);
            foreach (BankTransaction i in bankAcc2.bankTranses)
            {
                Console.WriteLine($"{i.GetTransactionInfo()}");
            }
        }
        static void Task3()
        {
            BankAccount bankAcc1 = new BankAccount(9281374.091878912374m, TypeOfBankAccount.Сберегательный);
            BankAccount bankAcc2 = new BankAccount(2374978912497.5582198591258214m, TypeOfBankAccount.Сберегательный);
            bankAcc2.TakeMoney(87234.535566m);
            bankAcc1.MoneyTransfer(bankAcc2, 1294714.38257823m);
            bankAcc1.Dispose();
            bankAcc2.Dispose();
        }
        static void Task4()
        {
            Song mySong = new Song();
            Song mySong2 = new Song("Песня2", "Пушкин", mySong);
            Console.WriteLine(mySong2.Title());
            Console.WriteLine(mySong.Title());

        }
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}