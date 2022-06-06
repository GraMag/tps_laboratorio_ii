using Entidades.enums;
using Entidades;
using NUnit.Framework;
using Entidades.clases;
using Entidades.excepciones;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Comparar_Email_OK()
        {
            string mail = "test@mail.com";
            string mail2 = "test@mail.com";

            bool actual = Helpers.ValidarEmail(mail, mail2);

            Assert.IsTrue(actual);

        }

        [Test]
        public void Lanzar_RepetirEmailExcepcion()
        {
            string mail = "test@mail.com";
            string mail2 = "test2@mail.com";

            Assert.Throws<RepetirEmailException>(() => Helpers.ValidarEmail(mail, mail2));
        }

        [Test]
        public void Lanzar_EmailInvalidoException()
        {
            string mail = "test #@mail.com";

            Assert.Throws<EmailInvalidoException>(() => Helpers.ValidarEmail(mail));
        }
    }
}