using System.Security.Cryptography.X509Certificates;

namespace RegistroTeslaPrueba8
{
    internal class Program
    {
        // Después de la clase, declaramos estructura de lista y 
        // la Lista inicial desde la cual, dentro del Main, crearemos
        // directamente la nueva lista
        struct autos   // Carga de estructura de datos para la lista.
        {
            public string modelo;
            public int year;
            public int kmActual;
            public int kmService;
            public string color;
            public string owner;
        }
        static List<autos> listaAutos; // declaración inicial de Listas.

        static void Main(string[] args) // Método principal
        {
            listaAutos = new List<autos>(); // Declaración de la nueva lista.
                                            // Observar: La struct, nombre de List entre <> y declaración
                                            // dentro del método Agregar; se llaman igual.

            Console.WriteLine("Programa de registro básico de vehículos TESLA");
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n Elija una opción:");
                Console.WriteLine("\n 1: Alta de un vehículo.\n 2: Baja de un vehículo.\n 3: Ver listado completo." +
                    "\n 4: Listado por año.\n 5: Listado por kilómetros.\n 6: Vehículo con más kilómetros." +
                    "\n 7: Salir del Registro.\n");
                string opcion = (Console.ReadLine());

                switch (opcion)
                {

                    case "1": Agregar(); break;
                    case "2": Borrar(); break;
                    case "3": VerListaCompleta(); break;
                    case "4": ListaPorYear(); break;
                    case "5": ListaPorKm(); break;
                    case "6": autoConMasKm(); break;
                    case "7": salir = true; Console.WriteLine("Usted ha salido del Registro"); break;
                    default:
                        Console.WriteLine("Opción no válida"); break;
                }
            }
        }
        static void Agregar() //OPCION NRO. 1
                              // Método para agregar datos a la nueva lista.
        {
            autos v; // Declaramos 'v' para poder después agregar (Add)
                     // también llamado 'Dato de tipo 'autos''
            Console.WriteLine("Modelo del vehículo: ");
            v.modelo = Console.ReadLine();//Inicializa el modelo.
            if (v.modelo == "") { Console.WriteLine("sin asignar"); }

            Console.WriteLine("Año de fabricación: ");
            v.year = 0;
            string validaYear = Convert.ToString(v.year);
            validaYear = Console.ReadLine();//Inicializa el año de fabricación del vehículo..
            if (validaYear != "")
            {
                v.year = Convert.ToInt32(validaYear);
                Convert.ToInt32(v.year);
            }
            else { Console.WriteLine("sin asignar"); }

            Console.WriteLine("Kilómetros actuales: ");
            v.kmActual = 0;
            string validaKmActual = Convert.ToString(v.kmActual);
            validaKmActual = Console.ReadLine();//Inicializa los kilómetros actuales.
            if (validaKmActual != "")
            {
                v.kmActual = Convert.ToInt32(validaKmActual);
                Convert.ToInt32(v.kmActual);
            }
            else { Console.WriteLine("sin asignar"); }

            Console.WriteLine("Kmts. en los que se realizó el último service: ");
            v.kmService = 0;
            string validaKmService = Convert.ToString(v.kmService);
            validaKmService = Console.ReadLine();// Inicializa los Kms. en los que se realizó el service.
            if (validaKmService != "")
            {
                v.kmService = Convert.ToInt32(validaKmService);
                Convert.ToInt32(v.kmService);
            }
            else { Console.WriteLine("Sin asignar"); }

            Console.WriteLine("Color del vehículo: ");
            v.color = Console.ReadLine();//Inicializa el color del vehículo.
            if (v.color == "") { Console.WriteLine("sin asignar"); }

            Console.WriteLine("Dueño del vehículo: ");
            v.owner = Console.ReadLine(); //Inicializa el nombre del dueño.
            if (v.owner == "") { Console.WriteLine("sin asignar"); }

            listaAutos.Add(v);//Esta es la herramienta
                              //que agrega los
                              //valores inicializados, a la lista.
            Console.WriteLine("\n El alta de vehículo ha sido exitosa");
            Console.WriteLine("\n Para completar campos sin asignar, deberá borrar el vehículo dado de Alta y volver a grabarlo");
            Console.WriteLine("\n Presione Enter para Volver al menú principal");
            Console.ReadLine();
        }

        static void Borrar()// OPCION NRO. 2
                            //Elimina un modelo de veículo con todas sus características.
        {
            Console.WriteLine("Indique la posición del vehículo a dar de baja");
            int posicABorrar = Convert.ToInt32(Console.ReadLine()) - 1;

            if (posicABorrar >= listaAutos.Count) //Condicional para determinar si la opción a borrar
                                                  //está fuera del rango.
            {
                Console.WriteLine("Posición incorrecta");
            }
            else
            {
                listaAutos.RemoveAt(posicABorrar);
            }
            Console.WriteLine("\n El vehículo ha sido dado de baja");
            Console.WriteLine("\n Presione Enter para Volver al menú principal");
            Console.ReadLine();
        }
        static void VerListaCompleta()//OPCION NRO. 3
                                      // Muestra el listado completo de todos los vehículos.
        {
            Console.WriteLine("Listado completo de vehículos");
            if (listaAutos.Count == 0) //Condicional que se ejecuta si no hay ningún vehículo en la lista.
            {

                Console.WriteLine("La lista se encuentra vacía. Elija la opción '1' para comenzar.");
            }
            else
            {
                //Con este for, recorremos todos los datos y los muestra.
                for (var i = 0; i < listaAutos.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + $"Modelo: " + listaAutos[i].modelo + " - Año: " + listaAutos[i].year +
                        " - Kms. actuales: " + listaAutos[i].kmActual + " - Kms. Service: " + listaAutos[i].kmService +
                        " - Color: " + listaAutos[i].color + " - Dueño: " + listaAutos[i].owner);

                }
            }
            Console.WriteLine("\n Presione Enter para Volver al menú principal");
            Console.ReadLine();
        }
        static void ListaPorYear() // OPCION NRO. 4
        {
            //Listado ordenado por año de fabricación en orden descendente. 
            var listaOrdenada = listaAutos.OrderByDescending(t => t.year);

            Console.WriteLine("Lista de vehículos ordenados por año");

            foreach (autos t in listaOrdenada)
            {
                Console.WriteLine($"Modelo: {t.modelo} - Año: {t.year} - Kms. actuales: {t.kmActual} - Kms. Service:" +
                    $" {t.kmService} - Color: {t.color} - Dueño: {t.owner}");
            }
            Console.WriteLine("\n Presione Enter para Volver al menú principal");
            Console.ReadLine();
        }
        static void ListaPorKm() // OPCION NRO. 5
        {
            //Listado ordenado por kilómetros en orden descendente.
            var listaOrdenada = listaAutos.OrderByDescending(t => t.kmActual);

            Console.WriteLine("Lista de vehículos ordenados por kilómetros");

            foreach (autos t in listaOrdenada)
            {
                Console.WriteLine($"Modelo: {t.modelo} - Año: {t.year} - Kms. actuales: {t.kmActual} - Kms. Service:" +
                    $" {t.kmService} - Color: {t.color} - Dueño: {t.owner}");
            }
            Console.WriteLine("\n Presione Enter para Volver al menú principal");
            Console.ReadLine();
        }
        static void autoConMasKm() // OPCION NRO. 6
        {
            //Muestra el modelo con todas sus características, con más kilómetros.
            var listaOrdenada = listaAutos.OrderByDescending(t => t.kmActual);
            var masKmts = listaOrdenada.First();
            Console.WriteLine("El vehículo con más kilómetros es: ");
            Console.WriteLine($"\n Modelo: {masKmts.modelo} - Año: {masKmts.year} - Kms. actuales: {masKmts.kmActual} -" +
                $" Kms. Service: {masKmts.kmService} - Color: {masKmts.color} - Dueño: {masKmts.owner}");
            Console.WriteLine("\n Presione Enter para Volver al menú principal");
            Console.ReadLine();
        }
    }
}
