using System.Windows.Forms;

namespace Hexagon
{
    class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel() : base()
        {
            this.DoubleBuffered = true;
        }
    }
}
