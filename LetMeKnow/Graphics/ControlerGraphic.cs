﻿using LetMeKnow.DataClass;
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
            var height=rect.Height;
            var width=rect.Width;
            var half = Math.Min(height, width) / 2;
            var startPoint = half / 2;

            canvas.FillColor = Colors.Yellow;
            canvas.DrawRectangle(0, 0, width, height);
            canvas.DrawEllipse(startPoint, startPoint, half, half);
            canvas.FillEllipse(startPoint, startPoint, (float)(half* Procedure), (float)(half * Procedure));
        }
    }
}
