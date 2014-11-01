namespace DraftHelper
{
    partial class FormDraftHelper
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupRef = new System.Windows.Forms.GroupBox();
            this.groupTarget = new System.Windows.Forms.GroupBox();
            this.buttonSubstitution = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textRefPath = new System.Windows.Forms.TextBox();
            this.buttonRefPathFinder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textRefSCol = new System.Windows.Forms.TextBox();
            this.textRefTCol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTargetPathFinder = new System.Windows.Forms.Button();
            this.textTargetTCol = new System.Windows.Forms.TextBox();
            this.textTargetSCol = new System.Windows.Forms.TextBox();
            this.textTargetPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundSubstitutor = new System.ComponentModel.BackgroundWorker();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupRef.SuspendLayout();
            this.groupTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textLog);
            this.tabPage1.Controls.Add(this.buttonSubstitution);
            this.tabPage1.Controls.Add(this.groupTarget);
            this.tabPage1.Controls.Add(this.groupRef);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto substitution";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // groupRef
            // 
            this.groupRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRef.Controls.Add(this.label3);
            this.groupRef.Controls.Add(this.label2);
            this.groupRef.Controls.Add(this.buttonRefPathFinder);
            this.groupRef.Controls.Add(this.textRefTCol);
            this.groupRef.Controls.Add(this.textRefSCol);
            this.groupRef.Controls.Add(this.textRefPath);
            this.groupRef.Controls.Add(this.label1);
            this.groupRef.Location = new System.Drawing.Point(13, 13);
            this.groupRef.Name = "groupRef";
            this.groupRef.Size = new System.Drawing.Size(671, 109);
            this.groupRef.TabIndex = 0;
            this.groupRef.TabStop = false;
            this.groupRef.Text = "Reference";
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
            this.groupTarget.Location = new System.Drawing.Point(13, 128);
            this.groupTarget.Name = "groupTarget";
            this.groupTarget.Size = new System.Drawing.Size(671, 106);
            this.groupTarget.TabIndex = 1;
            this.groupTarget.TabStop = false;
            this.groupTarget.Text = "Target";
            // 
            // buttonSubstitution
            // 
            this.buttonSubstitution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubstitution.Location = new System.Drawing.Point(578, 243);
            this.buttonSubstitution.Name = "buttonSubstitution";
            this.buttonSubstitution.Size = new System.Drawing.Size(106, 23);
            this.buttonSubstitution.TabIndex = 2;
            this.buttonSubstitution.Text = "&Substitution";
            this.buttonSubstitution.UseVisualStyleBackColor = true;
            this.buttonSubstitution.Click += new System.EventHandler(this.buttonSubstitution_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // textRefPath
            // 
            this.textRefPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRefPath.Location = new System.Drawing.Point(58, 27);
            this.textRefPath.Name = "textRefPath";
            this.textRefPath.Size = new System.Drawing.Size(552, 21);
            this.textRefPath.TabIndex = 1;
            // 
            // buttonRefPathFinder
            // 
            this.buttonRefPathFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefPathFinder.Location = new System.Drawing.Point(616, 25);
            this.buttonRefPathFinder.Name = "buttonRefPathFinder";
            this.buttonRefPathFinder.Size = new System.Drawing.Size(42, 23);
            this.buttonRefPathFinder.TabIndex = 2;
            this.buttonRefPathFinder.Text = "...";
            this.buttonRefPathFinder.UseVisualStyleBackColor = true;
            this.buttonRefPathFinder.Click += new System.EventHandler(this.buttonRefPathFinder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source Column";
            // 
            // textRefSCol
            // 
            this.textRefSCol.Location = new System.Drawing.Point(121, 65);
            this.textRefSCol.Name = "textRefSCol";
            this.textRefSCol.Size = new System.Drawing.Size(106, 21);
            this.textRefSCol.TabIndex = 4;
            this.textRefSCol.Text = "B";
            // 
            // textRefTCol
            // 
            this.textRefTCol.Location = new System.Drawing.Point(367, 65);
            this.textRefTCol.Name = "textRefTCol";
            this.textRefTCol.Size = new System.Drawing.Size(106, 21);
            this.textRefTCol.TabIndex = 6;
            this.textRefTCol.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Translated Column";
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.BackColor = System.Drawing.SystemColors.Info;
            this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLog.Location = new System.Drawing.Point(13, 272);
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(671, 187);
            this.textLog.TabIndex = 3;
            this.textLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Translated Column";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Source Column";
            // 
            // buttonTargetPathFinder
            // 
            this.buttonTargetPathFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetPathFinder.Location = new System.Drawing.Point(616, 27);
            this.buttonTargetPathFinder.Name = "buttonTargetPathFinder";
            this.buttonTargetPathFinder.Size = new System.Drawing.Size(42, 23);
            this.buttonTargetPathFinder.TabIndex = 2;
            this.buttonTargetPathFinder.Text = "...";
            this.buttonTargetPathFinder.UseVisualStyleBackColor = true;
            this.buttonTargetPathFinder.Click += new System.EventHandler(this.buttonTargetPathFinder_Click);
            // 
            // textTargetTCol
            // 
            this.textTargetTCol.Location = new System.Drawing.Point(367, 67);
            this.textTargetTCol.Name = "textTargetTCol";
            this.textTargetTCol.Size = new System.Drawing.Size(106, 21);
            this.textTargetTCol.TabIndex = 6;
            this.textTargetTCol.Text = "C";
            // 
            // textTargetSCol
            // 
            this.textTargetSCol.Location = new System.Drawing.Point(121, 67);
            this.textTargetSCol.Name = "textTargetSCol";
            this.textTargetSCol.Size = new System.Drawing.Size(106, 21);
            this.textTargetSCol.TabIndex = 4;
            this.textTargetSCol.Text = "B";
            // 
            // textTargetPath
            // 
            this.textTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTargetPath.Location = new System.Drawing.Point(58, 29);
            this.textTargetPath.Name = "textTargetPath";
            this.textTargetPath.Size = new System.Drawing.Size(552, 21);
            this.textTargetPath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Path";
            // 
            // backgroundSubstitutor
            // 
            this.backgroundSubstitutor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSubstitutor_DoWork);
            this.backgroundSubstitutor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSubstitutor_RunWorkerCompleted);
            // 
            // FormDraftHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDraftHelper";
            this.Text = "Draft Helper";
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupRef.ResumeLayout(false);
            this.groupRef.PerformLayout();
            this.groupTarget.ResumeLayout(false);
            this.groupTarget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupRef;
        private System.Windows.Forms.GroupBox groupTarget;
        private System.Windows.Forms.Button buttonSubstitution;
        private System.Windows.Forms.Button buttonRefPathFinder;
        private System.Windows.Forms.TextBox textRefPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRefTCol;
        private System.Windows.Forms.TextBox textRefSCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTargetPathFinder;
        private System.Windows.Forms.TextBox textTargetTCol;
        private System.Windows.Forms.TextBox textTargetSCol;
        private System.Windows.Forms.TextBox textTargetPath;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundSubstitutor;
    }
}

