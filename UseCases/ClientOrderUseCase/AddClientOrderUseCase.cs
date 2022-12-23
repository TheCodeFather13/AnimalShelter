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
    public class AddClientOrderUseCase : IAddClientOrderUseCase
    {
        private readonly IClientOrderRepository _clientOrderRepository;

        public AddClientOrderUseCase(IClientOrderRepository clientOrderRepository)
        {
            _clientOrderRepository = clientOrderRepository;
        }
        public void AddClientOrder(ClientOrder clientOrder)
        {
            _clientOrderRepository.AddOrder(clientOrder);
        }
    }
}
