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
            point_Ppl_Btn = new Button();
            point_panel = new FlowLayoutPanel();
            point_Btn = new Button();
            heuresup_Btn = new Button();
            affPres_Btn = new Button();
            fact_Btn = new Button();
            fact_panel = new FlowLayoutPanel();
            repartFact_Btn = new Button();
            zonerepart_Btn = new Button();
            doc_Btn = new Button();
            doc_panel = new FlowLayoutPanel();
            docreq_Btn = new Button();
            set_Btn = new Button();
            param_panel = new FlowLayoutPanel();
            paramBtn = new Button();
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
            point_panel.SuspendLayout();
            fact_panel.SuspendLayout();
            doc_panel.SuspendLayout();
            param_panel.SuspendLayout();
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
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(59, 17);
            label1.Name = "label1";
            label1.Size = new Size(106, 36);
            label1.TabIndex = 2;
            label1.Text = "JIRAMA";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(minimizebtn);
            panel1.Controls.Add(closebtn);
            panel1.Location = new Point(1182, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 45);
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
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(point_Ppl_Btn);
            flowLayoutPanel1.Controls.Add(point_panel);
            flowLayoutPanel1.Controls.Add(fact_Btn);
            flowLayoutPanel1.Controls.Add(fact_panel);
            flowLayoutPanel1.Controls.Add(doc_Btn);
            flowLayoutPanel1.Controls.Add(doc_panel);
            flowLayoutPanel1.Controls.Add(set_Btn);
            flowLayoutPanel1.Controls.Add(param_panel);
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(257, 695);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // point_Ppl_Btn
            // 
            point_Ppl_Btn.BackColor = Color.DimGray;
            point_Ppl_Btn.FlatAppearance.BorderSize = 0;
            point_Ppl_Btn.FlatStyle = FlatStyle.Flat;
            point_Ppl_Btn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            point_Ppl_Btn.ForeColor = Color.FromArgb(25, 25, 25);
            point_Ppl_Btn.Image = Properties.Resources.logo_jirama;
            point_Ppl_Btn.Location = new Point(8, 23);
            point_Ppl_Btn.Name = "point_Ppl_Btn";
            point_Ppl_Btn.Size = new Size(245, 49);
            point_Ppl_Btn.TabIndex = 0;
            point_Ppl_Btn.Text = "POINTAGE";
            point_Ppl_Btn.TextAlign = ContentAlignment.MiddleLeft;
            point_Ppl_Btn.UseVisualStyleBackColor = false;
            point_Ppl_Btn.Click += point_Ppl_Btn_Click;
            // 
            // point_panel
            // 
            point_panel.Controls.Add(point_Btn);
            point_panel.Controls.Add(heuresup_Btn);
            point_panel.Controls.Add(affPres_Btn);
            point_panel.Location = new Point(8, 78);
            point_panel.Name = "point_panel";
            point_panel.Size = new Size(240, 165);
            point_panel.TabIndex = 12;
            // 
            // point_Btn
            // 
            point_Btn.BackColor = Color.Gray;
            point_Btn.FlatAppearance.BorderSize = 0;
            point_Btn.FlatStyle = FlatStyle.Flat;
            point_Btn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            point_Btn.ForeColor = SystemColors.ActiveCaptionText;
            point_Btn.Location = new Point(3, 3);
            point_Btn.Name = "point_Btn";
            point_Btn.Size = new Size(200, 49);
            point_Btn.TabIndex = 1;
            point_Btn.Text = "Pointage";
            point_Btn.TextAlign = ContentAlignment.MiddleLeft;
            point_Btn.UseVisualStyleBackColor = false;
            point_Btn.Click += pointagebtn_Click;
            // 
            // heuresup_Btn
            // 
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.FlatAppearance.BorderSize = 0;
            heuresup_Btn.FlatStyle = FlatStyle.Flat;
            heuresup_Btn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            heuresup_Btn.ForeColor = SystemColors.ButtonHighlight;
            heuresup_Btn.Location = new Point(3, 58);
            heuresup_Btn.Name = "heuresup_Btn";
            heuresup_Btn.Size = new Size(200, 49);
            heuresup_Btn.TabIndex = 2;
            heuresup_Btn.Text = "Heure Suplémentaire";
            heuresup_Btn.TextAlign = ContentAlignment.MiddleLeft;
            heuresup_Btn.UseVisualStyleBackColor = false;
            heuresup_Btn.Click += heuresup_click;
            // 
            // affPres_Btn
            // 
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.FlatAppearance.BorderSize = 0;
            affPres_Btn.FlatStyle = FlatStyle.Flat;
            affPres_Btn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            affPres_Btn.ForeColor = SystemColors.ButtonHighlight;
            affPres_Btn.Location = new Point(3, 113);
            affPres_Btn.Name = "affPres_Btn";
            affPres_Btn.Size = new Size(200, 49);
            affPres_Btn.TabIndex = 3;
            affPres_Btn.Text = "Afficher Présence";
            affPres_Btn.TextAlign = ContentAlignment.MiddleLeft;
            affPres_Btn.UseVisualStyleBackColor = false;
            affPres_Btn.Click += affPres_Btn_Click;
            // 
            // fact_Btn
            // 
            fact_Btn.BackColor = Color.DimGray;
            fact_Btn.FlatAppearance.BorderSize = 0;
            fact_Btn.FlatStyle = FlatStyle.Flat;
            fact_Btn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            fact_Btn.ForeColor = Color.FromArgb(25, 25, 25);
            fact_Btn.Image = Properties.Resources.logo_jirama;
            fact_Btn.Location = new Point(8, 249);
            fact_Btn.Name = "fact_Btn";
            fact_Btn.Size = new Size(245, 49);
            fact_Btn.TabIndex = 4;
            fact_Btn.Text = "FACTURE";
            fact_Btn.TextAlign = ContentAlignment.MiddleLeft;
            fact_Btn.UseVisualStyleBackColor = false;
            fact_Btn.Click += fact_Btn_Click;
            // 
            // fact_panel
            // 
            fact_panel.Controls.Add(repartFact_Btn);
            fact_panel.Controls.Add(zonerepart_Btn);
            fact_panel.Location = new Point(8, 304);
            fact_panel.Name = "fact_panel";
            fact_panel.Size = new Size(238, 108);
            fact_panel.TabIndex = 13;
            // 
            // repartFact_Btn
            // 
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.FlatAppearance.BorderSize = 0;
            repartFact_Btn.FlatStyle = FlatStyle.Flat;
            repartFact_Btn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            repartFact_Btn.ForeColor = SystemColors.ButtonHighlight;
            repartFact_Btn.Location = new Point(3, 3);
            repartFact_Btn.Name = "repartFact_Btn";
            repartFact_Btn.Size = new Size(200, 49);
            repartFact_Btn.TabIndex = 5;
            repartFact_Btn.Text = "Répartition Facture";
            repartFact_Btn.TextAlign = ContentAlignment.MiddleLeft;
            repartFact_Btn.UseVisualStyleBackColor = false;
            repartFact_Btn.Click += repartFact_Btn_Click;
            // 
            // zonerepart_Btn
            // 
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.FlatAppearance.BorderSize = 0;
            zonerepart_Btn.FlatStyle = FlatStyle.Flat;
            zonerepart_Btn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zonerepart_Btn.ForeColor = SystemColors.ButtonHighlight;
            zonerepart_Btn.Location = new Point(3, 58);
            zonerepart_Btn.Name = "zonerepart_Btn";
            zonerepart_Btn.Size = new Size(200, 49);
            zonerepart_Btn.TabIndex = 6;
            zonerepart_Btn.Text = "Zone de répartition";
            zonerepart_Btn.TextAlign = ContentAlignment.MiddleLeft;
            zonerepart_Btn.UseVisualStyleBackColor = false;
            zonerepart_Btn.Click += zonerepart_Btn_Click;
            // 
            // doc_Btn
            // 
            doc_Btn.BackColor = Color.DimGray;
            doc_Btn.FlatAppearance.BorderSize = 0;
            doc_Btn.FlatStyle = FlatStyle.Flat;
            doc_Btn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            doc_Btn.ForeColor = Color.FromArgb(25, 25, 25);
            doc_Btn.Image = Properties.Resources.logo_jirama;
            doc_Btn.Location = new Point(8, 418);
            doc_Btn.Name = "doc_Btn";
            doc_Btn.Size = new Size(245, 49);
            doc_Btn.TabIndex = 7;
            doc_Btn.Text = "DOCUMENTATION";
            doc_Btn.TextAlign = ContentAlignment.MiddleLeft;
            doc_Btn.UseVisualStyleBackColor = false;
            doc_Btn.Click += doc_Btn_Click;
            // 
            // doc_panel
            // 
            doc_panel.Controls.Add(docreq_Btn);
            doc_panel.Location = new Point(8, 473);
            doc_panel.Name = "doc_panel";
            doc_panel.Size = new Size(243, 59);
            doc_panel.TabIndex = 15;
            // 
            // docreq_Btn
            // 
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.FlatAppearance.BorderSize = 0;
            docreq_Btn.FlatStyle = FlatStyle.Flat;
            docreq_Btn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            docreq_Btn.ForeColor = SystemColors.ButtonHighlight;
            docreq_Btn.Location = new Point(3, 3);
            docreq_Btn.Name = "docreq_Btn";
            docreq_Btn.Size = new Size(200, 49);
            docreq_Btn.TabIndex = 8;
            docreq_Btn.Text = "Doccuments requis";
            docreq_Btn.TextAlign = ContentAlignment.MiddleLeft;
            docreq_Btn.UseVisualStyleBackColor = false;
            docreq_Btn.Click += docreq_Btn_Click;
            // 
            // set_Btn
            // 
            set_Btn.BackColor = Color.DimGray;
            set_Btn.FlatAppearance.BorderSize = 0;
            set_Btn.FlatStyle = FlatStyle.Flat;
            set_Btn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            set_Btn.ForeColor = Color.FromArgb(25, 25, 25);
            set_Btn.Image = Properties.Resources.logo_jirama;
            set_Btn.Location = new Point(8, 538);
            set_Btn.Name = "set_Btn";
            set_Btn.Size = new Size(245, 49);
            set_Btn.TabIndex = 10;
            set_Btn.Text = "PARAMETRE";
            set_Btn.TextAlign = ContentAlignment.MiddleLeft;
            set_Btn.UseVisualStyleBackColor = false;
            set_Btn.Click += set_Btn_Click;
            // 
            // param_panel
            // 
            param_panel.Controls.Add(paramBtn);
            param_panel.Location = new Point(8, 593);
            param_panel.Name = "param_panel";
            param_panel.Size = new Size(245, 59);
            param_panel.TabIndex = 16;
            // 
            // paramBtn
            // 
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.FlatAppearance.BorderSize = 0;
            paramBtn.FlatStyle = FlatStyle.Flat;
            paramBtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            paramBtn.ForeColor = SystemColors.ButtonHighlight;
            paramBtn.Location = new Point(3, 3);
            paramBtn.Name = "paramBtn";
            paramBtn.Size = new Size(200, 49);
            paramBtn.TabIndex = 11;
            paramBtn.Text = "Paramètre";
            paramBtn.TextAlign = ContentAlignment.MiddleLeft;
            paramBtn.UseVisualStyleBackColor = false;
            paramBtn.Click += paramBtn_Click;
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
            pointagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            listView1.Location = new Point(0, 72);
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
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(45, 35);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
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
            point_panel.ResumeLayout(false);
            fact_panel.ResumeLayout(false);
            doc_panel.ResumeLayout(false);
            param_panel.ResumeLayout(false);
            pointagePanel.ResumeLayout(false);
            pointagePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button point_Ppl_Btn;
        private Button point_Btn;
        private Button heuresup_Btn;
        private Button affPres_Btn;
        private Button fact_Btn;
        private Button repartFact_Btn;
        private Button zonerepart_Btn;
        private PictureBox logoBox;
        private Button doc_Btn;
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
        private Button docreq_Btn;
        private Button set_Btn;
        private Button paramBtn;
        private FlowLayoutPanel point_panel;
        private FlowLayoutPanel fact_panel;
        private FlowLayoutPanel doc_panel;
        private FlowLayoutPanel param_panel;
    }
}