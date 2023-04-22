
namespace EjemploColeccTest
{
    public class Alumno
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Facultad { get; set; }

        public string Condicion { get; set; }

        public Alumno(string nombre, string facultad, string condicion, int edad)
        {
            Edad = edad;
            Nombre = nombre;
            Facultad = facultad;
            Condicion = condicion;
        }
    }
}
