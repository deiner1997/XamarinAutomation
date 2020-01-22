using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinAndroid
{
    public class SearchPage : BasePage
    {
        readonly string skipButton;
        readonly string searchTextBox;
        readonly string searchWrite;
        readonly string text;


        public SearchPage(IApp app)
            : base(app)
        {
                skipButton = "btn_skip";
                searchTextBox = "search_widget_textbox";
                searchWrite = "search_autoCompleteTextView";
                text = "DELL";


        }

        public SearchPage UserTapsSkipButton()
        {
            app.WaitForElement(c => c.Marked(skipButton));
            app.Tap(c => c.Marked(skipButton));

            return this;
        }

        public SearchPage UserTapSerchText()
        {

            app.WaitForElement(c => c.Marked(searchTextBox));
            app.Tap(searchTextBox);

            return this;
        }

        public SearchPage UserSearchProduct()
        {

            app.WaitForElement(searchWrite);
            app.EnterText(searchWrite, text);

            return this;
        }

        public SearchPage EnterPressSerch()
        {

            app.PressEnter();

            return this;
        }
    }
}
