using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataAnimalsPluginInterfaces
{
    public interface IClientOrderRepository
    {
        public void AddOrder(ClientOrder clientOrder);
        public void RemoveOrder(int clientId);
        public ClientOrder GetClientOrderById(int clientOrder);
    }
}
