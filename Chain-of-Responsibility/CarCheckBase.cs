using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    abstract class CarCheckBase
    {
        const int MaxResult = 5;

        private CarCheckBase next;

        public void SetNext(CarCheckBase next)
        {
            this.next = next;
        }

        public void HandleRequest(Car car)
        {
            var integrityCheck = new Random().Next(1, 10);

            if (integrityCheck <= MaxResult)
            {
                car.HasMalfunction = true;
                car.Error = $"{this.GetType().FullName} malfunction";
            }

            else
            {
                car.HasMalfunction = false;
                if (next != null)
                {
                    next.HandleRequest(car);
                }
            }


        }
    }

    class BasicCheck : CarCheckBase { }
    class ElectrianCheck : CarCheckBase { }
    class MechanicCheck : CarCheckBase { }
    class ExpertCheck : CarCheckBase { }
}
