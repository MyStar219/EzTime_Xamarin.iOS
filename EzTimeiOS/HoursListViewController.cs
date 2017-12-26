using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UIKit;

namespace EzTimeiOS
{
    public partial class HoursListViewController : UIViewController
    {
        #region Params

        Global GlobalFunc = new Global();

        int ii_month, ii_year;
        DateTime dt_current;

        #endregion

        public HoursListViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.initUI();

            this.SearchHandleTouchUpInside();

            this.setControlEventHandlers();


            // Perform any additional setup after loading the view, typically from a nib.
        }

        #region UIControl

        void initUI()
        {
            btnSearch.Hidden = true;
            ii_month = DateTime.Now.Month;
            ii_year = DateTime.Now.Year;
            dt_current = new DateTime(ii_year, ii_month, 1);
            lblMonth.Text = "חודש:  " + dt_current.ToString("MM/yyyy");
        }

        #endregion


        #region ControlEvents

        void setControlEventHandlers()
        {
            
            btnBack.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PopViewController(true);
            };

            btnPrevMonth.TouchUpInside += (sender, e) =>
            {
                dt_current = dt_current.AddMonths(-1); lblMonth.Text = "חודש:  " + dt_current.ToString("MM/yyyy");
                SearchHandleTouchUpInside();
            };

            btnNextMonth.TouchUpInside += (sender, e) =>
            {
                dt_current = dt_current.AddMonths(1); lblMonth.Text = "חודש:  " + dt_current.ToString("MM/yyyy");
                SearchHandleTouchUpInside();
            };

            btnSearch.TouchUpInside += (sender, e) =>
            {
                SearchHandleTouchUpInside();
            };
        }

        public async void SearchHandleTouchUpInside()
        {
            string url = "http://412.co.il/webservices/wshours.aspx?e=" + SingleData.getInstance().EmpID + "&m=" + dt_current.ToString("MM") + "&y=" + dt_current.ToString("yyyy");
            string s_json = await GlobalFunc.FetchAsync(url);

            var json = JsonConvert.DeserializeObject<HoursRecord>(s_json);

            if (json.hours.Count > 0)
            {
                var hoursString = new String[json.hours.Count];

                for (int i = 0; i < json.hours.Count; i++)
                {
                    hoursString[i] = json.hours[i].Monthday + " " + json.hours[i].weekday + " " + json.hours[i].HourLine;
                    Console.WriteLine(hoursString[i]);

                }

                tblViewHours.Source = new HoursTableSource(this, hoursString);

            }
            else
            {
                var okCancelAlertController = UIAlertController.Create(SingleData.getInstance().alertStr, "לא דווחו שעות עבור החודש.", UIAlertControllerStyle.Alert);
                okCancelAlertController.AddAction(UIAlertAction.Create(SingleData.getInstance().okStr, UIAlertActionStyle.Default, null));
                PresentViewController(okCancelAlertController, true, null);

            }

        }

        #endregion

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public class HoursRecord
    {
        public List<Hour> hours { get; set; }

    }
    public class Hour
    {
        [JsonProperty("GregDate")]
        public DateTime GregDate { get; set; }
        [JsonProperty("MonthDay")]
        public string Monthday { get; set; }
        [JsonProperty("weekday")]
        public string weekday { get; set; }
        [JsonProperty("daytype")]
        public int daytype { get; set; }
        [JsonProperty("HourType")]
        public string HourType { get; set; }
        [JsonProperty("HourLine")]
        public string HourLine { get; set; }
    }
}

