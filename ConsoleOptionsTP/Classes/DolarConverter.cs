namespace ConsoleOptionsTP.Classes
{
    internal class DolarConverter
    {
        public DolarConverter(double amount, double change)
        {
            Amount = amount;
            Change = change;
        }

    internal double Amount { get; set; }
    internal double Change { get; set; }

    internal double Convert()
        {
            return double.Round(this.Amount/this.Change,2); ;
        }

    }
}
