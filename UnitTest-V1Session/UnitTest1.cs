using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VersionOne.SDK.APIClient;
using MsgManager;

namespace UnitTest_V1Session
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestiV1SessionPass()
		{
			//Create a V1Session
			V1Session session = new V1Session();
			session.accessToken = "asdf";
			var result = session.LoginToV1();
			Assert.IsTrue( result);	

			
		}
	}
}
