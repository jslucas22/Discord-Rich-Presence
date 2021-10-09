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
        private bool _camposVazios;

        #endregion ..:: Variáveis ::..

        #region ..:: Métodos Auxiliares ::..

        private void ArredondarCantos()
        {
            Region = Region.FromHrgn(CantosArredondados.ArredondarCantos(0, 0, Width, Height, 5, 5));
        }

        public void SalvarInformacoes(string idAplicacao, string estado, string detalhes, string imagemRaw)
        {
            Settings.Default.ID = idAplicacao;
            Settings.Default.Estado = estado;
            Settings.Default.Detalhes = detalhes;
            Settings.Default.ImagemRaw = imagemRaw;

            Settings.Default.Save();
        }

        private void CarregarInformacoes()
        {
            txtIdAplicacao.Text = Convert.ToString(Settings.Default.ID);
            txtDetalhes.Text = Settings.Default.Detalhes;
            txtEstado.Text = Settings.Default.Estado;
            txtImagemRaw.Text = Settings.Default.ImagemRaw;
        }

        private bool ExisteCamposVazios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    _camposVazios = true;
                }
                else
                {
                    _camposVazios = false;
                }
            }
            return _camposVazios;
        }

        private void Inicializar()
        {
            _helper = new Helper(txtIdAplicacao.Text, txtDetalhes.Text, txtEstado.Text, txtImagemRaw.Text);
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

        private void z_Load(object sender, EventArgs e) => CarregarInformacoes();
      
        private void btnInicializar_Click_1(object sender, EventArgs e)
        {
            Inicializar();

            if (!ExisteCamposVazios())
            {
                _helper.Inicializar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de continuar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            _helper.DefinirPresenca();
        }

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

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e) => _movimento = 0;
        private void picFechar_Click(object sender, EventArgs e) => Application.Exit();
        private void picMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        #endregion ..:: Eventos ::..                
    }
}
