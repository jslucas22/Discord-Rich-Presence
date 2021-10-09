using System;
using System.Runtime.InteropServices;

namespace RPC.Classes
{
    public class CantosArredondados
    {
        #region ..:: Coordenadas ::..

        /*    y
         *    |    z
         *    |   /
         *    |  /
         *    | /
         *    |/____________ x
         */

        #endregion ..:: Coordenadas ::..

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CriarCantoArredondado
        (
            int _esquerdaRetangulo,
            int _topoRetangulo,
            int _direitaRetangulo,
            int _inferiorRetangulo,
            int _larguraRetangulo,
            int _alturaRetangulo
        );

        /// <summary>
        /// Cria os cantos arredondados para o form
        /// </summary>
        /// <param name="esquerda">Esquerda superior do frm   (x) </param>
        /// <param name="topo">Esquerda superior do frm       (y) </param>
        /// <param name="direita">Direita inferior do frm     (x) </param>
        /// <param name="inferior">Direita inferior do frm    (y) </param>
        /// <param name="largura">Largura do frm                  </param>
        /// <param name="altura">Tamanho do frm                   </param>
        /// <returns></returns>
        public static IntPtr ArredondarCantos(int esquerda, int topo, int direita, int inferior, int largura, int altura)
        {
            return CriarCantoArredondado(esquerda, topo, direita, inferior, largura, altura);
        }
    }
}