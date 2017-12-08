using System;
using System.Collections.Generic;
using MessageManClean;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VersionOne.SDK.APIClient;

namespace UnitTest_Session
{
	[TestClass]
	public class UnitTest1
	{
		string url = "https://www11.v1host.com/VersionOneMi";
		string tokenFail = "=asdlfkj=";
		string tokenPass = "1.tmw39jJHozYGcOuH++q/E0xwyC8=";

		[TestMethod]
		public void loginFail()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenFail,url);
			session.messageStore = new V1MessageStore();
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			 Assert.IsFalse(result);
		}
		[TestMethod]
		public void loginPass()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenPass, url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			Assert.IsTrue(result);
		}
		[TestMethod]
		public void queryMessages()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenPass, url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			List<Message> dump = session.myV1Server.QueryMessages();
			Assert.IsTrue((dump.Count > 2000) );
		}
		[TestMethod]
		public void deleteMessages()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenPass, url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			List<Message> dump = session.myV1Server.QueryMessages();
			int firstCount =  dump.Count;
			
			// Delete all Messages here
			//DeleteAllMessages();	
			int finalCount =  dump.Count;
			Assert.IsTrue((firstCount>0)&&(finalCount ==0));
		}
		[TestMethod]
		public void deleteSingleMessage()
		{
			V1Session session = new V1Session();
			session.myV1Server = new LcInstance(tokenPass, url);
			var result = session.myV1Server.login();
			System.Console.WriteLine(result);
			List<Message> dump = session.myV1Server.QueryMessages();
			Oid oidToDie =  dump[1].messageOid;
			session.messageStore.DeleteSingleMessage(dump[1],session.myV1Server.service);			
			//DeleteAllMessages();	
			int finalCount =  dump.Count;
			Assert.IsTrue((firstCount>0)&&(finalCount ==0));
		}

	}
}
