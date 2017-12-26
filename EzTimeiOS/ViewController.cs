using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UIKit;

namespace EzTimeiOS
{
    public partial class ViewController : UIViewController
    {
        #region Params

        Global GlobalFunc = new Global();

        #endregion

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.setControlEventHandlers();

            this.hideKeyboard();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        #region ControlEvents

        void setControlEventHandlers()
        {

            btnLogin.TouchUpInside += async (object sender, EventArgs e) =>
            {
                
                string url = "http://412.co.il/webservices/wsuser.aspx?u=" + txtFldUserName.Text + "&pw=" + txtFldPassword.Text;

                string s_json = await GlobalFunc.FetchAsync(url);




                if (s_json == "0")
                {
                    var okCancelAlertController = UIAlertController.Create(SingleData.getInstance().alertStr, "שם משתמש או סיסמא אינם נכונים!", UIAlertControllerStyle.Alert);
                    okCancelAlertController.AddAction(UIAlertAction.Create(SingleData.getInstance().okStr, UIAlertActionStyle.Default, null));
                    PresentViewController(okCancelAlertController, true, null);
                }
                else
                {
                    var json = JsonConvert.DeserializeObject<Record>(s_json);
                    SingleData.getInstance().UserID = json.users[0].UserID;
                    SingleData.getInstance().UserName = json.users[0].UserName;
                    SingleData.getInstance().UserTypeID = json.users[0].UserTypeID;
                    SingleData.getInstance().EmpID = json.users[0].EmpID;
                    SingleData.getInstance().EmpNo = json.emp[0].EmpNo;
                    SingleData.getInstance().ClientID = json.emp[0].ClientID;
                    SingleData.getInstance().DeptID = json.emp[0].DeptID;
                    SingleData.getInstance().ClientName = json.emp[0].ClientName;
                    SingleData.getInstance().CompanyName = json.emp[0].CompanyName;
                    SingleData.getInstance().EmpFirstName = json.emp[0].EmpFirstName;
                    SingleData.getInstance().EmpLastName = json.emp[0].EmpLastName;
                    SingleData.getInstance().DeptName = json.emp[0].DeptName;
                    SingleData.getInstance().Pict = json.emp[0].pict;

                    try
                    {
                        HomeViewController viewCtrl = (HomeViewController)this.Storyboard.InstantiateViewController("HomeViewController");

                        this.NavigationController.PushViewController(viewCtrl, true);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }

                }

            };

        }

        #endregion


        #region HideKeyboard

        private void hideKeyboard()
        {

            UITapGestureRecognizer g_recognizer = new UITapGestureRecognizer(() =>
            {
                this.txtFldUserName.ResignFirstResponder();
                this.txtFldPassword.ResignFirstResponder();

            });

            this.loginView.AddGestureRecognizer(g_recognizer);
        }

        #endregion


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
    public class Record
    {
        public List<User> users { get; set; }
        public List<Emp> emp { get; set; }
        public List<Permission> Perm { get; set; }
    }
    public class User
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int UserTypeID { get; set; }
        public int EmpID { get; set; }
    }

    public class Emp
    {
        public int ClientID { get; set; }
        public int DeptID { get; set; }
        public string EmpNo { get; set; }
        public string ClientName { get; set; }
        public string CompanyName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string DeptName { get; set; }
        public string pict { get; set; }
    }
    public class Permission
    {
        public string PrivCode { get; set; }
        public bool CanView { get; set; }
        public bool CanCreate { get; set; }
        public bool CanModify { get; set; }
        public bool CanDelete { get; set; }
        public int PrivID { get; set; }
        public string PrivDescr { get; set; }
    }

}
