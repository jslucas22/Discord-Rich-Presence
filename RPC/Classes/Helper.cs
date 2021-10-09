using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace RPC.Classes
{
    public class Helper
    {
        #region ..:: Variáveis ::..
        
        private DiscordRpcClient _discordRpcClient;
        private zMain _main;
        private string _idAplicaco;
        private string _detalhes;
        private string _estado;
        private string _imagemRaw;

        #endregion ..:: Variáives ::..

        public Helper(string idAplicaco, string detalhes, string estado, string imagemRaw)
        {
            _idAplicaco = idAplicaco;
            _detalhes = detalhes;
            _estado = estado;
            _imagemRaw = imagemRaw;
        }

        public void Inicializar()
        {
            try
            {
                _main = new zMain();
                _main.btnInicializar.Enabled = false;

                _discordRpcClient = new DiscordRpcClient(_idAplicaco);
                _discordRpcClient.Logger = new ConsoleLogger()
                {
                    Level = LogLevel.Warning
                };
                _discordRpcClient.Initialize();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _main.btnAlterarStatus.Enabled = true;
                _main.SalvarInformacoes(_idAplicaco, _estado, _detalhes, _imagemRaw);
            }
        }

        public void DefinirPresenca()
        {
            try
            {
                _discordRpcClient.SetPresence(new RichPresence()
                {
                    Details = _detalhes,
                    State = _estado,
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = _imagemRaw,
                        LargeImageText = "Discord RPC Tool by ZLucas <3",
                    }
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _main.SalvarInformacoes(_idAplicaco, _estado, _detalhes, _imagemRaw);
            }
        }
    }
}
