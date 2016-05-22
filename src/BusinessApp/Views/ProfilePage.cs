using Xamarin.Forms;

namespace BusinessApp.Views
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            BackgroundColor = Color.White;

            var relativeLayout = new RelativeLayout {HeightRequest = 100};

            DrawBackgroundImage(ref relativeLayout);
            DrawBoxView(ref relativeLayout);
            DrawDome(ref relativeLayout);
            DrawProfileImage(ref relativeLayout);

            Content = relativeLayout;
        }

        private static void DrawBackgroundImage(ref RelativeLayout relativeLayout)
        {
            var backgroundImage = new Image
            {
                Source = new FileImageSource {File = "capa.jpg"},
                Aspect = Aspect.AspectFill,
                IsOpaque = true,
                Opacity = 0.8
            };
            relativeLayout.Children.Add(backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent(parent => parent.Width),
                Constraint.RelativeToParent(parent => parent.Height*.5));
        }

        private static void DrawBoxView(ref RelativeLayout relativeLayout)
        {
            var boxView = new BoxView {Color = Color.Black.MultiplyAlpha(.5)};
            relativeLayout.Children.Add(boxView,
                Constraint.Constant(0), Constraint.Constant(0),
                Constraint.RelativeToParent(parent => parent.Width),
                Constraint.RelativeToParent(parent => parent.Height*.5));
        }

        //Add cúpula branca
        private static void DrawDome(ref RelativeLayout relativeLayout)
        {
            var dome = new Image {Aspect = Aspect.AspectFill, Source = new FileImageSource {File = "dome.png"}};
            relativeLayout.Children.Add(dome, Constraint.Constant(-10),
                Constraint.RelativeToParent(parent => parent.Height*.5 - 50),
                Constraint.RelativeToParent(parent => parent.Width + 10),
                Constraint.Constant(75));
        }

        private static void DrawProfileImage(ref RelativeLayout relativeLayout)
        {
            var profileImage = new Image
            {
                Aspect = Aspect.AspectFill,
                Source = new FileImageSource {File = "profileImage.jpg"}
            };
            relativeLayout.Children.Add(profileImage,
                Constraint.RelativeToParent(parent => parent.Width/2 - profileImage.Width/2),
                Constraint.RelativeToParent(parent => parent.Height*.25),
                Constraint.RelativeToParent(parent => parent.Width*.5),
                Constraint.RelativeToParent(parent => parent.Width*.5));
        }
    }
}
