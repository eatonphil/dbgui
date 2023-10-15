using System.Text;

using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

using SkiaSharp;
using SkiaSharp.HarfBuzz;

namespace DBGUI {
    class Table {
	List<List<String>> results = new List<List<String>{};
	SKColor textColor = SKColors.Black;
	SKColor backgroundColor = SKColors.White;
	public SKRect Frame { get; set; }

	public void Draw(SKCanvas canvas) {
	    canvas.Save();
	   
	    canvas.Translate(Frame.Left, Frame.Top);
	    canvas.ClipRect(new SKRect(0, 0, Frame.Width, Frame.Height));

	    canvas.DrawColor(backgroundColor, SKBlendMode.Src);

            var textPaint = new SKPaint();
            textPaint.TextSize = textSize;
            textPaint.Color = textColor;
	    textPaint.TextEncoding = SKTextEncoding.Utf8;
	    textPaint.IsAntialias = true;

	    var lineBufferSize = 10;
	    foreach (var row in this.results) {
		foreach (var cell in row) {
		    // TODO: draw cell
		    // CanvasExtensions.DrawShapedText(canvas, s, 25, 25 + textSize * i + lineBuffer, textPaint);
		}
	    }

	    canvas.Restore();
	}
    }
}
