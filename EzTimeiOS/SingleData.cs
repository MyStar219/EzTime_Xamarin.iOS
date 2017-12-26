using System;
namespace EzTimeiOS
{
    public class SingleData
    {
        #region Instance

        public int UserID;
        public string UserName;
        public int UserTypeID;
        public int EmpID;
        public string EmpNo;
        public int ClientID;
        public int DeptID;
        public string ClientName;
        public string CompanyName;
        public string EmpFirstName;
        public string EmpLastName;
        public string DeptName;
        public string Pict;

        public string alertStr;
        public string okStr;

        #endregion

        public static SingleData instance = null;
        public static SingleData getInstance()
        {
            if (instance == null)
            {
                instance = new SingleData();

                instance.alertStr = "עֵרָנִי";
                instance.okStr = "בסדר";

            }

            return instance;
        }
    }
}
