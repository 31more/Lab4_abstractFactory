using System;

namespace lab_4
{
    /// <summary>
    /// Client сlass, depends on Service
    /// </summary>
    class Client
    {
        App app_cl;

        public Client(App a)
        {
            app_cl = a;
        }

        public void GetApp(string OSName)
        {
            switch (OSName)
            {
             case  "size":
                 app_cl.size();
                 break;
             case  "speedOfWork":
                 app_cl.speedOfWork();
                 break;
             case  "codec":
                 app_cl.codec();
                 break;
             case  "communication":
                 app_cl.communication();
                 break;
             case  "browserSupport":
                 app_cl.browserSupport();
                 break;
             case  "friendList":
                 app_cl.friendList();
                 break;
             case  "lowLatency":
                 app_cl.lowLatency();
                 break;
             case  "minimalCPUUsage":
                 app_cl.minimalCPUUsage();
                 break;
             case  "resolution":
                 app_cl.resolution();
                 break;
             case  "multipleChannels":
                 app_cl.multipleChannels();
                 break;
                 
                 default:
                     throw new ArgumentException("Wrong OS");
            }
        }
    }
}