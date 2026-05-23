using System;

List<Dispositivo> miEcosistema = new List<Dispositivo>();

Heladera heladeraMason = new Heladera();
heladeraMason.Nombre = "Heladera Samsung";
heladeraMason.TemperaturaActual = 4; 

Television teleMason = new Television();
teleMason.Nombre = "Smart TV LG";
teleMason.CanalActual = 12;


/*
luego de esto vamos a mi añadirlos a la lista que previamente creamos, la lista de ecosistema.
*/

miEcosistema.Add(heladeraMason);
miEcosistema.Add(teleMason);

// como ultimo encendemos todo en un bucle

foreach (Dispositivo aparato in miEcosistema)

{
    aparato.Encender();

}
/*para evitar que el programa falle usamos una estructura llamada try-catch
  try: pones el codigo que pensas que va a fallar.
  catch: si algo sale mal adentro de try el programa no explota, catch 
  es un mensaje de error amigable.
*/

Console.WriteLine("¿Qué acción querés hacer con la Heladera?");
Console.WriteLine("Encender");
Console.WriteLine("Apagar");

string accion = Console.ReadLine()!; 


switch(accion)
{
    case "Encender":
    heladeraMason.Encender();
    break;

    case "Apagar":
    heladeraMason.Apagar();
    break;

    default:
    Console.WriteLine("Opcion incorrecta, no existe esa accion.");
    break;

}

{
    if (heladeraMason.EstaEncendido == false)
    {
        Console.WriteLine("La heladera esta apagada.");
    }


else
Console.WriteLine("Porfavor, Ingresa la temperatura para la heladera (-1 a 7 grados)");
   {
    try
        {
            string entradaUsuario = Console.ReadLine()!.ToLower();
            int temperaturaUsuario = int.Parse(entradaUsuario); //convierto el texto a un entero

              if (temperaturaUsuario >= -1 && temperaturaUsuario <= 7)
                {
                heladeraMason.TemperaturaActual = temperaturaUsuario;
        
               Console.WriteLine ("Ajustando temperatura a " + heladeraMason.TemperaturaActual + " grados.");
                }
             else
                {
                  Console.WriteLine("Error, la heladera no soporta esa temperatura, debes poner una adecuada.");
                }
        }
         catch
        {
            Console.WriteLine("Error, coloque un numero valido.");
        }
    }
 
}




public class Dispositivo

{
    public string Nombre = "";
    public bool EstaEncendido;

    public void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine($"{Nombre} Se encendio.");

    }

    public void Apagar()
    {
        EstaEncendido = false;
        Console.WriteLine($"{Nombre} Se apago.");
    }
}


public class Heladera : Dispositivo 
{
    public int TemperaturaActual;

}

public class Television : Dispositivo
{
    public int CanalActual;
}