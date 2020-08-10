namespace ColegioSanJose
{
    partial class AlternativaArrayComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAlternativas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPop
            // 
            this.btnPop.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPop.Location = new System.Drawing.Point(13, 0);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(160, 29);
            this.btnPop.TabIndex = 1;
            this.btnPop.Text = "Quitar alternativa";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPush.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPush.Location = new System.Drawing.Point(401, 0);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(174, 29);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Agregar alternativa";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAlternativas);
            this.panel1.Controls.Add(this.btnPush);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 29);
            this.panel1.TabIndex = 3;
            // 
            // lblAlternativas
            // 
            this.lblAlternativas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternativas.Location = new System.Drawing.Point(3, 5);
            this.lblAlternativas.Name = "lblAlternativas";
            this.lblAlternativas.Size = new System.Drawing.Size(118, 19);
            this.lblAlternativas.TabIndex = 13;
            this.lblAlternativas.Text = "ALTERNATIVAS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 29);
            this.panel2.TabIndex = 3;
            // 
            // AlternativaArrayComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AlternativaArrayComponent";
            this.Size = new System.Drawing.Size(748, 210);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAlternativas;
    }
}
