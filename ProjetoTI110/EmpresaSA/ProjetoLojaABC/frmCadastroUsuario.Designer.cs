
namespace ProjetoLojaABC
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.txtCodigoFucionario = new System.Windows.Forms.TextBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblFuncSemUsuario = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.pnlCRUD.SuspendLayout();
            this.gpbFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(5, 470);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(793, 87);
            this.pnlCRUD.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(668, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 71);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(557, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 70);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(445, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 70);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(334, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 70);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(225, 9);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 70);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(116, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 70);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(5, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 70);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(112, 143);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(226, 24);
            this.txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(41, 146);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 86);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 24);
            this.txtNome.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(5, 89);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(78, 34);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(94, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.Controls.Add(this.txtCodigoFucionario);
            this.gpbFuncionarios.Controls.Add(this.lblCodigoFuncionario);
            this.gpbFuncionarios.Controls.Add(this.lblFuncSemUsuario);
            this.gpbFuncionarios.Controls.Add(this.label1);
            this.gpbFuncionarios.Controls.Add(this.txtRepetirSenha);
            this.gpbFuncionarios.Controls.Add(this.lblRepetirSenha);
            this.gpbFuncionarios.Controls.Add(this.txtSenha);
            this.gpbFuncionarios.Controls.Add(this.lblSenha);
            this.gpbFuncionarios.Controls.Add(this.txtNome);
            this.gpbFuncionarios.Controls.Add(this.lblUsuario);
            this.gpbFuncionarios.Controls.Add(this.txtCodigo);
            this.gpbFuncionarios.Controls.Add(this.lblCodigo);
            this.gpbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFuncionarios.Location = new System.Drawing.Point(24, 12);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(749, 452);
            this.gpbFuncionarios.TabIndex = 13;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Dados";
            // 
            // txtCodigoFucionario
            // 
            this.txtCodigoFucionario.Enabled = false;
            this.txtCodigoFucionario.Location = new System.Drawing.Point(565, 356);
            this.txtCodigoFucionario.MaxLength = 5;
            this.txtCodigoFucionario.Name = "txtCodigoFucionario";
            this.txtCodigoFucionario.Size = new System.Drawing.Size(94, 24);
            this.txtCodigoFucionario.TabIndex = 13;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(429, 359);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(130, 18);
            this.lblCodigoFuncionario.TabIndex = 12;
            this.lblCodigoFuncionario.Text = "codigo funcionario";
            // 
            // lblFuncSemUsuario
            // 
            this.lblFuncSemUsuario.FormattingEnabled = true;
            this.lblFuncSemUsuario.ItemHeight = 18;
            this.lblFuncSemUsuario.Location = new System.Drawing.Point(482, 86);
            this.lblFuncSemUsuario.Name = "lblFuncSemUsuario";
            this.lblFuncSemUsuario.Size = new System.Drawing.Size(244, 220);
            this.lblFuncSemUsuario.TabIndex = 11;
            this.lblFuncSemUsuario.SelectedIndexChanged += new System.EventHandler(this.lblFuncSemUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "funcionarios sem usuario";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtRepetirSenha.Location = new System.Drawing.Point(112, 194);
            this.txtRepetirSenha.MaxLength = 10;
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = 'l';
            this.txtRepetirSenha.Size = new System.Drawing.Size(226, 24);
            this.txtRepetirSenha.TabIndex = 3;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(5, 194);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(101, 18);
            this.lblRepetirSenha.TabIndex = 9;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroUsuario";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.pnlCRUD.ResumeLayout(false);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.ListBox lblFuncSemUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoFucionario;
        private System.Windows.Forms.Label lblCodigoFuncionario;
    }
}