using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class PersonTests
    {
        // Cuando se pasa un Id que es correcto, se debería asignar el Id al objeto correctamente debido a que la validación fue correcta.

        [Test]
        public void TestGoodId_1()
        {
            Person person = new Person("Example name", "53002299"); 
            Assert.AreEqual("53002299", person.ID);
        }

        // Este test demuestra que se aceptan Id con un guion
        [Test]
        public void TestGoodId_2()
        {
            Person person = new Person("Example name", "5300229-9");
            Assert.AreEqual("5300229-9", person.ID);
        }

        // Este test demuestra que se aceptan Id con un punto
        [Test]
        public void TestGoodId_3()
        {
            Person person = new Person("Example name", "5300229.9");
            Assert.AreEqual("5300229.9", person.ID);
        }

        // Cuando se pasa un Id que no es correcto, no se asigna esa Id a el objeto, se asigna null debido a que la validación falló.

        [Test]
        public void TestWrongId_1()
        {
            Person person = new Person("Example name", "5300229");
            Assert.AreEqual(null, person.ID);
        }

        [Test]
        public void TestWrongId_2()
        {
            Person person = new Person("Example name", "11111111111111");
            Assert.AreEqual(null, person.ID);
        }

        [Test]
        public void TestWrongId_3()
        {
            Person person = new Person("Example name", "");
            Assert.AreEqual(null, person.ID);
        }

        [Test]
        public void TestValidName()
        {
            Person person = new Person("Joel Alayon", "53002299"); 
            Assert.AreEqual("Joel Alayon", person.Name);
        }


        [Test]
        public void TestInvalidName()
        {
            Person person = new Person("", "53002299"); 
            Assert.AreEqual(null, person.Name);
        }

    }
}