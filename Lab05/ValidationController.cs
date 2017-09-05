using Foundation;
using System;
using UIKit;

namespace Lab05
{
    public partial class ValidationController : UIViewController
    {
        public ValidationController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ValidateActivityButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                Validate();
            };
        }

        async void Validate()
        {
            var Client = new SALLab06.ServiceClient();
            var Result = await Client.ValidateAsync(Email.Text, Password.Text, this);

            var Alert = UIAlertController.Create("Resultado"
                       , $"{Result.Status}\n{Result.FullName}\n{Result.Token}"
                       , UIAlertControllerStyle.Alert
                       );
            Alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(Alert, true, null);
        }
    }
}