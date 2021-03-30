namespace SOLID.OCP
{
    class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - amount * 0.1;
        }
    }
}
