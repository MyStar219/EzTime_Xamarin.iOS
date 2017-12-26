// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace EzTimeiOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView loginView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFldPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFldUserName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnLogin != null) {
                btnLogin.Dispose ();
                btnLogin = null;
            }

            if (loginView != null) {
                loginView.Dispose ();
                loginView = null;
            }

            if (txtFldPassword != null) {
                txtFldPassword.Dispose ();
                txtFldPassword = null;
            }

            if (txtFldUserName != null) {
                txtFldUserName.Dispose ();
                txtFldUserName = null;
            }
        }
    }
}