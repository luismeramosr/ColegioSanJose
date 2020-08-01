namespace ColegioSanJose
{
    partial class AlternativaComponent
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
            this.rb = new System.Windows.Forms.RadioButton();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtAlternativa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb.Location = new System.Drawing.Point(14, 5);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(161, 24);
            this.rb.TabIndex = 0;
            this.rb.TabStop = true;
            this.rb.Text = "Cambiar alternativa";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(382, 3);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 28);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Location = new System.Drawing.Point(13, 7);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(350, 20);
            this.txtAlternativa.TabIndex = 2;
            this.txtAlternativa.Visible = false;
            // 
            // AlternativaComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtAlternativa);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.rb);
            this.Name = "AlternativaComponent";
            this.Size = new System.Drawing.Size(473, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtAlternativa;
        public System.Windows.Forms.RadioButton rb;
    }
}
