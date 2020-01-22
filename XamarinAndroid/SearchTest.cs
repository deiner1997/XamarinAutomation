using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinAndroid
{
    [TestFixture()]
    public class SearchTest : BaseTest
    {

        [Test()]
        public void UserSearch()
        {
            new SearchPage(app)
               
                .UserTapsSkipButton()
                .UserTapSerchText()
                .UserSearchProduct()
                .EnterPressSerch();
            
        }
    }
}
