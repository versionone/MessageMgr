using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsgManager;

namespace UnitTest_Session
{
	[TestClass]
	public class UnitTest1
	{
		string url = "https://www11.v1host.com/VersionOneMi";
		string tokenFail = "=asdlfkj=";
		string tokenPass = "1.tmw39jJHozYGcOuH++q/E0xwyC8=";

		[TestMethod]
		public void test_LoginToV1F()
		{
			V1Session session = new V1Session(url, tokenFail);
			var result = session.LoginToV1();
			System.Console.WriteLine(result);
			 Assert.IsFalse(result);
		}
		[TestMethod]
		public void test_LoginToV1P()
		{
			V1Session session = new V1Session(url, tokenPass);
			var result = session.LoginToV1();
			System.Console.WriteLine(result);
				Assert.IsTrue(result);
		}
	}
}
