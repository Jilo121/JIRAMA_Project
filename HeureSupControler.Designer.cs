namespace JIRAMA
{
    partial class HeureSupControler
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            affNom = new Label();
            searchMatr = new Button();
            label2 = new Label();
            matricul_input = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            addBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // affNom
            // 
            affNom.AutoSize = true;
            affNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            affNom.ForeColor = SystemColors.ButtonHighlight;
            affNom.Location = new Point(360, 17);
            affNom.Name = "affNom";
            affNom.Size = new Size(100, 21);
            affNom.TabIndex = 7;
            affNom.Text = "Afficher nom";
            // 
            // searchMatr
            // 
            searchMatr.Cursor = Cursors.Hand;
            searchMatr.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            searchMatr.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 33, 30);
            searchMatr.FlatStyle = FlatStyle.Flat;
            searchMatr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchMatr.ForeColor = Color.DarkCyan;
            searchMatr.Location = new Point(246, 12);
            searchMatr.Name = "searchMatr";
            searchMatr.Size = new Size(108, 33);
            searchMatr.TabIndex = 6;
            searchMatr.Text = "Chercher";
            searchMatr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(7, 18);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 5;
            label2.Text = "Matricule :";
            // 
            // matricul_input
            // 
            matricul_input.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            matricul_input.Location = new Point(105, 11);
            matricul_input.MaxLength = 6;
            matricul_input.Name = "matricul_input";
            matricul_input.Size = new Size(135, 33);
            matricul_input.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(affNom);
            panel1.Controls.Add(searchMatr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(matricul_input);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 55);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(1129, 627);
            panel3.TabIndex = 11;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 33, 30);
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkCyan;
            addBtn.Location = new Point(3, 11);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(108, 33);
            addBtn.TabIndex = 7;
            addBtn.Text = "Ajouter";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 33, 30);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(117, 11);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 8;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 33, 30);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkCyan;
            button3.Location = new Point(231, 11);
            button3.Name = "button3";
            button3.Size = new Size(108, 33);
            button3.TabIndex = 9;
            button3.Text = "Chercher";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(addBtn);
            panel2.Location = new Point(708, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 55);
            panel2.TabIndex = 9;
            // 
            // HeureSupControler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HeureSupControler";
            Size = new Size(1132, 689);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label affNom;
        private Button searchMatr;
        private Label label2;
        private TextBox matricul_input;
        private Panel panel1;
        private Panel panel3;
        private Button addBtn;
        private Button button2;
        private Button button3;
        private Panel panel2;
    }
}
