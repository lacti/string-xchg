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
            this.buttonExport = new System.Windows.Forms.Button();
            this.textSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.textExcelPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFromFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkOneSheet = new System.Windows.Forms.CheckBox();
            this.checkCopyTranslated = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "to excel";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(458, 67);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(138, 36);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "export to excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textSourceFolder
            // 
            this.textSourceFolder.AllowDrop = true;
            this.textSourceFolder.Location = new System.Drawing.Point(88, 36);
            this.textSourceFolder.Name = "textSourceFolder";
            this.textSourceFolder.Size = new System.Drawing.Size(508, 25);
            this.textSourceFolder.TabIndex = 1;
            this.textSourceFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textPath_DragDrop);
            this.textSourceFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textPath_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "from excel";
            // 
            // buttonExchange
            // 
            this.buttonExchange.Location = new System.Drawing.Point(458, 86);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(138, 39);
            this.buttonExchange.TabIndex = 4;
            this.buttonExchange.Text = "exchange string";
            this.buttonExchange.UseVisualStyleBackColor = true;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // textExcelPath
            // 
            this.textExcelPath.AllowDrop = true;
            this.textExcelPath.Location = new System.Drawing.Point(88, 55);
            this.textExcelPath.Name = "textExcelPath";
            this.textExcelPath.Size = new System.Drawing.Size(508, 25);
            this.textExcelPath.TabIndex = 3;
            this.textExcelPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textPath_DragDrop);
            this.textExcelPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textPath_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "excel";
            // 
            // textFromFolder
            // 
            this.textFromFolder.AllowDrop = true;
            this.textFromFolder.Location = new System.Drawing.Point(88, 24);
            this.textFromFolder.Name = "textFromFolder";
            this.textFromFolder.Size = new System.Drawing.Size(508, 25);
            this.textFromFolder.TabIndex = 1;
            this.textFromFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textPath_DragDrop);
            this.textFromFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textPath_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "folder";
            // 
            // checkOneSheet
            // 
            this.checkOneSheet.AutoSize = true;
            this.checkOneSheet.Location = new System.Drawing.Point(88, 77);
            this.checkOneSheet.Name = "checkOneSheet";
            this.checkOneSheet.Size = new System.Drawing.Size(95, 19);
            this.checkOneSheet.TabIndex = 3;
            this.checkOneSheet.Text = "one sheet";
            this.checkOneSheet.UseVisualStyleBackColor = true;
            // 
            // checkCopyTranslated
            // 
            this.checkCopyTranslated.AutoSize = true;
            this.checkCopyTranslated.Location = new System.Drawing.Point(206, 77);
            this.checkCopyTranslated.Name = "checkCopyTranslated";
            this.checkCopyTranslated.Size = new System.Drawing.Size(130, 19);
            this.checkCopyTranslated.TabIndex = 3;
            this.checkCopyTranslated.Text = "copy translated";
            this.checkCopyTranslated.UseVisualStyleBackColor = true;
            // 
            // FormExchanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormExchanger";
            this.Text = "Lua ↔ Excel (string)";
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

