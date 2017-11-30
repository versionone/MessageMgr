using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VersionOne.SDK.APIClient;

namespace MsgManager
{
	public class Message
	{
		private Oid _message;
		public Oid message
		{
			get { return _message; }
			set { _message = value; }
		}
		private string _messageName;
		public string messageName
		{
			get { return _messageName; }
			set { _messageName = value; }
		}

	}
    public class V1MessageStore
    {
//        private MessageFilter messageFilter;
         
        //private ICollection<Message> msgList;
        private V1Connector _v1Instance;
		public V1Connector v1Instance
		{
			get { return _v1Instance; }
			set { _v1Instance = value; }
		}
		private string _userName;
		public string userName
		{
			get { return _userName; }
			set { _userName = value; }
		}



		//This is set up because I have items in StaticTools that should be able to read from the messageContainer for console printing
		public ICollection<Message> _messageContainer;
        
        public ICollection<Message> messageList
        {
            get { return _messageContainer; }
        }
       
        public V1MessageStore(V1Connector v1In, string userNameIn)
        {

            try
            {
                v1Instance = v1In;
				userName = userNameIn;
				
 //               messageFilter = new MessageFilter();
//                messageFilter.Recipient.Add(_v1In.LoggedInMember);
            }
            catch(Exception ex)
            {
               
            }
        }
       
        //Load up the store
        public void QueryMessages()
        {
			//   _messageContainer = _v1In.Get.Messages(messageFilter);

			IServices services = new Services(v1Instance);
			IAssetType storyType = services.Meta.GetAssetType("MessageReceipt");
			Query query = new Query(storyType);

			IAttributeDefinition nameAttribute = storyType.GetAttributeDefinition("ID");
			IAttributeDefinition estimateAttribute = storyType.GetAttributeDefinition("Message.Name");
			query.Selection.Add(nameAttribute);
			query.Selection.Add(estimateAttribute);
			QueryResult result = services.Retrieve(query);

			foreach (Asset story in result.Assets)
			{
				Console.WriteLine(story.Oid.Token);
				Console.WriteLine(story.GetAttribute(nameAttribute).Value);
				Console.WriteLine(story.GetAttribute(estimateAttribute).Value);
				Console.WriteLine();
			}


		}

        //This returns a copy of the message List to be used by gui or console output
        //TODO this should Be a simple getter!!!!!!
        public ICollection<Message> GetMessageList()
        {
            return (ICollection<Message>) _messageContainer;
        }

        public void DeleteSingleMessage(Message msg)
        {
            try
            {
//                msg.DeleteReceipt();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem Attempting to delete a message "+ msg.messageName + " OID="+ msg + " " + e.Message);
            }
        }

        public void DeleteAllMessages()
        {
  /*          foreach (Message msg in _messageContainer)
            {
                DeleteSingleMessage(msg);    
            }
        }
        public Message TraverseList()
        {
            return (_messageContainer.ElementAt(1));
			*/
        }
    }
}
