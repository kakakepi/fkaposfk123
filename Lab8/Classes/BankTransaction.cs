namespace Lab8
{
    class BankTransaction
    {
        public readonly DateTime nowDate = DateTime.Now;
        public readonly decimal addedDeletedSum;
        public BankTransaction(decimal addedDeletedSum)
        {
            this.addedDeletedSum = addedDeletedSum;
        }
        public string GetTransactionInfo(){
            return $"{nowDate}, {addedDeletedSum}";
        }
    }
}