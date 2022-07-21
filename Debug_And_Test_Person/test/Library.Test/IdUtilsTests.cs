using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
  public class IdUtilsTests
  {
    // Estos tests los hice por hacer algo mas. Con los tests de Person bastaría, pero decidí hacerlos porque si hago algun cambio en la clase
    // estoy seguro de que tengo tests para esta clase específica.
    [Test]
    public void TestValidId_1()
    {
      bool valid = IdUtils.IdIsValid("53002299"); 
      Assert.AreEqual(true, valid);
    }

    [Test]
    public void TestValidId_2()
    {
      bool valid = IdUtils.IdIsValid("5300229.9"); 
      Assert.AreEqual(true, valid);
    }

    [Test]
    public void TestValidId_3()
    {
      bool valid = IdUtils.IdIsValid("5300229-9"); 
      Assert.AreEqual(true, valid);
    }

     [Test]
    public void TestInvalidId_1()
    {
      bool valid = IdUtils.IdIsValid(""); 
      Assert.AreEqual(false, valid);
    }

    [Test]
    public void TestInvalidId_2()
    {
      bool valid = IdUtils.IdIsValid("Text"); 
      Assert.AreEqual(false, valid);
    }

    [Test]
    public void TestInvalidId_3()
    {
      bool valid = IdUtils.IdIsValid("5300229/9"); 
      Assert.AreEqual(false, valid);
    }
  }
}
