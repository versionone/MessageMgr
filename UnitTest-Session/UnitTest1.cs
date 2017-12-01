using System;
using System.Collections.Generic;
using MessageManClean;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenFail,url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			 Assert.IsFalse(result);
		}
		[TestMethod]
		public void test_LoginToV1P()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenPass, url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			Assert.IsTrue(result);
		}
		[TestMethod]
		public void test_Query()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenPass, url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			List<Message> dump = session.myV1Server.QueryMessages();
			Assert.IsTrue((dump.Count > 2000) );
		}
	}
}
