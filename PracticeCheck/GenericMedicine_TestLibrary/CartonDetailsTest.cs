using System;
using GenericMedicine;
using NUnit.Framework;

namespace GenericMedicine_TestLibrary
{
    [TestFixture]
    class CartonDetailsTest
    {
        private Program program;
        private  Medicine medicine;
        [SetUp]
        public void inti()
        {
            program = new Program();
            medicine = new Medicine()
            {
                Name = "Tylenol",
                GenericMedicineName = "Paracetamol",
                Composition = "Paracetamol 500mg",
                ExpiryDate = new DateTime(2023,04,07),
                PricePerStrip = 25
            };
        }


        //Test With Correct Input Data

        [TestCase(10,"2021-10-05","Dummy Address",250)]
        [TestCase(20, "2021-10-05", "Dummy Address", 500)]
        [TestCase(5, "2021-10-05", "Dummy Address", 125)]
        public void CreateCartonDetails_OnCorrectValues_ReturnsValidObject(int medicinestripcount,
            DateTime LaunchDate, string retailerAddress, double ExpectedtotalAmount)
        {
            Console.WriteLine("Expiry Date : "+medicine.ExpiryDate);
            Console.WriteLine("Launch Date : "+LaunchDate);
            CartonDetail carton = program.CreateCartonDetail(medicinestripcount, LaunchDate, retailerAddress, medicine);
            //test for medicine equality
            Assert.AreEqual(carton.Medicine.Name, medicine.Name);
            Assert.AreEqual(carton.Medicine.GenericMedicineName, medicine.GenericMedicineName);
            Assert.AreEqual(carton.Medicine.Composition, medicine.Composition);
            Assert.AreEqual(carton.Medicine.ExpiryDate, medicine.ExpiryDate);
            Assert.AreEqual(carton.Medicine.PricePerStrip, medicine.PricePerStrip);

            Assert.AreEqual(medicinestripcount,carton.MedicineStripCount);
            Assert.AreEqual(LaunchDate,carton.LaunchDate);
            Assert.AreEqual(retailerAddress,carton.RetailerAddress);
            Assert.AreEqual(ExpectedtotalAmount,carton.TotalAmount);

        }


        //Tests with negative strip count

        [TestCase(-10, "2020-10-05", "Dummy Address", 250)]
        [TestCase(-20, "2020-10-05", "Dummy Address", 500)]
        [TestCase(-5, "2020-10-05", "Dummy Address", 125)]
        public void CreateCartonDetails_OnNegativeStripCount_ReturnsNullObject(int medicinestripcount,
            DateTime LaunchDate, string retailerAddress, double ExpectedtotalAmount)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateCartonDetail(medicinestripcount, LaunchDate, retailerAddress, medicine));
            Assert.AreEqual("Incorrect strip count. Please check", ex.Message);
        }


        //Tests with DateOf Launch After Expiry Data
        [TestCase(10, "2024-10-05", "Dummy Address", 250)]
        [TestCase(20, "2025-10-05", "Dummy Address", 500)]
        [TestCase(5, "2026-10-05", "Dummy Address", 125)]
        public void CreateCartonDetails_OnDateOfLaunchAfterExpiry_ReturnsNullObject( int medicinestripcount,
            DateTime LaunchDate, string retailerAddress, double ExpectedtotalAmount)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateCartonDetail(medicinestripcount, LaunchDate, retailerAddress,medicine));
            Assert.AreEqual("Launch date greater than expiry date. Please check", ex.Message);
        }


        //Tests With Null Value For Medicine Object
        [TestCase(10, "2020-10-05", "Dummy Address", 250)]
        [TestCase(20, "2020-10-05", "Dummy Address", 500)]
        [TestCase(5, "2020-10-05", "Dummy Address", 125)]
        public void CreateCartonDetails_OnNullMedicine_ReturnsNullObject(int medicinestripcount,
            DateTime LaunchDate, string retailerAddress, double ExpectedtotalAmount)
        {
            medicine = null;
            CartonDetail carton = program.CreateCartonDetail(medicinestripcount, LaunchDate, retailerAddress, medicine);
            Assert.IsNull(carton);
        }

    }
}
