using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VersionOne.SDK.APIClient;

namespace MsgManager
{
    public class V1MessageStore
    {
        private MessageFilter messageFilter;
         
        //private ICollection<Message> msgList;
        private V1Instance _v1In;

        //This is set up because I have items in StaticTools that should be able to read from the messageContainer for console printing
        public ICollection<Message> _messageContainer;
        
        public ICollection<Message> messageList
        {
            get { return _messageContainer; }
        }
       
        public V1MessageStore(V1Connector v1In)
        {
            try
            {
                _v1In = v1In;
                messageFilter = new MessageFilter();
                messageFilter.Recipient.Add(_v1In.LoggedInMember);
            }
            catch(Exception ex)
            {
               
            }
        }
       
        //Load up the store
        public void QueryMessages()
        {
            _messageContainer = _v1In.Get.Messages(messageFilter);
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
                msg.DeleteReceipt();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem Attempting to delete a message "+ msg.Name + " OID="+ msg + " " + e.Message);
            }
        }

        public void DeleteAllMessages()
        {
            foreach (Message msg in _messageContainer)
            {
                DeleteSingleMessage(msg);    
            }
        }
        public Message TraverseList()
        {
            return (_messageContainer.ElementAt(1));
        }
    }
}
