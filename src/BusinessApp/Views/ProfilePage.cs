using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace BusinessApp.Views
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            BackgroundColor = Color.White;

            var relativeLayout = new RelativeLayout {HeightRequest = 100};

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

            var boxView = new BoxView {Color = Color.Black.MultiplyAlpha(.5)};
            relativeLayout.Children.Add(boxView,
                Constraint.Constant(0), Constraint.Constant(0),
                Constraint.RelativeToParent(parent => parent.Width),
                Constraint.RelativeToParent(parent => parent.Height*.5));

            var dome = new Image {Aspect = Aspect.AspectFill, Source = new FileImageSource {File = "dome.png"}};
            relativeLayout.Children.Add(dome, Constraint.Constant(-10),
                Constraint.RelativeToParent(parent => parent.Height*.5 - 50),
                Constraint.RelativeToParent(parent => parent.Width + 10),
                Constraint.Constant(75));

            var settings = new Image
            {
                Source = new FileImageSource { File = "settings.png" },
                HeightRequest = 32,
                WidthRequest = 32
            };

            relativeLayout.Children.Add(settings,
                Constraint.RelativeToParent((parent) => parent.Width * .05),
                Constraint.RelativeToParent((parent) => (parent.Height * .48)),
                Constraint.RelativeToParent((parent) => parent.Width * .15),
                Constraint.RelativeToParent((parent) => parent.Width * .15));

            var share = new Image
            {
                Source = new FileImageSource { File = "share.png" },
                HeightRequest = 72,
                WidthRequest = 72
            };


            relativeLayout.Children.Add(share,
                Constraint.RelativeToParent((parent) => parent.Width * .95 - (parent.Width * .15)),
                Constraint.RelativeToParent((parent) => (parent.Height * .48)),
                Constraint.RelativeToParent((parent) => parent.Width * .15),
                Constraint.RelativeToParent((parent) => parent.Width * .15));


            var profileImage = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 2,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = new FileImageSource { File = "profileImage.jpg" }
            };

            relativeLayout.Children.Add(profileImage,
                Constraint.RelativeToParent((parent) => ((parent.Width - profileImage.Width) / 2)),
                Constraint.RelativeToParent((parent) => parent.Height * .21),
                Constraint.RelativeToParent((parent) => parent.Width * .5),
                Constraint.RelativeToParent((parent) => parent.Width * .5)
            );

            var details = new DetailsView();

            relativeLayout.Children.Add(details, Constraint.Constant(0),
                Constraint.RelativeToView(dome, (parent, view) => view.Y + view.Height - 20),
                Constraint.RelativeToParent((parent) => parent.Width),
                Constraint.Constant(120)
            );

            var body = new BodyView();

            relativeLayout.Children.Add(body, Constraint.Constant(0),
                Constraint.RelativeToView(details, (parent, view) => view.Y + view.Height - 20),
                Constraint.RelativeToParent((parent) => parent.Width),
                Constraint.RelativeToView(details, (parent, view) => {
                    var detailsbottomY = view.Y + view.Height;
                    return parent.Height - detailsbottomY;
                }));

            Content = relativeLayout;
        }
    }
}
