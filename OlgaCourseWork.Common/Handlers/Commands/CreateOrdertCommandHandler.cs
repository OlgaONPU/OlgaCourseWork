using MediatR;
using OlgaCourseWork.Common.Commands;
using OlgaCourseWork.Common.Interfaces.Services;

namespace OlgaCourseWork.Common.Handlers.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public CreateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            if (!IsValidCommand(command))
                return false;

            return await _orderService.CreateOrder(command, cancellationToken);
        }

        private bool IsValidCommand(CreateOrderCommand command)
        {
            if (command == null ||
                command.ProductId == Guid.Empty ||
                string.IsNullOrWhiteSpace(command.ClientName) ||
                string.IsNullOrWhiteSpace(command.ClientPhone) ||
                !IsValidPhoneNumber(command.ClientPhone))
            {
                return false;
            }

            return true;
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 7 && phone.Length <= 15;
        }
    }
}
