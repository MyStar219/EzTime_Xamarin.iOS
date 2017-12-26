using System;
using CoreLocation;
using UIKit;

namespace EzTimeiOS
{
    public partial class HomeViewController : UIViewController
    {
        #region Params

        Global GlobalFunc = new Global();

        private String currentLat = "0";
        private String currentLong = "0";
            
        #endregion

        public HomeViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.initUI();

            this.setControlEventHandlers();

            CLLocationManager lm = new CLLocationManager(); //changed the class name
            lm.DesiredAccuracy = 1;
            lm.RequestAlwaysAuthorization();
            lm.RequestWhenInUseAuthorization();

            if(CLLocationManager.LocationServicesEnabled) {
                lm.LocationsUpdated += delegate (object sender, CLLocationsUpdatedEventArgs e) {
                    foreach (CLLocation l in e.Locations)
                    {
                        Console.WriteLine(l.Coordinate.Latitude.ToString() + ", " + l.Coordinate.Longitude.ToString());

                        currentLat = l.Coordinate.Latitude.ToString();
                        currentLong = l.Coordinate.Longitude.ToString();

                    }
                };

                lm.StartUpdatingLocation();
            }

            // Perform any additional setup after loading the view, typically from a nib.
        }

        #region UIControl

        void initUI() {
            
            lblWelcome.Text = "ברוך הבא, " + SingleData.getInstance().EmpFirstName + " " + SingleData.getInstance().EmpLastName;
        }
        #endregion

        #region ControlEvents

        void setControlEventHandlers()
        {
            btnBack.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PopViewController(true);
            };

            btnRecord.TouchUpInside += async (object sender, EventArgs e) =>
            {
                string url = "http://412.co.il/webservices/wsrecord.aspx?e=" + SingleData.getInstance().EmpNo + "&lng=" + currentLong + "&lat=" + currentLat;
                Console.WriteLine(url);

                string s_result = await GlobalFunc.FetchAsync(url);
                if (s_result == "1")
                {
                    var okCancelAlertController = UIAlertController.Create(SingleData.getInstance().alertStr, "הדיווח נקלט בהצלחה!", UIAlertControllerStyle.Alert);
                    okCancelAlertController.AddAction(UIAlertAction.Create(SingleData.getInstance().okStr, UIAlertActionStyle.Default, null));
                    PresentViewController(okCancelAlertController, true, null);

                }
            };

            btnMyHours.TouchUpInside += (sender, e) =>
            {
                this.GoToHoursListScreen();
            };
        }

        #endregion

        #region GotoScreen

        void GoToHoursListScreen()
        {
            try
            {
                HoursListViewController viewCtrl = (HoursListViewController)this.Storyboard.InstantiateViewController("HoursListViewController");

                this.NavigationController.PushViewController(viewCtrl, true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        #endregion


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

