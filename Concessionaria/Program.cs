using Concessionaria;

Veicoli veicolo = new Veicoli();

veicolo.model.Add("Porshe Caarrera");
veicolo.typology.Add("maccchina");
veicolo.displacement.Add(3000);
veicolo.colour.Add("Bianco");
veicolo.port.Add(3);
veicolo.seats.Add(2);

veicolo.model.Add("BMW GT2");
veicolo.typology.Add("moto");
veicolo.displacement.Add(1250);
veicolo.colour.Add("Nera");
veicolo.port.Add(0);
veicolo.seats.Add(2);

veicolo.model.Add("Ferrari SF90 Spider");
veicolo.typology.Add("macchina");
veicolo.displacement.Add(8000);
veicolo.colour.Add("Rossa");
veicolo.port.Add(3);
veicolo.seats.Add(2);

veicolo.model.Add("Yamaha Xmax 300");
veicolo.typology.Add("moto");
veicolo.displacement.Add(1300);
veicolo.colour.Add("Nera");
veicolo.port.Add(0);
veicolo.seats.Add(2);


veicolo.visualizza(veicolo.model, veicolo.typology, veicolo.displacement, veicolo.colour, veicolo.port, veicolo.seats);