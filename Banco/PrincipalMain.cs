using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class PrincipalMain
    {
        public static void Main(string[] args)
        {
            Informacion Banco = new Informacion();
            Informacion Inicio = new Informacion();
            Informacion Menu = new Informacion();
            Informacion Salir = new Informacion();
            Informacion OpcionCuenta = new Informacion();
            do
            {
                try
                {
                    //Console.Clear();
                    Banco.BancoInicio();
                    Menu.OpcionMenu();
                    int Opciones = int.Parse(Console.ReadLine());
                    switch (Opciones)
                    {
                        case 1:
                            OpcionCuenta.Cuenta();
                            break;

                        case 2:
                            Salir.OpcionSalir();
                            break;

                        default:
                            Console.WriteLine("Ingreso un dato invalido");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ingreso un dato invalido");
                }

            } while (true);
        }
    }
}
