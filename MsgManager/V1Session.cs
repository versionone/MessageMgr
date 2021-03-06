﻿using System;
using System.Windows.Forms;
using VersionOne.SDK.ObjectModel;

namespace MsgManager
{
    public class V1Session
    {
        private string _Password;
        private string _UserName;
        private string _v1URL;
        private bool isLoggedIn=false;
        public V1MessageStore messageStore;
        public V1Instance V1Inst { get; set; }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Member { get; set; }


        public string V1Path
        {
            get { return _v1URL; }
            set { _v1URL = value; }
        }

        public void SetServerPath(string v1Server)
        {
            V1Path = v1Server;
        }

        public Boolean LoginToV1()
        {
            //We will assume that this is true until an exception is thrown to make it false
            // I did it this way because during debug, I could not determine what values in the V1Inst
            //That I could use to determine if there was a successful login occurred.  The V1Inst is NOT null when 
            //it fails and according to the debugger, I cannot access certain threads after the exception has been thrown.

            isLoggedIn = true;
            try
            {
                V1Inst = new V1Instance(_v1URL, _UserName, _Password);
                V1Inst.Validate();
            }
            catch (AuthenticationException e)
            {
                isLoggedIn = false;
            }
            catch(Exception)
            {
                isLoggedIn = false;
            }
            return isLoggedIn;
        }

        public void LogOutOfV1()
        {
            V1Inst = null;
            isLoggedIn = false;
        }

        public void PrepGlobalMessage()
        {
            messageStore = new V1MessageStore(V1Inst);
        }
    }
}