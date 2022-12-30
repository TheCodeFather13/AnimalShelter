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
    public class EditClientOrderUseCase : IEditClientOrderUseCase
    {
        private readonly IClientOrderRepository _clientOrderRepository;

        public EditClientOrderUseCase(IClientOrderRepository clientOrderRepository)
        {
            _clientOrderRepository = clientOrderRepository;
        }
        public void Execute(ClientOrder clientOrder)
        {
            _clientOrderRepository.Update(clientOrder);
        }
    }
}
