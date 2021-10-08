
namespace RPC
{
    partial class z
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.txtIdAplicacao = new System.Windows.Forms.TextBox();
            this.txtImagemRaw = new System.Windows.Forms.TextBox();
            this.txtImagemBlob = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.lblIDApp = new System.Windows.Forms.Label();
            this.lblImagemGrande = new System.Windows.Forms.Label();
            this.lblImagemBlob = new System.Windows.Forms.Label();
            this.btnAlterarStatus = new RPC.Controles.CustomButton();
            this.btnInicializar = new RPC.Controles.CustomButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNomePrograma = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtEstado.Location = new System.Drawing.Point(13, 169);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(192, 16);
            this.txtEstado.TabIndex = 5;
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalhes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtDetalhes.Location = new System.Drawing.Point(13, 118);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(192, 16);
            this.txtDetalhes.TabIndex = 3;
            // 
            // txtIdAplicacao
            // 
            this.txtIdAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtIdAplicacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtIdAplicacao.Location = new System.Drawing.Point(13, 67);
            this.txtIdAplicacao.Name = "txtIdAplicacao";
            this.txtIdAplicacao.Size = new System.Drawing.Size(192, 16);
            this.txtIdAplicacao.TabIndex = 1;
            // 
            // txtImagemRaw
            // 
            this.txtImagemRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtImagemRaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagemRaw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtImagemRaw.Location = new System.Drawing.Point(13, 220);
            this.txtImagemRaw.Name = "txtImagemRaw";
            this.txtImagemRaw.Size = new System.Drawing.Size(192, 16);
            this.txtImagemRaw.TabIndex = 7;
            // 
            // txtImagemBlob
            // 
            this.txtImagemBlob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.txtImagemBlob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagemBlob.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtImagemBlob.Location = new System.Drawing.Point(13, 271);
            this.txtImagemBlob.Name = "txtImagemBlob";
            this.txtImagemBlob.Size = new System.Drawing.Size(192, 16);
            this.txtImagemBlob.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 145);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(12, 97);
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
            this.lblImagemGrande.Location = new System.Drawing.Point(10, 199);
            this.lblImagemGrande.Name = "lblImagemGrande";
            this.lblImagemGrande.Size = new System.Drawing.Size(73, 13);
            this.lblImagemGrande.TabIndex = 6;
            this.lblImagemGrande.Text = "Imagem Raw";
            // 
            // lblImagemBlob
            // 
            this.lblImagemBlob.AutoSize = true;
            this.lblImagemBlob.Location = new System.Drawing.Point(12, 250);
            this.lblImagemBlob.Name = "lblImagemBlob";
            this.lblImagemBlob.Size = new System.Drawing.Size(76, 13);
            this.lblImagemBlob.TabIndex = 8;
            this.lblImagemBlob.Text = "Imagem Blob";
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
            this.btnAlterarStatus.Location = new System.Drawing.Point(248, 258);
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
            this.btnInicializar.Location = new System.Drawing.Point(248, 215);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(194, 35);
            this.btnInicializar.TabIndex = 12;
            this.btnInicializar.TamanhoBorda = 0;
            this.btnInicializar.TamanhoRaio = 4;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = false;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click_1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblNomePrograma);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(454, 25);
            this.pnlHeader.TabIndex = 14;
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
            // z
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(454, 312);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAlterarStatus);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.lblImagemBlob);
            this.Controls.Add(this.lblImagemGrande);
            this.Controls.Add(this.lblIDApp);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtImagemBlob);
            this.Controls.Add(this.txtImagemRaw);
            this.Controls.Add(this.txtIdAplicacao);
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.txtEstado);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "z";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zSoft | Rich Presence";
            this.Load += new System.EventHandler(this.z_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.TextBox txtIdAplicacao;
        private System.Windows.Forms.TextBox txtImagemRaw;
        private System.Windows.Forms.TextBox txtImagemBlob;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Label lblIDApp;
        private System.Windows.Forms.Label lblImagemGrande;
        private System.Windows.Forms.Label lblImagemBlob;
        private Controles.CustomButton btnInicializar;
        private Controles.CustomButton btnAlterarStatus;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNomePrograma;
    }
}

