using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyFoodSupply;

namespace TestLibrary_FoodSupply
{
   [TestFixture]
    public class FoodDetailsTest
    {
        public Program program;
        [SetUp]

        public void Init()
        {
            program = new Program();
        }


        [Test]
        [TestCase("Biriyani",1,"2022-03-01",120)]
        [TestCase("Fries", 2, "2022-04-01", 80)]
        [TestCase("Brownie", 3, "2023-03-11", 150)]
        public void CreateFoodDetails_OnCorrectInputs_ReturnValidFoodDetailObject(string name, int dishType, DateTime expiryDate, double price)
        {
            var foodDetail = program.CreateFoodDetail(name,dishType,expiryDate,price);

            Assert.AreEqual(name,foodDetail.Name);
            Assert.AreEqual(dishType,(int)foodDetail.DishType);
            Assert.AreEqual(expiryDate,foodDetail.ExpiryDate);
            Assert.AreEqual(price,foodDetail.Price);
        }

        [Test]
        [TestCase("", 1, "2022-03-01", 120)]
        [TestCase("", 2, "2021-04-01", 80)]
        [TestCase("", 2, "2021-04-01", 80)]
        [TestCase("", 3, "2023-03-11", 150)]
        public void CreateFoodDetails_OnEmptyFoodName_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", ex.Message);
        }


        [Test]

        [TestCase("Biriyani", 1, "2021-03-01", -120)]
        [TestCase("Fries", 2, "2021-04-01", -80)]
        [TestCase("Brownie", 3, "2023-03-11", -150)]
        public void CreateFoodDetails_OnNegativeValueForPrice_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", ex.Message);
        }



        [Test]

        [TestCase("Biriyani", 1, "2011-03-01", 120)]
        [TestCase("Fries", 2, "2011-04-01", 80)]
        [TestCase("Brownie", 3, "2013-03-11", 150)]
        public void CreateFoodDetails_OnPastExpiryDate_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", ex.Message);
        }


    }
}
