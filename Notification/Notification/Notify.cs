using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static Siticone.Desktop.UI.WinForms.Suite.Descriptions;

namespace Notification
{
    public partial class Notify : Form
    {
        private Notify.enmAction action;
        private int x, y;
        private static List<Notify> activeNotifications = new List<Notify>();

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Error,
            Warning,
            Information
        }

        public Notify()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Notify_Load(object sender, EventArgs e)
        {
            panel1.Width = 0;
            FillPanelAsync(370);
            int padding = 5;
            int horizontalOffset = 1570;
            int verticalOffset = 5;
            int numberOfNotifications = activeNotifications.Count;

            this.Top = verticalOffset + (this.Height + padding) * numberOfNotifications;
            this.Left = -this.Width;
            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - horizontalOffset;
            this.y = this.Top;

            activeNotifications.Add(this);
        }

        private async void FillPanelAsync(int targetWidth)
        {
            int step = 5;
            while (panel1.Width < targetWidth)
            {
                panel1.Width += step;
                if (panel1.Width > targetWidth)
                {
                    panel1.Width = targetWidth;
                }
                await Task.Delay(20);
            }
        }

        private async void timershow_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    await Task.Delay(2000);
                    action = enmAction.close;
                    break;

                case Notify.enmAction.start:
                    this.timershow.Interval = 10;
                    this.Opacity += 0.05;

                    if (this.Left < this.x)
                    {
                        this.Left += 10;
                    }
                    else
                    {
                        if (this.Opacity >= 1.0)
                        {
                            action = Notify.enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timershow.Interval = 10;
                    this.Opacity -= 0.05;
                    this.Left -= 10;
                    if (this.Opacity <= 0.0)
                    {
                        activeNotifications.Remove(this);

                        await UpdatePos();
                        base.Close();
                    }
                    break;
            }
        }

        private async Task UpdatePos()
        {
            int padding = 5;
            int verticalOffset = 5;

            for (int i = 0; i < activeNotifications.Count; i++)
            {
                Notify notify = activeNotifications[i];
                int targetTop = verticalOffset + (notify.Height + padding) * i;

                while (notify.Top > targetTop)
                {
                    notify.Top -= 5;
                    await Task.Delay(10);
                }

                notify.Top = targetTop;
                notify.y = notify.Top;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notify frm = (Notify)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    int padding = 5;
                    int horizontalOffset = 1570;
                    int verticalOffset = 10;

                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - horizontalOffset;
                    this.y = verticalOffset + (this.Height + padding) * (i - 1);
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.notificationtill.Text = "Success";
                    this.notificationmessage.Text = msg;
                    this.notificationicon.Image = Properties.Resources.Success;
                    break;
                case enmType.Error:
                    this.notificationtill.Text = "Error";
                    this.notificationmessage.Text = msg;
                    this.notificationicon.Image = Properties.Resources.Error;
                    break;
                case enmType.Warning:
                    this.notificationtill.Text = "Warning";
                    this.notificationmessage.Text = msg;
                    this.notificationicon.Image = Properties.Resources.Warning;
                    break;
                case enmType.Information:
                    this.notificationtill.Text = "Information";
                    this.notificationmessage.Text = msg;
                    this.notificationicon.Image = Properties.Resources.Bell;
                    break;
            }

            this.Show();
            this.action = enmAction.start;
            this.timershow.Interval = 15;
            this.timershow.Start();
        }
    }
}
