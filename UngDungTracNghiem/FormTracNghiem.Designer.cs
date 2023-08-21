namespace UngDungTracNghiem
{
    partial class FormTracNghiem
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
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.RadioButton();
            this.lbB = new System.Windows.Forms.RadioButton();
            this.lbC = new System.Windows.Forms.RadioButton();
            this.lbD = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnPreviousQuestion = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelShowNumberOfQuestion = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Location = new System.Drawing.Point(36, 31);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(51, 20);
            this.lbNoiDung.TabIndex = 0;
            this.lbNoiDung.Text = "label1";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(64, 55);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(119, 24);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "radioButton1";
            this.lbA.UseVisualStyleBackColor = true;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(64, 85);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(119, 24);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "radioButton2";
            this.lbB.UseVisualStyleBackColor = true;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(64, 115);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(119, 24);
            this.lbC.TabIndex = 3;
            this.lbC.Text = "radioButton3";
            this.lbC.UseVisualStyleBackColor = true;
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(64, 145);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(119, 24);
            this.lbD.TabIndex = 4;
            this.lbD.Text = "radioButton4";
            this.lbD.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "D. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "D. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "D. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "A. ";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(40, 227);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(130, 31);
            this.btnNextQuestion.TabIndex = 12;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnPreviousQuestion
            // 
            this.btnPreviousQuestion.Location = new System.Drawing.Point(40, 286);
            this.btnPreviousQuestion.Name = "btnPreviousQuestion";
            this.btnPreviousQuestion.Size = new System.Drawing.Size(130, 31);
            this.btnPreviousQuestion.TabIndex = 13;
            this.btnPreviousQuestion.Text = "Previous Question";
            this.btnPreviousQuestion.UseVisualStyleBackColor = true;
            this.btnPreviousQuestion.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
            // 
            // panelShowNumberOfQuestion
            // 
            this.panelShowNumberOfQuestion.Location = new System.Drawing.Point(641, 55);
            this.panelShowNumberOfQuestion.Name = "panelShowNumberOfQuestion";
            this.panelShowNumberOfQuestion.Size = new System.Drawing.Size(484, 314);
            this.panelShowNumberOfQuestion.TabIndex = 14;
            // 
            // FormTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelShowNumberOfQuestion);
            this.Controls.Add(this.btnPreviousQuestion);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbNoiDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTracNghiem";
            this.Text = "FormTracNghiem";
            this.Load += new System.EventHandler(this.FormTracNghiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.RadioButton lbA;
        private System.Windows.Forms.RadioButton lbB;
        private System.Windows.Forms.RadioButton lbC;
        private System.Windows.Forms.RadioButton lbD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnPreviousQuestion;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelShowNumberOfQuestion;
    }
}