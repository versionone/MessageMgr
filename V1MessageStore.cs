using System;
using System.Collections.Generic;
using VersionOne.SDK.APIClient;

namespace MessageManClean
{
	public class Message
	{
		public Oid messageOid { get; set; }

		public string messageName { get; set; }

		public Message(Oid oid,string msg)
		{
			this.messageOid = oid;
			this.messageName = msg;
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
       
        public V1MessageStore()
        {

            try
            {
                //v1Instance = v1In;
			//	userName = userNameIn;
				
 //               messageFilter = new MessageFilter();
//                messageFilter.Recipient.Add(_v1In.LoggedInMember);
            }
            catch(Exception ex)
            {
               
            }
        }
       
        //Load up the store


        //This returns a copy of the message List to be used by gui or console output
        //TODO this should Be a simple getter!!!!!!
        public ICollection<Message> GetMessageList()
        {
            return (ICollection<Message>) _messageContainer;
        }

        public void DeleteSingleMessage(Message msg,IServices serviceIn)
        {
	        IOperation deleteOperation = serviceIn.Meta.GetOperation("MessageReceipt.Delete");
	        Oid deletedMr = serviceIn.ExecuteOperation(deleteOperation, msg.messageOid);
	        try
	        {
		        Query query = new Query(deletedMr.Momentless);
		        serviceIn.Retrieve(query);
	        }
		    catch (Exception e)
	        {
                //Console.WriteLine("Problem Attempting to delete a message "+ msg.messageName + " OID="+ msg + " " + e.Message);
		        Console.WriteLine("Error trying to delete MessageReceipt: " + msg.messageOid.Token);

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
