namespace JIRAMA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            emailLogin = new TextBox();
            pswLogin = new TextBox();
            loginbtn = new Button();
            pictureBox1 = new PictureBox();
            loginpanel = new Panel();
            button1 = new Button();
            reduce = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            loginpanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(50, 361);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(50, 409);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1; 
            label2.Text = "Mot de passe";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLogin
            // 
            emailLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLogin.Location = new Point(173, 358);
            emailLogin.Name = "emailLogin";
            emailLogin.Size = new Size(182, 29);
            emailLogin.TabIndex = 2;
            // 
            // pswLogin
            // 
            pswLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pswLogin.Location = new Point(173, 406);
            pswLogin.Name = "pswLogin";
            pswLogin.Size = new Size(182, 29);
            pswLogin.TabIndex = 3;
            pswLogin.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.Location = new Point(45, 450);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(310, 36);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Se connecter";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_jirama;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(45, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // loginpanel
            // 
            loginpanel.AutoSize = true;
            loginpanel.BackColor = Color.FromArgb(39, 65, 97);
            loginpanel.BorderStyle = BorderStyle.FixedSingle;
            loginpanel.Controls.Add(pictureBox1);
            loginpanel.Controls.Add(loginbtn);
            loginpanel.Controls.Add(emailLogin);
            loginpanel.Controls.Add(pswLogin);
            loginpanel.Controls.Add(label1);
            loginpanel.Controls.Add(label2);
            loginpanel.Location = new Point(400, 50);
            loginpanel.Name = "loginpanel";
            loginpanel.Padding = new Padding(10);
            loginpanel.Size = new Size(400, 501);
            loginpanel.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 105, 105);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 77, 77);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1147, -1);
            button1.Name = "button1";
            button1.Size = new Size(50, 30);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // reduce
            // 
            reduce.BackColor = Color.FromArgb(128, 128, 255);
            reduce.FlatAppearance.BorderSize = 0;
            reduce.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            reduce.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            reduce.FlatStyle = FlatStyle.Flat;
            reduce.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reduce.Location = new Point(1091, 0);
            reduce.Name = "reduce";
            reduce.Size = new Size(50, 30);
            reduce.TabIndex = 8;
            reduce.Text = "_";
            reduce.UseVisualStyleBackColor = false;
            reduce.Click += reduce_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.pngtree_dark_waves_water_pattern_blue_background_picture_image_1345564;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 600);
            Controls.Add(reduce);
            Controls.Add(button1);
            Controls.Add(loginpanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 600);
            MinimumSize = new Size(1200, 600);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "JIRAMA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailLogin;
        private TextBox pswLogin;
        private Button loginbtn;
        private PictureBox pictureBox1;
        private Panel loginpanel;
        private Button button1;
        private Button reduce;
    }
}