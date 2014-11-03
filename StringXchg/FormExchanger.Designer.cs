namespace StringXchg
{
    partial class FormExchanger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCopyTranslated = new System.Windows.Forms.CheckBox();
            this.checkOneSheet = new System.Windows.Forms.CheckBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.textExcelPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFromFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCopyTranslated);
            this.groupBox1.Controls.Add(this.checkOneSheet);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.textSourceFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(539, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "to excel";
            // 
            // checkCopyTranslated
            // 
            this.checkCopyTranslated.AutoSize = true;
            this.checkCopyTranslated.Location = new System.Drawing.Point(180, 62);
            this.checkCopyTranslated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCopyTranslated.Name = "checkCopyTranslated";
            this.checkCopyTranslated.Size = new System.Drawing.Size(111, 16);
            this.checkCopyTranslated.TabIndex = 3;
            this.checkCopyTranslated.Text = "copy translated";
            this.checkCopyTranslated.UseVisualStyleBackColor = true;
            // 
            // checkOneSheet
            // 
            this.checkOneSheet.AutoSize = true;
            this.checkOneSheet.Location = new System.Drawing.Point(77, 62);
            this.checkOneSheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkOneSheet.Name = "checkOneSheet";
            this.checkOneSheet.Size = new System.Drawing.Size(80, 16);
            this.checkOneSheet.TabIndex = 3;
            this.checkOneSheet.Text = "one sheet";
            this.checkOneSheet.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(401, 54);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(121, 29);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "export to excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textSourceFolder
            // 
            this.textSourceFolder.AllowDrop = true;
            this.textSourceFolder.Location = new System.Drawing.Point(77, 29);
            this.textSourceFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSourceFolder.Name = "textSourceFolder";
            this.textSourceFolder.Size = new System.Drawing.Size(445, 21);
            this.textSourceFolder.TabIndex = 1;
            this.textSourceFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textPath_DragDrop);
            this.textSourceFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textPath_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExchange);
            this.groupBox2.Controls.Add(this.textExcelPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textFromFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(539, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "from excel";
            // 
            // buttonExchange
            // 
            this.buttonExchange.Location = new System.Drawing.Point(401, 69);
            this.buttonExchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(121, 31);
            this.buttonExchange.TabIndex = 4;
            this.buttonExchange.Text = "exchange string";
            this.buttonExchange.UseVisualStyleBackColor = true;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // textExcelPath
            // 
            this.textExcelPath.AllowDrop = true;
            this.textExcelPath.Location = new System.Drawing.Point(77, 44);
            this.textExcelPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textExcelPath.Name = "textExcelPath";
            this.textExcelPath.Size = new System.Drawing.Size(445, 21);
            this.textExcelPath.TabIndex = 3;
            this.textExcelPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textPath_DragDrop);
            this.textExcelPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textPath_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "excel";
            // 
            // textFromFolder
            // 
            this.textFromFolder.AllowDrop = true;
            this.textFromFolder.Location = new System.Drawing.Point(77, 19);
            this.textFromFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFromFolder.Name = "textFromFolder";
            this.textFromFolder.Size = new System.Drawing.Size(445, 21);
            this.textFromFolder.TabIndex = 1;
            this.textFromFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textPath_DragDrop);
            this.textFromFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textPath_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "folder";
            // 
            // FormExchanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 226);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormExchanger";
            this.Text = "Lua ↔ Excel (string)";
            this.Load += new System.EventHandler(this.FormExchanger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textSourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExchange;
        private System.Windows.Forms.TextBox textExcelPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFromFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkCopyTranslated;
        private System.Windows.Forms.CheckBox checkOneSheet;
    }
}

