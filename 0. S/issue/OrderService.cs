namespace Solid.0_S.Problem
{
    internal class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);
                var invoice = this.CreateInvoice(order);
                this.EmailInvoice(invoice);
                File.WriteAllText(@"c:\DataLog.txt", "The order is completed");
            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
            }
        }
        
        public bool InsertOrder(Order order)
        {
            //Code to insert the order in the database 
            return true
        }
        public Invoice CreateInvoice(Order order)
        {
            //Code to create Invoice
            return new Invoice()
        }
        public class Order
        {

        }
        public class Invoice
        {

        }
    }
}