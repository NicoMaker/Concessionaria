using Concessionaria;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

List <Veicoli> veicolis = new List <Veicoli>();

veicolis.Add(new Car()
{
    Model = "Kia Rio",
    Displacement = 1500,
    Colour = "Bianco",
    Seats = 5,
    Port = 5
});

veicolis.Add(new Motorbike()
{
    Model= "BMW GT2",
    Displacement = 950,
    Colour = "nero",
    Seats = 2
});


for (int i = 0; i < veicolis.Count; i++)
    veicolis[i].PrintVeicolo();