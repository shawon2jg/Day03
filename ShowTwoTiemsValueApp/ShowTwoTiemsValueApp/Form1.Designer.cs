namespace ShowTwoTiemsValueApp
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
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.showResultTextBox = new System.Windows.Forms.TextBox();
            this.calculateNumberBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show Result";
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(106, 43);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.aNumberTextBox.TabIndex = 2;
            // 
            // showResultTextBox
            // 
            this.showResultTextBox.Location = new System.Drawing.Point(106, 80);
            this.showResultTextBox.Name = "showResultTextBox";
            this.showResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.showResultTextBox.TabIndex = 3;
            // 
            // calculateNumberBotton
            // 
            this.calculateNumberBotton.Location = new System.Drawing.Point(41, 152);
            this.calculateNumberBotton.Name = "calculateNumberBotton";
            this.calculateNumberBotton.Size = new System.Drawing.Size(189, 23);
            this.calculateNumberBotton.TabIndex = 4;
            this.calculateNumberBotton.Text = "Calculate Number In Two Times";
            this.calculateNumberBotton.UseVisualStyleBackColor = true;
            this.calculateNumberBotton.Click += new System.EventHandler(this.calculateNumberInTwoTimes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calculateNumberBotton);
            this.Controls.Add(this.showResultTextBox);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.TextBox showResultTextBox;
        private System.Windows.Forms.Button calculateNumberBotton;
    }
}

