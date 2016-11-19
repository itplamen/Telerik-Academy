namespace _05.Image_Counter
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Web.UI;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.IncreasePageVisits();
            this.GenerateImage();
        }

        private void IncreasePageVisits()
        {
            this.Application.Lock();

            if (this.Application["Visits"] == null)
            {
                this.Application["Visits"] = 1;
            }
            else
            {
                this.Application["Visits"] = (int)this.Application["Visits"] + 1;
            }

            this.Application.UnLock();
        }

        private string GetVisitors()
        {
            return this.Application["Visits"].ToString();
        }

        private void GenerateImage()
        {
            using (Bitmap bitmap = new Bitmap(100, 100))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.FillRectangle(Brushes.Black, 0, 0, 200, 200);
                    graphics.DrawString(
                        this.GetVisitors(), 
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