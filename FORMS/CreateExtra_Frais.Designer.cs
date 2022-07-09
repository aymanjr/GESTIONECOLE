namespace GESTIONECOLE.FORMS
{
    partial class CreateExtra_Frais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateExtra_Frais));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.combo_type = new Bunifu.Framework.UI.BunifuDropdown();
            this.description_richtext = new System.Windows.Forms.RichTextBox();
            this.txt_cost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_type = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(18, 472);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 33);
            this.label7.TabIndex = 111;
            this.label7.Text = "Cost : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 33);
            this.label5.TabIndex = 110;
            this.label5.Text = "Description : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 33);
            this.label4.TabIndex = 109;
            this.label4.Text = "Frais Type : ";
            // 
            // btnajouter
            // 
            this.btnajouter.Active = true;
            this.btnajouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnajouter.AllowDrop = true;
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnajouter.BorderRadius = 5;
            this.btnajouter.ButtonText = "Ajouter";
            this.btnajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajouter.DisabledColor = System.Drawing.Color.Gray;
            this.btnajouter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnajouter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnajouter.Iconimage")));
            this.btnajouter.Iconimage_right = null;
            this.btnajouter.Iconimage_right_Selected = null;
            this.btnajouter.Iconimage_Selected = null;
            this.btnajouter.IconMarginLeft = 0;
            this.btnajouter.IconMarginRight = 0;
            this.btnajouter.IconRightVisible = false;
            this.btnajouter.IconRightZoom = 0D;
            this.btnajouter.IconVisible = false;
            this.btnajouter.IconZoom = 0D;
            this.btnajouter.IsTab = true;
            this.btnajouter.Location = new System.Drawing.Point(518, 537);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(0);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnajouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnajouter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.btnajouter.selected = true;
            this.btnajouter.Size = new System.Drawing.Size(136, 43);
            this.btnajouter.TabIndex = 112;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnajouter.Textcolor = System.Drawing.Color.Silver;
            this.btnajouter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // combo_type
            // 
            this.combo_type.BackColor = System.Drawing.Color.Transparent;
            this.combo_type.BorderRadius = 3;
            this.combo_type.DisabledColor = System.Drawing.Color.Gray;
            this.combo_type.ForeColor = System.Drawing.Color.Silver;
            this.combo_type.items = new string[] {
        "Other"};
            this.combo_type.Location = new System.Drawing.Point(218, 11);
            this.combo_type.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.combo_type.Name = "combo_type";
            this.combo_type.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.combo_type.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.combo_type.selectedIndex = 0;
            this.combo_type.Size = new System.Drawing.Size(436, 46);
            this.combo_type.TabIndex = 147;
            this.combo_type.onItemSelected += new System.EventHandler(this.combo_type_onItemSelected);
            // 
            // description_richtext
            // 
            this.description_richtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.description_richtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_richtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_richtext.ForeColor = System.Drawing.Color.Silver;
            this.description_richtext.Location = new System.Drawing.Point(24, 223);
            this.description_richtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.description_richtext.Name = "description_richtext";
            this.description_richtext.Size = new System.Drawing.Size(628, 213);
            this.description_richtext.TabIndex = 148;
            this.description_richtext.Text = "";
            // 
            // txt_cost
            // 
            this.txt_cost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_cost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_cost.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_cost.ForeColor = System.Drawing.Color.Silver;
            this.txt_cost.HintForeColor = System.Drawing.Color.Silver;
            this.txt_cost.HintText = "";
            this.txt_cost.isPassword = false;
            this.txt_cost.LineFocusedColor = System.Drawing.Color.Silver;
            this.txt_cost.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.txt_cost.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txt_cost.LineThickness = 4;
            this.txt_cost.Location = new System.Drawing.Point(132, 460);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cost.MaxLength = 32767;
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(522, 57);
            this.txt_cost.TabIndex = 149;
            this.txt_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cost.OnValueChanged += new System.EventHandler(this.txt_cost_OnValueChanged);
            this.txt_cost.Click += new System.EventHandler(this.txt_cost_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_type);
            this.panel1.Location = new System.Drawing.Point(111, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 78);
            this.panel1.TabIndex = 150;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 151;
            this.label1.Text = "Autre Type : ";
            // 
            // txt_type
            // 
            this.txt_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_type.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_type.ForeColor = System.Drawing.Color.Silver;
            this.txt_type.HintForeColor = System.Drawing.Color.Empty;
            this.txt_type.HintText = "";
            this.txt_type.isPassword = false;
            this.txt_type.LineFocusedColor = System.Drawing.Color.Silver;
            this.txt_type.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.txt_type.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txt_type.LineThickness = 4;
            this.txt_type.Location = new System.Drawing.Point(165, 15);
            this.txt_type.Margin = new System.Windows.Forms.Padding(6);
            this.txt_type.MaxLength = 32767;
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(300, 51);
            this.txt_type.TabIndex = 151;
            this.txt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = true;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Return";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(9, 537);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(135, 52);
            this.bunifuFlatButton1.TabIndex = 151;
            this.bunifuFlatButton1.Text = "Return";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // CreateExtra_Frais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(672, 600);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.description_richtext);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateExtra_Frais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateExtra_Frais";
            this.Load += new System.EventHandler(this.CreateExtra_Frais_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnajouter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown combo_type;
        private System.Windows.Forms.RichTextBox description_richtext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cost;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_type;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}