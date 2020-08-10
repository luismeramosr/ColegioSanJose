namespace ColegioSanJose
{
    partial class FormCrearEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearEvaluacion));
            this.panelPushPop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.panelPushPop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPushPop
            // 
            this.panelPushPop.Controls.Add(this.lblPregunta);
            this.panelPushPop.Controls.Add(this.panel3);
            this.panelPushPop.Controls.Add(this.panel1);
            this.panelPushPop.Controls.Add(this.btnAnterior);
            this.panelPushPop.Controls.Add(this.panel2);
            this.panelPushPop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPushPop.Location = new System.Drawing.Point(0, 0);
            this.panelPushPop.Name = "panelPushPop";
            this.panelPushPop.Size = new System.Drawing.Size(748, 29);
            this.panelPushPop.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(614, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 29);
            this.panel3.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(29, 29);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarPregunta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(649, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 29);
            this.panel1.TabIndex = 16;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(0, 0);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(29, 29);
            this.btnQuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuitar.TabIndex = 15;
            this.btnQuitar.TabStop = false;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarPregunta_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(713, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 29);
            this.panel2.TabIndex = 16;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(6, 0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(29, 29);
            this.btnSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(684, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(29, 29);
            this.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(3, 5);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(93, 19);
            this.lblPregunta.TabIndex = 17;
            this.lblPregunta.Text = "PREGUNTA ";
            // 
            // FormCrearEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.panelPushPop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrearEvaluacion";
            this.Text = "FormCrearEvaluacion";
            this.panelPushPop.ResumeLayout(false);
            this.panelPushPop.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPushPop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnQuitar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSiguiente;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.Label lblPregunta;
    }
}