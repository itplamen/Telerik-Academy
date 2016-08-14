using System;
using System.Web.UI;

namespace _01.Random_number__HTML_Controls_
{
    public partial class Index : Page
    {
        private Random randomNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.randomNumber = new Random();
        }
 
        protected void ButtonGenerate_Click(object sender, EventArgs e)
        {
            int minRange;
            int.TryParse(this.MinRange.Value, out minRange);

            int maxRange;
            int.TryParse(this.MaxRange.Value, out maxRange);

            this.GeneratedNumber.InnerHtml = this.randomNumber.Next(minRange, maxRange).ToString();
        }
    }
}