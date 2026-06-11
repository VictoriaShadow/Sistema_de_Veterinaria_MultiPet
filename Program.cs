using HerenciaPoliformismoApp;
List<Mascota> pacientes = new List<Mascota>();

pacientes.Add(new Perro { Nombre = "Rex", EsEntrenado = true });
pacientes.Add(new Gato { Nombre = "Michi" });

Console.WriteLine("--- Turnos del Día ---");

foreach (var paciente in pacientes)
{
    paciente.RealizarExamen();
}
Console.ReadLine();