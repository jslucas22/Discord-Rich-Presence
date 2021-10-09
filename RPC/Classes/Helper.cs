using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace RPC.Classes
{
    public class Helper
    {
        #region ..:: Variáveis ::..
        
        private DiscordRpcClient _discordRpcClient;

        #endregion ..:: Variáives ::..

        #region ..:: Instancias ::..

        private zMain _main = new zMain();

        #endregion ..:: Instancias ::..

        public void Inicializar(string idAplicacao)
        {
            try
            {
                _main.btnInicializar.Enabled = false;

                _discordRpcClient = new DiscordRpcClient(idAplicacao);
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
                _main.SalvarInformacoes();
            }
        }

        public void DefinirPresenca(string detalhes, string estado, string imagemRaw)
        {
            try
            {
                _discordRpcClient.SetPresence(new RichPresence()
                {
                    Details = detalhes,
                    State = estado,
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = imagemRaw,
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
                _main.SalvarInformacoes();
            }
        }
    }
}
