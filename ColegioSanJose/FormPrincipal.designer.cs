namespace ColegioSanJose
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDespegable = new System.Windows.Forms.Panel();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnconfuser = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnconf = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDespegable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelForm);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarra);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 527);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.AutoSize = true;
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelForm.Controls.Add(this.lbfecha);
            this.panelForm.Controls.Add(this.lbHora);
            this.panelForm.Controls.Add(this.imgLogo);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(220, 30);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(780, 497);
            this.panelForm.TabIndex = 2;
            // 
            // lbfecha
            // 
            this.lbfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.SlateGray;
            this.lbfecha.Location = new System.Drawing.Point(143, 380);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(126, 46);
            this.lbfecha.TabIndex = 2;
            this.lbfecha.Text = "label1";
            // 
            // lbHora
            // 
            this.lbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.lbHora.Location = new System.Drawing.Point(221, 262);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(249, 91);
            this.lbHora.TabIndex = 1;
            this.lbHora.Text = "label1";
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(210, -5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(346, 293);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMenu.Controls.Add(this.panelDespegable);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.btnconf);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.btnHorario);
            this.panelMenu.Controls.Add(this.btnCursos);
            this.panelMenu.Controls.Add(this.btnPerfil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 497);
            this.panelMenu.TabIndex = 1;
            // 
            // panelDespegable
            // 
            this.panelDespegable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelDespegable.Controls.Add(this.btnayuda);
            this.panelDespegable.Controls.Add(this.btnconfuser);
            this.panelDespegable.Location = new System.Drawing.Point(-1, 226);
            this.panelDespegable.Name = "panelDespegable";
            this.panelDespegable.Size = new System.Drawing.Size(221, 74);
            this.panelDespegable.TabIndex = 12;
            // 
            // btnayuda
            // 
            this.btnayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.Color.White;
            this.btnayuda.Location = new System.Drawing.Point(0, 36);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(221, 36);
            this.btnayuda.TabIndex = 1;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // btnconfuser
            // 
            this.btnconfuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconfuser.FlatAppearance.BorderSize = 0;
            this.btnconfuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnconfuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnconfuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfuser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfuser.ForeColor = System.Drawing.Color.White;
            this.btnconfuser.Location = new System.Drawing.Point(0, 0);
            this.btnconfuser.Name = "btnconfuser";
            this.btnconfuser.Size = new System.Drawing.Size(221, 36);
            this.btnconfuser.TabIndex = 0;
            this.btnconfuser.Text = "Configurar Usuario";
            this.btnconfuser.UseVisualStyleBackColor = true;
            this.btnconfuser.Click += new System.EventHandler(this.btnconfuser_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.panel5.Location = new System.Drawing.Point(1, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 40);
            this.panel5.TabIndex = 11;
            // 
            // btnconf
            // 
            this.btnconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconf.FlatAppearance.BorderSize = 0;
            this.btnconf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnconf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconf.ForeColor = System.Drawing.Color.White;
            this.btnconf.Image = ((System.Drawing.Image)(resources.GetObject("btnconf.Image")));
            this.btnconf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconf.Location = new System.Drawing.Point(-1, 185);
            this.btnconf.Name = "btnconf";
            this.btnconf.Size = new System.Drawing.Size(221, 40);
            this.btnconf.TabIndex = 10;
            this.btnconf.Text = "Configurar";
            this.btnconf.UseVisualStyleBackColor = true;
            this.btnconf.Click += new System.EventHandler(this.btnconf_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(0, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 9;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 457);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(220, 40);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(1, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 40);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(1, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(174, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnHorario.Image")));
            this.btnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.Location = new System.Drawing.Point(0, 139);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(221, 40);
            this.btnHorario.TabIndex = 2;
            this.btnHorario.Text = "Horario";
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnCursos.Image")));
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(1, 93);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(220, 40);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(1, 47);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(220, 40);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.panelBarra.Controls.Add(this.btnminimizar);
            this.panelBarra.Controls.Add(this.btnrestaurar);
            this.panelBarra.Controls.Add(this.btnmaximizar);
            this.panelBarra.Controls.Add(this.btncerrar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1000, 30);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(924, 8);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(16, 16);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(948, 8);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 1;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(948, 8);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 0;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(972, 7);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(16, 16);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 527);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.reloadPanel);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelDespegable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnconf;
        private System.Windows.Forms.Panel panelDespegable;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnconfuser;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tmHoraFecha;
    }
}

