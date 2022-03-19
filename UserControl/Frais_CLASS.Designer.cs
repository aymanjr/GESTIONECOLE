namespace GESTIONECOLE.FORMS
{
    partial class Frais_CLASS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frais_CLASS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifierBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_cost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datagridviewclass = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_year = new Bunifu.Framework.UI.BunifuDropdown();
            this.refresh_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(139, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 135;
            this.label4.Text = "Class Frais";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ModifierBtn);
            this.groupBox1.Controls.Add(this.txt_cost);
            this.groupBox1.Location = new System.Drawing.Point(453, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 182);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 143;
            this.label2.Text = "Cost : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Active = true;
            this.ModifierBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ModifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ModifierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModifierBtn.BorderRadius = 5;
            this.ModifierBtn.ButtonText = "Modifier Frais";
            this.ModifierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifierBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ModifierBtn.Iconcolor = System.Drawing.Color.Silver;
            this.ModifierBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ModifierBtn.Iconimage")));
            this.ModifierBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("ModifierBtn.Iconimage_right")));
            this.ModifierBtn.Iconimage_right_Selected = null;
            this.ModifierBtn.Iconimage_Selected = null;
            this.ModifierBtn.IconMarginLeft = 0;
            this.ModifierBtn.IconMarginRight = 0;
            this.ModifierBtn.IconRightVisible = false;
            this.ModifierBtn.IconRightZoom = 0D;
            this.ModifierBtn.IconVisible = false;
            this.ModifierBtn.IconZoom = 0D;
            this.ModifierBtn.IsTab = true;
            this.ModifierBtn.Location = new System.Drawing.Point(102, 138);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ModifierBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ModifierBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.ModifierBtn.selected = true;
            this.ModifierBtn.Size = new System.Drawing.Size(153, 28);
            this.ModifierBtn.TabIndex = 143;
            this.ModifierBtn.Text = "Modifier Frais";
            this.ModifierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModifierBtn.Textcolor = System.Drawing.Color.Silver;
            this.ModifierBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // txt_cost
            // 
            this.txt_cost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_cost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_cost.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cost.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_cost.ForeColor = System.Drawing.Color.Silver;
            this.txt_cost.HintForeColor = System.Drawing.Color.Silver;
            this.txt_cost.HintText = "";
            this.txt_cost.isPassword = false;
            this.txt_cost.LineFocusedColor = System.Drawing.Color.Silver;
            this.txt_cost.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_cost.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txt_cost.LineThickness = 4;
            this.txt_cost.Location = new System.Drawing.Point(102, 47);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cost.MaxLength = 32767;
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(131, 37);
            this.txt_cost.TabIndex = 140;
            this.txt_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datagridviewclass
            // 
            this.datagridviewclass.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.datagridviewclass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewclass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridviewclass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.datagridviewclass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewclass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewclass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridviewclass.ColumnHeadersHeight = 30;
            this.datagridviewclass.DoubleBuffered = true;
            this.datagridviewclass.EnableHeadersVisualStyles = false;
            this.datagridviewclass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.datagridviewclass.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.datagridviewclass.HeaderForeColor = System.Drawing.Color.Silver;
            this.datagridviewclass.Location = new System.Drawing.Point(14, 124);
            this.datagridviewclass.Name = "datagridviewclass";
            this.datagridviewclass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewclass.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridviewclass.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.datagridviewclass.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewclass.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.datagridviewclass.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datagridviewclass.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.datagridviewclass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewclass.Size = new System.Drawing.Size(394, 241);
            this.datagridviewclass.TabIndex = 142;
            this.datagridviewclass.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewclass_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(30, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 147;
            this.label3.Text = "Annee :";
            // 
            // combo_year
            // 
            this.combo_year.BackColor = System.Drawing.Color.Transparent;
            this.combo_year.BorderRadius = 3;
            this.combo_year.DisabledColor = System.Drawing.Color.Gray;
            this.combo_year.ForeColor = System.Drawing.Color.Silver;
            this.combo_year.items = new string[0];
            this.combo_year.Location = new System.Drawing.Point(125, 62);
            this.combo_year.Name = "combo_year";
            this.combo_year.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.combo_year.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.combo_year.selectedIndex = -1;
            this.combo_year.Size = new System.Drawing.Size(211, 30);
            this.combo_year.TabIndex = 146;
            this.combo_year.onItemSelected += new System.EventHandler(this.combo_year_onItemSelected);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.ImageActive = null;
            this.refresh_btn.Location = new System.Drawing.Point(371, 62);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(37, 30);
            this.refresh_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh_btn.TabIndex = 148;
            this.refresh_btn.TabStop = false;
            this.refresh_btn.Zoom = 10;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Frais_CLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridviewclass);
            this.Controls.Add(this.label4);
            this.Name = "Frais_CLASS";
            this.Size = new System.Drawing.Size(726, 387);
            this.Load += new System.EventHandler(this.Frais_CLASS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton ModifierBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cost;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewclass;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown combo_year;
        private Bunifu.Framework.UI.BunifuImageButton refresh_btn;
    }
}
