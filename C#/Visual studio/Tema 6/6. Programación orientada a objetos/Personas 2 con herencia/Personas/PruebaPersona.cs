Persona p1, p2;

p1 = new Persona("Nacho");

p2 = new Persona();
/*p2.SetNombre("Ana");*/
p2.Nombre = "Ana";
PersonaInglesa p3 = new PersonaInglesa("John");
PersonaItaliana p4 = new PersonaItaliana("Paolo");
p1.Saludar();
p2.Saludar("Hola, buenas, me llamo Ana");
p3.Saludar();
p3.TomarTe();
p4.Saludar();

