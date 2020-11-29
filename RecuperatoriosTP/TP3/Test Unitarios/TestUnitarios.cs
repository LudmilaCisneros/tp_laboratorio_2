using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clases_Abstractas;
using Clases_Instanciables;
using Excepciones;

namespace Test_Unitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void Test_CheckearDniInvalidoException()
        {
            Alumno miAlumno = new Alumno(2, "Ludmila", "Cisneros", "99999999999", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_CheckearNacionalidadInvalidaException()
        {
            Alumno miAlumno = new Alumno(2, "Ludmila", "Cisneros", "90000000", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void Test_CheckearAlumnoRepetidoException()
        {
            Universidad uni = new Universidad();
            Alumno miAlumno1 = new Alumno(3, "Ludmila", "Cisneros", "5685", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);

            uni += miAlumno1;
            uni += miAlumno1;
        }


    }
}
