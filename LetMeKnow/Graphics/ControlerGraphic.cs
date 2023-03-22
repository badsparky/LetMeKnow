using LetMeKnow.TodoClass;
using LetMeKnow.Models;
using LetMeKnow.Graphics.Drawer;

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
            var shape = new Drawer.Drawer.Ellipse(Math.Min(rect.Width, rect.Height) / 2);
            Drawer.Drawer.Draw(canvas, rect, shape, Colors.LightYellow);
            Drawer.Drawer.Draw(canvas, rect,shape,Colors.Yellow, Procedure);
        }
       
    }
}
