namespace RapidPack;

public class ParcelCalculator
{

    public double Oblicz(int waga,int wysokosc,int glebokosc,int szerokosc, bool Checked, int Typ)
    {
        
        int baza = 10;
        double cenaKoncowa = 0;

       
        cenaKoncowa += waga*2;
        if (150 < wysokosc + glebokosc + szerokosc)
        {
            cenaKoncowa*=1.5;
        }

        if (Checked = true)
        {
            cenaKoncowa += 15;
        }

        if (Typ == 1)
        {
            cenaKoncowa += 10;
        }
        else if (Typ == 2)
        {
            cenaKoncowa = 100;
        }
            
        return cenaKoncowa;

    }
    
    
    
    
    
}