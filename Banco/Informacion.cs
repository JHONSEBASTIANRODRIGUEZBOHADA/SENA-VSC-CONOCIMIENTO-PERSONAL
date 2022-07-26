using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Informacion
    {
        Datos Dato = new Datos();

        public void BancoInicio()
        {
            Console.WriteLine("\n*********************************");
            Console.WriteLine("************   BANCO  ***********");
            Console.WriteLine("*********************************");
        }

        public void OpcionMenu()
        {
            Console.WriteLine("\n1.Cuenta");
            Console.WriteLine("2.Salir");
        }

        public void OpcionSalir()
        {
            Console.WriteLine("Salir");
        }

        public void OpcionRegresar()
        {
            Console.WriteLine("Regresar");
        }

        public void Cuenta()
        {
            int Opciones = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n1.Ingresar a la cuenta");
                    Console.WriteLine("2.Regresar");
                    Opciones = int.Parse(Console.ReadLine());
                    switch (Opciones)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese el usuario");
                            Dato.Usuarioingresar1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la contraseña");
                            Dato.Contraseñaingresar1 = double.Parse(Console.ReadLine());

                            if (Dato.Usuarioingresar1 == Dato.Documento11 && Dato.Contraseñaingresar1 == Dato.Contraseña11 || Dato.Usuarioingresar1 == Dato.Documento21 && Dato.Contraseñaingresar1 == Dato.Contraseña21 || Dato.Usuarioingresar1 == Dato.Documento31 && Dato.Contraseñaingresar1 == Dato.Contraseña31)
                            {
                                do
                                {
                                    try
                                    {
                                        Console.WriteLine("\nIngrese la opcion que desee realizar");
                                        Console.WriteLine("\n1.Retirar dinero");
                                        Console.WriteLine("2.Depositar dinero");
                                        Console.WriteLine("3.Ver estado de la cuenta");
                                        Console.WriteLine("4.Regresar");
                                        Opciones = int.Parse(Console.ReadLine());
                                        switch (Opciones)
                                        {

                                            case 1:
                                                do
                                                {
                                                    Console.WriteLine("\n1.100.000");
                                                    Console.WriteLine("2.300.000");
                                                    Console.WriteLine("3.500.000");
                                                    Console.WriteLine("4.700.000");
                                                    Console.WriteLine("5.900.000");
                                                    Console.WriteLine("6.Regresar");
                                                    Opciones = int.Parse(Console.ReadLine());
                                                    switch (Opciones)
                                                    {
                                                        case 1:
                                                            if (Dato.Dinero1 == 0)
                                                            {
                                                                Console.WriteLine("No tiene la cantidad de dinero para hacer el retiro");
                                                            }
                                                            else
                                                            {
                                                                Dato.Dinero1 = Dato.Dinero1 - 100000;
                                                                Console.WriteLine($"Su cuenta actualemte tiene {Dato.Dinero1}");
                                                            }
                                                            break;

                                                        case 2:
                                                            if (Dato.Dinero1 == 0)
                                                            {
                                                                Console.WriteLine("No tiene la cantidad de dinero para hacer el retiro");
                                                            }
                                                            else
                                                            {
                                                                Dato.Dinero1 = Dato.Dinero1 - 300000;
                                                                Console.WriteLine($"Su cuenta actualemte tiene {Dato.Dinero1}");
                                                            }
                                                            break;

                                                        case 3:
                                                            if (Dato.Dinero1 == 0)
                                                            {
                                                                Console.WriteLine("No tiene la cantidad de dinero para hacer el retiro");
                                                            }
                                                            else
                                                            {

                                                                Dato.Dinero1 = Dato.Dinero1 - 500000;
                                                                Console.WriteLine($"Su cuenta actualemte tiene {Dato.Dinero1}");
                                                            }
                                                            break;

                                                        case 4:
                                                            if (Dato.Dinero1 == 0)
                                                            {
                                                                Console.WriteLine("No tiene la cantidad de dinero para hacer el retiro");
                                                            }
                                                            else
                                                            {
                                                                Dato.Dinero1 = Dato.Dinero1 - 700000;
                                                                Console.WriteLine($"Su cuenta actualemte tiene {Dato.Dinero1}");
                                                            }
                                                            break;

                                                        case 5:
                                                            if (Dato.Dinero1 == 0)
                                                            {
                                                                Console.WriteLine("No tiene la cantidad de dinero para hacer el retiro");
                                                            }
                                                            else
                                                            {
                                                                Dato.Dinero1 = Dato.Dinero1 - 900000;
                                                                Console.WriteLine($"Su cuenta actualemte tiene {Dato.Dinero1}");
                                                            }
                                                            break;

                                                        case 6:
                                                            OpcionRegresar();
                                                            break;

                                                        default:
                                                            Console.WriteLine("Ingreso un dato invalido");
                                                            break;
                                                    }
                                                } while (Opciones != 6);
                                                break;

                                            case 2:
                                                Console.WriteLine("\nIngrese el valor del dinero que quiere depositar");
                                                Dato.Dineroingresar1 = int.Parse(Console.ReadLine());
                                                if (Dato.Dineroingresar1 < 0)
                                                {
                                                    Console.WriteLine("Ingreso un valor negativo");
                                                }
                                                else
                                                {
                                                    Dato.Dinero1 = Dato.Dineroingresar1 + Dato.Dinero1;
                                                    Console.WriteLine($"Su dinero actual en la cuenta es: {Dato.Dinero1}");
                                                }
                                                break;

                                            case 3:
                                                Console.WriteLine(Dato.Dinero1);
                                                break;

                                            case 4:
                                                OpcionRegresar();
                                                break;

                                            default:
                                                Console.WriteLine("Ingreso un dato invalido");
                                                break;
                                        }
                                    }catch(Exception ex)
                                    {
                                        Console.WriteLine("ingreso un dato invalido");
                                    }
                                } while (Opciones != 4);
                            }
                            else
                            {
                                Console.WriteLine("Usuario o contraseña incorrectos");
                            }
                            break;

                        case 2:
                            OpcionRegresar();
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
            }while(Opciones != 2);
            
        }
    }
}
