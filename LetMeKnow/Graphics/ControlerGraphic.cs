using LetMeKnow.DataClass;
using LetMeKnow.Models;

namespace LetMeKnow.Graphics
{
    public class GraphicsDrawable : IDrawable
    {
        ControlerModel ControlerModel;
        ToDo ToDo;
        double Procedure { get { return Math.Min(1, ToDo.LeftTime / ToDo.Span); } }

        public GraphicsDrawable(ToDo todo)
        {
            ToDo = todo;
        }

        public void Draw(ICanvas canvas, RectF rect)
        {
            canvas.FillColor = Colors.Yellow;
            canvas.FillRectangle(0, 0, rect.Width, rect.Height);
        }
    }
}
