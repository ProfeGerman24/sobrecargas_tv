using Clase03;

namespace Claro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto unContacto = new Contacto("Lucas", "555");

            List<Contacto> listaAgenda = new List<Contacto>();
            listaAgenda.Add(new Contacto("Juan", "444"));
            listaAgenda.Add(new Contacto("Maria", "333"));
            listaAgenda.Add(new Contacto("Luis", "222"));
            listaAgenda.Add(unContacto);

            Celular celu = new Celular(EMarca.Xiaomi, "X23", 16, 512, listaAgenda);
            celu.Encendido = true;
            celu.Llamar(unContacto);

        }
    }
}
