namespace Solid.0_S.Solution
{
    internal class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotifationService _notificationService;
        private readonly IInvoiceService _invoiceService;
        private readonly ILoggerService _loggerService;

        public OrderService(IOrderRepository orderRepository, IInvoiceService invoiceService, INotifationService notificationService, ILoggerService loggerService)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
            _invoiceService = invoiceService;
            _loggerService = loggerService;
        }
        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InsertOrder(order);
                
                var invoice = _invoiceService.CreateInvoice(order);

                notificationService.EmailInvoice(invoice);

                
            }
        }
    }
}