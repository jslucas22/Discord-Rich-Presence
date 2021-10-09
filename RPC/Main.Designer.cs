
namespace RPC
{
    partial class zMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.lblIDApp = new System.Windows.Forms.Label();
            this.lblImagemGrande = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNomePrograma = new System.Windows.Forms.Label();
            this.pnlImagemRaw = new RPC.Controles.CustomPanel();
            this.txtImagemRaw = new System.Windows.Forms.TextBox();
            this.pnlEstado = new RPC.Controles.CustomPanel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.pnlCustomDetalhes = new RPC.Controles.CustomPanel();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.pnlIdAplicacao = new RPC.Controles.CustomPanel();
            this.txtIdAplicacao = new System.Windows.Forms.TextBox();
            this.btnAlterarStatus = new RPC.Controles.CustomButton();
            this.btnInicializar = new RPC.Controles.CustomButton();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlImagemRaw.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlCustomDetalhes.SuspendLayout();
            this.pnlIdAplicacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 164);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(12, 104);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(51, 13);
            this.lblDetalhes.TabIndex = 2;
            this.lblDetalhes.Text = "Detalhes";
            // 
            // lblIDApp
            // 
            this.lblIDApp.AutoSize = true;
            this.lblIDApp.Location = new System.Drawing.Point(12, 39);
            this.lblIDApp.Name = "lblIDApp";
            this.lblIDApp.Size = new System.Drawing.Size(70, 13);
            this.lblIDApp.TabIndex = 0;
            this.lblIDApp.Text = "ID Aplicação";
            // 
            // lblImagemGrande
            // 
            this.lblImagemGrande.AutoSize = true;
            this.lblImagemGrande.Location = new System.Drawing.Point(10, 225);
            this.lblImagemGrande.Name = "lblImagemGrande";
            this.lblImagemGrande.Size = new System.Drawing.Size(73, 13);
            this.lblImagemGrande.TabIndex = 6;
            this.lblImagemGrande.Text = "Imagem Raw";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.picMinimizar);
            this.pnlHeader.Controls.Add(this.picFechar);
            this.pnlHeader.Controls.Add(this.lblNomePrograma);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(473, 25);
            this.pnlHeader.TabIndex = 14;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // lblNomePrograma
            // 
            this.lblNomePrograma.AutoSize = true;
            this.lblNomePrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.lblNomePrograma.Location = new System.Drawing.Point(3, 6);
            this.lblNomePrograma.Name = "lblNomePrograma";
            this.lblNomePrograma.Size = new System.Drawing.Size(151, 13);
            this.lblNomePrograma.TabIndex = 1;
            this.lblNomePrograma.Text = "zRPC | Discord Rich Presence";
            // 
            // pnlImagemRaw
            // 
            this.pnlImagemRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlImagemRaw.Controls.Add(this.txtImagemRaw);
            this.pnlImagemRaw.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnlImagemRaw.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlImagemRaw.CorTextoBotao = System.Drawing.Color.White;
            this.pnlImagemRaw.ForeColor = System.Drawing.Color.White;
            this.pnlImagemRaw.Location = new System.Drawing.Point(15, 251);
            this.pnlImagemRaw.Name = "pnlImagemRaw";
            this.pnlImagemRaw.Size = new System.Drawing.Size(199, 23);
            this.pnlImagemRaw.TabIndex = 18;
            this.pnlImagemRaw.TamanhoBorda = 0;
            this.pnlImagemRaw.TamanhoRaio = 4;
            // 
            // txtImagemRaw
            // 
            this.txtImagemRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtImagemRaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagemRaw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtImagemRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.txtImagemRaw.Location = new System.Drawing.Point(3, 2);
            this.txtImagemRaw.Name = "txtImagemRaw";
            this.txtImagemRaw.Size = new System.Drawing.Size(192, 16);
            this.txtImagemRaw.TabIndex = 7;
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlEstado.Controls.Add(this.txtEstado);
            this.pnlEstado.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnlEstado.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlEstado.CorTextoBotao = System.Drawing.Color.White;
            this.pnlEstado.ForeColor = System.Drawing.Color.White;
            this.pnlEstado.Location = new System.Drawing.Point(15, 190);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(199, 23);
            this.pnlEstado.TabIndex = 17;
            this.pnlEstado.TamanhoBorda = 0;
            this.pnlEstado.TamanhoRaio = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.txtEstado.Location = new System.Drawing.Point(3, 3);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(192, 16);
            this.txtEstado.TabIndex = 5;
            // 
            // pnlCustomDetalhes
            // 
            this.pnlCustomDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlCustomDetalhes.Controls.Add(this.txtDetalhes);
            this.pnlCustomDetalhes.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnlCustomDetalhes.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlCustomDetalhes.CorTextoBotao = System.Drawing.Color.White;
            this.pnlCustomDetalhes.ForeColor = System.Drawing.Color.White;
            this.pnlCustomDetalhes.Location = new System.Drawing.Point(15, 130);
            this.pnlCustomDetalhes.Name = "pnlCustomDetalhes";
            this.pnlCustomDetalhes.Size = new System.Drawing.Size(199, 23);
            this.pnlCustomDetalhes.TabIndex = 16;
            this.pnlCustomDetalhes.TamanhoBorda = 0;
            this.pnlCustomDetalhes.TamanhoRaio = 4;
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalhes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.txtDetalhes.Location = new System.Drawing.Point(3, 3);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(192, 16);
            this.txtDetalhes.TabIndex = 3;
            // 
            // pnlIdAplicacao
            // 
            this.pnlIdAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlIdAplicacao.Controls.Add(this.txtIdAplicacao);
            this.pnlIdAplicacao.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnlIdAplicacao.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.pnlIdAplicacao.CorTextoBotao = System.Drawing.Color.White;
            this.pnlIdAplicacao.ForeColor = System.Drawing.Color.White;
            this.pnlIdAplicacao.Location = new System.Drawing.Point(15, 70);
            this.pnlIdAplicacao.Name = "pnlIdAplicacao";
            this.pnlIdAplicacao.Size = new System.Drawing.Size(199, 23);
            this.pnlIdAplicacao.TabIndex = 15;
            this.pnlIdAplicacao.TamanhoBorda = 0;
            this.pnlIdAplicacao.TamanhoRaio = 4;
            // 
            // txtIdAplicacao
            // 
            this.txtIdAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtIdAplicacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtIdAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.txtIdAplicacao.Location = new System.Drawing.Point(3, 3);
            this.txtIdAplicacao.Name = "txtIdAplicacao";
            this.txtIdAplicacao.Size = new System.Drawing.Size(192, 16);
            this.txtIdAplicacao.TabIndex = 1;
            // 
            // btnAlterarStatus
            // 
            this.btnAlterarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnAlterarStatus.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAlterarStatus.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnAlterarStatus.CorTextoBotao = System.Drawing.Color.White;
            this.btnAlterarStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarStatus.Enabled = false;
            this.btnAlterarStatus.FlatAppearance.BorderSize = 0;
            this.btnAlterarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarStatus.ForeColor = System.Drawing.Color.White;
            this.btnAlterarStatus.Location = new System.Drawing.Point(267, 243);
            this.btnAlterarStatus.Name = "btnAlterarStatus";
            this.btnAlterarStatus.Size = new System.Drawing.Size(194, 35);
            this.btnAlterarStatus.TabIndex = 13;
            this.btnAlterarStatus.TamanhoBorda = 0;
            this.btnAlterarStatus.TamanhoRaio = 4;
            this.btnAlterarStatus.Text = "Alterar Status";
            this.btnAlterarStatus.UseVisualStyleBackColor = false;
            this.btnAlterarStatus.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnInicializar
            // 
            this.btnInicializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnInicializar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnInicializar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnInicializar.CorTextoBotao = System.Drawing.Color.White;
            this.btnInicializar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicializar.FlatAppearance.BorderSize = 0;
            this.btnInicializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicializar.ForeColor = System.Drawing.Color.White;
            this.btnInicializar.Location = new System.Drawing.Point(267, 200);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(194, 35);
            this.btnInicializar.TabIndex = 12;
            this.btnInicializar.TamanhoBorda = 0;
            this.btnInicializar.TamanhoRaio = 4;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = false;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click_1);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = global::RPC.Properties.Resources.minus_22px;
            this.picMinimizar.Location = new System.Drawing.Point(418, 1);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(22, 22);
            this.picMinimizar.TabIndex = 3;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picFechar
            // 
            this.picFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFechar.Image = global::RPC.Properties.Resources.multiply_22px;
            this.picFechar.Location = new System.Drawing.Point(446, 1);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(22, 22);
            this.picFechar.TabIndex = 2;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // zMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(473, 297);
            this.Controls.Add(this.pnlImagemRaw);
            this.Controls.Add(this.pnlEstado);
            this.Controls.Add(this.pnlCustomDetalhes);
            this.Controls.Add(this.pnlIdAplicacao);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAlterarStatus);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.lblImagemGrande);
            this.Controls.Add(this.lblIDApp);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.lblEstado);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "zMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zSoft | Rich Presence";
            this.Load += new System.EventHandler(this.z_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlImagemRaw.ResumeLayout(false);
            this.pnlImagemRaw.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.pnlCustomDetalhes.ResumeLayout(false);
            this.pnlCustomDetalhes.PerformLayout();
            this.pnlIdAplicacao.ResumeLayout(false);
            this.pnlIdAplicacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.TextBox txtIdAplicacao;
        private System.Windows.Forms.TextBox txtImagemRaw;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Label lblIDApp;
        private System.Windows.Forms.Label lblImagemGrande;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNomePrograma;
        private Controles.CustomPanel pnlIdAplicacao;
        private Controles.CustomPanel pnlCustomDetalhes;
        private Controles.CustomPanel pnlEstado;
        private Controles.CustomPanel pnlImagemRaw;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        public Controles.CustomButton btnInicializar;
        public Controles.CustomButton btnAlterarStatus;
    }
}

