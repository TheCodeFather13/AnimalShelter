﻿using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.ClientOrderUseCasesInterfaces
{
    public interface IEditClientOrderUseCase
    {
        public void Execute(ClientOrder clientOrder);
    }
}
