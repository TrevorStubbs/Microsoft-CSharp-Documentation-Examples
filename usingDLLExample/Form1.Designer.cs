namespace usingDLLExample
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
            this.firstNumber = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.txtFirstNo = new System.Windows.Forms.TextBox();
            this.txtSecNo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumber
            // 
            this.firstNumber.AutoSize = true;
            this.firstNumber.Location = new System.Drawing.Point(82, 45);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(66, 13);
            this.firstNumber.TabIndex = 0;
            this.firstNumber.Text = "First Number";
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.Location = new System.Drawing.Point(64, 82);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(84, 13);
            this.secondNumber.TabIndex = 1;
            this.secondNumber.Text = "Second Number";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(111, 154);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 13);
            this.result.TabIndex = 2;
            this.result.Text = "Result";
            // 
            // txtFirstNo
            // 
            this.txtFirstNo.Location = new System.Drawing.Point(176, 42);
            this.txtFirstNo.Name = "txtFirstNo";
            this.txtFirstNo.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNo.TabIndex = 3;
            // 
            // txtSecNo
            // 
            this.txtSecNo.Location = new System.Drawing.Point(176, 79);
            this.txtSecNo.Name = "txtSecNo";
            this.txtSecNo.Size = new System.Drawing.Size(100, 20);
            this.txtSecNo.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(176, 147);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Addition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Subtraction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 247);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecNo);
            this.Controls.Add(this.txtFirstNo);
            this.Controls.Add(this.result);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Name = "Form1";
            this.Text = "Using DLL Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumber;
        private System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox txtFirstNo;
        private System.Windows.Forms.TextBox txtSecNo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

