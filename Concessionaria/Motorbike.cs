namespace Concessionaria;

public class Motorbike : Veicoli
{
    private string _type { get; } = "Moto";
    public override void PrintVeicolo() =>
        Console.WriteLine($"modello : {Model} , tipo : {_type} , cilindrata : {Displacement} , colore {Colour} , posti a sedere : {Seats}");
}