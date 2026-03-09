using System;

namespace RapidPack
{
    public class ParcelCalculator
    {

        public static double CalculatePrice(
            double weight,
            double height,
            double width,
            double depth,
            bool express,
            string type)
        {


            if (weight > 30)
            {
                throw new Exception("Nie obsługujemy paczek cięższych niż 30 kg.");
            }

            double price;


            if (type == "Paleta")
            {
                price = 100;
            }
            else
            {


                price = 10;


                price += weight * 2;


                double dimensionSum = height + width + depth;

                if (dimensionSum > 150)
                {
                    price = price * 1.5;
                }


                if (type == "Ostrożnie")
                {
                    price += 10;
                }
            }


            if (express)
            {
                price += 15;
            }

            return price;
        }

    }
}