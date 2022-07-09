namespace GESTIONECOLE.FORMS
{
    partial class Print_FraisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_FraisForm));
            this.panelprint = new System.Windows.Forms.Panel();
            this.datetimelabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.costlabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.datefraislabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Printbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelprint
            // 
            this.panelprint.BackColor = System.Drawing.Color.White;
            this.panelprint.Controls.Add(this.Printbutton);
            this.panelprint.Controls.Add(this.datetimelabel);
            this.panelprint.Controls.Add(this.label18);
            this.panelprint.Controls.Add(this.label17);
            this.panelprint.Controls.Add(this.costlabel);
            this.panelprint.Controls.Add(this.label16);
            this.panelprint.Controls.Add(this.label14);
            this.panelprint.Controls.Add(this.datefraislabel);
            this.panelprint.Controls.Add(this.descriptionlabel);
            this.panelprint.Controls.Add(this.typelabel);
            this.panelprint.Controls.Add(this.label11);
            this.panelprint.Controls.Add(this.label12);
            this.panelprint.Controls.Add(this.label13);
            this.panelprint.Controls.Add(this.label5);
            this.panelprint.Controls.Add(this.label6);
            this.panelprint.Controls.Add(this.label7);
            this.panelprint.Controls.Add(this.label4);
            this.panelprint.Controls.Add(this.label3);
            this.panelprint.Controls.Add(this.label2);
            this.panelprint.Controls.Add(this.label1);
            this.panelprint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelprint.Location = new System.Drawing.Point(0, -9);
            this.panelprint.Name = "panelprint";
            this.panelprint.Size = new System.Drawing.Size(635, 574);
            this.panelprint.TabIndex = 0;
            this.panelprint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprint_Paint);
            // 
            // datetimelabel
            // 
            this.datetimelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetimelabel.AutoSize = true;
            this.datetimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimelabel.Location = new System.Drawing.Point(-129, 33);
            this.datetimelabel.Name = "datetimelabel";
            this.datetimelabel.Size = new System.Drawing.Size(17, 18);
            this.datetimelabel.TabIndex = 20;
            this.datetimelabel.Text = "?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(424, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "_________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(424, 424);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "SIGNATURE:";
            // 
            // costlabel
            // 
            this.costlabel.AutoSize = true;
            this.costlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costlabel.Location = new System.Drawing.Point(229, 224);
            this.costlabel.Name = "costlabel";
            this.costlabel.Size = new System.Drawing.Size(14, 16);
            this.costlabel.TabIndex = 17;
            this.costlabel.Text = "?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Cout :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 29);
            this.label14.TabIndex = 15;
            this.label14.Text = "Les Charges";
            // 
            // datefraislabel
            // 
            this.datefraislabel.AutoSize = true;
            this.datefraislabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefraislabel.Location = new System.Drawing.Point(229, 270);
            this.datefraislabel.Name = "datefraislabel";
            this.datefraislabel.Size = new System.Drawing.Size(14, 16);
            this.datefraislabel.TabIndex = 13;
            this.datefraislabel.Text = "?";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.Location = new System.Drawing.Point(229, 318);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(14, 16);
            this.descriptionlabel.TabIndex = 12;
            this.descriptionlabel.Text = "?";
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelabel.Location = new System.Drawing.Point(229, 177);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(14, 16);
            this.typelabel.TabIndex = 11;
            this.typelabel.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Date : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Description :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "MOHAMMEDIA  RUE 12 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "SCHOOL_TEST@GMAIL.COM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "+21252123123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADRESS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "EMAIL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TELE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Systeme scolaire";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Printbutton
            // 
            this.Printbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Printbutton.BackColor = System.Drawing.Color.Transparent;
            this.Printbutton.Image = global::GESTIONECOLE.Properties.Resources.printicon;
            this.Printbutton.ImageActive = null;
            this.Printbutton.Location = new System.Drawing.Point(595, 21);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(37, 34);
            this.Printbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Printbutton.TabIndex = 159;
            this.Printbutton.TabStop = false;
            this.Printbutton.Zoom = 10;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            this.Printbutton.MouseHover += new System.EventHandler(this.Printbutton_MouseHover);
            // 
            // Print_FraisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 565);
            this.Controls.Add(this.panelprint);
            this.Name = "Print_FraisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_FraisForm";
            this.Load += new System.EventHandler(this.Print_FraisForm_Load);
            this.panelprint.ResumeLayout(false);
            this.panelprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelprint;
        private Bunifu.Framework.UI.BunifuImageButton Printbutton;
        private System.Windows.Forms.Label datefraislabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label costlabel;
        private System.Windows.Forms.Label label16;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label datetimelabel;
    }
}