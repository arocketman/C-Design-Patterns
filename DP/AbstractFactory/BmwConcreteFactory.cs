﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.AbstractFactory
{
    public class BmwConcreteFactory : AbstractFactory
    {
        public ICar CreateCar()
        {
            return new BmwCar();
        }
    }
}
