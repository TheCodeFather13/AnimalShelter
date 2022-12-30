using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.ClientOrderUseCasesInterfaces;
using UseCases.DataAnimalsPluginInterfaces;

namespace UseCases.ClientOrderUseCase
{
    public class GetClientOrderCountUseCase : IGetClientOrderCountUseCase
    {
        private readonly IClientOrderRepository _clientOrderRepository;

        public GetClientOrderCountUseCase(IClientOrderRepository clientOrderRepository)
        {
            _clientOrderRepository = clientOrderRepository;
        }
        public int GetCount()
        {
           return _clientOrderRepository.GetOrderCount();
        }
    }
}
