namespace SOLID.OCP
{
    class GoldInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - amount * 0.6;
        }
    }
}
