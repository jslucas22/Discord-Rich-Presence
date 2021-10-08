using DiscordRPC;
using DiscordRPC.Logging;
using RPC.Properties;
using System;
using System.Windows.Forms;

namespace RPC
{
    public partial class z : Form
    {
        #region ..:: Variáveis ::..

        private DiscordRpcClient _discordRpcClient;

        #endregion ..:: Variáveis ::..

        #region ..:: Métodos Auxiliares ::..

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAtualizar.Enabled = true;
                SalvarInformacoes();
            }
        }

        private void SalvarInformacoes()
        {
            Settings.Default.ID = (long)Convert.ToDecimal(txtIdAplicacao.Text);
            Settings.Default.Estado = txtEstado.Text;
            Settings.Default.Detalhes = txtDetalhes.Text;
            Settings.Default.ImagemRaw = txtImagemRaw.Text;
            Settings.Default.ImagemBlob = txtImagemBlob.Text;

            Settings.Default.Save();
        }



        private void DefinirPresenca()
        {
            try
            {
                _discordRpcClient.SetPresence(new RichPresence()
                {
                    Details = txtDetalhes.Text,
                    State = txtEstado.Text,
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = txtImagemRaw.Text,
                        LargeImageText = "ZLucas B!tches",
                        SmallImageKey = txtImagemBlob.Text
                    }
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoes()
        {
            txtIdAplicacao.Text = Convert.ToString(Settings.Default.ID);
            txtDetalhes.Text = Settings.Default.Detalhes;
            txtEstado.Text = Settings.Default.Estado;
            txtImagemRaw.Text = Settings.Default.ImagemRaw;
            txtImagemBlob.Text = Settings.Default.ImagemBlob;
        }

        #endregion ..:: Métodos Auxiliares ::..

        #region ..:: Construtor ::..

        public z()
        {
            InitializeComponent();
        }

        #endregion ..:: Construtor ::..

        #region ..:: Eventos ::..

        private void z_Load(object sender, EventArgs e) => CarregarInformacoes();
        private void btnInicializar_Click(object sender, EventArgs e) => Inicializar();
        private void btnAtualizar_Click(object sender, EventArgs e) => DefinirPresenca();

        #endregion ..:: Eventos ::..
    }
}
