using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.WindowsAzure.MobileServices;
using UIKit;

namespace PlatAuction.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            try
            {
                CurrentPlatform.Init();
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch(Exception e)
            {
                throw (e);
            }
        }
    }
}
