namespace Adherent_tp4
{
    partial class FormGestionAV3
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
            this.listAdhe = new System.Windows.Forms.ListBox();
            this.radButtAdhe = new System.Windows.Forms.RadioButton();
            this.radButtGest = new System.Windows.Forms.RadioButton();
            this.tabControlAdheGest = new System.Windows.Forms.TabControl();
            this.tabAdhe = new System.Windows.Forms.TabPage();
            this.labAdheAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBMail = new System.Windows.Forms.TextBox();
            this.buttModMail = new System.Windows.Forms.Button();
            this.labAdheMail = new System.Windows.Forms.Label();
            this.labAdhePrenom = new System.Windows.Forms.Label();
            this.labAdheNom = new System.Windows.Forms.Label();
            this.labMailAdhe = new System.Windows.Forms.Label();
            this.labPrenomAdhe = new System.Windows.Forms.Label();
            this.labNomAdhe = new System.Windows.Forms.Label();
            this.tabGest = new System.Windows.Forms.TabPage();
            this.textBoxAgeG = new System.Windows.Forms.TextBox();
            this.labGestDateNaissance = new System.Windows.Forms.Label();
            this.buttSuppAdheGest = new System.Windows.Forms.Button();
            this.buttAjoutAdheGest = new System.Windows.Forms.Button();
            this.textBoxMailG = new System.Windows.Forms.TextBox();
            this.textBoxPreG = new System.Windows.Forms.TextBox();
            this.textBoxNomG = new System.Windows.Forms.TextBox();
            this.labMailGest = new System.Windows.Forms.Label();
            this.labPrenomGest = new System.Windows.Forms.Label();
            this.labNomGest = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.tabControlAdheGest.SuspendLayout();
            this.tabAdhe.SuspendLayout();
            this.tabGest.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAdhe
            // 
            this.listAdhe.FormattingEnabled = true;
            this.listAdhe.ItemHeight = 20;
            this.listAdhe.Location = new System.Drawing.Point(48, 44);
            this.listAdhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAdhe.Name = "listAdhe";
            this.listAdhe.Size = new System.Drawing.Size(555, 444);
            this.listAdhe.TabIndex = 0;
            this.listAdhe.SelectedIndexChanged += new System.EventHandler(this.listAdhe_SelectedIndexChanged);
            // 
            // radButtAdhe
            // 
            this.radButtAdhe.AutoSize = true;
            this.radButtAdhe.Checked = true;
            this.radButtAdhe.Location = new System.Drawing.Point(48, 520);
            this.radButtAdhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radButtAdhe.Name = "radButtAdhe";
            this.radButtAdhe.Size = new System.Drawing.Size(91, 24);
            this.radButtAdhe.TabIndex = 1;
            this.radButtAdhe.TabStop = true;
            this.radButtAdhe.Text = "Adhérent";
            this.radButtAdhe.UseVisualStyleBackColor = true;
            this.radButtAdhe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radButtGest
            // 
            this.radButtGest.AutoSize = true;
            this.radButtGest.Location = new System.Drawing.Point(231, 520);
            this.radButtGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radButtGest.Name = "radButtGest";
            this.radButtGest.Size = new System.Drawing.Size(113, 24);
            this.radButtGest.TabIndex = 2;
            this.radButtGest.Text = "Gestionnaire";
            this.radButtGest.UseVisualStyleBackColor = true;
            // 
            // tabControlAdheGest
            // 
            this.tabControlAdheGest.Controls.Add(this.tabAdhe);
            this.tabControlAdheGest.Controls.Add(this.tabGest);
            this.tabControlAdheGest.Location = new System.Drawing.Point(691, 44);
            this.tabControlAdheGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlAdheGest.Name = "tabControlAdheGest";
            this.tabControlAdheGest.SelectedIndex = 0;
            this.tabControlAdheGest.Size = new System.Drawing.Size(349, 445);
            this.tabControlAdheGest.TabIndex = 3;
            this.tabControlAdheGest.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAdhe
            // 
            this.tabAdhe.Controls.Add(this.labAdheAge);
            this.tabAdhe.Controls.Add(this.label1);
            this.tabAdhe.Controls.Add(this.TextBMail);
            this.tabAdhe.Controls.Add(this.buttModMail);
            this.tabAdhe.Controls.Add(this.labAdheMail);
            this.tabAdhe.Controls.Add(this.labAdhePrenom);
            this.tabAdhe.Controls.Add(this.labAdheNom);
            this.tabAdhe.Controls.Add(this.labMailAdhe);
            this.tabAdhe.Controls.Add(this.labPrenomAdhe);
            this.tabAdhe.Controls.Add(this.labNomAdhe);
            this.tabAdhe.Location = new System.Drawing.Point(4, 29);
            this.tabAdhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdhe.Name = "tabAdhe";
            this.tabAdhe.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdhe.Size = new System.Drawing.Size(341, 412);
            this.tabAdhe.TabIndex = 0;
            this.tabAdhe.Text = "Adhérent";
            this.tabAdhe.UseVisualStyleBackColor = true;
            this.tabAdhe.Click += new System.EventHandler(this.tabAdhe_Click);
            // 
            // labAdheAge
            // 
            this.labAdheAge.AutoSize = true;
            this.labAdheAge.Location = new System.Drawing.Point(131, 261);
            this.labAdheAge.Name = "labAdheAge";
            this.labAdheAge.Size = new System.Drawing.Size(50, 20);
            this.labAdheAge.TabIndex = 11;
            this.labAdheAge.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Age :";
            // 
            // TextBMail
            // 
            this.TextBMail.Location = new System.Drawing.Point(112, 182);
            this.TextBMail.Name = "TextBMail";
            this.TextBMail.Size = new System.Drawing.Size(206, 27);
            this.TextBMail.TabIndex = 7;
            this.TextBMail.Text = "sf";
            // 
            // buttModMail
            // 
            this.buttModMail.Location = new System.Drawing.Point(33, 332);
            this.buttModMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttModMail.Name = "buttModMail";
            this.buttModMail.Size = new System.Drawing.Size(148, 31);
            this.buttModMail.TabIndex = 6;
            this.buttModMail.Text = "Modifier le mail";
            this.buttModMail.UseVisualStyleBackColor = true;
            this.buttModMail.Click += new System.EventHandler(this.buttModMail_Click);
            // 
            // labAdheMail
            // 
            this.labAdheMail.AutoSize = true;
            this.labAdheMail.Location = new System.Drawing.Point(131, 185);
            this.labAdheMail.Name = "labAdheMail";
            this.labAdheMail.Size = new System.Drawing.Size(0, 20);
            this.labAdheMail.TabIndex = 5;
            // 
            // labAdhePrenom
            // 
            this.labAdhePrenom.AutoSize = true;
            this.labAdhePrenom.Location = new System.Drawing.Point(131, 119);
            this.labAdhePrenom.Name = "labAdhePrenom";
            this.labAdhePrenom.Size = new System.Drawing.Size(50, 20);
            this.labAdhePrenom.TabIndex = 4;
            this.labAdhePrenom.Text = "label5";
            // 
            // labAdheNom
            // 
            this.labAdheNom.AutoSize = true;
            this.labAdheNom.Location = new System.Drawing.Point(131, 57);
            this.labAdheNom.Name = "labAdheNom";
            this.labAdheNom.Size = new System.Drawing.Size(50, 20);
            this.labAdheNom.TabIndex = 3;
            this.labAdheNom.Text = "label4";
            // 
            // labMailAdhe
            // 
            this.labMailAdhe.AutoSize = true;
            this.labMailAdhe.Location = new System.Drawing.Point(33, 185);
            this.labMailAdhe.Name = "labMailAdhe";
            this.labMailAdhe.Size = new System.Drawing.Size(45, 20);
            this.labMailAdhe.TabIndex = 2;
            this.labMailAdhe.Text = "Mail :";
            // 
            // labPrenomAdhe
            // 
            this.labPrenomAdhe.AutoSize = true;
            this.labPrenomAdhe.Location = new System.Drawing.Point(33, 119);
            this.labPrenomAdhe.Name = "labPrenomAdhe";
            this.labPrenomAdhe.Size = new System.Drawing.Size(67, 20);
            this.labPrenomAdhe.TabIndex = 1;
            this.labPrenomAdhe.Text = "Prénom :";
            // 
            // labNomAdhe
            // 
            this.labNomAdhe.AutoSize = true;
            this.labNomAdhe.Location = new System.Drawing.Point(33, 57);
            this.labNomAdhe.Name = "labNomAdhe";
            this.labNomAdhe.Size = new System.Drawing.Size(49, 20);
            this.labNomAdhe.TabIndex = 0;
            this.labNomAdhe.Text = "Nom :";
            // 
            // tabGest
            // 
            this.tabGest.Controls.Add(this.textBoxAgeG);
            this.tabGest.Controls.Add(this.labGestDateNaissance);
            this.tabGest.Controls.Add(this.buttSuppAdheGest);
            this.tabGest.Controls.Add(this.buttAjoutAdheGest);
            this.tabGest.Controls.Add(this.textBoxMailG);
            this.tabGest.Controls.Add(this.textBoxPreG);
            this.tabGest.Controls.Add(this.textBoxNomG);
            this.tabGest.Controls.Add(this.labMailGest);
            this.tabGest.Controls.Add(this.labPrenomGest);
            this.tabGest.Controls.Add(this.labNomGest);
            this.tabGest.Location = new System.Drawing.Point(4, 29);
            this.tabGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGest.Name = "tabGest";
            this.tabGest.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGest.Size = new System.Drawing.Size(341, 412);
            this.tabGest.TabIndex = 1;
            this.tabGest.Text = "Gestionnaire";
            this.tabGest.UseVisualStyleBackColor = true;
            // 
            // textBoxAgeG
            // 
            this.textBoxAgeG.Location = new System.Drawing.Point(192, 250);
            this.textBoxAgeG.Name = "textBoxAgeG";
            this.textBoxAgeG.Size = new System.Drawing.Size(114, 27);
            this.textBoxAgeG.TabIndex = 10;
            // 
            // labGestDateNaissance
            // 
            this.labGestDateNaissance.AutoSize = true;
            this.labGestDateNaissance.Location = new System.Drawing.Point(31, 253);
            this.labGestDateNaissance.Name = "labGestDateNaissance";
            this.labGestDateNaissance.Size = new System.Drawing.Size(136, 20);
            this.labGestDateNaissance.TabIndex = 9;
            this.labGestDateNaissance.Text = "Date de naissance :";
            // 
            // buttSuppAdheGest
            // 
            this.buttSuppAdheGest.Location = new System.Drawing.Point(34, 356);
            this.buttSuppAdheGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttSuppAdheGest.Name = "buttSuppAdheGest";
            this.buttSuppAdheGest.Size = new System.Drawing.Size(193, 31);
            this.buttSuppAdheGest.TabIndex = 8;
            this.buttSuppAdheGest.Text = "Supprimer l\'adhérent";
            this.buttSuppAdheGest.UseVisualStyleBackColor = true;
            this.buttSuppAdheGest.Click += new System.EventHandler(this.buttSuppAdheGest_Click);
            // 
            // buttAjoutAdheGest
            // 
            this.buttAjoutAdheGest.Location = new System.Drawing.Point(34, 298);
            this.buttAjoutAdheGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttAjoutAdheGest.Name = "buttAjoutAdheGest";
            this.buttAjoutAdheGest.Size = new System.Drawing.Size(147, 31);
            this.buttAjoutAdheGest.TabIndex = 7;
            this.buttAjoutAdheGest.Text = "Ajouter l\'adhérent";
            this.buttAjoutAdheGest.UseVisualStyleBackColor = true;
            this.buttAjoutAdheGest.Click += new System.EventHandler(this.buttAjoutAdheGest_Click);
            // 
            // textBoxMailG
            // 
            this.textBoxMailG.Location = new System.Drawing.Point(192, 184);
            this.textBoxMailG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMailG.Name = "textBoxMailG";
            this.textBoxMailG.Size = new System.Drawing.Size(114, 27);
            this.textBoxMailG.TabIndex = 6;
            // 
            // textBoxPreG
            // 
            this.textBoxPreG.Location = new System.Drawing.Point(192, 120);
            this.textBoxPreG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPreG.Name = "textBoxPreG";
            this.textBoxPreG.Size = new System.Drawing.Size(114, 27);
            this.textBoxPreG.TabIndex = 5;
            // 
            // textBoxNomG
            // 
            this.textBoxNomG.Location = new System.Drawing.Point(192, 52);
            this.textBoxNomG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomG.Name = "textBoxNomG";
            this.textBoxNomG.Size = new System.Drawing.Size(114, 27);
            this.textBoxNomG.TabIndex = 4;
            // 
            // labMailGest
            // 
            this.labMailGest.AutoSize = true;
            this.labMailGest.Location = new System.Drawing.Point(34, 187);
            this.labMailGest.Name = "labMailGest";
            this.labMailGest.Size = new System.Drawing.Size(45, 20);
            this.labMailGest.TabIndex = 3;
            this.labMailGest.Text = "Mail :";
            // 
            // labPrenomGest
            // 
            this.labPrenomGest.AutoSize = true;
            this.labPrenomGest.Location = new System.Drawing.Point(34, 123);
            this.labPrenomGest.Name = "labPrenomGest";
            this.labPrenomGest.Size = new System.Drawing.Size(67, 20);
            this.labPrenomGest.TabIndex = 2;
            this.labPrenomGest.Text = "Prenom :";
            // 
            // labNomGest
            // 
            this.labNomGest.AutoSize = true;
            this.labNomGest.Location = new System.Drawing.Point(34, 55);
            this.labNomGest.Name = "labNomGest";
            this.labNomGest.Size = new System.Drawing.Size(49, 20);
            this.labNomGest.TabIndex = 1;
            this.labNomGest.Text = "Nom :";
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Location = new System.Drawing.Point(48, 496);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(104, 20);
            this.labRole.TabIndex = 5;
            this.labRole.Text = "Choisir un rôle";
            // 
            // FormGestionAV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 600);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.tabControlAdheGest);
            this.Controls.Add(this.radButtGest);
            this.Controls.Add(this.radButtAdhe);
            this.Controls.Add(this.listAdhe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGestionAV3";
            this.Text = "Gestion des adhérents";
            this.Load += new System.EventHandler(this.GestAdhe_Load);
            this.tabControlAdheGest.ResumeLayout(false);
            this.tabAdhe.ResumeLayout(false);
            this.tabAdhe.PerformLayout();
            this.tabGest.ResumeLayout(false);
            this.tabGest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listAdhe;
        private RadioButton radButtAdhe;
        private RadioButton radButtGest;
        private TabControl tabControlAdheGest;
        private TabPage tabAdhe;
        private TabPage tabGest;
        private Label labRole;
        private Button buttModMail;
        private Label labAdheMail;
        private Label labAdhePrenom;
        private Label labAdheNom;
        private Label labMailAdhe;
        private Label labPrenomAdhe;
        private Label labNomAdhe;
        private Button buttSuppAdheGest;
        private Button buttAjoutAdheGest;
        private TextBox textBoxMailG;
        private TextBox textBoxPreG;
        private TextBox textBoxNomG;
        private Label labMailGest;
        private Label labPrenomGest;
        private Label labNomGest;
        private TextBox TextBMail;
        private Label labGestDateNaissance;
        private Label labAdheAge;
        private Label label1;
        private TextBox textBoxAgeG;
    }
}