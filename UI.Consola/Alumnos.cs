using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    public class Alumnos
    {
        AlumnoLogic AlumnoNegocio;

        public Alumnos()
        {
            AlumnoNegocio = new AlumnoLogic();
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
            List<AlumnoInscripcion> listaAlumnos = AlumnoNegocio.GetAll();
            listaAlumnos.ForEach(alumno => { MostrarDatos(alumno); });
        }

        private void Consultar()
        {
            try
            {
                Console.WriteLine("Ingrese el ID a consultar.");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(AlumnoNegocio.GetOne(ID));
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
            AlumnoInscripcion alumno = new AlumnoInscripcion();

            Console.WriteLine("Ingrese Condicion:");
            alumno.Condicion = Console.ReadLine();

            Console.WriteLine("Ingrese IDAlumno:");
            alumno.IDAlumno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese IDCurso:");
            alumno.IDCurso = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota:");
            alumno.Nota = int.Parse(Console.ReadLine());

            alumno.State = BusinessEntity.States.New;

            AlumnoNegocio.Save(alumno);

            Console.WriteLine(alumno.ID);
        }


        private void Modificar()
        {
            try
            {
                Console.WriteLine("Ingrese el ID a consultar.");
                int ID = int.Parse(Console.ReadLine());

                AlumnoInscripcion alumno = AlumnoNegocio.GetOne(ID);

                Console.WriteLine("Ingrese Condicion:");
                alumno.Condicion = Console.ReadLine();

                Console.WriteLine("Ingrese IDAlumno:");
                alumno.IDAlumno = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese IDCurso:");
                alumno.IDCurso = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Nota:");
                alumno.Nota = int.Parse(Console.ReadLine());

                alumno.State = BusinessEntity.States.Modified;
                AlumnoNegocio.Save(alumno);
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

                AlumnoNegocio.Delete(ID);
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

        private void MostrarDatos(AlumnoInscripcion alum)
        {
            string fila = String.Format("|{0,2}|{1,10}|{2,25}|{3,15}|{4,10}|{5,10}", alum.ID, alum.State, alum.Condicion, alum.IDAlumno, alum.IDCurso, alum.Nota);
            Console.WriteLine(fila);
        }
    }
}
