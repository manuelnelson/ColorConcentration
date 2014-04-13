namespace ColorConcentration
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPercentValue = new System.Windows.Forms.Label();
            this.tbxBlueLower = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(170, 86);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(170, 199);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(40, 60);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(205, 20);
            this.tbxFileName.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(40, 24);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 17);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(37, 188);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(65, 13);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "Percentage:";
            this.lblPercentage.Visible = false;
            // 
            // lblPercentValue
            // 
            this.lblPercentValue.AutoSize = true;
            this.lblPercentValue.Location = new System.Drawing.Point(108, 188);
            this.lblPercentValue.Name = "lblPercentValue";
            this.lblPercentValue.Size = new System.Drawing.Size(0, 13);
            this.lblPercentValue.TabIndex = 5;
            // 
            // tbxBlueLower
            // 
            this.tbxBlueLower.Location = new System.Drawing.Point(40, 143);
            this.tbxBlueLower.Name = "tbxBlueLower";
            this.tbxBlueLower.Size = new System.Drawing.Size(46, 20);
            this.tbxBlueLower.TabIndex = 6;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(154, 143);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(46, 20);
            this.tbxBlue.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blue Lower";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blue Upper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxBlueLower);
            this.Controls.Add(this.lblPercentValue);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.browseButton);
            this.Name = "Form1";
            this.Text = "Red Concentration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPercentValue;
        private System.Windows.Forms.TextBox tbxBlueLower;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

