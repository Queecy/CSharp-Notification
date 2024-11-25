namespace Notification
{
    partial class Notify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notify));
            this.FormBorderLess = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.timershow = new System.Windows.Forms.Timer(this.components);
            this.notificationicon = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.panel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.notificationmessage = new System.Windows.Forms.Label();
            this.notificationtill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormBorderLess
            // 
            this.FormBorderLess.AnimationInterval = 700;
            this.FormBorderLess.BorderRadius = 15;
            this.FormBorderLess.ContainerControl = this;
            this.FormBorderLess.DockForm = false;
            this.FormBorderLess.DockIndicatorTransparencyValue = 0.5D;
            this.FormBorderLess.DragForm = false;
            this.FormBorderLess.HasFormShadow = false;
            this.FormBorderLess.ResizeForm = false;
            this.FormBorderLess.ShadowColor = System.Drawing.Color.White;
            this.FormBorderLess.TransparentWhileDrag = true;
            // 
            // timershow
            // 
            this.timershow.Tick += new System.EventHandler(this.timershow_Tick);
            // 
            // notificationicon
            // 
            this.notificationicon.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.notificationicon.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.notificationicon.Image = ((System.Drawing.Image)(resources.GetObject("notificationicon.Image")));
            this.notificationicon.ImageOffset = new System.Drawing.Point(0, 0);
            this.notificationicon.ImageRotate = 0F;
            this.notificationicon.ImageSize = new System.Drawing.Size(30, 30);
            this.notificationicon.Location = new System.Drawing.Point(2, 10);
            this.notificationicon.Name = "notificationicon";
            this.notificationicon.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.notificationicon.Size = new System.Drawing.Size(54, 39);
            this.notificationicon.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(-20, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 100);
            this.panel1.TabIndex = 71;
            // 
            // notificationmessage
            // 
            this.notificationmessage.AutoSize = true;
            this.notificationmessage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.notificationmessage.ForeColor = System.Drawing.Color.Gray;
            this.notificationmessage.Location = new System.Drawing.Point(53, 31);
            this.notificationmessage.Name = "notificationmessage";
            this.notificationmessage.Size = new System.Drawing.Size(56, 14);
            this.notificationmessage.TabIndex = 70;
            this.notificationmessage.Text = "Message";
            // 
            // notificationtill
            // 
            this.notificationtill.AutoSize = true;
            this.notificationtill.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.notificationtill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notificationtill.Location = new System.Drawing.Point(52, 11);
            this.notificationtill.Name = "notificationtill";
            this.notificationtill.Size = new System.Drawing.Size(85, 19);
            this.notificationtill.TabIndex = 69;
            this.notificationtill.Text = "Notification";
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(338, 62);
            this.Controls.Add(this.notificationicon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notificationmessage);
            this.Controls.Add(this.notificationtill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notify";
            this.Load += new System.EventHandler(this.Notify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm FormBorderLess;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton notificationicon;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel panel1;
        private System.Windows.Forms.Label notificationmessage;
        private System.Windows.Forms.Label notificationtill;
        internal System.Windows.Forms.Timer timershow;
    }
}