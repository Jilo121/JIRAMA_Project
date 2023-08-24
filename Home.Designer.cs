namespace JIRAMA
{
    partial class Home
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
            header = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            minimizebtn = new Button();
            closebtn = new Button();
            logoBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listeEmpBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel2 = new Panel();
            pointagePanel = new Panel();
            listView1 = new ListView();
            affNom = new Label();
            searchMatr = new Button();
            label2 = new Label();
            matricul_input = new TextBox();
            header.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pointagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(label1);
            header.Controls.Add(panel1);
            header.Controls.Add(logoBox);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Padding = new Padding(20, 5, 5, 5);
            header.Size = new Size(1400, 55);
            header.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(59, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 2;
            label1.Text = "JIRAMA";
            // 
            // panel1
            // 
            panel1.Controls.Add(minimizebtn);
            panel1.Controls.Add(closebtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1181, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 45);
            panel1.TabIndex = 1;
            // 
            // minimizebtn
            // 
            minimizebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            minimizebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            minimizebtn.FlatStyle = FlatStyle.Flat;
            minimizebtn.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            minimizebtn.ForeColor = Color.Teal;
            minimizebtn.Location = new Point(102, 0);
            minimizebtn.Name = "minimizebtn";
            minimizebtn.Size = new Size(49, 42);
            minimizebtn.TabIndex = 1;
            minimizebtn.Text = "-";
            minimizebtn.UseVisualStyleBackColor = true;
            minimizebtn.Click += minimizebtn_Click;
            // 
            // closebtn
            // 
            closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            closebtn.ForeColor = Color.Red;
            closebtn.Location = new Point(157, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(49, 42);
            closebtn.TabIndex = 0;
            closebtn.Text = "🗙";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.logo_jirama;
            logoBox.Location = new Point(3, 3);
            logoBox.Margin = new Padding(20, 3, 3, 3);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(50, 50);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(listeEmpBtn);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(257, 695);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // listeEmpBtn
            // 
            listeEmpBtn.BackColor = Color.DimGray;
            listeEmpBtn.FlatAppearance.BorderSize = 0;
            listeEmpBtn.FlatStyle = FlatStyle.Flat;
            listeEmpBtn.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listeEmpBtn.ForeColor = SystemColors.ButtonHighlight;
            listeEmpBtn.Image = Properties.Resources.logo_jirama;
            listeEmpBtn.Location = new Point(8, 23);
            listeEmpBtn.Name = "listeEmpBtn";
            listeEmpBtn.Size = new Size(245, 49);
            listeEmpBtn.TabIndex = 0;
            listeEmpBtn.Text = "POINTAGE";
            listeEmpBtn.TextAlign = ContentAlignment.MiddleLeft;
            listeEmpBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(8, 78);
            button1.Name = "button1";
            button1.Size = new Size(200, 49);
            button1.TabIndex = 1;
            button1.Text = "Pointage";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(8, 133);
            button2.Name = "button2";
            button2.Size = new Size(200, 49);
            button2.TabIndex = 2;
            button2.Text = "Heure Suplémentaire";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(8, 188);
            button3.Name = "button3";
            button3.Size = new Size(200, 49);
            button3.TabIndex = 3;
            button3.Text = "Afficher Présence";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.logo_jirama;
            button4.Location = new Point(8, 243);
            button4.Name = "button4";
            button4.Size = new Size(245, 49);
            button4.TabIndex = 4;
            button4.Text = "FACTURE";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(8, 298);
            button5.Name = "button5";
            button5.Size = new Size(200, 49);
            button5.TabIndex = 5;
            button5.Text = "Répartition Facture";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(8, 353);
            button6.Name = "button6";
            button6.Size = new Size(200, 49);
            button6.TabIndex = 6;
            button6.Text = "Zone de répartition";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.logo_jirama;
            button7.Location = new Point(8, 408);
            button7.Name = "button7";
            button7.Size = new Size(245, 49);
            button7.TabIndex = 7;
            button7.Text = "PARAMETRE";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Location = new Point(260, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 2;
            // 
            // pointagePanel
            // 
            pointagePanel.Controls.Add(listView1);
            pointagePanel.Controls.Add(affNom);
            pointagePanel.Controls.Add(searchMatr);
            pointagePanel.Controls.Add(label2);
            pointagePanel.Controls.Add(matricul_input);
            pointagePanel.Location = new Point(263, 61);
            pointagePanel.Name = "pointagePanel";
            pointagePanel.Size = new Size(1132, 689);
            pointagePanel.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ScrollBar;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(24, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(1100, 597);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // affNom
            // 
            affNom.AutoSize = true;
            affNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            affNom.ForeColor = SystemColors.ButtonHighlight;
            affNom.Location = new Point(407, 32);
            affNom.Name = "affNom";
            affNom.Size = new Size(100, 21);
            affNom.TabIndex = 3;
            affNom.Text = "Afficher nom";
            affNom.Click += affNom_Click;
            // 
            // searchMatr
            // 
            searchMatr.Cursor = Cursors.Hand;
            searchMatr.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            searchMatr.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 33, 30);
            searchMatr.FlatStyle = FlatStyle.Flat;
            searchMatr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchMatr.ForeColor = Color.DarkCyan;
            searchMatr.Location = new Point(284, 26);
            searchMatr.Name = "searchMatr";
            searchMatr.Size = new Size(108, 33);
            searchMatr.TabIndex = 2;
            searchMatr.Text = "Chercher";
            searchMatr.UseVisualStyleBackColor = true;
            searchMatr.Click += searchMatr_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 27);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 1;
            label2.Text = "Matricule :";
            // 
            // matricul_input
            // 
            matricul_input.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            matricul_input.Location = new Point(143, 25);
            matricul_input.MaxLength = 6;
            matricul_input.Name = "matricul_input";
            matricul_input.Size = new Size(135, 33);
            matricul_input.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1400, 750);
            Controls.Add(pointagePanel);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            header.ResumeLayout(false);
            header.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pointagePanel.ResumeLayout(false);
            pointagePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button listeEmpBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox logoBox;
        private Button button7;
        private Panel panel1;
        private Button closebtn;
        private Button minimizebtn;
        private Label label1;
        private Panel panel2;
        private Panel pointagePanel;
        private TextBox matricul_input;
        private Label label2;
        private Button searchMatr;
        private Label affNom;
        private ListView listView1;
    }
}