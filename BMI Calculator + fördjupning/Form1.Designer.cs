namespace BMI_Calculator___fördjupning
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBMIValue = new System.Windows.Forms.Label();
            this.txtbVikt = new System.Windows.Forms.TextBox();
            this.txtbHöjd = new System.Windows.Forms.TextBox();
            this.txtbBMIRes = new System.Windows.Forms.TextBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtbNamn = new System.Windows.Forms.TextBox();
            this.btnModeSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(758, 68);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(180, 80);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Calculate";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(758, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 80);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset values";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(758, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 80);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit BMI";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(33, 23);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(486, 46);
            this.lblBMI.TabIndex = 1;
            this.lblBMI.Text = "Body Mass Index calculator";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(117, 260);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(133, 25);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (KG)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(117, 413);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(162, 25);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (Meters)";
            // 
            // lblBMIValue
            // 
            this.lblBMIValue.AutoSize = true;
            this.lblBMIValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIValue.Location = new System.Drawing.Point(117, 567);
            this.lblBMIValue.Name = "lblBMIValue";
            this.lblBMIValue.Size = new System.Drawing.Size(108, 25);
            this.lblBMIValue.TabIndex = 2;
            this.lblBMIValue.Text = "BMI value";
            // 
            // txtbVikt
            // 
            this.txtbVikt.Location = new System.Drawing.Point(311, 261);
            this.txtbVikt.Name = "txtbVikt";
            this.txtbVikt.Size = new System.Drawing.Size(100, 26);
            this.txtbVikt.TabIndex = 3;
            // 
            // txtbHöjd
            // 
            this.txtbHöjd.Location = new System.Drawing.Point(311, 412);
            this.txtbHöjd.Name = "txtbHöjd";
            this.txtbHöjd.Size = new System.Drawing.Size(100, 26);
            this.txtbHöjd.TabIndex = 3;
            // 
            // txtbBMIRes
            // 
            this.txtbBMIRes.Location = new System.Drawing.Point(269, 530);
            this.txtbBMIRes.Multiline = true;
            this.txtbBMIRes.Name = "txtbBMIRes";
            this.txtbBMIRes.Size = new System.Drawing.Size(198, 63);
            this.txtbBMIRes.TabIndex = 4;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(122, 127);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(68, 25);
            this.lblNamn.TabIndex = 5;
            this.lblNamn.Text = "Name";
            // 
            // txtbNamn
            // 
            this.txtbNamn.Location = new System.Drawing.Point(311, 121);
            this.txtbNamn.Name = "txtbNamn";
            this.txtbNamn.Size = new System.Drawing.Size(100, 26);
            this.txtbNamn.TabIndex = 6;
            // 
            // btnModeSwitch
            // 
            this.btnModeSwitch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeSwitch.Location = new System.Drawing.Point(758, 344);
            this.btnModeSwitch.Name = "btnModeSwitch";
            this.btnModeSwitch.Size = new System.Drawing.Size(180, 80);
            this.btnModeSwitch.TabIndex = 7;
            this.btnModeSwitch.Text = "Mode Switch";
            this.btnModeSwitch.UseVisualStyleBackColor = true;
            this.btnModeSwitch.Click += new System.EventHandler(this.btnModeSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.btnModeSwitch);
            this.Controls.Add(this.txtbNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.txtbBMIRes);
            this.Controls.Add(this.txtbHöjd);
            this.Controls.Add(this.txtbVikt);
            this.Controls.Add(this.lblBMIValue);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMIValue;
        private System.Windows.Forms.TextBox txtbVikt;
        private System.Windows.Forms.TextBox txtbHöjd;
        private System.Windows.Forms.TextBox txtbBMIRes;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtbNamn;
        private System.Windows.Forms.Button btnModeSwitch;
    }
}

