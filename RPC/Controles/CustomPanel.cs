using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace RPC.Controles
{
    public class CustomPanel : Panel
    {

        #region ..:: Variáveis ::..

        private int _tamanhoBorda = 0;
        private int _tamanhoRadius = 0;
        private Color _corBorda = Color.MediumSlateBlue;

        #endregion ..:: Variáveis ::..

        #region ..:: Propriedades ::..

        [Category("ZLucas RPresence - Propriedades")]
        public int TamanhoBorda
        {
            get { return _tamanhoBorda; }
            set
            {
                _tamanhoBorda = value;
                this.Invalidate();
            }
        }
        [Category("ZLucas RPresence - Propriedades")]
        public int TamanhoRaio
        {
            get { return _tamanhoRadius; }
            set
            {
                _tamanhoRadius = value;
                this.Invalidate();
            }
        }
        [Category("ZLucas RPresence - Propriedades")]
        public Color CorBorda
        {
            get { return _corBorda; }
            set
            {
                _corBorda = value;
                this.Invalidate();
            }
        }
        [Category("ZLucas RPresence - Propriedades")]
        public Color CorBotao
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("ZLucas RPresence - Propriedades")]
        public Color CorTextoBotao
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion ..:: Propriedades ::..

        #region ..:: Construtor ::..

        public CustomPanel()
        {
            this.Size = new Size(100, 100);
            this.BackColor = Color.RoyalBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Panel_Resize);
        }

        #endregion ..:: Construtor ::..

        #region ..:: Métodos ::..

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (_tamanhoRadius > this.Height)
                _tamanhoRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle retangulo, float raio)
        {
            GraphicsPath raphicsPath = new GraphicsPath();
            float tamanhoCurva = raio * 2F;
            raphicsPath.StartFigure();
            raphicsPath.AddArc(retangulo.X, retangulo.Y, tamanhoCurva, tamanhoCurva, 180, 90);
            raphicsPath.AddArc(retangulo.Right - tamanhoCurva, retangulo.Y, tamanhoCurva, tamanhoCurva, 270, 90);
            raphicsPath.AddArc(retangulo.Right - tamanhoCurva, retangulo.Bottom - tamanhoCurva, tamanhoCurva, tamanhoCurva, 0, 90);
            raphicsPath.AddArc(retangulo.X, retangulo.Bottom - tamanhoCurva, tamanhoCurva, tamanhoCurva, 90, 90);
            raphicsPath.CloseFigure();
            return raphicsPath;
        }

        protected override void OnPaint(PaintEventArgs pEvento)
        {
            base.OnPaint(pEvento);
            Rectangle superficieRetangulo = this.ClientRectangle;
            Rectangle bordaRetangulo = Rectangle.Inflate(superficieRetangulo, -_tamanhoBorda, -_tamanhoBorda);
            int suavidadeBorda = 2;

            if (_tamanhoBorda > 0)
            {
                suavidadeBorda = _tamanhoBorda;
            }

            if (_tamanhoRadius > 2)
            {
                using (GraphicsPath gpSuperficie = GetFigurePath(superficieRetangulo, _tamanhoRadius))
                using (GraphicsPath pBorda = GetFigurePath(bordaRetangulo, _tamanhoRadius - _tamanhoBorda))
                using (Pen penSuperficie = new Pen(this.Parent.BackColor, suavidadeBorda))
                using (Pen penBorda = new Pen(_corBorda, _tamanhoBorda))
                {
                    pEvento.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    this.Region = new Region(gpSuperficie);

                    pEvento.Graphics.DrawPath(penSuperficie, gpSuperficie);

                    if (_tamanhoBorda >= 1)
                        pEvento.Graphics.DrawPath(penBorda, pBorda);
                }
            }
            else
            {
                pEvento.Graphics.SmoothingMode = SmoothingMode.None;

                this.Region = new Region(superficieRetangulo);

                if (_tamanhoBorda >= 1)
                {
                    using (Pen penBorda = new Pen(_corBorda, _tamanhoBorda))
                    {
                        penBorda.Alignment = PenAlignment.Inset;
                        pEvento.Graphics.DrawRectangle(penBorda, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        #endregion ..:: Métodos ::..
    }
}
