using Concessionaria;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

string jsonAuto = File.ReadAllText("Auto.json");
string jsonMoto = File.ReadAllText("Moto.json");

List<Veicoli> veicoli = new List<Veicoli>();

List<Car>? car = JsonConvert.DeserializeObject<List<Car>>(jsonAuto);
List<Motorbike>? moto = JsonConvert.DeserializeObject<List<Motorbike>>(jsonMoto);

car?.ForEach((c) => veicoli.Add(c));
moto?.ForEach((m) => veicoli.Add(m));


for (int i = 0; i < veicoli.Count; i++)
    veicoli[i].PrintVeicolo();