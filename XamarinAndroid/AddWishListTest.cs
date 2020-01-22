using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinAndroid
{
    [TestFixture()]
    public class AddWishListTest :BaseTest
    {
        [Test()]
        public void UserTestWishList()
        {

            new AddWishListPage(app)
                .UserTapsSkipButton()
                .UserTapIcon()
                .UserSearchCategory()
                .UserSearchSubcategory()
                .UserTapImageOne()
                .UserTapImageTwo()
                .UserAddWishList();
        }


    }
}
