using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase03
{
    public class Celular
    {

        #region Atributos
        
        private EMarca marca;
        private string modelo;
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;

        private List<Contacto> agenda;
        private List<App> appsInstaladas;


        #endregion

        #region Propiedades

        public EMarca Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ram { get => ram; set => ram = value; }
        public double Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public double AlmacenamientoActual { get => almacenamientoActual; set => almacenamientoActual = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        #endregion

        #region Constructores
        //DRY
        public Celular()
        {
            this.agenda = new List<Contacto>();
            this.appsInstaladas = new List<App>();
            this.almacenamientoActual = 0;
            this.encendido = false;
        }
        public Celular(EMarca marca, string modelo, int ram, double almacenamiento):this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ram = ram;
            this.almacenamiento = almacenamiento;
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, List<Contacto> agenda)
            :this(marca, modelo, ram, almacenamiento)
        {
            this.agenda = agenda; 
        }



        #endregion

        #region Metodos de instancia

        public string AlternarEncendido()
        {
            string mensaje;
            if(this.encendido == true)
            {
                this.encendido = false;
                mensaje = "Apagado";
            }
            else
            {
                this.encendido = true;
                mensaje = "Encendido";

            }

            return mensaje;
        }

        public void Llamar(string numero)
        {
            if (this.encendido == true)
            {
                if(BuscarEnAgenda(numero) == true)
                {
                    Console.WriteLine($"Llamando al numero: {numero}");
                }
                else
                {
                    Console.WriteLine("Contacto desconocido");
                }
            }
            else
            {
                Console.WriteLine("Telefono apagado");
            }
           
        }
        public void Llamar(string numero, string nombre)
        {
            if (this.encendido == true)
            {
                Console.WriteLine($"----------{nombre}-----------");
                this.Llamar(numero);
            }
            else
            {
                Console.WriteLine("Apagado");
            }

        }
        public void Llamar(Contacto unContacto)
        {
            if (this.encendido == true)
            {
                this.Llamar(unContacto.numero, unContacto.nombre); 
            }
            else
            {
                Console.WriteLine("Apagado");

            }
        }
        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool esta = false;

            foreach(Contacto c in agenda)
            {
                if(numeroIngresado == c.numero) // c.numero deberia acceder a la propiedad Numero
                {
                    esta = true;
                    break;
                }                
            }

            return esta; 
        }

        private bool InstalarAplicacion(App miApp)
        {


            return true;
        }

        private bool VerificarEspacio(double nuevoSize)
        {
            return true;
        }

        public string mostrarCelular()
        {
            return "";
        }

        #endregion

        #region Sobrecarga de operadores
      

        
        #endregion

        #region Metodos Estaticos
        public static void ListarCelulares(List<Celular> celulares)
        {
        
        }
        
        #endregion
    }
}
