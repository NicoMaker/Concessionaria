namespace Concessionaria;

internal class Veicoli
{
    public List<string> model = new List<string>();
    public List<string> typology = new List<string>();
    public List<int> displacement = new List<int>();
    public List<string> colour = new List<string>();
    public List<int> port = new List<int>();
    public List<int> seats = new List<int>();

    public void visualizza(List<string> model, List<string> typology, List<int> displacement, List<string> colour, List<int> port, List<int> seats)
    {
        for (int i = 0; i < model.Count; i++)
        {
            Console.WriteLine($"il {i + 1} modello ha le seguenti caratteristiche");
            Console.WriteLine("modello " + model[i]);
            Console.WriteLine("tipologia " + typology[i]);
            Console.WriteLine("cilindrata " + displacement[i]);
            Console.WriteLine("colore " + colour[i]);
            Console.WriteLine("numero porte " + port[i]);
            Console.WriteLine("posti a sedere " + seats[i]);
        }
    }
}