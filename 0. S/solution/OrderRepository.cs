namespace Solid.0_S.Solution
{
    interface IOrderRepository
    {
        public bool InsertOrder(Order order);

    }
    class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            //Code to Insert the Order in the database
            return true
        }
    }
}