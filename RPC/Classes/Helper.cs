using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace RPC.Classes
{
    public class Helper
    {
        #region ..:: Variáveis ::..
        
        private DiscordRpcClient _discordRpcClient;
        private zMain _main = new zMain();
        private readonly string _idAplicaco;
        private readonly string _detalhes;
        private readonly string _estado;
        private readonly string _imagemRaw;

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
                        LargeImageText = "Discord RPC Tool by ZLucas <3"                        
                    }
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
