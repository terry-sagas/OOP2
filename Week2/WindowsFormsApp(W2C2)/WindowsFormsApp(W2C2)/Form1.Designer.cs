namespace WindowsFormsApp_W2C2_
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSub = new System.Windows.Forms.RadioButton();
            this.rbtnMul = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.input.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSub);
            this.groupBox1.Controls.Add(this.rbtnMul);
            this.groupBox1.Controls.Add(this.rbtnDivide);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(46, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnSub
            // 
            this.rbtnSub.AutoSize = true;
            this.rbtnSub.Location = new System.Drawing.Point(24, 80);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(95, 24);
            this.rbtnSub.TabIndex = 1;
            this.rbtnSub.Text = "Subtract";
            this.rbtnSub.UseVisualStyleBackColor = true;
            // 
            // rbtnMul
            // 
            this.rbtnMul.AutoSize = true;
            this.rbtnMul.Location = new System.Drawing.Point(24, 128);
            this.rbtnMul.Name = "rbtnMul";
            this.rbtnMul.Size = new System.Drawing.Size(86, 24);
            this.rbtnMul.TabIndex = 2;
            this.rbtnMul.Text = "Multiply";
            this.rbtnMul.UseVisualStyleBackColor = true;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(24, 176);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(77, 24);
            this.rbtnDivide.TabIndex = 3;
            this.rbtnDivide.Text = "Divide";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Checked = true;
            this.rbtnAdd.Location = new System.Drawing.Point(24, 32);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(63, 24);
            this.rbtnAdd.TabIndex = 0;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(183, 18);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(124, 26);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(183, 60);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(124, 26);
            this.txtNum2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(183, 106);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.ReadOnly = true;
            this.txtCalc.Size = new System.Drawing.Size(124, 26);
            this.txtCalc.TabIndex = 5;
            this.txtCalc.TextChanged += new System.EventHandler(this.txtCalc_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Location = new System.Drawing.Point(242, 244);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(93, 39);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(242, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // input
            // 
            this.input.Controls.Add(this.txtNum2);
            this.input.Controls.Add(this.label1);
            this.input.Controls.Add(this.label2);
            this.input.Controls.Add(this.txtCalc);
            this.input.Controls.Add(this.txtNum1);
            this.input.Controls.Add(this.label3);
            this.input.Location = new System.Drawing.Point(28, 24);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(341, 141);
            this.input.TabIndex = 0;
            this.input.TabStop = false;
            this.input.Text = "Input";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSub;
        private System.Windows.Forms.RadioButton rbtnMul;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox input;
    }
}

