using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;


using System.Text;

namespace XamarinAndroid
{
   public class BaseTest
    {
        public IApp app;

        [SetUp] //setup the test
        public void BeforeEachTest()
        {
            app = ConfigureApp
              .Android
              // TODO: Update this path to point to your Android app and uncomment the
              // code if the app is not included in the solution.
              .ApkFile("C://Users//deine//source//repos//XamarinAndroid//XamarinAndroid//Apk//flipkart.apk")
              .StartApp();
            //rONumber = RandomString (15);
        }
    }
}
