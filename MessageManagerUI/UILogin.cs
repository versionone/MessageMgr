using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MsgManager;
using VersionOne.SDK.APIClient;
using VersionOne.SDK.ObjectModel;
using OmMessage = VersionOne.SDK.ObjectModel.Message;
using System.Configuration;

namespace MsgManagerUI
{
    public class UiLogin
    {
        private bool _connectState=false;
        public bool isV1Connected
        {
         get
            {
                return _connectState;
            }    
        }

        public UiLogin(string path, string userName, string password)
        {
            this._connectState = false;
            // I don't like how this global ass Session is behaving.
            Session.V1S = new V1Session();
            
            // If user forgets to enter a string, we look in the config file for the server
        /*TODO kill    cuz the interface will handle this upon load
            if (path.Length==0)
            {
                //TODO for now, assume that user will always have a config file member or they entered on in textbox
                path = UiUtils.GetPathFromConfig();
            }
            */
            Session.V1S.SetServerPath(path);
            Session.V1S.UserName = userName;
            Session.V1S.Password = password;
            if (!Session.V1S.LoginToV1())
            {
                MessageBox.Show("Problem with trying to authenticate VersionOne. Check your VersionOne URL,username and password. ");
            }
            else
            {
                _connectState = true;
            }
        }
        
        
    }
}
