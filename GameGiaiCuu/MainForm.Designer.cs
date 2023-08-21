namespace GameGiaiCuu
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuaCauKhi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.panelShowQuaCauKhi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnQuaCauKhi);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 333);
            this.panel1.TabIndex = 0;
            // 
            // btnQuaCauKhi
            // 
            this.btnQuaCauKhi.Location = new System.Drawing.Point(0, 0);
            this.btnQuaCauKhi.Name = "btnQuaCauKhi";
            this.btnQuaCauKhi.Size = new System.Drawing.Size(237, 23);
            this.btnQuaCauKhi.TabIndex = 1;
            this.btnQuaCauKhi.Text = "Qua Cau Khi";
            this.btnQuaCauKhi.UseVisualStyleBackColor = true;
            this.btnQuaCauKhi.Click += new System.EventHandler(this.btnQuaCauKhi_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(3, 308);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(237, 23);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panelShowQuaCauKhi
            // 
            this.panelShowQuaCauKhi.Location = new System.Drawing.Point(244, 0);
            this.panelShowQuaCauKhi.Name = "panelShowQuaCauKhi";
            this.panelShowQuaCauKhi.Size = new System.Drawing.Size(984, 533);
            this.panelShowQuaCauKhi.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 535);
            this.Controls.Add(this.panelShowQuaCauKhi);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnQuaCauKhi;
        private System.Windows.Forms.Panel panelShowQuaCauKhi;
    }
}