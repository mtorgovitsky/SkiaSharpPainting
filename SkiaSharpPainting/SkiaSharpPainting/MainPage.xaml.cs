using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace SkiaSharpPainting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPainting(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                StrokeWidth = 25
            };

            var x = info.Width / 2;

            canvas.DrawCircle(230, 100, 100, paint);

            paint.Style = SKPaintStyle.Fill;
            paint.Color = SKColors.Blue;
            canvas.DrawCircle(230, 100, 100, paint);

            paint.Style = SKPaintStyle.Stroke;
            paint.StrokeWidth = 5;

            SKPath path = new SKPath();
            path.MoveTo(0, 0);
            path.LineTo(120, 120);
            path.MoveTo(120, 0);
            path.LineTo(0, 120);
            canvas.DrawPath(path, paint);

            paint.TextSize = 60;
            canvas.DrawText("Skia Sharp!", 300, 300, paint);
        }
    }
}
