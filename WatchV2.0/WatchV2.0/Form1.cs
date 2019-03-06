using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchV2._0
{
    public partial class Dong_Ho : Form
    {

        public Dong_Ho()
        {
            InitializeComponent();
        }


        private void Dong_Ho_Load(object sender, EventArgs e)
        {
            LBGio.Font = new Font("QUARTZ", 48, FontStyle.Bold);
            LBGiay.Font = new Font("QUARTZ", 24, FontStyle.Bold);
            Change_Picture();
        }
        string sHour;
        string sMin;
        string sSec;
        string iDayofWeek;
        string iDay;
        string iMonth;
        string iYear;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sHour = DateTime.Now.Hour.ToString();
            sMin = DateTime.Now.Minute.ToString();
            sSec = DateTime.Now.Second.ToString();

            if (DateTime.Now.Hour < 10)
                sHour = "0" + sHour;
            if (DateTime.Now.Minute < 10)
                sMin = "0" + sMin;
            if (DateTime.Now.Second < 10)
                sSec = "0" + sSec;
            LBGio.Text = sHour + ":" + sMin;
            LBGiay.Text = sSec;
            iDayofWeek = DateTime.Now.DayOfWeek.ToString();
            iDay = DateTime.Now.Day.ToString();
            iMonth = DateTime.Now.Month.ToString();
            iYear = DateTime.Now.Year.ToString();
            if (iDayofWeek.ToLower() == "monday")
                iDayofWeek = "Thứ Hai";
            else if (iDayofWeek.ToLower() == "tuesday")
                iDayofWeek = "Thứ Ba";
            else if (iDayofWeek.ToLower() == "wednesday")
                iDayofWeek = "Thứ Tư";
            else if (iDayofWeek.ToLower() == "thursday")
                iDayofWeek = "Thứ Năm";
            else if (iDayofWeek.ToLower() == "friday")
                iDayofWeek = "Thứ Sáu";
            else if (iDayofWeek.ToLower() == "saturday")
                iDayofWeek = "Thứ Bảy";
            else if (iDayofWeek.ToLower() == "sunday")
                iDayofWeek = "Chủ Nhật";
            DMY.Text = iDayofWeek + ", " + iDay + " Tháng " + iMonth + " Năm " + iYear;
            if (DateTime.Now.Hour == 6 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
                Change_Picture();
            if (DateTime.Now.Hour == 19 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
                Change_Picture();
        }
        private void Change_Picture()
        {
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 19)
            {
                PB1.Image = Image.FromFile(@"sun.png");
            }
            else
            {
                PB1.Image = Image.FromFile(@"moon.png");
            }
        }

        //Move
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void Dong_Ho_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }


    }

}
