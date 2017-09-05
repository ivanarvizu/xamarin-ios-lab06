// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Lab05
{
    [Register ("ValidationController")]
    partial class ValidationController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Email { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Password { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ValidateActivityButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Email != null) {
                Email.Dispose ();
                Email = null;
            }

            if (Password != null) {
                Password.Dispose ();
                Password = null;
            }

            if (ValidateActivityButton != null) {
                ValidateActivityButton.Dispose ();
                ValidateActivityButton = null;
            }
        }
    }
}