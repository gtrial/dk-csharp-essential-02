namespace task04
{
    internal static class Program
    {
        private static void Main()
        {
            Invoice invoice = new(10, "Customer 10", "Provider 2");
            invoice.PrintInvoice();
        }
    }
}
