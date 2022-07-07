using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    public class Usuarios
    {
        UsuarioLogic UsuarioNegocio;

        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                @"1– Listado General
2– Consulta
3– Agregar
4- Modificar
5- Eliminar
6- Salir");
            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.WriteLine("");
            switch (opcion.Key)
            {
                case ConsoleKey.D1: this.ListadoGeneral(); ; break;
                case ConsoleKey.D2: this.Consultar(); break;
                case ConsoleKey.D3: this.Agregar(); break;
                case ConsoleKey.D4: this.Modificar(); break;
                case ConsoleKey.D5: this.Eliminar(); break;
                case ConsoleKey.D6: break;
                default: Console.WriteLine("Por favor, ingrese una opcion valida."); break;
            }

            if (opcion.Key != ConsoleKey.D6) { Console.ReadKey(); this.Menu(); }
        }

        private void ListadoGeneral()
        {
            List<Usuario> listaUsuarios = UsuarioNegocio.GetAll();
            listaUsuarios.ForEach(usuario => { MostrarDatos(usuario); });
        }

        private void Consultar()
        {
            try
            {
                Console.WriteLine("Ingrese el ID a consultar.");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID debe ser del tipo entero.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        private void Agregar()
        {
            Usuario usuario = new Usuario();


            Console.WriteLine("Ingrese Nombre:");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Apellido:");
            usuario.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese Nombre de Usuario:");
            usuario.NombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingrese Clave:");
            usuario.Clave = Console.ReadLine();

            Console.WriteLine("Ingrese Email:");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese estado del usuario (1-Habilitado Otro-No habilitado):");
            usuario.Habilitado = (Console.ReadKey().Key == ConsoleKey.D1);
            usuario.State = BusinessEntity.States.New;

            UsuarioNegocio.Save(usuario);

            Console.WriteLine(usuario.ID);
        }


        private void Modificar()
        {
            try
            {
                Console.WriteLine("Ingrese el ID a consultar.");
                int ID = int.Parse(Console.ReadLine());

                Usuario usuario = UsuarioNegocio.GetOne(ID);

                Console.WriteLine("Ingrese Nombre:");
                usuario.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese Apellido:");
                usuario.Apellido = Console.ReadLine();

                Console.WriteLine("Ingrese Nombre de Usuario:");
                usuario.NombreUsuario = Console.ReadLine();

                Console.WriteLine("Ingrese Clave:");
                usuario.Clave = Console.ReadLine();

                Console.WriteLine("Ingrese Email:");
                usuario.Email = Console.ReadLine();

                Console.WriteLine("Ingrese estado del usuario (1-Habilitado Otro-No habilitado):");
                usuario.Habilitado = (Console.ReadKey().Key == ConsoleKey.D1);
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID debe ser del tipo entero.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        private void Eliminar()
        {
            try
            {
                Console.WriteLine("Ingrese el ID a eliminar.");
                int ID = int.Parse(Console.ReadLine());

                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID debe ser del tipo entero.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }

        }

        private void MostrarDatos(Usuario usr)
        {
            string fila = String.Format("|{0,2}|{1,10}|{2,25}|{3,15}|{4,10}|{5,10}|{6,15}|", usr.ID, usr.State, usr.Email, usr.Nombre, usr.Apellido, usr.NombreUsuario, usr.Clave);
            Console.WriteLine(fila);
        }
    }
}
