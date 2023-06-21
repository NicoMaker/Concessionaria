namespace Concessionaria;

public abstract class Veicoli
{
    public string Model = "";
    public int Displacement = 0;
    public string Colour = "";
    public int Seats = 0;

    public abstract void PrintVeicolo();
}