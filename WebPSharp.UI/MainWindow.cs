using System.Drawing.Drawing2D;

namespace WebPSharp.UI
{
    public partial class MainWindow : Form
    {
        #region "WndProc Constants"
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        #endregion 
        public MainWindow()
        {
            InitializeComponent();
            SetupForm();
          
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
           // this.Size = new Size(450, 300);
            this.Padding = new Padding(0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            notificationBox1.NotificationType = ReaLTaiizor.Controls.NotificationBox.Type.Warning;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
          
           base.OnPaint(e);
           MakeTheWindowCornersRound();
           FillFormBackColour(e);
        }

        private void spaceButton1_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void MakeTheWindowCornersRound()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }
        private void FillFormBackColour(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                     this.ClientRectangle,
                        Color.FromArgb(45, 45, 48),  // dark grey
                        Color.FromArgb(28, 28, 28),  // almost black
                     LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        protected override void WndProc(ref Message m)
        {
        
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);


                // If the mouse is in the "content" area
                if ((int)m.Result == HTCLIENT)
                {
                    // Pretend it’s on the title bar , so user can drag the window
                    m.Result = (IntPtr)HTCAPTION;
                }
                return;
            }
            base.WndProc(ref m);
        }
    }
}
