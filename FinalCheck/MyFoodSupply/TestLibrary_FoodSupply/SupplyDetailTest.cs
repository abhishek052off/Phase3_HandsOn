using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;

namespace TestLibrary_FoodSupply
{
    class SupplyDetailTest
    {
        private Program program;
        private FoodDetail foodDetail;

        [SetUp]
        public void Init()
        {
            program = new Program();
            foodDetail = new FoodDetail()
            {
                Name = "Biriyani",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2022, 8, 4),
                Price = 100
            };
        }
        
        [Test]
        [TestCase(10, "2021-05-07", "Restaurant_name", 50,1050)]
        [TestCase(20, "2021-04-09", "Restaurant_name", 50, 2050)]
        [TestCase(5, "2021-07-07", "Restaurant_name", 50, 550)]
        public void CreateSupplyDetail_OnCorrectInputs_ReturnValidSupplyDetailObject(int Count, DateTime requestDate, string sellerName, double packingCharge,double expectedTotal)
        { 
            var  supplyDetail = program.CreateSupplyDetail(Count, requestDate, sellerName, packingCharge, foodDetail);


            Assert.That(supplyDetail, Is.TypeOf<SupplyDetail>());
            Assert.AreEqual(Count,supplyDetail.Count);
            Assert.AreEqual(requestDate,supplyDetail.RequestDate);
            Assert.AreEqual(sellerName,supplyDetail.SellerName);
            Assert.AreEqual(packingCharge,supplyDetail.PackingCharge);
            Assert.AreEqual(expectedTotal,supplyDetail.TotalCost);

            // test for food item

            Assert.AreEqual( foodDetail.Name , supplyDetail.FoodItem.Name);
            Assert.AreEqual( (int)foodDetail.DishType, (int)supplyDetail.FoodItem.DishType);
            Assert.AreEqual(foodDetail.ExpiryDate, supplyDetail.FoodItem.ExpiryDate);
            Assert.AreEqual( foodDetail.Price, supplyDetail.FoodItem.Price);

        }

        [Test]
        [TestCase(0, "2021-05-07", "Restaurant_name", 50, 1050)]
        [TestCase(-20, "2021-04-09", "Restaurant_name", 50, 2050)]
        [TestCase(-5, "2021-07-07", "Restaurant_name", 50, 550)]
        public void CreateSupplyDetail_OnNegativeOrZeroFoodItem_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge,double expectedTotal)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
            Assert.AreEqual("Incorrect food item count. Please check", ex.Message);
        }

        [Test]
        [TestCase(10, "2021-02-07", "Restaurant_name", 50, 1050)]
        [TestCase(20, "2011-01-09", "Restaurant_name", 50, 2050)]
        [TestCase(5, "2020-07-07", "Restaurant_name", 50, 550)]
        public void CreateSupplyDetail_RequestDateInPast_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, double expectedTotal)
        {
           var ex =  Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
           Assert.AreEqual("Incorrect food request date. Please provide valid value", ex.Message);
        }

        [Test]
        [TestCase(10, "2021-05-07", "Restaurant_name", 50, 1050)]
        [TestCase(20, "2021-04-09", "Restaurant_name", 50, 2050)]
        [TestCase(5, "2021-07-07", "Restaurant_name", 50, 550)]
        public void CreateSupplyDetail_OnNullFoodDetail_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge,double expectedTotal)  
        {
            foodDetail = null;
            var supplyDetail = program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail);
            Assert.IsNull(supplyDetail);
        }
    }
}
