using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PNChartDemos {

    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate {

        UIWindow window;
        UIStoryboard storyboard;

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions) {
            window = new UIWindow(UIScreen.MainScreen.Bounds);
            storyboard = UIStoryboard.FromName("PNChartStoryboard", null);
            window.RootViewController = (UIViewController)storyboard.InstantiateInitialViewController();
            window.MakeKeyAndVisible();
            return true;
        }
    }
}

