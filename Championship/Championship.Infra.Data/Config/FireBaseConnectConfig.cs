using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Championship.Infra.Data.Config
{
    public class FireBaseConnectConfig
    {
        private string AuthString { get; set; }
        private string BasePath { get; set; }
        IFirebaseClient client;

        public FireBaseConnectConfig ()
        {
            this.AuthString = "KS1lJRbCy186SbVKHBrSdggOVGQSebuEDFR3jon3";
            this.BasePath = "https://championshipdb.firebaseio.com/";
        }

        public void Connect()
        {
            IFirebaseConfig config = new FirebaseConfig {
                AuthSecret = this.AuthString,
                BasePath = this.BasePath
            };
            
            client = new FireSharp.FirebaseClient(config);
            if (client != null) {
                
            }
        }
    }
}
