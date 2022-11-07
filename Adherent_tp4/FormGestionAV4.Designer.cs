namespace Adherent_tp4
{
    partial class FormGestionAV4
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
            this.listBAdhe = new System.Windows.Forms.ListBox();
            this.radButtAdhe = new System.Windows.Forms.RadioButton();
            this.radButtGest = new System.Windows.Forms.RadioButton();
            this.tabControlAdheGest = new System.Windows.Forms.TabControl();
            this.tabAdhe = new System.Windows.Forms.TabPage();
            this.butDesincription = new System.Windows.Forms.Button();
            this.butInscription = new System.Windows.Forms.Button();
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
            this.textBResGest = new System.Windows.Forms.TextBox();
            this.textBoxDateActGest = new System.Windows.Forms.TextBox();
            this.labDateDebGest = new System.Windows.Forms.Label();
            this.textBTarifActGest = new System.Windows.Forms.TextBox();
            this.textBTypeActGest = new System.Windows.Forms.TextBox();
            this.textBNomActGest = new System.Windows.Forms.TextBox();
            this.labTarifGest = new System.Windows.Forms.Label();
            this.labTypeActGest = new System.Windows.Forms.Label();
            this.LabGestNomAct = new System.Windows.Forms.Label();
            this.butSupAct = new System.Windows.Forms.Button();
            this.butAjoutAct = new System.Windows.Forms.Button();
            this.buttSuppAdheGest = new System.Windows.Forms.Button();
            this.buttAjoutAdheGest = new System.Windows.Forms.Button();
            this.textBoxAgeG = new System.Windows.Forms.TextBox();
            this.labGestDateNaissance = new System.Windows.Forms.Label();
            this.textBoxMailG = new System.Windows.Forms.TextBox();
            this.textBoxPreG = new System.Windows.Forms.TextBox();
            this.textBoxNomG = new System.Windows.Forms.TextBox();
            this.labMailGest = new System.Windows.Forms.Label();
            this.labPrenomGest = new System.Windows.Forms.Label();
            this.labNomGest = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.listBAct = new System.Windows.Forms.ListBox();
            this.butAfficheAct = new System.Windows.Forms.Button();
            this.tabControlAdheGest.SuspendLayout();
            this.tabAdhe.SuspendLayout();
            this.tabGest.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBAdhe
            // 
            this.listBAdhe.FormattingEnabled = true;
            this.listBAdhe.ItemHeight = 20;
            this.listBAdhe.Location = new System.Drawing.Point(48, 44);
            this.listBAdhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBAdhe.Name = "listBAdhe";
            this.listBAdhe.Size = new System.Drawing.Size(296, 444);
            this.listBAdhe.TabIndex = 0;
            this.listBAdhe.SelectedIndexChanged += new System.EventHandler(this.listAdhe_SelectedIndexChanged);
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
            this.tabControlAdheGest.Location = new System.Drawing.Point(815, 43);
            this.tabControlAdheGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlAdheGest.Name = "tabControlAdheGest";
            this.tabControlAdheGest.SelectedIndex = 0;
            this.tabControlAdheGest.Size = new System.Drawing.Size(822, 445);
            this.tabControlAdheGest.TabIndex = 3;
            // 
            // tabAdhe
            // 
            this.tabAdhe.Controls.Add(this.butDesincription);
            this.tabAdhe.Controls.Add(this.butInscription);
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
            this.tabAdhe.Size = new System.Drawing.Size(814, 412);
            this.tabAdhe.TabIndex = 0;
            this.tabAdhe.Text = "Adhérent";
            this.tabAdhe.UseVisualStyleBackColor = true;
            // 
            // butDesincription
            // 
            this.butDesincription.Location = new System.Drawing.Point(428, 236);
            this.butDesincription.Name = "butDesincription";
            this.butDesincription.Size = new System.Drawing.Size(166, 33);
            this.butDesincription.TabIndex = 13;
            this.butDesincription.Text = "Se désinscrire";
            this.butDesincription.UseVisualStyleBackColor = true;
            this.butDesincription.Click += new System.EventHandler(this.butDesincription_Click);
            // 
            // butInscription
            // 
            this.butInscription.Location = new System.Drawing.Point(428, 145);
            this.butInscription.Name = "butInscription";
            this.butInscription.Size = new System.Drawing.Size(166, 33);
            this.butInscription.TabIndex = 12;
            this.butInscription.Text = "S\'inscrire a l\'act";
            this.butInscription.UseVisualStyleBackColor = true;
            this.butInscription.Click += new System.EventHandler(this.butInscription_Click);
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
            this.tabGest.Controls.Add(this.textBResGest);
            this.tabGest.Controls.Add(this.textBoxDateActGest);
            this.tabGest.Controls.Add(this.labDateDebGest);
            this.tabGest.Controls.Add(this.textBTarifActGest);
            this.tabGest.Controls.Add(this.textBTypeActGest);
            this.tabGest.Controls.Add(this.textBNomActGest);
            this.tabGest.Controls.Add(this.labTarifGest);
            this.tabGest.Controls.Add(this.labTypeActGest);
            this.tabGest.Controls.Add(this.LabGestNomAct);
            this.tabGest.Controls.Add(this.butSupAct);
            this.tabGest.Controls.Add(this.butAjoutAct);
            this.tabGest.Controls.Add(this.buttSuppAdheGest);
            this.tabGest.Controls.Add(this.buttAjoutAdheGest);
            this.tabGest.Controls.Add(this.textBoxAgeG);
            this.tabGest.Controls.Add(this.labGestDateNaissance);
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
            this.tabGest.Size = new System.Drawing.Size(814, 412);
            this.tabGest.TabIndex = 1;
            this.tabGest.Text = "Gestionnaire";
            this.tabGest.UseVisualStyleBackColor = true;
            // 
            // textBResGest
            // 
            this.textBResGest.Location = new System.Drawing.Point(354, 291);
            this.textBResGest.Name = "textBResGest";
            this.textBResGest.Size = new System.Drawing.Size(65, 27);
            this.textBResGest.TabIndex = 40;
            // 
            // textBoxDateActGest
            // 
            this.textBoxDateActGest.Location = new System.Drawing.Point(635, 236);
            this.textBoxDateActGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDateActGest.Name = "textBoxDateActGest";
            this.textBoxDateActGest.Size = new System.Drawing.Size(114, 27);
            this.textBoxDateActGest.TabIndex = 39;
            // 
            // labDateDebGest
            // 
            this.labDateDebGest.AutoSize = true;
            this.labDateDebGest.Location = new System.Drawing.Point(417, 236);
            this.labDateDebGest.Name = "labDateDebGest";
            this.labDateDebGest.Size = new System.Drawing.Size(171, 20);
            this.labDateDebGest.TabIndex = 38;
            this.labDateDebGest.Text = "Date début de l\'activité :";
            // 
            // textBTarifActGest
            // 
            this.textBTarifActGest.Location = new System.Drawing.Point(635, 170);
            this.textBTarifActGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBTarifActGest.Name = "textBTarifActGest";
            this.textBTarifActGest.Size = new System.Drawing.Size(114, 27);
            this.textBTarifActGest.TabIndex = 37;
            // 
            // textBTypeActGest
            // 
            this.textBTypeActGest.Location = new System.Drawing.Point(635, 106);
            this.textBTypeActGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBTypeActGest.Name = "textBTypeActGest";
            this.textBTypeActGest.Size = new System.Drawing.Size(114, 27);
            this.textBTypeActGest.TabIndex = 36;
            // 
            // textBNomActGest
            // 
            this.textBNomActGest.Location = new System.Drawing.Point(635, 42);
            this.textBNomActGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBNomActGest.Name = "textBNomActGest";
            this.textBNomActGest.Size = new System.Drawing.Size(114, 27);
            this.textBNomActGest.TabIndex = 35;
            // 
            // labTarifGest
            // 
            this.labTarifGest.AutoSize = true;
            this.labTarifGest.Location = new System.Drawing.Point(458, 177);
            this.labTarifGest.Name = "labTarifGest";
            this.labTarifGest.Size = new System.Drawing.Size(44, 20);
            this.labTarifGest.TabIndex = 34;
            this.labTarifGest.Text = "Tarif :";
            // 
            // labTypeActGest
            // 
            this.labTypeActGest.AutoSize = true;
            this.labTypeActGest.Location = new System.Drawing.Point(417, 109);
            this.labTypeActGest.Name = "labTypeActGest";
            this.labTypeActGest.Size = new System.Drawing.Size(127, 20);
            this.labTypeActGest.TabIndex = 33;
            this.labTypeActGest.Text = "Type de l\'activité :";
            // 
            // LabGestNomAct
            // 
            this.LabGestNomAct.AutoSize = true;
            this.LabGestNomAct.Location = new System.Drawing.Point(458, 45);
            this.LabGestNomAct.Name = "LabGestNomAct";
            this.LabGestNomAct.Size = new System.Drawing.Size(49, 20);
            this.LabGestNomAct.TabIndex = 32;
            this.LabGestNomAct.Text = "Nom :";
            // 
            // butSupAct
            // 
            this.butSupAct.Location = new System.Drawing.Point(448, 342);
            this.butSupAct.Name = "butSupAct";
            this.butSupAct.Size = new System.Drawing.Size(169, 31);
            this.butSupAct.TabIndex = 31;
            this.butSupAct.Text = "Supprimer l\'activité";
            this.butSupAct.UseVisualStyleBackColor = true;
            this.butSupAct.Click += new System.EventHandler(this.butSupAct_Click);
            // 
            // butAjoutAct
            // 
            this.butAjoutAct.Location = new System.Drawing.Point(448, 284);
            this.butAjoutAct.Name = "butAjoutAct";
            this.butAjoutAct.Size = new System.Drawing.Size(169, 31);
            this.butAjoutAct.TabIndex = 7;
            this.butAjoutAct.Text = "Ajouter l\'activité";
            this.butAjoutAct.UseVisualStyleBackColor = true;
            this.butAjoutAct.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttSuppAdheGest
            // 
            this.buttSuppAdheGest.Location = new System.Drawing.Point(41, 342);
            this.buttSuppAdheGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttSuppAdheGest.Name = "buttSuppAdheGest";
            this.buttSuppAdheGest.Size = new System.Drawing.Size(178, 31);
            this.buttSuppAdheGest.TabIndex = 28;
            this.buttSuppAdheGest.Text = "Supprimer l\'adhérent";
            this.buttSuppAdheGest.UseVisualStyleBackColor = true;
            this.buttSuppAdheGest.Click += new System.EventHandler(this.buttSuppAdheGest_Click_1);
            // 
            // buttAjoutAdheGest
            // 
            this.buttAjoutAdheGest.Location = new System.Drawing.Point(42, 284);
            this.buttAjoutAdheGest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttAjoutAdheGest.Name = "buttAjoutAdheGest";
            this.buttAjoutAdheGest.Size = new System.Drawing.Size(177, 31);
            this.buttAjoutAdheGest.TabIndex = 27;
            this.buttAjoutAdheGest.Text = "Ajouter l\'adhérent";
            this.buttAjoutAdheGest.UseVisualStyleBackColor = true;
            this.buttAjoutAdheGest.Click += new System.EventHandler(this.buttAjoutAdheGest_Click_1);
            // 
            // textBoxAgeG
            // 
            this.textBoxAgeG.Location = new System.Drawing.Point(183, 236);
            this.textBoxAgeG.Name = "textBoxAgeG";
            this.textBoxAgeG.Size = new System.Drawing.Size(114, 27);
            this.textBoxAgeG.TabIndex = 30;
            // 
            // labGestDateNaissance
            // 
            this.labGestDateNaissance.AutoSize = true;
            this.labGestDateNaissance.Location = new System.Drawing.Point(39, 239);
            this.labGestDateNaissance.Name = "labGestDateNaissance";
            this.labGestDateNaissance.Size = new System.Drawing.Size(136, 20);
            this.labGestDateNaissance.TabIndex = 29;
            this.labGestDateNaissance.Text = "Date de naissance :";
            // 
            // textBoxMailG
            // 
            this.textBoxMailG.Location = new System.Drawing.Point(184, 170);
            this.textBoxMailG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMailG.Name = "textBoxMailG";
            this.textBoxMailG.Size = new System.Drawing.Size(114, 27);
            this.textBoxMailG.TabIndex = 26;
            // 
            // textBoxPreG
            // 
            this.textBoxPreG.Location = new System.Drawing.Point(184, 106);
            this.textBoxPreG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPreG.Name = "textBoxPreG";
            this.textBoxPreG.Size = new System.Drawing.Size(114, 27);
            this.textBoxPreG.TabIndex = 25;
            // 
            // textBoxNomG
            // 
            this.textBoxNomG.Location = new System.Drawing.Point(184, 38);
            this.textBoxNomG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomG.Name = "textBoxNomG";
            this.textBoxNomG.Size = new System.Drawing.Size(114, 27);
            this.textBoxNomG.TabIndex = 24;
            // 
            // labMailGest
            // 
            this.labMailGest.AutoSize = true;
            this.labMailGest.Location = new System.Drawing.Point(41, 173);
            this.labMailGest.Name = "labMailGest";
            this.labMailGest.Size = new System.Drawing.Size(45, 20);
            this.labMailGest.TabIndex = 23;
            this.labMailGest.Text = "Mail :";
            // 
            // labPrenomGest
            // 
            this.labPrenomGest.AutoSize = true;
            this.labPrenomGest.Location = new System.Drawing.Point(38, 109);
            this.labPrenomGest.Name = "labPrenomGest";
            this.labPrenomGest.Size = new System.Drawing.Size(67, 20);
            this.labPrenomGest.TabIndex = 22;
            this.labPrenomGest.Text = "Prenom :";
            // 
            // labNomGest
            // 
            this.labNomGest.AutoSize = true;
            this.labNomGest.Location = new System.Drawing.Point(39, 41);
            this.labNomGest.Name = "labNomGest";
            this.labNomGest.Size = new System.Drawing.Size(49, 20);
            this.labNomGest.TabIndex = 21;
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
            // listBAct
            // 
            this.listBAct.FormattingEnabled = true;
            this.listBAct.ItemHeight = 20;
            this.listBAct.Location = new System.Drawing.Point(375, 45);
            this.listBAct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBAct.Name = "listBAct";
            this.listBAct.Size = new System.Drawing.Size(216, 444);
            this.listBAct.TabIndex = 6;
            // 
            // butAfficheAct
            // 
            this.butAfficheAct.Location = new System.Drawing.Point(375, 520);
            this.butAfficheAct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAfficheAct.Name = "butAfficheAct";
            this.butAfficheAct.Size = new System.Drawing.Size(216, 24);
            this.butAfficheAct.TabIndex = 28;
            this.butAfficheAct.Text = "Afficher toutes les activités";
            this.butAfficheAct.UseVisualStyleBackColor = true;
            this.butAfficheAct.Click += new System.EventHandler(this.butAfficheAct_Click);
            // 
            // FormGestionAV4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 600);
            this.Controls.Add(this.butAfficheAct);
            this.Controls.Add(this.listBAct);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.tabControlAdheGest);
            this.Controls.Add(this.radButtGest);
            this.Controls.Add(this.radButtAdhe);
            this.Controls.Add(this.listBAdhe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGestionAV4";
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

        private ListBox listBAdhe;
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
        private TextBox TextBMail;
        private Label labAdheAge;
        private Label label1;
        private ListBox listBAct;
        private Button butAjoutAct;
        private Button buttSuppAdheGest;
        private Button buttAjoutAdheGest;
        private TextBox textBoxAgeG;
        private Label labGestDateNaissance;
        private TextBox textBoxMailG;
        private TextBox textBoxPreG;
        private TextBox textBoxNomG;
        private Label labMailGest;
        private Label labPrenomGest;
        private Label labNomGest;
        private Button butSupAct;
        private Label LabGestNomAct;
        private Label labDateDebGest;
        private TextBox textBTarifActGest;
        private TextBox textBTypeActGest;
        private TextBox textBNomActGest;
        private Label labTarifGest;
        private Label labTypeActGest;
        private TextBox textBoxDateActGest;
        private Button butAfficheAct;
        private TextBox textBResGest;
        private Button butInscription;
        private Button butDesincription;
    }
}