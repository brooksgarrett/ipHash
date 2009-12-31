namespace ipHash
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ipTB = new System.Windows.Forms.TextBox();
            this.hashBTN = new System.Windows.Forms.Button();
            this.hashTB = new System.Windows.Forms.TextBox();
            this.reverseBTN = new System.Windows.Forms.Button();
            this.ipErrorTip = new System.Windows.Forms.ToolTip(this.components);
            this.hashErrorTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ipTB
            // 
            this.ipTB.AllowDrop = true;
            this.ipTB.Location = new System.Drawing.Point(13, 13);
            this.ipTB.MaxLength = 15;
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(192, 20);
            this.ipTB.TabIndex = 0;
            this.ipTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ipTB_KeyUp);
            // 
            // hashBTN
            // 
            this.hashBTN.Location = new System.Drawing.Point(211, 11);
            this.hashBTN.Name = "hashBTN";
            this.hashBTN.Size = new System.Drawing.Size(75, 23);
            this.hashBTN.TabIndex = 1;
            this.hashBTN.Text = "Hash";
            this.hashBTN.UseVisualStyleBackColor = true;
            this.hashBTN.Click += new System.EventHandler(this.ipBTN_Click);
            // 
            // hashTB
            // 
            this.hashTB.Location = new System.Drawing.Point(13, 40);
            this.hashTB.MaxLength = 16;
            this.hashTB.Name = "hashTB";
            this.hashTB.Size = new System.Drawing.Size(192, 20);
            this.hashTB.TabIndex = 2;
            this.hashTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hashTB_KeyUp);
            // 
            // reverseBTN
            // 
            this.reverseBTN.Location = new System.Drawing.Point(211, 38);
            this.reverseBTN.Name = "reverseBTN";
            this.reverseBTN.Size = new System.Drawing.Size(75, 23);
            this.reverseBTN.TabIndex = 3;
            this.reverseBTN.Text = "Reverse";
            this.reverseBTN.UseVisualStyleBackColor = true;
            this.reverseBTN.Click += new System.EventHandler(this.hashBTN_Click);
            // 
            // ipErrorTip
            // 
            this.ipErrorTip.IsBalloon = true;
            this.ipErrorTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ipErrorTip.ToolTipTitle = "IPAddress";
            // 
            // hashErrorTip
            // 
            this.hashErrorTip.IsBalloon = true;
            this.hashErrorTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.hashErrorTip.ToolTipTitle = "Hash";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(305, 75);
            this.Controls.Add(this.reverseBTN);
            this.Controls.Add(this.hashTB);
            this.Controls.Add(this.hashBTN);
            this.Controls.Add(this.ipTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ipHasher";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Button hashBTN;
        private System.Windows.Forms.TextBox hashTB;
        private System.Windows.Forms.Button reverseBTN;
        private System.Windows.Forms.ToolTip ipErrorTip;
        private System.Windows.Forms.ToolTip hashErrorTip;
    }
}

