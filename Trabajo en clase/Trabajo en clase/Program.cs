using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_en_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> ListaPersonas = new List<Persona>();
            

            void Almacenar (List<Persona> almacenar)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("TBCLASE.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, almacenar);
                stream.Close();
            }
            void Cargar()
            {

            }
           
            while (true)
            {

                Console.WriteLine("ESCOJA EL NUMERO DE ALGUNA DE LAS SIGUIENTES OPCIONES QUE TENEMOS PARA USTED: ");
                Console.WriteLine("");
                Console.WriteLine("1. CARGAR: ");
                Console.WriteLine("2. SERIALIZAR: ");
                Console.WriteLine("3. CREAR PERSONA: ");
                Console.WriteLine("4. MOSTRAR PERSONAS: ");
                Console.WriteLine("E. SALIR DEL PROGRAMA: ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("");
                    Console.WriteLine("DAME LOS DATOS DE LA PERSONA EN EL SIGUIENTE ORDEN: NOMBRE,APELLIDO,EDAD");
                    string Nombre = Console.ReadLine();
                    string Apellido = Console.ReadLine();
                    string Edad = Console.ReadLine();
                    Persona persona = new Persona(Nombre, Apellido, Int32.Parse(Edad));
                    ListaPersonas.Add(persona);



                }
                if (choice == "4")
                {
                    for(int x = 0; x < ListaPersonas.Count(); x++)
                    {
                        Console.WriteLine(ListaPersonas[x].Informacion());
                    }
                }
                else if (choice == "E" || choice == "e")
                {
                    Console.WriteLine("Chao");
                    break;
                }
            }
        }
    }
}
