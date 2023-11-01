using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


public class Eletr
{
    public string Cod;
    public int Quant;
    public double Cap;

    public Eletr(string cod1, double capacit, int quant1)
    {

        Cod = cod1;
        Quant = quant1;
        Cap = capacit;

    }
    public void addestq(int addquant)
    {
        Quant += addquant;
    }

    public void removstq(int removquant)
    {
        Quant -= removquant;
    }




    public override String ToString()
    {
        return "Cap " + Cod + " " + Cap.ToString("F2", CultureInfo.InvariantCulture) + "uF "
         + Quant + " peças";

    }

}
