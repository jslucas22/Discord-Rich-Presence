using DiscordRPC;
using DiscordRPC.Logging;
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

        private DiscordRpcClient _discordRpcClient;

        private int _movimento;
        private int _movimentoX;
        private int _movimentoY;

        #endregion ..:: Variáveis ::..

        #region ..:: Instancias ::..

        private Helper _helper = new Helper();

        #endregion ..:: Instancias ::..


        #region ..:: Métodos Auxiliares ::..

        private void ArredondarCantos()
        {
            Region = Region.FromHrgn(CantosArredondados.ArredondarCantos(0, 0, Width, Height, 5, 5));
        }

        private void Inicializar()
        {
            try
            {
                btnInicializar.Enabled = false;

                _discordRpcClient = new DiscordRpcClient(txtIdAplicacao.Text);
                _discordRpcClient.Logger = new ConsoleLogger()
                {
                    Level = LogLevel.Warning
                };
                _discordRpcClient.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAlterarStatus.Enabled = true;
                SalvarInformacoes();
            }
        }

        public void SalvarInformacoes()
        {
            Settings.Default.ID = (long)Convert.ToDecimal(txtIdAplicacao.Text);
            Settings.Default.Estado = txtEstado.Text;
            Settings.Default.Detalhes = txtDetalhes.Text;
            Settings.Default.ImagemRaw = txtImagemRaw.Text;

            Settings.Default.Save();
        }

        private void CarregarInformacoes()
        {
            txtIdAplicacao.Text = Convert.ToString(Settings.Default.ID);
            txtDetalhes.Text = Settings.Default.Detalhes;
            txtEstado.Text = Settings.Default.Estado;
            txtImagemRaw.Text = Settings.Default.ImagemRaw;
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
        private void btnInicializar_Click_1(object sender, EventArgs e) => Inicializar();
        private void btnAtualizar_Click_1(object sender, EventArgs e) => _helper.DefinirPresenca(txtDetalhes.Text, txtEstado.Text, txtImagemRaw.Text);


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
