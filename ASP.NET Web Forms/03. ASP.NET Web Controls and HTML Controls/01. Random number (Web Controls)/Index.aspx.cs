using System;
using System.Web.UI;

namespace _01.Random_number__Web_Controls_
{
    public partial class Index : Page
    {
        private Random randomNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.randomNumber = new Random();
        }

        protected void GenerateNumber_Click(object sender, EventArgs e)
        {
            int minRange;
            int.TryParse(this.MinRange.Text, out minRange);

            int maxRange;
            int.TryParse(this.MaxRange.Text, out maxRange);

            this.GeneratedNumber.Text = this.randomNumber.Next(minRange, maxRange).ToString();
        }
    }
}