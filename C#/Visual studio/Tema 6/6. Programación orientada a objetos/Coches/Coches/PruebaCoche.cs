string marca, modelo;
int cilindrada;
float potencia;

Console.WriteLine("Escribe la marca del coche:");
marca = Console.ReadLine();

Console.WriteLine("Modelo del coche:");
modelo = Console.ReadLine();

Console.WriteLine("Introduce cilindrada:");
cilindrada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce potencia:");
potencia = Convert.ToSingle(Console.ReadLine());

Coche c = new Coche();
c.SetMarca(marca);
c.SetModelo(modelo);
c.SetCilindrada(cilindrada);
c.SetPotencia(potencia);

Console.WriteLine("Marca: " + c.GetMarca());
Console.WriteLine("Modelo: " + c.GetModelo());
Console.WriteLine("Cilindrada: " + c.GetCilindrada());
Console.WriteLine("Potencia: " + c.GetPotencia());

Coche c2 = new Coche("Renault", "Golf", 1400,1.3f);
Console.WriteLine("Marca: " + c2.GetMarca());
Console.WriteLine("Modelo: " + c2.GetModelo());
Console.WriteLine("Cilindrada: " + c2.GetCilindrada());
Console.WriteLine("Potencia: " + c2.GetPotencia());
