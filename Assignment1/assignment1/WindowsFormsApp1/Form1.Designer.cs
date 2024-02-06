namespace WindowsFormsApp1
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
            this.lblNumOfDays = new System.Windows.Forms.Label();
            this.txtDayInput = new System.Windows.Forms.TextBox();
            this.txtDayNumber = new System.Windows.Forms.TextBox();
            this.lblDayNum = new System.Windows.Forms.Label();
            this.lblBookSales = new System.Windows.Forms.Label();
            this.txtSalesInput = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumOfDays
            // 
            this.lblNumOfDays.AutoSize = true;
            this.lblNumOfDays.Location = new System.Drawing.Point(39, 26);
            this.lblNumOfDays.Name = "lblNumOfDays";
            this.lblNumOfDays.Size = new System.Drawing.Size(123, 20);
            this.lblNumOfDays.TabIndex = 0;
            this.lblNumOfDays.Text = "Number of Days";
            // 
            // txtDayInput
            // 
            this.txtDayInput.Location = new System.Drawing.Point(182, 26);
            this.txtDayInput.Name = "txtDayInput";
            this.txtDayInput.Size = new System.Drawing.Size(124, 26);
            this.txtDayInput.TabIndex = 1;
            this.txtDayInput.TextChanged += new System.EventHandler(this.txtDayInput_TextChanged);
            // 
            // txtDayNumber
            // 
            this.txtDayNumber.Location = new System.Drawing.Point(444, 26);
            this.txtDayNumber.Name = "txtDayNumber";
            this.txtDayNumber.ReadOnly = true;
            this.txtDayNumber.Size = new System.Drawing.Size(72, 26);
            this.txtDayNumber.TabIndex = 2;
            // 
            // lblDayNum
            // 
            this.lblDayNum.AutoSize = true;
            this.lblDayNum.Location = new System.Drawing.Point(376, 31);
            this.lblDayNum.Name = "lblDayNum";
            this.lblDayNum.Size = new System.Drawing.Size(46, 20);
            this.lblDayNum.TabIndex = 3;
            this.lblDayNum.Text = "Day#";
            // 
            // lblBookSales
            // 
            this.lblBookSales.AutoSize = true;
            this.lblBookSales.Location = new System.Drawing.Point(39, 89);
            this.lblBookSales.Name = "lblBookSales";
            this.lblBookSales.Size = new System.Drawing.Size(90, 20);
            this.lblBookSales.TabIndex = 4;
            this.lblBookSales.Text = "Book Sales";
            // 
            // txtSalesInput
            // 
            this.txtSalesInput.Location = new System.Drawing.Point(182, 83);
            this.txtSalesInput.Name = "txtSalesInput";
            this.txtSalesInput.Size = new System.Drawing.Size(124, 26);
            this.txtSalesInput.TabIndex = 5;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(43, 141);
            this.txtSales.Multiline = true;
            this.txtSales.Name = "txtSales";
            this.txtSales.ReadOnly = true;
            this.txtSales.Size = new System.Drawing.Size(473, 226);
            this.txtSales.TabIndex = 6;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(43, 398);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(473, 26);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(25, 451);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(96, 36);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnSum
            // 
            this.btnSum.Enabled = false;
            this.btnSum.Location = new System.Drawing.Point(127, 451);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(96, 36);
            this.btnSum.TabIndex = 9;
            this.btnSum.Text = "&Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Enabled = false;
            this.btnAverage.Location = new System.Drawing.Point(229, 451);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(96, 36);
            this.btnAverage.TabIndex = 10;
            this.btnAverage.Text = "&Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(331, 451);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 36);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtSalesInput);
            this.Controls.Add(this.lblBookSales);
            this.Controls.Add(this.lblDayNum);
            this.Controls.Add(this.txtDayNumber);
            this.Controls.Add(this.txtDayInput);
            this.Controls.Add(this.lblNumOfDays);
            this.Name = "Form1";
            this.Text = "Books Sales Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfDays;
        private System.Windows.Forms.TextBox txtDayInput;
        private System.Windows.Forms.TextBox txtDayNumber;
        private System.Windows.Forms.Label lblDayNum;
        private System.Windows.Forms.Label lblBookSales;
        private System.Windows.Forms.TextBox txtSalesInput;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
    }
}

