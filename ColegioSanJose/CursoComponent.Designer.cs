namespace ColegioSanJose
{
    partial class CursoComponent
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
            this.panelCurso = new System.Windows.Forms.Panel();
            this.pbCursoImg = new System.Windows.Forms.PictureBox();
            this.panelCursoNombre = new System.Windows.Forms.Panel();
            this.lbCursoNombre = new System.Windows.Forms.Label();
            this.panelCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursoImg)).BeginInit();
            this.panelCursoNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCurso
            // 
            this.panelCurso.Controls.Add(this.pbCursoImg);
            this.panelCurso.Controls.Add(this.panelCursoNombre);
            this.panelCurso.Location = new System.Drawing.Point(0, 0);
            this.panelCurso.Name = "panelCurso";
            this.panelCurso.Size = new System.Drawing.Size(190, 210);
            this.panelCurso.TabIndex = 0;
            // 
            // pbCursoImg
            // 
            this.pbCursoImg.Location = new System.Drawing.Point(20, 15);
            this.pbCursoImg.Name = "pbCursoImg";
            this.pbCursoImg.Size = new System.Drawing.Size(150, 140);
            this.pbCursoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCursoImg.TabIndex = 3;
            this.pbCursoImg.TabStop = false;
            this.pbCursoImg.MouseEnter += new System.EventHandler(this.pbCursoImg_MouseEnter);
            this.pbCursoImg.MouseLeave += new System.EventHandler(this.pbCursoImg_MouseLeave);
            // 
            // panelCursoNombre
            // 
            this.panelCursoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelCursoNombre.Controls.Add(this.lbCursoNombre);
            this.panelCursoNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCursoNombre.Location = new System.Drawing.Point(0, 170);
            this.panelCursoNombre.Name = "panelCursoNombre";
            this.panelCursoNombre.Size = new System.Drawing.Size(190, 40);
            this.panelCursoNombre.TabIndex = 0;
            // 
            // lbCursoNombre
            // 
            this.lbCursoNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursoNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lbCursoNombre.Location = new System.Drawing.Point(0, 0);
            this.lbCursoNombre.Name = "lbCursoNombre";
            this.lbCursoNombre.Size = new System.Drawing.Size(190, 30);
            this.lbCursoNombre.TabIndex = 2;
            this.lbCursoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CursoComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCurso);
            this.Name = "CursoComponent";
            this.Size = new System.Drawing.Size(190, 210);
            this.panelCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCursoImg)).EndInit();
            this.panelCursoNombre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCurso;
        private System.Windows.Forms.Panel panelCursoNombre;
        private System.Windows.Forms.Label lbCursoNombre;
        public System.Windows.Forms.PictureBox pbCursoImg;
    }
}
