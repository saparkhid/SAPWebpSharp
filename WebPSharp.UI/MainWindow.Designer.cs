namespace WebPSharp.UI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new ReaLTaiizor.Controls.TextBoxEdit();
            label1 = new Label();
            btnInput = new ReaLTaiizor.Controls.DreamButton();
            thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            pictureBoxPreview = new PictureBox();
            label2 = new Label();
            txtOutput = new ReaLTaiizor.Controls.TextBoxEdit();
            btnOutput = new ReaLTaiizor.Controls.DreamButton();
            btnConvert = new ReaLTaiizor.Controls.Button();
            label3 = new Label();
            label4 = new Label();
            notificationBox1 = new ReaLTaiizor.Controls.NotificationBox();
            btnOpenOutputFolder = new ReaLTaiizor.Controls.AirButton();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            spaceButton1 = new ReaLTaiizor.Controls.SpaceButton();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            thunderGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.Transparent;
            txtInput.Font = new Font("Tahoma", 11F);
            txtInput.ForeColor = Color.FromArgb(176, 183, 191);
            txtInput.Image = null;
            txtInput.Location = new Point(14, 80);
            txtInput.MaxLength = 32767;
            txtInput.Multiline = false;
            txtInput.Name = "txtInput";
            txtInput.ReadOnly = false;
            txtInput.Size = new Size(277, 41);
            txtInput.TabIndex = 9;
            txtInput.TextAlignment = HorizontalAlignment.Left;
            txtInput.UseSystemPasswordChar = false;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 10;
            label1.Text = "Input Image";
            // 
            // btnInput
            // 
            btnInput.ColorA = Color.FromArgb(31, 31, 31);
            btnInput.ColorB = Color.FromArgb(41, 41, 41);
            btnInput.ColorC = Color.FromArgb(51, 51, 51);
            btnInput.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnInput.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnInput.ForeColor = Color.FromArgb(40, 218, 255);
            btnInput.Location = new Point(297, 80);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(141, 40);
            btnInput.TabIndex = 12;
            btnInput.Text = "Pick";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // thunderGroupBox1
            // 
            thunderGroupBox1.BackColor = Color.Transparent;
            thunderGroupBox1.BodyColorA = Color.FromArgb(26, 26, 26);
            thunderGroupBox1.BodyColorB = Color.FromArgb(30, 30, 30);
            thunderGroupBox1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderGroupBox1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderGroupBox1.Controls.Add(pictureBoxPreview);
            thunderGroupBox1.ForeColor = Color.WhiteSmoke;
            thunderGroupBox1.Location = new Point(444, 80);
            thunderGroupBox1.Name = "thunderGroupBox1";
            thunderGroupBox1.Size = new Size(141, 136);
            thunderGroupBox1.TabIndex = 13;
            thunderGroupBox1.Text = "Preview";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(8, 31);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(126, 95);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 141);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 14;
            label2.Text = "Output Image";
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.Transparent;
            txtOutput.Font = new Font("Tahoma", 11F);
            txtOutput.ForeColor = Color.FromArgb(176, 183, 191);
            txtOutput.Image = null;
            txtOutput.Location = new Point(14, 175);
            txtOutput.MaxLength = 32767;
            txtOutput.Multiline = false;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = false;
            txtOutput.Size = new Size(277, 41);
            txtOutput.TabIndex = 15;
            txtOutput.TextAlignment = HorizontalAlignment.Left;
            txtOutput.UseSystemPasswordChar = false;
            txtOutput.TextChanged += this.txtOutput_TextChanged;
            // 
            // btnOutput
            // 
            btnOutput.ColorA = Color.FromArgb(31, 31, 31);
            btnOutput.ColorB = Color.FromArgb(41, 41, 41);
            btnOutput.ColorC = Color.FromArgb(51, 51, 51);
            btnOutput.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnOutput.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnOutput.ForeColor = Color.FromArgb(40, 218, 255);
            btnOutput.Location = new Point(297, 176);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(141, 40);
            btnOutput.TabIndex = 16;
            btnOutput.Text = "Pick";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.Transparent;
            btnConvert.BorderColor = Color.White;
            btnConvert.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnConvert.EnteredColor = Color.FromArgb(32, 34, 37);
            btnConvert.Font = new Font("Microsoft Sans Serif", 12F);
            btnConvert.Image = null;
            btnConvert.ImageAlign = ContentAlignment.MiddleLeft;
            btnConvert.InactiveColor = Color.FromArgb(32, 34, 37);
            btnConvert.Location = new Point(14, 242);
            btnConvert.Name = "btnConvert";
            btnConvert.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnConvert.PressedColor = Color.FromArgb(165, 37, 37);
            btnConvert.Size = new Size(571, 40);
            btnConvert.TabIndex = 17;
            btnConvert.Text = "Convert";
            btnConvert.TextAlignment = StringAlignment.Center;
            btnConvert.Click += btnConvert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 311);
            label3.Name = "label3";
            label3.Size = new Size(261, 21);
            label3.TabIndex = 18;
            label3.Text = "Developed by Seyed Ahmad Parkhid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 338);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 19;
            label4.Text = "https://www.cafebit.ir";
            // 
            // notificationBox1
            // 
            notificationBox1.BorderCurve = 8;
            notificationBox1.CloseForeColor = Color.Black;
            notificationBox1.ErrorBackColor = Color.Crimson;
            notificationBox1.ErrorBorderColor = Color.Crimson;
            notificationBox1.ErrorForeColor = Color.White;
            notificationBox1.ErrorTitleText = "ERROR";
            notificationBox1.Font = new Font("Tahoma", 9F);
            notificationBox1.Image = null;
            notificationBox1.Location = new Point(185, 135);
            notificationBox1.MinimumSize = new Size(100, 40);
            notificationBox1.Name = "notificationBox1";
            notificationBox1.NoticeBackColor = Color.Gray;
            notificationBox1.NoticeBorderColor = Color.Gray;
            notificationBox1.NoticeForeColor = Color.White;
            notificationBox1.NoticeTitleText = "NOTICE";
            notificationBox1.NotificationType = ReaLTaiizor.Controls.NotificationBox.Type.Notice;
            notificationBox1.RoundCorners = true;
            notificationBox1.ShowCloseButton = true;
            notificationBox1.Size = new Size(232, 123);
            notificationBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            notificationBox1.SuccessBackColor = Color.SeaGreen;
            notificationBox1.SuccessBorderColor = Color.SeaGreen;
            notificationBox1.SuccessForeColor = Color.White;
            notificationBox1.SuccessTitleText = "SUCCESS";
            notificationBox1.TabIndex = 20;
            notificationBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            notificationBox1.WarningBackColor = Color.FromArgb(255, 128, 0);
            notificationBox1.WarningBorderColor = Color.FromArgb(255, 128, 0);
            notificationBox1.WarningForeColor = Color.White;
            notificationBox1.WarningTitleText = "WARNING";
            // 
            // btnOpenOutputFolder
            // 
            btnOpenOutputFolder.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnOpenOutputFolder.Font = new Font("Segoe UI", 9F);
            btnOpenOutputFolder.Image = null;
            btnOpenOutputFolder.Location = new Point(236, 201);
            btnOpenOutputFolder.Name = "btnOpenOutputFolder";
            btnOpenOutputFolder.NoRounding = false;
            btnOpenOutputFolder.Size = new Size(139, 24);
            btnOpenOutputFolder.TabIndex = 22;
            btnOpenOutputFolder.Text = "Open Output Folder";
            btnOpenOutputFolder.Transparent = false;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel1.Location = new Point(216, 9);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(167, 18);
            headerLabel1.TabIndex = 23;
            headerLabel1.Text = "SAP WebP Sharp 1.0";
            // 
            // spaceButton1
            // 
            spaceButton1.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            spaceButton1.Font = new Font("Verdana", 8F);
            spaceButton1.Image = null;
            spaceButton1.Location = new Point(555, 9);
            spaceButton1.Name = "spaceButton1";
            spaceButton1.NoRounding = false;
            spaceButton1.Size = new Size(30, 30);
            spaceButton1.TabIndex = 24;
            spaceButton1.Text = "X";
            spaceButton1.TextAlignment = HorizontalAlignment.Center;
            spaceButton1.Transparent = false;
            spaceButton1.Click += spaceButton1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(597, 378);
            Controls.Add(spaceButton1);
            Controls.Add(headerLabel1);
            Controls.Add(btnOpenOutputFolder);
            Controls.Add(notificationBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnConvert);
            Controls.Add(btnOutput);
            Controls.Add(txtOutput);
            Controls.Add(label2);
            Controls.Add(thunderGroupBox1);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(btnInput);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(126, 50);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTheme1";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            thunderGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.TextBoxEdit txtInput;
        private Label label1;
        private ReaLTaiizor.Controls.DreamButton btnInput;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private PictureBox pictureBoxPreview;
        private Label label2;
        private ReaLTaiizor.Controls.TextBoxEdit txtOutput;
        private ReaLTaiizor.Controls.DreamButton btnOutput;
        private ReaLTaiizor.Controls.Button btnConvert;
        private Label label3;
        private Label label4;
        private ReaLTaiizor.Controls.NotificationBox notificationBox1;
        private ReaLTaiizor.Controls.AirButton btnOpenOutputFolder;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.SpaceButton spaceButton1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
