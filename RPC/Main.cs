using RPC.Classes;
using RPC.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPC
{
    public partial class zMain : Form
    {
        #region ..:: Variáveis ::..

        private int _movimento;
        private int _movimentoX;
        private int _movimentoY;
        private Helper _helper;

        #endregion ..:: Variáveis ::..

        #region ..:: Métodos Auxiliares ::..

        private void ArredondarCantos()
        {
            Region = Region.FromHrgn(CantosArredondados.ArredondarCantos(0, 0, Width, Height, 5, 5));
        }

        public void SalvarXFechar(string idAplicacao, string estado, string detalhes, string imagemRaw)
        {
            Settings.Default.ID = idAplicacao;
            Settings.Default.Estado = estado;
            Settings.Default.Detalhes = detalhes;
            Settings.Default.ImagemRaw = imagemRaw;

            Settings.Default.Save();

            Application.Exit();
        }

        private void CarregarInformacoes()
        {
            txtIdAplicacao.Text = Convert.ToString(Settings.Default.ID);
            txtDetalhes.Text = Settings.Default.Detalhes;
            txtEstado.Text = Settings.Default.Estado;
            txtImagemRaw.Text = Settings.Default.ImagemRaw;
        }

        private void Inicializar()
        {
            _helper = new Helper(txtIdAplicacao.Text, txtDetalhes.Text, txtEstado.Text, txtImagemRaw.Text);
        }

        private void AlterarEstadoComponentes()
        {
            btnInicializar.Enabled = false;
            btnDefinirValores.Enabled = true;
        }

        private void InicializarAplicacao()
        {
            try
            {
                Inicializar();

                if (!string.IsNullOrEmpty(txtIdAplicacao.Text))
                {
                    _helper.Inicializar();
                    AlterarEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Informe o ID da aplicação antes de continuar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefinirPresenca()
        {
            try
            {
                _helper.DefinirPresenca(txtDetalhes.Text, txtEstado.Text, txtImagemRaw.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion ..:: Métodos Auxiliares ::..

        #region ..:: Construtor ::..

        public zMain()
        {
            InitializeComponent();
            ArredondarCantos();
        }

        #endregion ..:: Construtor ::..

        #region ..:: Eventos ::..

        //# ------------------------------> Com Lambda <------------------------------

        private void z_Load(object sender, EventArgs e) => CarregarInformacoes();
        private void btnInicializar_Click_1(object sender, EventArgs e) => InicializarAplicacao();
        private void btnAtualizar_Click_1(object sender, EventArgs e) => DefinirPresenca();
        private void picFechar_Click(object sender, EventArgs e) => SalvarXFechar(txtIdAplicacao.Text, txtEstado.Text, txtDetalhes.Text, txtImagemRaw.Text);
        private void picMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e) => _movimento = 0;

        //# ------------------------------> Com Lambda <------------------------------


        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _movimento = 1;
            _movimentoX = e.X;
            _movimentoY = e.Y;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_movimento > 0)
            {
                SetDesktopLocation(MousePosition.X - _movimentoX, MousePosition.Y - _movimentoY);
            }
        }

        #endregion ..:: Eventos ::..                
    }
}
