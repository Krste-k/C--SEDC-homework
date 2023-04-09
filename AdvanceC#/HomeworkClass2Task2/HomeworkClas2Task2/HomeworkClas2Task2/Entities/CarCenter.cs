using HomeworkClas2Task2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas2Task2.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private CarWash carWash = new CarWash();
        private GasPump gasPump = new GasPump();
        private RepairService repairService = new RepairService();
        public void CheckVehicle(Vehicle vehicle)
        {
            repairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            repairService.FixVehicle(vehicle);
        }

        public void PumpGas(Vehicle vehicle)
        {
            gasPump.PumpGas(vehicle);
        }

        public void WashCar(Car car)
        {
            carWash.WashCar(car);
        }

        public void WashTrailer(Truck truck)
        {
            carWash.WashTrailer(truck);
        }
    }
}
