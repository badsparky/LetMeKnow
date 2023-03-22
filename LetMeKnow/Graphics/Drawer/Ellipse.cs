namespace LetMeKnow.Graphics.Drawer;
 
public class Drawer
{
    public class Ellipse
    {
        public float Diamiter;
        public Ellipse(float diamiter)
        {
            Diamiter = diamiter;
        } 
    }

    public static void Draw(ICanvas canvas,RectF rect,Ellipse ellipse,Color color, double factor=1 ) 
    {
        var height = rect.Height;
        var width = rect.Width;
        var diamiter = (float)(ellipse.Diamiter * factor);
        var sX =(float) (width - diamiter )/ 2;
        var sY = (float)(height - diamiter) / 2;

        canvas.FillColor = color;
        canvas.FillEllipse(sX, sY, diamiter, diamiter);
    }
}
