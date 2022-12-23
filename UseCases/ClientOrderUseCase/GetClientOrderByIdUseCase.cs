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
    public class GetClientOrderByIdUseCase : IGetClientOrderByIdUseCase
    {
        private readonly IClientOrderRepository _clientOrderRepository;

        public GetClientOrderByIdUseCase(IClientOrderRepository clientOrderRepository)
        {
            _clientOrderRepository = clientOrderRepository;
        }
        public ClientOrder GetClientOrderById(int clientId)
        {
            return _clientOrderRepository.GetClientOrderById(clientId);
        }
    }
}
