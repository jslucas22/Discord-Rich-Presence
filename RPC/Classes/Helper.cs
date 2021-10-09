using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace RPC.Classes
{
    public class Helper
    {
        #region ..:: Variáveis ::..

        private DiscordRpcClient _discordRpcClient;
        private readonly string _idAplicaco;

        #endregion ..:: Variáives ::..

        #region ..:: Construtor ::..

        public Helper(string idAplicaco)
        {
            _idAplicaco = idAplicaco;
        }

        #endregion ..:: Construtor ::..

        #region ..:: Metodos ::..

        public void Inicializar()
        {
            try
            {
                _discordRpcClient = new DiscordRpcClient(_idAplicaco)
                {
                    Logger = new ConsoleLogger()
                    {
                        Level = LogLevel.Warning
                    }
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

        #endregion ..:: Metodos ::..
    }
}
