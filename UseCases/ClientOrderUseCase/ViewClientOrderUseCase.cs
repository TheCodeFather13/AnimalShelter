using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.ClientOrderUseCasesInterfaces;
using UseCases.DataAnimalsPluginInterfaces;

namespace UseCases.ClientOrderUseCase
{
    public class ViewClientOrderUseCase : IViewClientOrderUseCase
    {
        private readonly IClientOrderRepository _clientOrderRepository;

        public ViewClientOrderUseCase(IClientOrderRepository clientOrderRepository)
        {
            _clientOrderRepository = clientOrderRepository;
        }
        public IEnumerable<ClientOrder> Execute()
        {
            return _clientOrderRepository.GetClientsOrders();
        }
    }
}
