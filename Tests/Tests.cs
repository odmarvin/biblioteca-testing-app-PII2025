using App.Entidades;

namespace Tests
{
    public class Tests
    {
        private Biblioteca _biblioteca;
        private Libro _libro1;
        private Libro _libro2;

        [SetUp]
        public void Setup()
        {
            _biblioteca = new Biblioteca();
            _libro1 = new Libro("1984", "George Orwell");
            _libro2 = new Libro("El Principito", "Antoine de Saint-Exupéry");
            _biblioteca.AgregarLibro(_libro1);
            _biblioteca.AgregarLibro(_libro2);
        }

        [Test]
        public void PrestarLibro_LibroDisponible_PrestaLibroCorrectamente()
        {
            // Act

            // Assert
        }

        [Test]
        public void PrestarLibro_LibroNoDisponible_LanzaExcepcion()
        {
            // Act

            // Assert
        }

        [Test]
        public void DevolverLibro_LibroPrestado_DevolveLibroCorrectamente()
        {
            // Act

            // Assert
        }

        [Test]
        public void DevolverLibro_LibroNoPrestado_LanzaExcepcion()
        {
            // Act

            // Assert
        }

        [Test]
        public void ObtenerLibros_RetornaListaDeLibros()
        {
            // Act

            // Assert
        }
    }
}