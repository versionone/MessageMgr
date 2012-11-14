using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using VersionOne.SDK.ObjectModel;


namespace MsgManager
{
    public static class StaticConsoleTools
    {
        public static void DumpMessages(V1Session session)
        {
            try
            {
                foreach (Message m in session.messageStore.GetMessageList())
                {
                    System.Console.WriteLine("___________________________");
                    Debug.Assert(m.ID != null, "m.ID != null");
                    System.Console.WriteLine("ID: " +m.ID.ToString());
                    System.Console.WriteLine("NAME: " +m.Name.ToString());
                    System.Console.WriteLine("DESCRIPTION: " +m.Description);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Problem with printing out messages from Global Store. "+e.Message);
            }
        }
    }
}