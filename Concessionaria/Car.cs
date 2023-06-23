namespace Concessionaria;

public class Car : Veicoli
{
    public int Port
    {
        get; 
        set;
    }

    public override void PrintVeicolo() =>
      Console.WriteLine($"modello : {Model} , tipo : {GetType().Name} , cilindrata : {Displacement} , colore {Colour} , posti a sedere : {Seats}, porte : {Port}");
}