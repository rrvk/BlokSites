namespace BlokSites
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBlockSites = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.lslList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(46, 6);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(134, 20);
            this.txtSite.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(46, 32);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(134, 23);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geblokeerde sites";
            // 
            // lstBlockSites
            // 
            this.lstBlockSites.FormattingEnabled = true;
            this.lstBlockSites.Location = new System.Drawing.Point(186, 24);
            this.lstBlockSites.Name = "lstBlockSites";
            this.lstBlockSites.Size = new System.Drawing.Size(169, 225);
            this.lstBlockSites.TabIndex = 4;
            this.lstBlockSites.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBlockSites_KeyDown);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(46, 61);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(134, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Inport list";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lslList
            // 
            this.lslList.FormattingEnabled = true;
            this.lslList.Location = new System.Drawing.Point(46, 89);
            this.lslList.Name = "lslList";
            this.lslList.Size = new System.Drawing.Size(134, 160);
            this.lslList.TabIndex = 5;
            this.lslList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lslList_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 259);
            this.Controls.Add(this.lslList);
            this.Controls.Add(this.lstBlockSites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Block Sites";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBlockSites;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox lslList;
    }
}

