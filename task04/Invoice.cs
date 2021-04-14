using System;
namespace task04
{
    public class Invoice
    {
        private string article = "article 1";
        private int quantity = 1;

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        private int Account { get; }
        private string Customer { get; }
        private string Provider { get; }

        private void ComputePrice(out decimal fullPrice, out decimal netPrice)
        {
            fullPrice = quantity * (article == "article 1" ? 100 : 200);
            netPrice = (decimal)0.8 * fullPrice;
        }

        public void PrintInvoice()
        {
            ComputePrice(out var fullPrice, out var netPrice);
            Console.WriteLine($"Account: {Account}\n" +
                              $"Customer: {Customer}\n" +
                              $"Provider: {Provider}\n" +
                              $"Article: {article}\n" +
                              $"Quantity: {quantity}\n" +
                              $"Full price: {fullPrice}\n" +
                              $"Net price: {netPrice}\n");
        }
    }
}
