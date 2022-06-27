namespace GESTIONECOLE.FORMS
{
    partial class CREATEINSCRIPTIONFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CREATEINSCRIPTIONFORM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NIVEAUCOMBO = new System.Windows.Forms.ComboBox();
            this.CLASSCOMBO = new System.Windows.Forms.ComboBox();
            this.TXTCOST = new System.Windows.Forms.TextBox();
            this.elevecombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AJOUTERBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.refreshBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.rechercherBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_annescolaire = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateinscLABEL = new System.Windows.Forms.Label();
            this.AnnescolaireLABEL = new System.Windows.Forms.Label();
            this.classnomLABEL = new System.Windows.Forms.Label();
            this.telelabel = new System.Windows.Forms.Label();
            this.tuteurNOMLABEL = new System.Windows.Forms.Label();
            this.nomcompletLABEL = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.precedentBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.print1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercherBTN)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precedentBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // NIVEAUCOMBO
            // 
            this.NIVEAUCOMBO.FormattingEnabled = true;
            this.NIVEAUCOMBO.Location = new System.Drawing.Point(183, 110);
            this.NIVEAUCOMBO.Name = "NIVEAUCOMBO";
            this.NIVEAUCOMBO.Size = new System.Drawing.Size(179, 21);
            this.NIVEAUCOMBO.TabIndex = 0;
            this.NIVEAUCOMBO.SelectedIndexChanged += new System.EventHandler(this.NIVEAUCOMBO_SelectedIndexChanged);
            // 
            // CLASSCOMBO
            // 
            this.CLASSCOMBO.FormattingEnabled = true;
            this.CLASSCOMBO.Location = new System.Drawing.Point(183, 176);
            this.CLASSCOMBO.Name = "CLASSCOMBO";
            this.CLASSCOMBO.Size = new System.Drawing.Size(179, 21);
            this.CLASSCOMBO.TabIndex = 1;
            this.CLASSCOMBO.SelectedIndexChanged += new System.EventHandler(this.CLASSCOMBO_SelectedIndexChanged);
            // 
            // TXTCOST
            // 
            this.TXTCOST.Location = new System.Drawing.Point(183, 326);
            this.TXTCOST.Name = "TXTCOST";
            this.TXTCOST.Size = new System.Drawing.Size(179, 20);
            this.TXTCOST.TabIndex = 3;
            // 
            // elevecombo
            // 
            this.elevecombo.FormattingEnabled = true;
            this.elevecombo.Location = new System.Drawing.Point(183, 251);
            this.elevecombo.Name = "elevecombo";
            this.elevecombo.Size = new System.Drawing.Size(179, 21);
            this.elevecombo.TabIndex = 10;
            this.elevecombo.SelectedIndexChanged += new System.EventHandler(this.elevecombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 94;
            this.label5.Text = "Class : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 94;
            this.label6.Text = "Niveau : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 95;
            this.label7.Text = "Eleve : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(12, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 96;
            this.label8.Text = "Cost Insc : ";
            // 
            // AJOUTERBTN
            // 
            this.AJOUTERBTN.Active = true;
            this.AJOUTERBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.AJOUTERBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.AJOUTERBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AJOUTERBTN.BorderRadius = 5;
            this.AJOUTERBTN.ButtonText = "Ajouter eleve";
            this.AJOUTERBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AJOUTERBTN.DisabledColor = System.Drawing.Color.Gray;
            this.AJOUTERBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.AJOUTERBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("AJOUTERBTN.Iconimage")));
            this.AJOUTERBTN.Iconimage_right = null;
            this.AJOUTERBTN.Iconimage_right_Selected = null;
            this.AJOUTERBTN.Iconimage_Selected = null;
            this.AJOUTERBTN.IconMarginLeft = 0;
            this.AJOUTERBTN.IconMarginRight = 0;
            this.AJOUTERBTN.IconRightVisible = false;
            this.AJOUTERBTN.IconRightZoom = 0D;
            this.AJOUTERBTN.IconVisible = false;
            this.AJOUTERBTN.IconZoom = 0D;
            this.AJOUTERBTN.IsTab = true;
            this.AJOUTERBTN.Location = new System.Drawing.Point(239, 409);
            this.AJOUTERBTN.Margin = new System.Windows.Forms.Padding(0);
            this.AJOUTERBTN.Name = "AJOUTERBTN";
            this.AJOUTERBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.AJOUTERBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.AJOUTERBTN.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.AJOUTERBTN.selected = true;
            this.AJOUTERBTN.Size = new System.Drawing.Size(127, 28);
            this.AJOUTERBTN.TabIndex = 100;
            this.AJOUTERBTN.Text = "Ajouter eleve";
            this.AJOUTERBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AJOUTERBTN.Textcolor = System.Drawing.Color.Silver;
            this.AJOUTERBTN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTERBTN.Click += new System.EventHandler(this.AJOUTERBTN_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(405, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(438, 379);
            this.dataGridView1.TabIndex = 102;
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.Color.Transparent;
            this.refreshBTN.Image = ((System.Drawing.Image)(resources.GetObject("refreshBTN.Image")));
            this.refreshBTN.ImageActive = null;
            this.refreshBTN.Location = new System.Drawing.Point(809, 15);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(34, 32);
            this.refreshBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBTN.TabIndex = 114;
            this.refreshBTN.TabStop = false;
            this.refreshBTN.Zoom = 10;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // rechercherBTN
            // 
            this.rechercherBTN.BackColor = System.Drawing.Color.Transparent;
            this.rechercherBTN.Image = ((System.Drawing.Image)(resources.GetObject("rechercherBTN.Image")));
            this.rechercherBTN.ImageActive = null;
            this.rechercherBTN.Location = new System.Drawing.Point(769, 15);
            this.rechercherBTN.Name = "rechercherBTN";
            this.rechercherBTN.Size = new System.Drawing.Size(34, 32);
            this.rechercherBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rechercherBTN.TabIndex = 113;
            this.rechercherBTN.TabStop = false;
            this.rechercherBTN.Zoom = 10;
            this.rechercherBTN.Click += new System.EventHandler(this.rechercherBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(419, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "Annee Scolaire";
            // 
            // combo_annescolaire
            // 
            this.combo_annescolaire.BackColor = System.Drawing.Color.Transparent;
            this.combo_annescolaire.BorderRadius = 3;
            this.combo_annescolaire.DisabledColor = System.Drawing.Color.Gray;
            this.combo_annescolaire.ForeColor = System.Drawing.Color.Silver;
            this.combo_annescolaire.items = new string[0];
            this.combo_annescolaire.Location = new System.Drawing.Point(569, 15);
            this.combo_annescolaire.Name = "combo_annescolaire";
            this.combo_annescolaire.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.combo_annescolaire.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.combo_annescolaire.selectedIndex = -1;
            this.combo_annescolaire.Size = new System.Drawing.Size(194, 30);
            this.combo_annescolaire.TabIndex = 111;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = true;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Dashboard";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 0D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-9, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(168, 34);
            this.bunifuFlatButton1.TabIndex = 115;
            this.bunifuFlatButton1.Text = "Dashboard";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(194, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 116;
            this.label9.Text = "INSCRIPTION ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.panel2.Location = new System.Drawing.Point(852, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 501);
            this.panel2.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(386, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 490);
            this.panel1.TabIndex = 118;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateinscLABEL);
            this.panel3.Controls.Add(this.AnnescolaireLABEL);
            this.panel3.Controls.Add(this.classnomLABEL);
            this.panel3.Controls.Add(this.telelabel);
            this.panel3.Controls.Add(this.tuteurNOMLABEL);
            this.panel3.Controls.Add(this.nomcompletLABEL);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.bunifuImageButton4);
            this.panel3.Location = new System.Drawing.Point(895, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 392);
            this.panel3.TabIndex = 119;
            // 
            // dateinscLABEL
            // 
            this.dateinscLABEL.AutoSize = true;
            this.dateinscLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateinscLABEL.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dateinscLABEL.Location = new System.Drawing.Point(188, 337);
            this.dateinscLABEL.Name = "dateinscLABEL";
            this.dateinscLABEL.Size = new System.Drawing.Size(0, 16);
            this.dateinscLABEL.TabIndex = 134;
            // 
            // AnnescolaireLABEL
            // 
            this.AnnescolaireLABEL.AutoSize = true;
            this.AnnescolaireLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnescolaireLABEL.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AnnescolaireLABEL.Location = new System.Drawing.Point(188, 290);
            this.AnnescolaireLABEL.Name = "AnnescolaireLABEL";
            this.AnnescolaireLABEL.Size = new System.Drawing.Size(0, 16);
            this.AnnescolaireLABEL.TabIndex = 133;
            // 
            // classnomLABEL
            // 
            this.classnomLABEL.AutoSize = true;
            this.classnomLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classnomLABEL.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.classnomLABEL.Location = new System.Drawing.Point(188, 250);
            this.classnomLABEL.Name = "classnomLABEL";
            this.classnomLABEL.Size = new System.Drawing.Size(0, 16);
            this.classnomLABEL.TabIndex = 132;
            // 
            // telelabel
            // 
            this.telelabel.AutoSize = true;
            this.telelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telelabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.telelabel.Location = new System.Drawing.Point(188, 212);
            this.telelabel.Name = "telelabel";
            this.telelabel.Size = new System.Drawing.Size(0, 16);
            this.telelabel.TabIndex = 131;
            // 
            // tuteurNOMLABEL
            // 
            this.tuteurNOMLABEL.AutoSize = true;
            this.tuteurNOMLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuteurNOMLABEL.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tuteurNOMLABEL.Location = new System.Drawing.Point(188, 172);
            this.tuteurNOMLABEL.Name = "tuteurNOMLABEL";
            this.tuteurNOMLABEL.Size = new System.Drawing.Size(0, 16);
            this.tuteurNOMLABEL.TabIndex = 130;
            // 
            // nomcompletLABEL
            // 
            this.nomcompletLABEL.AutoSize = true;
            this.nomcompletLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomcompletLABEL.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomcompletLABEL.Location = new System.Drawing.Point(188, 131);
            this.nomcompletLABEL.Name = "nomcompletLABEL";
            this.nomcompletLABEL.Size = new System.Drawing.Size(0, 16);
            this.nomcompletLABEL.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(3, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 128;
            this.label13.Text = "Date Inscription : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(3, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 127;
            this.label12.Text = "Tele  : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(3, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 16);
            this.label11.TabIndex = 126;
            this.label11.Text = "Nom complet Tuteur : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(3, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 125;
            this.label10.Text = "Anne Scolaire : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 124;
            this.label3.Text = "Class Nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "Nom complet : ";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(105, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(102, 76);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 123;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(955, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "Les Plus Recents ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1208, 240);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(33, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 121;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // precedentBTN
            // 
            this.precedentBTN.BackColor = System.Drawing.Color.Transparent;
            this.precedentBTN.Image = ((System.Drawing.Image)(resources.GetObject("precedentBTN.Image")));
            this.precedentBTN.ImageActive = null;
            this.precedentBTN.Location = new System.Drawing.Point(864, 240);
            this.precedentBTN.Name = "precedentBTN";
            this.precedentBTN.Size = new System.Drawing.Size(28, 45);
            this.precedentBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.precedentBTN.TabIndex = 122;
            this.precedentBTN.TabStop = false;
            this.precedentBTN.Zoom = 10;
            this.precedentBTN.Click += new System.EventHandler(this.precedentBTN_Click);
            // 
            // print1
            // 
            this.print1.Active = true;
            this.print1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.print1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.print1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print1.BorderRadius = 5;
            this.print1.ButtonText = "Imprimer Insciption";
            this.print1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print1.DisabledColor = System.Drawing.Color.Gray;
            this.print1.Iconcolor = System.Drawing.Color.Transparent;
            this.print1.Iconimage = ((System.Drawing.Image)(resources.GetObject("print1.Iconimage")));
            this.print1.Iconimage_right = null;
            this.print1.Iconimage_right_Selected = null;
            this.print1.Iconimage_Selected = null;
            this.print1.IconMarginLeft = 0;
            this.print1.IconMarginRight = 0;
            this.print1.IconRightVisible = false;
            this.print1.IconRightZoom = 0D;
            this.print1.IconVisible = false;
            this.print1.IconZoom = 0D;
            this.print1.IsTab = true;
            this.print1.Location = new System.Drawing.Point(16, 409);
            this.print1.Margin = new System.Windows.Forms.Padding(0);
            this.print1.Name = "print1";
            this.print1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.print1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.print1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.print1.selected = true;
            this.print1.Size = new System.Drawing.Size(143, 28);
            this.print1.TabIndex = 123;
            this.print1.Text = "Imprimer Insciption";
            this.print1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.print1.Textcolor = System.Drawing.Color.Silver;
            this.print1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print1.Click += new System.EventHandler(this.print1_Click);
            // 
            // CREATEINSCRIPTIONFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1244, 446);
            this.Controls.Add(this.print1);
            this.Controls.Add(this.precedentBTN);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.rechercherBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_annescolaire);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AJOUTERBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.elevecombo);
            this.Controls.Add(this.TXTCOST);
            this.Controls.Add(this.CLASSCOMBO);
            this.Controls.Add(this.NIVEAUCOMBO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CREATEINSCRIPTIONFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREATEINSCRIPTIONFORM";
            this.Load += new System.EventHandler(this.CREATEINSCRIPTIONFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercherBTN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precedentBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NIVEAUCOMBO;
        private System.Windows.Forms.ComboBox CLASSCOMBO;
        private System.Windows.Forms.TextBox TXTCOST;
        private System.Windows.Forms.ComboBox elevecombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton AJOUTERBTN;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuImageButton refreshBTN;
        private Bunifu.Framework.UI.BunifuImageButton rechercherBTN;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown combo_annescolaire;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton precedentBTN;
        private System.Windows.Forms.Label dateinscLABEL;
        private System.Windows.Forms.Label AnnescolaireLABEL;
        private System.Windows.Forms.Label classnomLABEL;
        private System.Windows.Forms.Label telelabel;
        private System.Windows.Forms.Label tuteurNOMLABEL;
        private System.Windows.Forms.Label nomcompletLABEL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton print1;
    }
}