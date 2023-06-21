namespace Concessionaria;

public class Motorbike : Veicoli
{
    public override void PrintVeicolo() =>
        Console.WriteLine($"modello : {Model} , tipo : {GetType().Name} , cilindrata : {Displacement} , colore {Colour} , posti a sedere : {Seats}");
}