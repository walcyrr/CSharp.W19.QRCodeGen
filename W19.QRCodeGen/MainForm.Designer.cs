namespace W19.QRCodeGen
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
            this.components = new System.ComponentModel.Container();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSsid = new System.Windows.Forms.TextBox();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chkMostrarSenha = new System.Windows.Forms.CheckBox();
            this.picCorBloco = new System.Windows.Forms.PictureBox();
            this.lblAutenticacao = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.picCorFundo = new System.Windows.Forms.PictureBox();
            this.lblCorBloco = new System.Windows.Forms.Label();
            this.cmbAutenticacao = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblSsid = new System.Windows.Forms.Label();
            this.lblCorFundo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.chkSsidOculto = new System.Windows.Forms.CheckBox();
            this.pnlImagem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCorBloco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorFundo)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.pnlImagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // picQR
            // 
            this.picQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picQR.Location = new System.Drawing.Point(8, 8);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(455, 357);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 0;
            this.picQR.TabStop = false;
            // 
            // err
            // 
            this.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err.ContainerControl = this;
            // 
            // txtSenha
            // 
            this.err.SetIconPadding(this.txtSenha, 4);
            this.txtSenha.Location = new System.Drawing.Point(38, 131);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(256, 22);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtSsid
            // 
            this.err.SetIconPadding(this.txtSsid, 4);
            this.txtSsid.Location = new System.Drawing.Point(38, 38);
            this.txtSsid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.txtSsid.Name = "txtSsid";
            this.txtSsid.Size = new System.Drawing.Size(256, 22);
            this.txtSsid.TabIndex = 1;
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(924, 90);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(21, 33);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerador de código QR para conexões Wi-Fi";
            // 
            // chkMostrarSenha
            // 
            this.chkMostrarSenha.AutoSize = true;
            this.chkMostrarSenha.Location = new System.Drawing.Point(38, 157);
            this.chkMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.chkMostrarSenha.Name = "chkMostrarSenha";
            this.chkMostrarSenha.Size = new System.Drawing.Size(121, 21);
            this.chkMostrarSenha.TabIndex = 7;
            this.chkMostrarSenha.Text = "Mostrar senha";
            this.chkMostrarSenha.UseVisualStyleBackColor = true;
            this.chkMostrarSenha.CheckedChanged += new System.EventHandler(this.chkMostrarSenha_CheckedChanged);
            // 
            // picCorBloco
            // 
            this.picCorBloco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCorBloco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCorBloco.Location = new System.Drawing.Point(319, 104);
            this.picCorBloco.Name = "picCorBloco";
            this.picCorBloco.Size = new System.Drawing.Size(48, 24);
            this.picCorBloco.TabIndex = 24;
            this.picCorBloco.TabStop = false;
            this.picCorBloco.Click += new System.EventHandler(this.CorBloco_Click);
            // 
            // lblAutenticacao
            // 
            this.lblAutenticacao.AutoSize = true;
            this.lblAutenticacao.Location = new System.Drawing.Point(35, 64);
            this.lblAutenticacao.Name = "lblAutenticacao";
            this.lblAutenticacao.Size = new System.Drawing.Size(90, 17);
            this.lblAutenticacao.TabIndex = 3;
            this.lblAutenticacao.Text = "Autenticação";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(35, 111);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // picCorFundo
            // 
            this.picCorFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCorFundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCorFundo.Location = new System.Drawing.Point(321, 154);
            this.picCorFundo.Name = "picCorFundo";
            this.picCorFundo.Size = new System.Drawing.Size(48, 24);
            this.picCorFundo.TabIndex = 23;
            this.picCorFundo.TabStop = false;
            this.picCorFundo.Click += new System.EventHandler(this.CorFundo_Click);
            // 
            // lblCorBloco
            // 
            this.lblCorBloco.AutoSize = true;
            this.lblCorBloco.Location = new System.Drawing.Point(316, 84);
            this.lblCorBloco.Name = "lblCorBloco";
            this.lblCorBloco.Size = new System.Drawing.Size(88, 17);
            this.lblCorBloco.TabIndex = 8;
            this.lblCorBloco.TabStop = true;
            this.lblCorBloco.Text = "Cor do bloco";
            this.lblCorBloco.Click += new System.EventHandler(this.CorBloco_Click);
            // 
            // cmbAutenticacao
            // 
            this.cmbAutenticacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutenticacao.FormattingEnabled = true;
            this.cmbAutenticacao.Location = new System.Drawing.Point(38, 84);
            this.cmbAutenticacao.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.cmbAutenticacao.Name = "cmbAutenticacao";
            this.cmbAutenticacao.Size = new System.Drawing.Size(256, 24);
            this.cmbAutenticacao.TabIndex = 4;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(168, 197);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(105, 30);
            this.btnGerar.TabIndex = 10;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblSsid
            // 
            this.lblSsid.AutoSize = true;
            this.lblSsid.Location = new System.Drawing.Point(35, 18);
            this.lblSsid.Name = "lblSsid";
            this.lblSsid.Size = new System.Drawing.Size(39, 17);
            this.lblSsid.TabIndex = 0;
            this.lblSsid.Text = "SSID";
            // 
            // lblCorFundo
            // 
            this.lblCorFundo.AutoSize = true;
            this.lblCorFundo.Location = new System.Drawing.Point(316, 134);
            this.lblCorFundo.Name = "lblCorFundo";
            this.lblCorFundo.Size = new System.Drawing.Size(90, 17);
            this.lblCorFundo.TabIndex = 9;
            this.lblCorFundo.TabStop = true;
            this.lblCorFundo.Text = "Cor de fundo";
            this.lblCorFundo.Click += new System.EventHandler(this.CorFundo_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.ColumnCount = 2;
            this.pnlConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlConteudo.Controls.Add(this.pnlControles, 0, 0);
            this.pnlConteudo.Controls.Add(this.pnlImagem, 1, 0);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 90);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.RowCount = 1;
            this.pnlConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlConteudo.Size = new System.Drawing.Size(924, 379);
            this.pnlConteudo.TabIndex = 1;
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlControles.Controls.Add(this.chkSsidOculto);
            this.pnlControles.Controls.Add(this.btnGerar);
            this.pnlControles.Controls.Add(this.picCorBloco);
            this.pnlControles.Controls.Add(this.chkMostrarSenha);
            this.pnlControles.Controls.Add(this.picCorFundo);
            this.pnlControles.Controls.Add(this.lblSsid);
            this.pnlControles.Controls.Add(this.lblCorBloco);
            this.pnlControles.Controls.Add(this.txtSsid);
            this.pnlControles.Controls.Add(this.lblCorFundo);
            this.pnlControles.Controls.Add(this.lblSenha);
            this.pnlControles.Controls.Add(this.lblAutenticacao);
            this.pnlControles.Controls.Add(this.txtSenha);
            this.pnlControles.Controls.Add(this.cmbAutenticacao);
            this.pnlControles.Location = new System.Drawing.Point(3, 67);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(441, 245);
            this.pnlControles.TabIndex = 0;
            // 
            // chkSsidOculto
            // 
            this.chkSsidOculto.AutoSize = true;
            this.chkSsidOculto.Location = new System.Drawing.Point(300, 39);
            this.chkSsidOculto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.chkSsidOculto.Name = "chkSsidOculto";
            this.chkSsidOculto.Size = new System.Drawing.Size(71, 21);
            this.chkSsidOculto.TabIndex = 2;
            this.chkSsidOculto.Text = "Oculto";
            this.chkSsidOculto.UseVisualStyleBackColor = true;
            // 
            // pnlImagem
            // 
            this.pnlImagem.Controls.Add(this.picQR);
            this.pnlImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagem.Location = new System.Drawing.Point(450, 3);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Padding = new System.Windows.Forms.Padding(8);
            this.pnlImagem.Size = new System.Drawing.Size(471, 373);
            this.pnlImagem.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 469);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlTopo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[W19] Wi-Fi QR-Code";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCorBloco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorFundo)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.pnlImagem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chkMostrarSenha;
        private System.Windows.Forms.PictureBox picCorBloco;
        private System.Windows.Forms.Label lblAutenticacao;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox picCorFundo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblCorBloco;
        private System.Windows.Forms.ComboBox cmbAutenticacao;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblSsid;
        private System.Windows.Forms.Label lblCorFundo;
        private System.Windows.Forms.TextBox txtSsid;
        private System.Windows.Forms.TableLayoutPanel pnlConteudo;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.CheckBox chkSsidOculto;
    }
}