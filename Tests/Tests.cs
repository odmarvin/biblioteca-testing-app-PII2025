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
            // Arrange
            var titulo = "1984";

            // Act
            _biblioteca.PrestarLibro(titulo);

            // Assert
            Assert.IsTrue(_libro1.EstaPrestado);
        }

        [Test]
        public void PrestarLibro_LibroNoDisponible_LanzaExcepcion()
        {
            // Arrange
            var titulo = "Libro Inexistente";

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _biblioteca.PrestarLibro(titulo));
        }

        [Test]
        public void DevolverLibro_LibroPrestado_DevolveLibroCorrectamente()
        {
            // Arrange
            var titulo = "1984";
            _biblioteca.PrestarLibro(titulo);

            // Act
            _biblioteca.DevolverLibro(titulo);

            // Assert
            Assert.IsFalse(_libro1.EstaPrestado);
        }

        [Test]
        public void DevolverLibro_LibroNoPrestado_LanzaExcepcion()
        {
            // Arrange
            var titulo = "1984";

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _biblioteca.DevolverLibro(titulo));
        }

        [Test]
        public void ObtenerLibros_RetornaListaDeLibros()
        {
            // Arrange

            // Act
            var libros = _biblioteca.ObtenerLibros();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(2, libros.Count);
                Assert.Contains(_libro1, libros);
                Assert.Contains(_libro2, libros);
            });
        }
    }
}