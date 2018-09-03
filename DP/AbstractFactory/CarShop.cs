using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.AbstractFactory
{
    public class CarShop
    {
        AbstractFactory _carFactory;

        public CarShop(AbstractFactory factory)
        {
            _carFactory = factory;
        }

        public void RunShop()
        {
            for(int i = 0; i < 5; i++)
            {
                _carFactory.CreateCar().StartEngine();
            }
        }
    }
}
