using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;
using NUnit.Framework;

namespace GenericMedicine_TestLibrary
{
    [TestFixture]
    public class MedicineTest
    {
        private Program program;
        [SetUp]
        public void init()
        {
            program = new Program();
        }

        //Test With Correct Values 
        [Test]
        [TestCase("Tylenol","Paracetamol", "PARACETAMOL 500mg", "2022-10-05",32.25)]
        [TestCase("Modalert", "Modafinil", "Modafinil 100mg", "2021-10-07", 159)]
        [TestCase("Ativan", "Lorazopam", "Lorazopam 1mg", "2023-06-05", 97.30)]

        public void CreateMedicineDetails_CorrectInput_ReturnsValid(string Name,string GenericName,
            string Composition,DateTime ExpiryDate,double PricePerStrip)
        {
            Medicine medicine = program.CreateMedicineDetail(Name,GenericName, Composition, ExpiryDate, PricePerStrip);
            Assert.That(medicine, Is.TypeOf<Medicine>());
            Assert.AreEqual(Name,medicine.Name);
            Assert.AreEqual(GenericName,medicine.GenericMedicineName);
            Assert.AreEqual(Composition,medicine.Composition);
            Assert.AreEqual(ExpiryDate,medicine.ExpiryDate);
            Assert.AreEqual(PricePerStrip,medicine.PricePerStrip);
        }

        //Test with values Empty Value for Generic Medicine name
        [Test]
        [TestCase("Tylenol", "", "PARACETAMOL 500mg", "2022-10-05", 32.25)]
        [TestCase("Modalert", "", "Modafinil 100mg", "2021-10-07", 159)]
        [TestCase("Ativan", "", "Lorazopam 1mg", "2023-06-05", 97.30)]
        //[TestCase("Ativan", "Lorazopam", "Lorazopam 1mg", "2023-06-05", 97.30)]

        public void CreateMedicineDetails_EmptyGeneric_Exception(string Name,
            string GenericName, string Composition, DateTime ExpiryDate, double PricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateMedicineDetail(Name, GenericName, Composition, ExpiryDate, PricePerStrip));
            Assert.AreEqual(ex.Message, "Generic Medicine name cannot be empty. Please provide valid value");
        }


        //Test with negative values for price
        [Test]
        [TestCase("Tylenol", "Paracetamol", "PARACETAMOL 500mg", "2022-10-05", -32.25)]
        [TestCase("Modalert", "Modafinil", "Modafinil 100mg", "2021-10-07", -159)]
        [TestCase("Ativan", "Lorazopam", "Lorazopam 1mg", "2023-06-05", -97.30)]
        //[TestCase("Ativan", "Lorazopam", "Lorazopam 1mg", "2023-06-05", 97.30)]

        public void CreateMedicineDetails_NegativePrice_ThrowsException(string Name,
            string GenericName, string Composition, DateTime ExpiryDate, double PricePerStrip)
        { 
            var ex =  Assert.Throws<Exception>(()=> program.CreateMedicineDetail(Name, GenericName, Composition, ExpiryDate, PricePerStrip));
            Assert.AreEqual(ex.Message, "Incorrect value for Medicine price per strip. Please provide valid value");
        }


        [Test]
        [TestCase("Tylenol", "Paracetamol", "PARACETAMOL 500mg", "2012-10-05", 32.25)]
        [TestCase("Modalert", "Modafinil", "Modafinil 100mg", "2011-10-07", 159)]
        [TestCase("Ativan", "Lorazopam", "Lorazopam 1mg", "2013-06-05", 97.30)]
       // [TestCase("Ativan", "Lorazopam", "Lorazopam 1mg", "2023-06-05", 97.30)]
        public void CreateMedicineDetails_ExpiryLessThanCurrent_ThrowsException(string Name,
            string GenericName, string Composition, DateTime ExpiryDate, double PricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => program.CreateMedicineDetail(Name, GenericName, Composition, ExpiryDate, PricePerStrip));
            Assert.AreEqual(ex.Message, "Incorrect expiry date. Please provide valid value");
        }
    }
}
