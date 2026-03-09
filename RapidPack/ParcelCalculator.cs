using System;

namespace RapidPack
{
    public class ParcelCalculator
    {
        public double CalculatePrice(double weight, double height, double width, double depth, bool isExpress, string shipmentType)
        {
            // 1. Walidacja wagi (zawsze, nawet dla palety)
            if (weight > 30)
                throw new ArgumentException("Waga nie może przekraczać 30 kg!");

            double finalPrice = 0;

            // 2. Logika dla Palety
            if (shipmentType == "Paleta")
            {
                finalPrice = 100;
            }
            else
            {
                // 3. Logika Standardowa / Ostrożnie
                finalPrice = 10 + (weight * 2);

                // Gabaryt (suma wymiarów > 150 cm)
                if (height + width + depth > 150)
                {
                    finalPrice *= 1.5;
                }

                // Dodatek za "Ostrożnie"
                if (shipmentType == "Ostrożnie")
                {
                    finalPrice += 10;
                }
            }

            // 4. Usługi dodatkowe (Ekspres doliczany na końcu)
            if (isExpress)
            {
                finalPrice += 15;
            }

            return finalPrice;
        }
    }
}