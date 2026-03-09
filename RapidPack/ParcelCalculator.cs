using System;

namespace RapidPack
{
    public class ParcelCalculator
    {
        public double CalculatePrice(double weight, double height, double width, double depth, bool isExpress, string shipmentType)
        {
           
            if (weight > 30)
                throw new ArgumentException("Waga nie może przekraczać 30 kg!");

            double finalPrice = 0;

           
            if (shipmentType == "Paleta")
            {
                finalPrice = 100;
            }
            else
            {
                
                finalPrice = 10 + (weight * 2);

               
                if (height + width + depth > 150)
                {
                    finalPrice *= 1.5;
                }

               
                if (shipmentType == "Ostrożnie")
                {
                    finalPrice += 10;
                }
            }

            
            if (isExpress)
            {
                finalPrice += 15;
            }

            return finalPrice;
        }
    }
}