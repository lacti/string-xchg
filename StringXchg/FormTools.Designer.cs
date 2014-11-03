namespace StringXchg
{
    partial class FormTools
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExchange = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExcelPathBrowse = new System.Windows.Forms.Button();
            this.buttonFromFolderBrowse = new System.Windows.Forms.Button();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.textExcelPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFromFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSourceFolderBrowse = new System.Windows.Forms.Button();
            this.checkCopyTranslated = new System.Windows.Forms.CheckBox();
            this.checkOneSheet = new System.Windows.Forms.CheckBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSubstitution = new System.Windows.Forms.TabPage();
            this.buttonSubstitution = new System.Windows.Forms.Button();
            this.groupTarget = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTargetPathFinder = new System.Windows.Forms.Button();
            this.textTargetTCol = new System.Windows.Forms.TextBox();
            this.textTargetSCol = new System.Windows.Forms.TextBox();
            this.textTargetPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupRef = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRefPathFinder = new System.Windows.Forms.Button();
            this.textRefTCol = new System.Windows.Forms.TextBox();
            this.textRefSCol = new System.Windows.Forms.TextBox();
            this.textRefPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.tabReference = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonBuildSourcePathBrowse = new System.Windows.Forms.Button();
            this.textBuildRefTCol = new System.Windows.Forms.TextBox();
            this.textBuildRefSCol = new System.Windows.Forms.TextBox();
            this.textBuildSourcePath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonBuildReference = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabExchange.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSubstitution.SuspendLayout();
            this.groupTarget.SuspendLayout();
            this.groupRef.SuspendLayout();
            this.tabReference.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabExchange);
            this.tabControl1.Controls.Add(this.tabSubstitution);
            this.tabControl1.Controls.Add(this.tabReference);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 374);
            this.tabControl1.TabIndex = 2;
            // 
            // tabExchange
            // 
            this.tabExchange.Controls.Add(this.groupBox2);
            this.tabExchange.Controls.Add(this.groupBox1);
            this.tabExchange.Location = new System.Drawing.Point(4, 25);
            this.tabExchange.Name = "tabExchange";
            this.tabExchange.Size = new System.Drawing.Size(781, 345);
            this.tabExchange.TabIndex = 1;
            this.tabExchange.Text = "String Exchange (Lua)";
            this.tabExchange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExcelPathBrowse);
            this.groupBox2.Controls.Add(this.buttonFromFolderBrowse);
            this.groupBox2.Controls.Add(this.buttonExchange);
            this.groupBox2.Controls.Add(this.textExcelPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textFromFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(749, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel to Lua";
            // 
            // buttonExcelPathBrowse
            // 
            this.buttonExcelPathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcelPathBrowse.Location = new System.Drawing.Point(688, 58);
            this.buttonExcelPathBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExcelPathBrowse.Name = "buttonExcelPathBrowse";
            this.buttonExcelPathBrowse.Size = new System.Drawing.Size(48, 29);
            this.buttonExcelPathBrowse.TabIndex = 6;
            this.buttonExcelPathBrowse.Text = "...";
            this.buttonExcelPathBrowse.UseVisualStyleBackColor = true;
            this.buttonExcelPathBrowse.Click += new System.EventHandler(this.buttonExcelPathBrowse_Click);
            // 
            // buttonFromFolderBrowse
            // 
            this.buttonFromFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFromFolderBrowse.Location = new System.Drawing.Point(688, 24);
            this.buttonFromFolderBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFromFolderBrowse.Name = "buttonFromFolderBrowse";
            this.buttonFromFolderBrowse.Size = new System.Drawing.Size(48, 29);
            this.buttonFromFolderBrowse.TabIndex = 5;
            this.buttonFromFolderBrowse.Text = "...";
            this.buttonFromFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonFromFolderBrowse.Click += new System.EventHandler(this.buttonFromFolderBrowse_Click);
            // 
            // buttonExchange
            // 
            this.buttonExchange.Location = new System.Drawing.Point(598, 100);
            this.buttonExchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(138, 39);
            this.buttonExchange.TabIndex = 4;
            this.buttonExchange.Text = "Make &Lua";
            this.buttonExchange.UseVisualStyleBackColor = true;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // textExcelPath
            // 
            this.textExcelPath.AllowDrop = true;
            this.textExcelPath.Location = new System.Drawing.Point(101, 62);
            this.textExcelPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textExcelPath.Name = "textExcelPath";
            this.textExcelPath.Size = new System.Drawing.Size(571, 25);
            this.textExcelPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Excel File";
            // 
            // textFromFolder
            // 
            this.textFromFolder.AllowDrop = true;
            this.textFromFolder.Location = new System.Drawing.Point(101, 28);
            this.textFromFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFromFolder.Name = "textFromFolder";
            this.textFromFolder.Size = new System.Drawing.Size(571, 25);
            this.textFromFolder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lua Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSourceFolderBrowse);
            this.groupBox1.Controls.Add(this.checkCopyTranslated);
            this.groupBox1.Controls.Add(this.checkOneSheet);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.textSourceFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(749, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lua to Excel";
            // 
            // buttonSourceFolderBrowse
            // 
            this.buttonSourceFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSourceFolderBrowse.Location = new System.Drawing.Point(688, 32);
            this.buttonSourceFolderBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSourceFolderBrowse.Name = "buttonSourceFolderBrowse";
            this.buttonSourceFolderBrowse.Size = new System.Drawing.Size(48, 29);
            this.buttonSourceFolderBrowse.TabIndex = 4;
            this.buttonSourceFolderBrowse.Text = "...";
            this.buttonSourceFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonSourceFolderBrowse.Click += new System.EventHandler(this.buttonSourceFolderBrowse_Click);
            // 
            // checkCopyTranslated
            // 
            this.checkCopyTranslated.AutoSize = true;
            this.checkCopyTranslated.Location = new System.Drawing.Point(244, 78);
            this.checkCopyTranslated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCopyTranslated.Name = "checkCopyTranslated";
            this.checkCopyTranslated.Size = new System.Drawing.Size(130, 19);
            this.checkCopyTranslated.TabIndex = 3;
            this.checkCopyTranslated.Text = "copy translated";
            this.checkCopyTranslated.UseVisualStyleBackColor = true;
            // 
            // checkOneSheet
            // 
            this.checkOneSheet.AutoSize = true;
            this.checkOneSheet.Location = new System.Drawing.Point(101, 78);
            this.checkOneSheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkOneSheet.Name = "checkOneSheet";
            this.checkOneSheet.Size = new System.Drawing.Size(95, 19);
            this.checkOneSheet.TabIndex = 3;
            this.checkOneSheet.Text = "one sheet";
            this.checkOneSheet.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(598, 85);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(138, 36);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Make E&xcel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textSourceFolder
            // 
            this.textSourceFolder.AllowDrop = true;
            this.textSourceFolder.Location = new System.Drawing.Point(101, 36);
            this.textSourceFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSourceFolder.Name = "textSourceFolder";
            this.textSourceFolder.Size = new System.Drawing.Size(571, 25);
            this.textSourceFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lua Folder";
            // 
            // tabSubstitution
            // 
            this.tabSubstitution.Controls.Add(this.buttonSubstitution);
            this.tabSubstitution.Controls.Add(this.groupTarget);
            this.tabSubstitution.Controls.Add(this.groupRef);
            this.tabSubstitution.Location = new System.Drawing.Point(4, 25);
            this.tabSubstitution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSubstitution.Name = "tabSubstitution";
            this.tabSubstitution.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSubstitution.Size = new System.Drawing.Size(781, 345);
            this.tabSubstitution.TabIndex = 0;
            this.tabSubstitution.Text = "Auto substitution";
            this.tabSubstitution.UseVisualStyleBackColor = true;
            // 
            // buttonSubstitution
            // 
            this.buttonSubstitution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubstitution.Location = new System.Drawing.Point(645, 304);
            this.buttonSubstitution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSubstitution.Name = "buttonSubstitution";
            this.buttonSubstitution.Size = new System.Drawing.Size(121, 29);
            this.buttonSubstitution.TabIndex = 2;
            this.buttonSubstitution.Text = "&Substitution";
            this.buttonSubstitution.UseVisualStyleBackColor = true;
            this.buttonSubstitution.Click += new System.EventHandler(this.buttonSubstitution_Click);
            // 
            // groupTarget
            // 
            this.groupTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTarget.Controls.Add(this.label4);
            this.groupTarget.Controls.Add(this.label5);
            this.groupTarget.Controls.Add(this.buttonTargetPathFinder);
            this.groupTarget.Controls.Add(this.textTargetTCol);
            this.groupTarget.Controls.Add(this.textTargetSCol);
            this.groupTarget.Controls.Add(this.textTargetPath);
            this.groupTarget.Controls.Add(this.label6);
            this.groupTarget.Location = new System.Drawing.Point(15, 160);
            this.groupTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupTarget.Name = "groupTarget";
            this.groupTarget.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupTarget.Size = new System.Drawing.Size(751, 132);
            this.groupTarget.TabIndex = 1;
            this.groupTarget.TabStop = false;
            this.groupTarget.Text = "Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Translated Column";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Source Column";
            // 
            // buttonTargetPathFinder
            // 
            this.buttonTargetPathFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetPathFinder.Location = new System.Drawing.Point(688, 34);
            this.buttonTargetPathFinder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTargetPathFinder.Name = "buttonTargetPathFinder";
            this.buttonTargetPathFinder.Size = new System.Drawing.Size(48, 29);
            this.buttonTargetPathFinder.TabIndex = 2;
            this.buttonTargetPathFinder.Text = "...";
            this.buttonTargetPathFinder.UseVisualStyleBackColor = true;
            this.buttonTargetPathFinder.Click += new System.EventHandler(this.buttonTargetPathFinder_Click);
            // 
            // textTargetTCol
            // 
            this.textTargetTCol.Location = new System.Drawing.Point(419, 84);
            this.textTargetTCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTargetTCol.Name = "textTargetTCol";
            this.textTargetTCol.Size = new System.Drawing.Size(121, 25);
            this.textTargetTCol.TabIndex = 6;
            this.textTargetTCol.Text = "C";
            // 
            // textTargetSCol
            // 
            this.textTargetSCol.Location = new System.Drawing.Point(138, 84);
            this.textTargetSCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTargetSCol.Name = "textTargetSCol";
            this.textTargetSCol.Size = new System.Drawing.Size(121, 25);
            this.textTargetSCol.TabIndex = 4;
            this.textTargetSCol.Text = "B";
            // 
            // textTargetPath
            // 
            this.textTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTargetPath.Location = new System.Drawing.Point(66, 36);
            this.textTargetPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTargetPath.Name = "textTargetPath";
            this.textTargetPath.Size = new System.Drawing.Size(614, 25);
            this.textTargetPath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Path";
            // 
            // groupRef
            // 
            this.groupRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRef.Controls.Add(this.label7);
            this.groupRef.Controls.Add(this.label8);
            this.groupRef.Controls.Add(this.buttonRefPathFinder);
            this.groupRef.Controls.Add(this.textRefTCol);
            this.groupRef.Controls.Add(this.textRefSCol);
            this.groupRef.Controls.Add(this.textRefPath);
            this.groupRef.Controls.Add(this.label9);
            this.groupRef.Location = new System.Drawing.Point(15, 16);
            this.groupRef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupRef.Name = "groupRef";
            this.groupRef.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupRef.Size = new System.Drawing.Size(751, 136);
            this.groupRef.TabIndex = 0;
            this.groupRef.TabStop = false;
            this.groupRef.Text = "Reference";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Translated Column";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Source Column";
            // 
            // buttonRefPathFinder
            // 
            this.buttonRefPathFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefPathFinder.Location = new System.Drawing.Point(688, 31);
            this.buttonRefPathFinder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRefPathFinder.Name = "buttonRefPathFinder";
            this.buttonRefPathFinder.Size = new System.Drawing.Size(48, 29);
            this.buttonRefPathFinder.TabIndex = 2;
            this.buttonRefPathFinder.Text = "...";
            this.buttonRefPathFinder.UseVisualStyleBackColor = true;
            this.buttonRefPathFinder.Click += new System.EventHandler(this.buttonRefPathFinder_Click);
            // 
            // textRefTCol
            // 
            this.textRefTCol.Location = new System.Drawing.Point(419, 81);
            this.textRefTCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRefTCol.Name = "textRefTCol";
            this.textRefTCol.Size = new System.Drawing.Size(121, 25);
            this.textRefTCol.TabIndex = 6;
            this.textRefTCol.Text = "C";
            // 
            // textRefSCol
            // 
            this.textRefSCol.Location = new System.Drawing.Point(138, 81);
            this.textRefSCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRefSCol.Name = "textRefSCol";
            this.textRefSCol.Size = new System.Drawing.Size(121, 25);
            this.textRefSCol.TabIndex = 4;
            this.textRefSCol.Text = "B";
            // 
            // textRefPath
            // 
            this.textRefPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRefPath.Location = new System.Drawing.Point(66, 34);
            this.textRefPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRefPath.Name = "textRefPath";
            this.textRefPath.Size = new System.Drawing.Size(614, 25);
            this.textRefPath.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Path";
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.BackColor = System.Drawing.SystemColors.Info;
            this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLog.Location = new System.Drawing.Point(12, 391);
            this.textLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(785, 257);
            this.textLog.TabIndex = 4;
            this.textLog.Text = "";
            // 
            // tabReference
            // 
            this.tabReference.Controls.Add(this.buttonBuildReference);
            this.tabReference.Controls.Add(this.groupBox3);
            this.tabReference.Location = new System.Drawing.Point(4, 25);
            this.tabReference.Name = "tabReference";
            this.tabReference.Size = new System.Drawing.Size(781, 345);
            this.tabReference.TabIndex = 2;
            this.tabReference.Text = "Build Reference";
            this.tabReference.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.buttonBuildSourcePathBrowse);
            this.groupBox3.Controls.Add(this.textBuildRefTCol);
            this.groupBox3.Controls.Add(this.textBuildRefSCol);
            this.groupBox3.Controls.Add(this.textBuildSourcePath);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(15, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(751, 136);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reference";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Translated Column";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Source Column";
            // 
            // buttonBuildSourcePathBrowse
            // 
            this.buttonBuildSourcePathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildSourcePathBrowse.Location = new System.Drawing.Point(688, 31);
            this.buttonBuildSourcePathBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuildSourcePathBrowse.Name = "buttonBuildSourcePathBrowse";
            this.buttonBuildSourcePathBrowse.Size = new System.Drawing.Size(48, 29);
            this.buttonBuildSourcePathBrowse.TabIndex = 2;
            this.buttonBuildSourcePathBrowse.Text = "...";
            this.buttonBuildSourcePathBrowse.UseVisualStyleBackColor = true;
            this.buttonBuildSourcePathBrowse.Click += new System.EventHandler(this.buttonBuildSourcePathBrowse_Click);
            // 
            // textBuildRefTCol
            // 
            this.textBuildRefTCol.Location = new System.Drawing.Point(419, 81);
            this.textBuildRefTCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBuildRefTCol.Name = "textBuildRefTCol";
            this.textBuildRefTCol.Size = new System.Drawing.Size(121, 25);
            this.textBuildRefTCol.TabIndex = 6;
            this.textBuildRefTCol.Text = "C";
            // 
            // textBuildRefSCol
            // 
            this.textBuildRefSCol.Location = new System.Drawing.Point(138, 81);
            this.textBuildRefSCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBuildRefSCol.Name = "textBuildRefSCol";
            this.textBuildRefSCol.Size = new System.Drawing.Size(121, 25);
            this.textBuildRefSCol.TabIndex = 4;
            this.textBuildRefSCol.Text = "B";
            // 
            // textBuildSourcePath
            // 
            this.textBuildSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBuildSourcePath.Location = new System.Drawing.Point(66, 34);
            this.textBuildSourcePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBuildSourcePath.Name = "textBuildSourcePath";
            this.textBuildSourcePath.Size = new System.Drawing.Size(614, 25);
            this.textBuildSourcePath.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Path";
            // 
            // buttonBuildReference
            // 
            this.buttonBuildReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildReference.Location = new System.Drawing.Point(604, 304);
            this.buttonBuildReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuildReference.Name = "buttonBuildReference";
            this.buttonBuildReference.Size = new System.Drawing.Size(162, 29);
            this.buttonBuildReference.TabIndex = 3;
            this.buttonBuildReference.Text = "&Build Reference";
            this.buttonBuildReference.UseVisualStyleBackColor = true;
            this.buttonBuildReference.Click += new System.EventHandler(this.buttonBuildReference_Click);
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 661);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTools";
            this.Text = "String Tools";
            this.Load += new System.EventHandler(this.FormExchanger_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabExchange.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSubstitution.ResumeLayout(false);
            this.groupTarget.ResumeLayout(false);
            this.groupTarget.PerformLayout();
            this.groupRef.ResumeLayout(false);
            this.groupRef.PerformLayout();
            this.tabReference.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExchange;
        private System.Windows.Forms.TabPage tabSubstitution;
        private System.Windows.Forms.Button buttonSubstitution;
        private System.Windows.Forms.GroupBox groupTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTargetPathFinder;
        private System.Windows.Forms.TextBox textTargetTCol;
        private System.Windows.Forms.TextBox textTargetSCol;
        private System.Windows.Forms.TextBox textTargetPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRefPathFinder;
        private System.Windows.Forms.TextBox textRefTCol;
        private System.Windows.Forms.TextBox textRefSCol;
        private System.Windows.Forms.TextBox textRefPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExchange;
        private System.Windows.Forms.TextBox textExcelPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFromFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkCopyTranslated;
        private System.Windows.Forms.CheckBox checkOneSheet;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textSourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.Button buttonExcelPathBrowse;
        private System.Windows.Forms.Button buttonFromFolderBrowse;
        private System.Windows.Forms.Button buttonSourceFolderBrowse;
        private System.Windows.Forms.TabPage tabReference;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBuildSourcePathBrowse;
        private System.Windows.Forms.TextBox textBuildRefTCol;
        private System.Windows.Forms.TextBox textBuildRefSCol;
        private System.Windows.Forms.TextBox textBuildSourcePath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBuildReference;
    }
}

