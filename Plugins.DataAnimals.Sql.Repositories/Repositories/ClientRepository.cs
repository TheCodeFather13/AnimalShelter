using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;

namespace Plugins.DataAnimals.Sql.Repositories.Repositories
{
    public class ClientRepository : IClientOrderRepository
    {
        private readonly AnimalShelterDbContext _animalShelterDbContext;

        public ClientRepository(AnimalShelterDbContext animalShelterDbContext)
        {
            _animalShelterDbContext = animalShelterDbContext;
        }

        public void AddOrder(ClientOrder clientOrder)
        {
            try
            {
                _animalShelterDbContext.Add(clientOrder);
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClientOrder GetClientOrderById(int clientOrder)
        {
            return _animalShelterDbContext.ClientOrders.Find(clientOrder);
        }

        public void RemoveOrder(int clientId)
        {
            try
            {
                var clientOrderToDelete = GetClientOrderById(clientId);
                if (clientOrderToDelete == null) 
                {
                    return;                
                }
                _animalShelterDbContext.ClientOrders.Remove(clientOrderToDelete);
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
