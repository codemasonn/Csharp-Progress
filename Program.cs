using System;


//Creamos una lista de dispositivos

List<Dispositivo> miEcosistema = new List<Dispositivo>();

/* cya tneemos programados los objetos y aca los creamos, le damos la vida en el codigo.
a la heladera le damos un nombre, le damos la variable temperaturaactual y a este le definimos un numero

a la television lo mismo, un nombre, le asignamos la variable de canalactual y le definimos el numero.
*/


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










/*crear clase base, esta clase hace de "padre", es el pilar para las otras clases.
     esta clase puede tener dos tipos de propiedad 
        string o bool
        string = nombre
        bool = verdadero o falso
        double = 6.5
        

    ej: public void encender()
        public void Apagar()

        en uno la variable EstaEncendido va a estar en True y en otro en False*/

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





/*Crear las clases "hijas", se le llama herencia

    como estamos hablando de dispositivos podemos crear la clase
    heladera esta va a estar heredada de Dispositivo
    
    La heladera va a tener un int (entero) que estaria en Celcius, la variable se llama temperaturaactual
    luego la vamos a poder modificar

    tambien creamos un objeto llamado television, tambien le damos una variable 
    
     */

public class Heladera : Dispositivo 
{
    public int TemperaturaActual;

}

public class Television : Dispositivo
{
    public int CanalActual;
}



