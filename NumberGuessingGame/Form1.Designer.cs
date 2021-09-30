
namespace NumberGuessingGame
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
            this.lb = new System.Windows.Forms.Label();
            this.txb = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.answerLb = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(76, 17);
            this.lb.TabIndex = 0;
            this.lb.Text = "Guessing: ";
            // 
            // txb
            // 
            this.txb.Location = new System.Drawing.Point(15, 29);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(100, 22);
            this.txb.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(15, 57);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Check";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // answerLb
            // 
            this.answerLb.AutoSize = true;
            this.answerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLb.Location = new System.Drawing.Point(121, 29);
            this.answerLb.Name = "answerLb";
            this.answerLb.Size = new System.Drawing.Size(44, 18);
            this.answerLb.TabIndex = 3;
            this.answerLb.Text = "result";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(96, 57);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Restart";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 119);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.answerLb);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txb);
            this.Controls.Add(this.lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label answerLb;
        private System.Windows.Forms.Button btn2;
    }
}

