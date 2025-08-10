using ReaLTaiizor.Controls;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using System.Diagnostics;
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

        string selectedFileFullPath = "";
        string outputPath = "";
        public MainWindow()
        {
            InitializeComponent();
            HideNotificationBox();
            SetupForm();
            SetupFileDialogs();
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new Padding(0);
        }
        private void SetupFileDialogs()
        {
            openFileDialog1.Filter = "\"Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.tiff;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.tiff;*.gif|All files (*.*)|*.*\";";
            saveFileDialog1.Filter =  "WebP Image (*.webp)|*.webp";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void HideNotificationBox()
        {
            notificationBox1.Hide();
      
            btnOpenOutputFolder.Visible = false;
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
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedFileFullPath))
                {
                    ShowError("You must select a file");
                    return;
                }

                if (!System.IO.File.Exists(selectedFileFullPath))
                {
                    ShowError("You must select a file that exists...");
                    return;
                }
                if (string.IsNullOrEmpty(outputPath))
                {
                    ShowError("You must select an output file");
                    return;
                }
                using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(selectedFileFullPath))
                {
                    var options = new WebpEncoder
                    {
                        Quality = 100,
                        FileFormat = WebpFileFormatType.Lossless
                    };

                    image.Save(outputPath, options);
                }
                btnConvert.Enabled = false;
                btnInput.Enabled = false;
                btnOutput.Enabled = false;
                ShowSuccess("File Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOutput_TextChanged(object sender,EventArgs e)
        {
            outputPath = txtOutput.Text;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            selectedFileFullPath= txtInput.Text;
        }

        private void ShowError(string message)
        {
            var nb = new ReaLTaiizor.Controls.NotificationBox
            {
                Text = message,
                Size = new System.Drawing.Size(200, 70),
                Location = new System.Drawing.Point(185, 135)
            };
    
           
            nb.NotificationType = ReaLTaiizor.Controls.NotificationBox.Type.Error;
            this.Controls.Add(nb);
            nb.BringToFront();
        }

        private void ShowSuccess(string message)
        {
            var nb = new ReaLTaiizor.Controls.NotificationBox
            {
                Text = message,
                Size = new System.Drawing.Size(200, 100),
                Location = new System.Drawing.Point(185, 135)
            };
       
            AirButton openOutputFolder = new AirButton()
            {
                Text = "Open Output Folder",
                Size = new System.Drawing.Size(139, 24),
                Location = new System.Drawing.Point(200, 200)
            };
            openOutputFolder.Click += (s, e) =>
            {
                // your code here
                Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(outputPath));
            };
            nb.Disposed += (s, e) =>
            {
                this.Controls.Remove(openOutputFolder);
                openOutputFolder.Dispose();
                btnConvert.Enabled = true;
                btnInput.Enabled = true;
                btnOutput.Enabled = true;
            };

            nb.NotificationType = ReaLTaiizor.Controls.NotificationBox.Type.Success;
            this.Controls.Add(nb);
            this.Controls.Add(openOutputFolder);
            nb.BringToFront();
            openOutputFolder.BringToFront();

        }

        private void Nb_Disposed(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileFullPath = openFileDialog1.FileName;
                txtInput.Text = selectedFileFullPath;
                // Change extension to .webp
                outputPath = Path.ChangeExtension(selectedFileFullPath, ".webp");
                txtOutput.Text = outputPath;

                pictureBoxPreview.Image = System.Drawing.Image.FromFile(selectedFileFullPath);
            }
         
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            
                outputPath = saveFileDialog1.FileName;
                txtOutput.Text = outputPath;
               
            }

        }
        private void MakeTheWindowCornersRound()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            var rect = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }


        private void FillFormBackColour(PaintEventArgs e)
        {
            var rect = this.ClientRectangle;
            using (var brush = new LinearGradientBrush(
                        rect,
                        System.Drawing.Color.FromArgb(45, 45, 48),  // dark grey
                        System.Drawing.Color.FromArgb(28, 28, 28),  // almost black
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
