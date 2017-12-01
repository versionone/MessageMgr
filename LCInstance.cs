using System;
using System.Collections.Generic;
using VersionOne.SDK.APIClient;

namespace MessageManClean
{
	public class LcInstance
	{
		private bool _isLoggedIn = false;
		private V1Connector _v1Connection;
		private IServices _service;
		private string _accessToken;
		private Oid _memberOid;
		private string _v1Url;

		public LcInstance(string accessToken, string v1Url)
		{
			this.accessToken = accessToken;
			_v1Url = v1Url;
		}
		public bool isLoggedIn
		{
			get { return _isLoggedIn; }
			set { _isLoggedIn = value; }
		}
		public V1Connector v1Connection
		{
			get { return _v1Connection; }
			set { _v1Connection = value; }
		}

		public IServices service
		{
			get { return _service; }
			set { _service = value; }
		}

		public string accessToken
		{
			get { return _accessToken; }
			set { _accessToken = value; }
		}

		public Oid memberOid
		{
			get { return _memberOid; }
			set { _memberOid = value; }
		}

		public string v1Url
		{
			get { return _v1Url; }
			set { _v1Url = value; }
		}

		public Boolean login()
		{
			//We will assume that this is true until an exception is thrown to make it false
			// I did it this way because during debug, I could not determine what values in the V1Inst
			//That I could use to determine if there was a successful login occurred.  The V1Inst is NOT null when 
			//it fails and according to the debugger, I cannot access certain threads after the exception has been thrown.

			_isLoggedIn = false;
			//IServices services=null;

			try
			{
				// if  V1Inst = new V1Instance(_v1URL, _UserName, _Password);
				//V1Inst.Validate();
				//V1Inst =  V1Connector(_v1URL)

				v1Connection = V1Connector
					.WithInstanceUrl(v1Url)
					.WithUserAgentHeader("MessageMgr", "1.1")
					.WithAccessToken(accessToken)
					.Build();
				service = new Services(v1Connection);
			}
			catch (ArgumentNullException e)
			{
				_isLoggedIn = false;
			}
			catch (Exception e)
			{
				_isLoggedIn = false;
			}
			try
			{
				if (service.LoggedIn != null)
				{
					System.Console.WriteLine("shit");
					System.Console.WriteLine(service.LoggedIn);

					_isLoggedIn = true;
				}
			}
			catch (Exception e)
			{
				_isLoggedIn = false;
			}
			return _isLoggedIn;
		}

		public List<Message> QueryMessages()
		{
			List<Message> listRef = new List<Message>();
			//   _messageContainer = _v1In.Get.Messages(messageFilter);

			//IServices services = new Services(v1Instance);
			IAssetType messageReceiptType = service.Meta.GetAssetType("MessageReceipt");
			Query query = new Query(messageReceiptType);

			IAttributeDefinition idAttribute = messageReceiptType.GetAttributeDefinition("ID");
			IAttributeDefinition nameAttribute = messageReceiptType.GetAttributeDefinition("Message.Name");
			query.Selection.Add(idAttribute);
			query.Selection.Add(nameAttribute);
			QueryResult result = service.Retrieve(query);

			foreach (Asset story in result.Assets)
			{
				Console.WriteLine(story.Oid.Token);
				listRef.Add(new Message(story.Oid, story.GetAttribute(nameAttribute).Value.ToString()));
				Console.WriteLine(story.GetAttribute(nameAttribute).Value);
				Console.WriteLine(story.GetAttribute(idAttribute).Value);
				Console.WriteLine();
			}
			return listRef;

		}

		public void logout()
		{
			v1Connection = null;
			_isLoggedIn = false;
		}
	}
}