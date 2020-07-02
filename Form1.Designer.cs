namespace NorthWind
{
    partial class Form1
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
            this.cmbbxTables = new System.Windows.Forms.ComboBox();
            this.lstbxRows = new System.Windows.Forms.ListBox();
            this.rchbxDetail1 = new System.Windows.Forms.RichTextBox();
            this.rchbxDetail2 = new System.Windows.Forms.RichTextBox();
            this.rchbxDetail3 = new System.Windows.Forms.RichTextBox();
            this.rchbxDetail4 = new System.Windows.Forms.RichTextBox();
            this.lblDetail1 = new System.Windows.Forms.Label();
            this.lblDetail2 = new System.Windows.Forms.Label();
            this.lblDetail3 = new System.Windows.Forms.Label();
            this.lblDetail4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbbxTables
            // 
            this.cmbbxTables.FormattingEnabled = true;
            this.cmbbxTables.Location = new System.Drawing.Point(58, 37);
            this.cmbbxTables.Name = "cmbbxTables";
            this.cmbbxTables.Size = new System.Drawing.Size(260, 21);
            this.cmbbxTables.TabIndex = 9;
            this.cmbbxTables.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lstbxRows
            // 
            this.lstbxRows.FormattingEnabled = true;
            this.lstbxRows.Location = new System.Drawing.Point(38, 93);
            this.lstbxRows.Name = "lstbxRows";
            this.lstbxRows.Size = new System.Drawing.Size(299, 290);
            this.lstbxRows.TabIndex = 12;
            this.lstbxRows.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // rchbxDetail1
            // 
            this.rchbxDetail1.Location = new System.Drawing.Point(361, 104);
            this.rchbxDetail1.Name = "rchbxDetail1";
            this.rchbxDetail1.Size = new System.Drawing.Size(95, 38);
            this.rchbxDetail1.TabIndex = 13;
            this.rchbxDetail1.Text = "v";
            this.rchbxDetail1.Visible = false;
            // 
            // rchbxDetail2
            // 
            this.rchbxDetail2.Location = new System.Drawing.Point(361, 181);
            this.rchbxDetail2.Name = "rchbxDetail2";
            this.rchbxDetail2.Size = new System.Drawing.Size(95, 38);
            this.rchbxDetail2.TabIndex = 14;
            this.rchbxDetail2.Text = "";
            this.rchbxDetail2.Visible = false;
            // 
            // rchbxDetail3
            // 
            this.rchbxDetail3.Location = new System.Drawing.Point(361, 258);
            this.rchbxDetail3.Name = "rchbxDetail3";
            this.rchbxDetail3.Size = new System.Drawing.Size(95, 38);
            this.rchbxDetail3.TabIndex = 15;
            this.rchbxDetail3.Text = "";
            this.rchbxDetail3.Visible = false;
            // 
            // rchbxDetail4
            // 
            this.rchbxDetail4.Location = new System.Drawing.Point(361, 335);
            this.rchbxDetail4.Name = "rchbxDetail4";
            this.rchbxDetail4.Size = new System.Drawing.Size(95, 38);
            this.rchbxDetail4.TabIndex = 16;
            this.rchbxDetail4.Text = "";
            this.rchbxDetail4.Visible = false;
            // 
            // lblDetail1
            // 
            this.lblDetail1.AutoSize = true;
            this.lblDetail1.Location = new System.Drawing.Point(358, 88);
            this.lblDetail1.Name = "lblDetail1";
            this.lblDetail1.Size = new System.Drawing.Size(35, 13);
            this.lblDetail1.TabIndex = 17;
            this.lblDetail1.Text = "label1";
            this.lblDetail1.Visible = false;
            // 
            // lblDetail2
            // 
            this.lblDetail2.AutoSize = true;
            this.lblDetail2.Location = new System.Drawing.Point(358, 165);
            this.lblDetail2.Name = "lblDetail2";
            this.lblDetail2.Size = new System.Drawing.Size(35, 13);
            this.lblDetail2.TabIndex = 18;
            this.lblDetail2.Text = "label2";
            this.lblDetail2.Visible = false;
            // 
            // lblDetail3
            // 
            this.lblDetail3.AutoSize = true;
            this.lblDetail3.Location = new System.Drawing.Point(358, 242);
            this.lblDetail3.Name = "lblDetail3";
            this.lblDetail3.Size = new System.Drawing.Size(35, 13);
            this.lblDetail3.TabIndex = 19;
            this.lblDetail3.Text = "label3";
            this.lblDetail3.Visible = false;
            // 
            // lblDetail4
            // 
            this.lblDetail4.AutoSize = true;
            this.lblDetail4.Location = new System.Drawing.Point(358, 319);
            this.lblDetail4.Name = "lblDetail4";
            this.lblDetail4.Size = new System.Drawing.Size(35, 13);
            this.lblDetail4.TabIndex = 20;
            this.lblDetail4.Text = "label4";
            this.lblDetail4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 399);
            this.Controls.Add(this.lblDetail4);
            this.Controls.Add(this.lblDetail3);
            this.Controls.Add(this.lblDetail2);
            this.Controls.Add(this.lblDetail1);
            this.Controls.Add(this.rchbxDetail4);
            this.Controls.Add(this.rchbxDetail3);
            this.Controls.Add(this.rchbxDetail2);
            this.Controls.Add(this.rchbxDetail1);
            this.Controls.Add(this.lstbxRows);
            this.Controls.Add(this.cmbbxTables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbxTables;
        private System.Windows.Forms.ListBox lstbxRows;
        private System.Windows.Forms.RichTextBox rchbxDetail1;
        private System.Windows.Forms.RichTextBox rchbxDetail2;
        private System.Windows.Forms.RichTextBox rchbxDetail3;
        private System.Windows.Forms.RichTextBox rchbxDetail4;
        private System.Windows.Forms.Label lblDetail1;
        private System.Windows.Forms.Label lblDetail2;
        private System.Windows.Forms.Label lblDetail3;
        private System.Windows.Forms.Label lblDetail4;
    }
}

