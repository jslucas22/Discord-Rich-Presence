
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
            this.btnInicializar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(13, 139);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(192, 22);
            this.txtEstado.TabIndex = 5;
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(13, 88);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(192, 22);
            this.txtDetalhes.TabIndex = 3;
            // 
            // txtIdAplicacao
            // 
            this.txtIdAplicacao.Location = new System.Drawing.Point(13, 37);
            this.txtIdAplicacao.Name = "txtIdAplicacao";
            this.txtIdAplicacao.Size = new System.Drawing.Size(192, 22);
            this.txtIdAplicacao.TabIndex = 1;
            // 
            // txtImagemRaw
            // 
            this.txtImagemRaw.Location = new System.Drawing.Point(13, 190);
            this.txtImagemRaw.Name = "txtImagemRaw";
            this.txtImagemRaw.Size = new System.Drawing.Size(192, 22);
            this.txtImagemRaw.TabIndex = 7;
            // 
            // txtImagemBlob
            // 
            this.txtImagemBlob.Location = new System.Drawing.Point(13, 241);
            this.txtImagemBlob.Name = "txtImagemBlob";
            this.txtImagemBlob.Size = new System.Drawing.Size(192, 22);
            this.txtImagemBlob.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 115);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(12, 67);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(51, 13);
            this.lblDetalhes.TabIndex = 2;
            this.lblDetalhes.Text = "Detalhes";
            // 
            // lblIDApp
            // 
            this.lblIDApp.AutoSize = true;
            this.lblIDApp.Location = new System.Drawing.Point(12, 9);
            this.lblIDApp.Name = "lblIDApp";
            this.lblIDApp.Size = new System.Drawing.Size(70, 13);
            this.lblIDApp.TabIndex = 0;
            this.lblIDApp.Text = "ID Aplicação";
            // 
            // lblImagemGrande
            // 
            this.lblImagemGrande.AutoSize = true;
            this.lblImagemGrande.Location = new System.Drawing.Point(10, 169);
            this.lblImagemGrande.Name = "lblImagemGrande";
            this.lblImagemGrande.Size = new System.Drawing.Size(73, 13);
            this.lblImagemGrande.TabIndex = 6;
            this.lblImagemGrande.Text = "Imagem Raw";
            // 
            // lblImagemBlob
            // 
            this.lblImagemBlob.AutoSize = true;
            this.lblImagemBlob.Location = new System.Drawing.Point(12, 220);
            this.lblImagemBlob.Name = "lblImagemBlob";
            this.lblImagemBlob.Size = new System.Drawing.Size(76, 13);
            this.lblImagemBlob.TabIndex = 8;
            this.lblImagemBlob.Text = "Imagem Blob";
            // 
            // btnInicializar
            // 
            this.btnInicializar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicializar.Location = new System.Drawing.Point(248, 199);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(194, 30);
            this.btnInicializar.TabIndex = 10;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(248, 235);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(194, 30);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // z
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(454, 283);
            this.Controls.Add(this.btnAtualizar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "z";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zSoft | Rich Presence";
            this.Load += new System.EventHandler(this.z_Load);
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
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

