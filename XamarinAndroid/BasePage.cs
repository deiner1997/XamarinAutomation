using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinAndroid
{
    public class BasePage
    {
        protected readonly IApp app;


        protected BasePage(IApp app)
        {
            this.app = app;
        }
        /// <summary>
        /// Wait for element generic. 
        /// </summary>
        /// <param name="element">Element name as string</param>
        public void WaitForElement(string element)
        {

            app.WaitForElement(element, "Time out waiting for element: " + element, new TimeSpan(0, 0, 3, 0, 0));
        }

        /// Wait for element is not present in the screen. 
        /// </summary>
        /// <param name="element">Element name as string</param>
        public void WaitForElementNotPresent(string element)
        {

            app.WaitForNoElement(element, "Time out waiting for element not present: " + element, new TimeSpan(0, 0, 3, 0, 0));
        }

        /// <summary>
        /// Scrolls down until element appears.
        /// </summary>
        /// <param name="element">Element.</param>
        public void scrollDownUntilElementAppears(string element)
        {

            app.ScrollTo(element);
        }
    }
}
