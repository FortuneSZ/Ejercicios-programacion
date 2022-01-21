Vehiculo v = new Vehiculo("Seat", "Leon", 2000, 2.0f,4);
Coche c = new Coche("Ford", "Fiesta", 1400, 1.4f,4);
Moto m = new Moto("Yamaha", "232", 500, 1.2f,2);

m.SetPotencia(1.5f);
m.Circular();

c.Circular(80);

v.MostrarInformacion();
c.MostrarInformacion();
m.MostrarInformacion();