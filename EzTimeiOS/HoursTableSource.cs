using System;
using System.Collections.Generic;
using Foundation;

using UIKit;

namespace EzTimeiOS
{
    public class HoursTableSource : UITableViewSource
    {
        UIViewController rootController;
        private String[] hourTable;

        public HoursTableSource(UIViewController viewCtrl, String[] hourTable)
        {
            rootController = viewCtrl;

            this.hourTable = hourTable;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "identityCell");
            cell.BackgroundColor = UIColor.Clear;
            cell.TextLabel.TextAlignment = UITextAlignment.Center;
            cell.TextLabel.Lines = 1;
            cell.TextLabel.Text = hourTable[indexPath.Row];

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hourTable.Length;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 50;
        }

    }
}
