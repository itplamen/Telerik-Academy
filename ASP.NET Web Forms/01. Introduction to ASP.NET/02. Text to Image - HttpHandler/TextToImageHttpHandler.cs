namespace _02.Text_to_Image___HttpHandler
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Web;

    public class TextToImageHttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var text = context.Request.QueryString["text"];

            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException("Query string cannot be null!");
            }

            this.GenerateImage(context.Response, text, 500, 500, Color.Black,
                FontFamily.GenericSerif, 20, Brushes.Green, 0, 0, "image/png", ImageFormat.Png);
        }

        private void GenerateImage(HttpResponse response, string text, int width, int height, Color backgroundColor,
            FontFamily fontFamily, float emSize, Brush brush, float x, float y, string contentType, ImageFormat imageFormat)
        {
            using (var bitmap = new Bitmap(width, height))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(backgroundColor);
                    graphics.DrawString(text, new Font(fontFamily, emSize), brush, x, y);
                    response.ContentType = contentType;
                    bitmap.Save(response.OutputStream, imageFormat);
                }
            }
        }
    }
}