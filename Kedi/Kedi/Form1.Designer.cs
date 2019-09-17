namespace Kedi
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
            this.AdditionBt = new System.Windows.Forms.Button();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.InputTxBx1 = new System.Windows.Forms.TextBox();
            this.InputTxBx2 = new System.Windows.Forms.TextBox();
            this.AnswertxBx = new System.Windows.Forms.TextBox();
            this.SubtractBt = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdditionBt
            // 
            this.AdditionBt.Location = new System.Drawing.Point(89, 75);
            this.AdditionBt.Name = "AdditionBt";
            this.AdditionBt.Size = new System.Drawing.Size(70, 23);
            this.AdditionBt.TabIndex = 0;
            this.AdditionBt.Text = "+";
            this.AdditionBt.UseVisualStyleBackColor = true;
            this.AdditionBt.Click += new System.EventHandler(this.AdditionBt_Click);
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(201, 163);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(75, 23);
            this.AnswerBtn.TabIndex = 1;
            this.AnswerBtn.Text = "Answer";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // InputTxBx1
            // 
            this.InputTxBx1.Location = new System.Drawing.Point(89, 40);
            this.InputTxBx1.Name = "InputTxBx1";
            this.InputTxBx1.Size = new System.Drawing.Size(334, 20);
            this.InputTxBx1.TabIndex = 2;
            // 
            // InputTxBx2
            // 
            this.InputTxBx2.Location = new System.Drawing.Point(89, 126);
            this.InputTxBx2.Name = "InputTxBx2";
            this.InputTxBx2.Size = new System.Drawing.Size(334, 20);
            this.InputTxBx2.TabIndex = 3;
            // 
            // AnswertxBx
            // 
            this.AnswertxBx.Location = new System.Drawing.Point(89, 221);
            this.AnswertxBx.Name = "AnswertxBx";
            this.AnswertxBx.Size = new System.Drawing.Size(334, 20);
            this.AnswertxBx.TabIndex = 4;
            // 
            // SubtractBt
            // 
            this.SubtractBt.Location = new System.Drawing.Point(178, 75);
            this.SubtractBt.Name = "SubtractBt";
            this.SubtractBt.Size = new System.Drawing.Size(70, 23);
            this.SubtractBt.TabIndex = 5;
            this.SubtractBt.Text = "-";
            this.SubtractBt.UseVisualStyleBackColor = true;
            this.SubtractBt.Click += new System.EventHandler(this.SubtractBt_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Location = new System.Drawing.Point(272, 75);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(70, 23);
            this.MultiplyBtn.TabIndex = 7;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Location = new System.Drawing.Point(348, 75);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(75, 23);
            this.DivideBtn.TabIndex = 8;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 310);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubtractBt);
            this.Controls.Add(this.AnswertxBx);
            this.Controls.Add(this.InputTxBx2);
            this.Controls.Add(this.InputTxBx1);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.AdditionBt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdditionBt;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.TextBox InputTxBx1;
        private System.Windows.Forms.TextBox InputTxBx2;
        private System.Windows.Forms.TextBox AnswertxBx;
        private System.Windows.Forms.Button SubtractBt;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button DivideBtn;
    }
}

