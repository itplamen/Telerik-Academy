namespace _06.Visitors.WebClient
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Linq;
    using System.Web.UI;

    using Visitors.Data;
    using Visitors.Models;

    public partial class Index : Page
    {
        private VisitorsDbContext context = new VisitorsDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GenerateImage();
        }

        private int GetOrIncreasePageVisits()
        {
            var visitors = this.context.Visitors.FirstOrDefault();

            if (visitors == null)
            {
                var visitor = new Visitor
                {
                    Count = 1
                };

                this.context.Visitors.Add(visitor);
                this.context.SaveChanges();
                return visitor.Count;
            }
            else
            {
                visitors.Count++;
                this.context.SaveChanges();
                return visitors.Count;
            }
        }

        private void GenerateImage()
        {
            using (Bitmap bitmap = new Bitmap(100, 100))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.FillRectangle(Brushes.Black, 0, 0, 200, 200);
                    graphics.DrawString(
                        this.GetOrIncreasePageVisits().ToString(),
                        new Font("Arial", 40),
                        new SolidBrush(Color.White),
                        new PointF(30, 25)
                    );

                    this.Response.ContentType = "image/jpeg";
                    bitmap.Save(this.Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        }
    }
}