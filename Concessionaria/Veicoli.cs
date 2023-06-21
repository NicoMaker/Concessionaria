namespace Concessionaria;

public abstract class Veicoli
{
    public string Model;
    public int Displacement;
    public string Colour;
    public int Seats;

    public abstract void PrintVeicolo();
}