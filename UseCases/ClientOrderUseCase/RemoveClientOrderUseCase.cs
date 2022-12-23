using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.ClientOrderUseCasesInterfaces;
using UseCases.DataAnimalsPluginInterfaces;

namespace UseCases.ClientOrderUseCase
{
    public class RemoveClientOrderUseCase : IRemoveClientOrderUseCase
    {
        private readonly IClientOrderRepository _clientOrder;

        public RemoveClientOrderUseCase(IClientOrderRepository clientOrder)
        {
            _clientOrder = clientOrder;
        }
        public void RemoveClientOrder(int clientId)
        {
            _clientOrder.RemoveOrder(clientId);
        }
    }
}
