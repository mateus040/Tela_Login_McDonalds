namespace Tela_Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.Red;
            this.panel_lateral.Controls.Add(this.pictureBox3);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(250, 330);
            this.panel_lateral.TabIndex = 0;
            this.panel_lateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_lateral_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(65, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.LightGray;
            this.btn_login.Location = new System.Drawing.Point(311, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(413, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // linkCadastro
            // 
            this.linkCadastro.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkCadastro.LinkColor = System.Drawing.Color.DimGray;
            this.linkCadastro.Location = new System.Drawing.Point(447, 298);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(140, 17);
            this.linkCadastro.TabIndex = 0;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Não tenho cadastro";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(753, 9);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(15, 15);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(724, 9);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(15, 15);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_minimizar.TabIndex = 7;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(307, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA:";
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.ForeColor = System.Drawing.Color.LightGray;
            this.txt_senha.Location = new System.Drawing.Point(382, 168);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(342, 27);
            this.txt_senha.TabIndex = 8;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_usuario.Location = new System.Drawing.Point(382, 95);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(342, 27);
            this.txt_usuario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(293, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "USUÁRIO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel_lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_lateral;
        private Label label1;
        private Button btn_login;
        private LinkLabel linkCadastro;
        private PictureBox btn_fechar;
        private PictureBox btn_minimizar;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox txt_senha;
        private TextBox txt_usuario;
        private Label label3;
    }
}