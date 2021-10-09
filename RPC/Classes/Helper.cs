using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
