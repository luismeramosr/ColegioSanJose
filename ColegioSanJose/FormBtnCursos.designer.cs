namespace ColegioSanJose
{
    partial class FormBtnCursos
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
            this.panel19 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel19.Location = new System.Drawing.Point(0, 746);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(772, 23);
            this.panel19.TabIndex = 10;
            // 
            // FormBtnCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(772, 769);
            this.Controls.Add(this.panel19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBtnCursos";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.reloadPanel);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

