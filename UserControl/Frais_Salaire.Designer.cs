namespace GESTIONECOLE.FORMS
{
    partial class Frais_Salaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frais_Salaire));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ModifierBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datagridviewsalaire = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewsalaire)).BeginInit();
            this.SuspendLayout();
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
            this.ModifierBtn.Location = new System.Drawing.Point(437, 545);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ModifierBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ModifierBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(121)))));
            this.ModifierBtn.selected = true;
            this.ModifierBtn.Size = new System.Drawing.Size(230, 43);
            this.ModifierBtn.TabIndex = 144;
            this.ModifierBtn.Text = "Modifier Frais";
            this.ModifierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModifierBtn.Textcolor = System.Drawing.Color.Silver;
            this.ModifierBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // datagridviewsalaire
            // 
            this.datagridviewsalaire.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.datagridviewsalaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewsalaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridviewsalaire.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.datagridviewsalaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewsalaire.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewsalaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewsalaire.ColumnHeadersHeight = 30;
            this.datagridviewsalaire.DoubleBuffered = true;
            this.datagridviewsalaire.EnableHeadersVisualStyles = false;
            this.datagridviewsalaire.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.datagridviewsalaire.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.datagridviewsalaire.HeaderForeColor = System.Drawing.Color.Silver;
            this.datagridviewsalaire.Location = new System.Drawing.Point(48, 97);
            this.datagridviewsalaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridviewsalaire.Name = "datagridviewsalaire";
            this.datagridviewsalaire.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewsalaire.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewsalaire.RowHeadersWidth = 62;
            this.datagridviewsalaire.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.datagridviewsalaire.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewsalaire.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.datagridviewsalaire.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datagridviewsalaire.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.datagridviewsalaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewsalaire.Size = new System.Drawing.Size(978, 415);
            this.datagridviewsalaire.TabIndex = 143;
            this.datagridviewsalaire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewsalaire_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(444, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 37);
            this.label4.TabIndex = 142;
            this.label4.Text = "Salaire Frais";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frais_Salaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.datagridviewsalaire);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frais_Salaire";
            this.Size = new System.Drawing.Size(1089, 623);
            this.Load += new System.EventHandler(this.Frais_Salaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewsalaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton ModifierBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewsalaire;
        private System.Windows.Forms.Label label4;
    }
}
