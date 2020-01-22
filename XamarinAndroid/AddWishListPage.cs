using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinAndroid
{
    public class AddWishListPage : BasePage
    {
        readonly string skipButton;
        readonly string logoicono;
        readonly string category;
        readonly string subcategory;
        readonly string idimage;
        readonly string idimage2;
        readonly string idimage3;
        readonly int index1;
        readonly int index2;
        readonly string Wishlist;


        public AddWishListPage(IApp app)
            : base(app)
        {
            skipButton = "btn_skip";
            logoicono = "logo_icon";
            category = "Electronics";
            subcategory = "Laptops";
            idimage = "promotions_banner";
            idimage2 = "banner_0";
            index1 = 2;
            idimage3 = "NoResourceEntry-6";
            index2 = 1;
            Wishlist = "Wishlist";
        }

        public AddWishListPage UserTapsSkipButton()
        {
            app.WaitForElement(c => c.Marked(skipButton));
            app.Tap(c => c.Marked(skipButton));

            return this;
        }

        public AddWishListPage UserTapIcon()
        {

            app.WaitForElement(c => c.Marked(logoicono));
            app.Tap(c => c.Marked(logoicono));

            return this;
        }

        public AddWishListPage UserSearchCategory()
        {

            app.Tap(e => e.Marked(category));

            return this;
        }

        public AddWishListPage UserSearchSubcategory()
        {
            app.WaitForElement(c => c.Marked(subcategory));
            app.Tap(e => e.Marked(subcategory));
            return this;
        }
        public AddWishListPage UserTapImageOne()
        {
            app.WaitForElement(c => c.Marked(idimage));
            app.Tap(c => c.Marked(idimage2).Index(index1));

            return this;
        }
        public AddWishListPage UserTapImageTwo()
        {
            app.WaitForElement(c => c.Marked(idimage3));
            app.Tap(c => c.Marked(idimage3).Index(index2));

            return this;
        }
        public AddWishListPage UserAddWishList()
        {
            app.WaitForElement(e => e.Text(Wishlist));
            app.Tap(e => e.Text(Wishlist));
            return this;
        }
    }
}
