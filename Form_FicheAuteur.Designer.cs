namespace AdoTpFedi
{
    partial class Form_FicheAuteur
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
            label_num = new Label();
            label_nom = new Label();
            label_prenom = new Label();
            label_natio = new Label();
            textBox_num = new TextBox();
            textBox_nom = new TextBox();
            textBox_prenom = new TextBox();
            textBox_natio = new TextBox();
            button_annuler = new Button();
            button_valider = new Button();
            SuspendLayout();
            // 
            // label_num
            // 
            label_num.AutoSize = true;
            label_num.Location = new Point(44, 48);
            label_num.Name = "label_num";
            label_num.Size = new Size(51, 15);
            label_num.TabIndex = 0;
            label_num.Text = "Numéro";
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(44, 92);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(34, 15);
            label_nom.TabIndex = 1;
            label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            label_prenom.AutoSize = true;
            label_prenom.Location = new Point(44, 138);
            label_prenom.Name = "label_prenom";
            label_prenom.Size = new Size(49, 15);
            label_prenom.TabIndex = 2;
            label_prenom.Text = "Prénom";
            // 
            // label_natio
            // 
            label_natio.AutoSize = true;
            label_natio.Location = new Point(44, 182);
            label_natio.Name = "label_natio";
            label_natio.Size = new Size(65, 15);
            label_natio.TabIndex = 3;
            label_natio.Text = "Nationalité";
            // 
            // textBox_num
            // 
            textBox_num.Enabled = false;
            textBox_num.Location = new Point(147, 40);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(100, 23);
            textBox_num.TabIndex = 4;
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(147, 89);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(100, 23);
            textBox_nom.TabIndex = 5;
            // 
            // textBox_prenom
            // 
            textBox_prenom.Location = new Point(147, 135);
            textBox_prenom.Name = "textBox_prenom";
            textBox_prenom.Size = new Size(100, 23);
            textBox_prenom.TabIndex = 6;
            // 
            // textBox_natio
            // 
            textBox_natio.Location = new Point(147, 179);
            textBox_natio.Name = "textBox_natio";
            textBox_natio.Size = new Size(100, 23);
            textBox_natio.TabIndex = 7;
            // 
            // button_annuler
            // 
            button_annuler.Location = new Point(44, 245);
            button_annuler.Name = "button_annuler";
            button_annuler.Size = new Size(75, 23);
            button_annuler.TabIndex = 8;
            button_annuler.Text = "Annuler";
            button_annuler.UseVisualStyleBackColor = true;
            button_annuler.Click += button_annuler_Click;
            // 
            // button_valider
            // 
            button_valider.Location = new Point(186, 245);
            button_valider.Name = "button_valider";
            button_valider.Size = new Size(75, 23);
            button_valider.TabIndex = 9;
            button_valider.Text = "Valider";
            button_valider.UseVisualStyleBackColor = true;
            button_valider.Click += button_valider_Click;
            // 
            // Form_FicheAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 322);
            Controls.Add(button_valider);
            Controls.Add(button_annuler);
            Controls.Add(textBox_natio);
            Controls.Add(textBox_prenom);
            Controls.Add(textBox_nom);
            Controls.Add(textBox_num);
            Controls.Add(label_natio);
            Controls.Add(label_prenom);
            Controls.Add(label_nom);
            Controls.Add(label_num);
            Name = "Form_FicheAuteur";
            Text = "Fiche auteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_num;
        private Label label_nom;
        private Label label_prenom;
        private Label label_natio;
        private TextBox textBox_num;
        private TextBox textBox_nom;
        private TextBox textBox_prenom;
        private TextBox textBox_natio;
        private Button button_annuler;
        private Button button_valider;
    }
}