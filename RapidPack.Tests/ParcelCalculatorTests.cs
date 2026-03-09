using Xunit;
using RapidPack;
using System;

namespace RapidPack.Tests
{
    public class ParcelCalculatorTests
    {
        private readonly ParcelCalculator _calculator = new ParcelCalculator();

        [Fact]
        public void CalculatePrice_ShouldThrowException_WhenWeightOver30kg()
        {
            
            Assert.Throws<ArgumentException>(() => 
                _calculator.CalculatePrice(35, 10, 10, 10, false, "Standardowa"));
        }

        [Fact]
        public void CalculatePrice_ShouldReturn100_WhenPaletaIsSelected()
        {
           
            double price = _calculator.CalculatePrice(10, 200, 200, 200, false, "Paleta");

          
            Assert.Equal(100, price);
        }

        [Fact]
        public void CalculatePrice_ShouldApplyBulkSurcharge_WhenDimensionsOver150cm()
        {
            
            double price = _calculator.CalculatePrice(5, 60, 60, 60, false, "Standardowa");

            Assert.Equal(30, price);
        }

        [Fact]
        public void CalculatePrice_ShouldAdd15_WhenExpressIsChecked()
        {
            
            double price = _calculator.CalculatePrice(0, 10, 10, 10, true, "Standardowa");

            Assert.Equal(25, price);
        }
    }
}