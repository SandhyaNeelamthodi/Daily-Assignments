using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CarProject;


namespace CarTests
{
    //public class Class1
    //{
    //}
    [TestClass]
    public class CarTestsClass
    {
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        //TODO: constructor sets gasTankLevel properly

        //TODO: gasTankLevel is accurate after driving within tank range

        //TODO: gasTankLevel is accurate after attempting to drive past tank range

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }
}
