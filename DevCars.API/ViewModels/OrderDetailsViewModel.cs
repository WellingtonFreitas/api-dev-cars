using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.ViewModels
{
    public class OrderDetailsViewModel
    {
        public OrderDetailsViewModel(int idCustomer, int idCar, decimal totalCost, List<string> extraItems)
        {
            IdCustomer = idCustomer;
            IdCar = idCar;
            TotalCost = totalCost;
            ExtraItems = extraItems;
        }

        public int IdCustomer { get; set; }
        public int IdCar { get; set; }
        public decimal TotalCost { get; set; }
        public List<string> ExtraItems { get; set; }

    }
}
