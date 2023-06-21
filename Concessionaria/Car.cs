namespace Concessionaria;

public class Car : Veicoli
{
    public int Port;
    private string _type { get; } = "Auto";

    public override void PrintVeicolo() =>
      Console.WriteLine($"modello : {Model} , tipo : {_type} , cilindrata : {Displacement} , colore {Colour} , posti a sedere : {Seats}, porte : {Port}");
}