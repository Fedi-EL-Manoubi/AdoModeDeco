namespace AdoTpFedi
{
    partial class Form_ListeAuteur
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
            components = new System.ComponentModel.Container();
            dgv_ListeAuteur = new DataGridView();
            Num = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Prenom = new DataGridViewTextBoxColumn();
            Nation = new DataGridViewTextBoxColumn();
            btn_Afficher = new Button();
            btn_Modifier = new Button();
            btn_Supp = new Button();
            btn_nouveau = new Button();
            bs = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAuteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs).BeginInit();
            SuspendLayout();
            // 
            // dgv_ListeAuteur
            // 
            dgv_ListeAuteur.AllowUserToAddRows = false;
            dgv_ListeAuteur.AllowUserToDeleteRows = false;
            dgv_ListeAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListeAuteur.Columns.AddRange(new DataGridViewColumn[] { Num, Nom, Prenom, Nation });
            dgv_ListeAuteur.Location = new Point(12, 12);
            dgv_ListeAuteur.MultiSelect = false;
            dgv_ListeAuteur.Name = "dgv_ListeAuteur";
            dgv_ListeAuteur.ReadOnly = true;
            dgv_ListeAuteur.RowTemplate.Height = 25;
            dgv_ListeAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ListeAuteur.Size = new Size(545, 438);
            dgv_ListeAuteur.TabIndex = 0;
            dgv_ListeAuteur.CellContentClick += dgv_ListeAuteur_CellContentClick;
            // 
            // Num
            // 
            Num.HeaderText = "Numéro";
            Num.Name = "Num";
            Num.ReadOnly = true;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 200;
            // 
            // Prenom
            // 
            Prenom.HeaderText = "Prénom";
            Prenom.Name = "Prenom";
            Prenom.ReadOnly = true;
            // 
            // Nation
            // 
            Nation.HeaderText = "Nationalité";
            Nation.Name = "Nation";
            Nation.ReadOnly = true;
            // 
            // btn_Afficher
            // 
            btn_Afficher.Location = new Point(607, 31);
            btn_Afficher.Name = "btn_Afficher";
            btn_Afficher.Size = new Size(75, 23);
            btn_Afficher.TabIndex = 1;
            btn_Afficher.Text = "Afficher";
            btn_Afficher.UseVisualStyleBackColor = true;
            btn_Afficher.Click += btn_Afficher_Click;
            // 
            // btn_Modifier
            // 
            btn_Modifier.Location = new Point(607, 60);
            btn_Modifier.Name = "btn_Modifier";
            btn_Modifier.Size = new Size(75, 23);
            btn_Modifier.TabIndex = 2;
            btn_Modifier.Text = "Modifier";
            btn_Modifier.UseVisualStyleBackColor = true;
            btn_Modifier.Click += btn_Modifier_Click;
            // 
            // btn_Supp
            // 
            btn_Supp.Location = new Point(607, 89);
            btn_Supp.Name = "btn_Supp";
            btn_Supp.Size = new Size(75, 23);
            btn_Supp.TabIndex = 3;
            btn_Supp.Text = "Supprimer";
            btn_Supp.UseVisualStyleBackColor = true;
            // 
            // btn_nouveau
            // 
            btn_nouveau.Location = new Point(607, 118);
            btn_nouveau.Name = "btn_nouveau";
            btn_nouveau.Size = new Size(75, 23);
            btn_nouveau.TabIndex = 4;
            btn_nouveau.Text = "Nouveau";
            btn_nouveau.UseVisualStyleBackColor = true;
            // 
            // Form_ListeAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 471);
            Controls.Add(btn_nouveau);
            Controls.Add(btn_Supp);
            Controls.Add(btn_Modifier);
            Controls.Add(btn_Afficher);
            Controls.Add(dgv_ListeAuteur);
            Name = "Form_ListeAuteur";
            Text = "Liste des auteurs";
            Load += Form_ListeAuteur_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAuteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ListeAuteur;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Prenom;
        private DataGridViewTextBoxColumn Nation;
        private Button btn_Afficher;
        private Button btn_Modifier;
        private Button btn_Supp;
        private Button btn_nouveau;
        private BindingSource bs;
    }
}