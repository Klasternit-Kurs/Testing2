using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2;
using FakeItEasy;

namespace Testiranje
{
	[TestClass]
	public class DeliocTests
	{
		[TestMethod]
		public void TestDeljenje()
		{  //AAA
		   //Arrange

			var LazniParam = A.Fake<Parametri>();
			A.CallTo(() => LazniParam.x).Returns(6);
			A.CallTo(() => LazniParam.y).Returns(3);

			var del = new Delioc(LazniParam);

			//Act
			decimal actual = del.Deli();
			decimal expected = 2;


			//Assert
			Assert.AreEqual(expected, actual);
		}
		[TestClass]
		public class TestingParam
		{
			[TestMethod]
			public void ParamTest()
			{
				decimal a = 3;
				decimal b = 1;
				var p = new Parametri(a, b);

				Assert.AreEqual(a, p.x);
				Assert.AreEqual(b, p.y);
			}
		}
	}
}
