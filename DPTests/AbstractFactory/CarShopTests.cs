using Microsoft.VisualStudio.TestTools.UnitTesting;
using DP.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.AbstractFactory.Tests
{
    [TestClass()]
    public class CarShopTests
    {
        [TestMethod()]
        public void RunShopTest()
        {
            CarShop bmwCarShop = new CarShop(new BmwConcreteFactory());
            bmwCarShop.RunShop();

            Console.WriteLine("--------------");

            CarShop audiCarShop = new CarShop(new AudiConcreteFactory());
            audiCarShop.RunShop();


        }
    }
}