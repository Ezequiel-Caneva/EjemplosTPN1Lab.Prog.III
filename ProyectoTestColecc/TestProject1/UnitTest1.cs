using EjemploColeccTest;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DebeAgregarAlumnosALaLista()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            var p1 = new Alumno("Juan", "Derecho", "Regular", 23);
            var p2 = new Alumno("Pedro", "Ingenieria", "Libre", 25);
            var p3 = new Alumno("Juanita", "Medicina", "Regular", 22);

            //Utilizacion del metodo AddLast() y AddFirts()
            ListaAlumnos.AddLast(p1);
            ListaAlumnos.AddLast(p2);
            ListaAlumnos.AddFirst(p3);

            Assert.Equal(3, ListaAlumnos.Count);
            Assert.Equal(p2, ListaAlumnos.Last.Value);
            Assert.Equal(p3, ListaAlumnos.First.Value);
        }
        [Fact]
        public void DebeAgregarUnAlumnoDespuesDeUnNodoEspecifico()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            var p1 = new Alumno("Juan", "Derecho", "Regular", 23);
            var p2 = new Alumno("Pedro", "Ingenieria", "Libre", 25);
            var p3 = new Alumno("Juanita", "Medicina", "Regular", 22);

            ListaAlumnos.AddLast(p1);
            ListaAlumnos.AddLast(p2);
            ListaAlumnos.AddLast(p3);

            //Utilizacion merodo Find() y AddBefore()
            var nodo = ListaAlumnos.Find(p2);
            var nuevoAlumno = new Alumno("Lucia", "Ciencias Exactas", "Regular", 20);
            ListaAlumnos.AddBefore(nodo, nuevoAlumno);

            Assert.Equal(4, ListaAlumnos.Count);
            Assert.Equal(nuevoAlumno, nodo.Previous.Value);
            Assert.Equal(p1, nodo.Previous.Previous.Value);

            //Utilizacion metodo RemoveLast()
            ListaAlumnos.RemoveLast();

            Assert.Equal(3, ListaAlumnos.Count);

            //Utilizacion metodo Clear()
            ListaAlumnos.Clear();

            Assert.Equal(0, ListaAlumnos.Count);
        }
        [Fact]
        public void DebeDeterminarSiUnAlumnoSeEncuentraONo()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            ListaAlumnos.AddFirst(new Alumno("Juana", "Ciencias Exactas", "Libre", 19));
            ListaAlumnos.AddFirst(new Alumno("Pedro", "Ingenieria", "Regular", 22));
            ListaAlumnos.AddFirst(new Alumno("Lucia", "Medicina", "Libre", 20));

            var p4 = new Alumno("Jose", "Derecho", "Regular", 24);

            //Utilizacion metodo Contains()
            if (ListaAlumnos.Contains(p4) == true)
            {
                Assert.False(ListaAlumnos.Contains(p4));
            }
            else
            {
                ListaAlumnos.AddLast(p4);

                Assert.True(ListaAlumnos.Contains(p4));
            }
        }
        [Fact]
        public void DebeCopiarLaListaAUnaMatrizUnidemensional()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            var p1 = new Alumno("Juan", "Derecho", "Regular", 23);
            var p2 = new Alumno("Pedro", "Ingenieria", "Libre", 25);
            var p3 = new Alumno("Juanita", "Medicina", "Regular", 22);

            ListaAlumnos.AddLast(p1);
            ListaAlumnos.AddLast(p2);
            ListaAlumnos.AddLast(p3);

            Alumno[] arregloAlumnos = new Alumno[3];

            //Utilizacion metodo CopyTo()
            ListaAlumnos.CopyTo(arregloAlumnos, 0);

            //Utilizacion metodo Equals()
            Assert.True(p1.Equals(arregloAlumnos[0]));
            Assert.True(p2.Equals(arregloAlumnos[1]));
            Assert.True(p3.Equals(arregloAlumnos[2]));
        }
    }
}