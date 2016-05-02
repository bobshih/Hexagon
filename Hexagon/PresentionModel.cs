
using System.Collections.Generic;
namespace Hexagon
{
    class PresentionModel
    {
        Model _model;

        public PresentionModel(int width, int height, int size=10)
        {
            _model = new Model(width, height, size);
        }

        public int Radius
        {
            get
            {
                return _model.Radius;
            }
        }

        public List<vector2> GetHexagons()
        {
            return _model.GetHexagons();
        }

        public void SetWidthAndHeight(int w, int h)
        {
            _model.SetWidthAndHeight(w, h);
        }
    }
}
