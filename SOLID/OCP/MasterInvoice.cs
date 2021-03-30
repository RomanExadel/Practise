namespace SOLID.OCP
{
    class MasterInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - amount * 0.3;
        }
    }
}
