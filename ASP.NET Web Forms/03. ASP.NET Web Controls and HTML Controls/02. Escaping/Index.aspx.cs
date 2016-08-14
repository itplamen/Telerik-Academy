using System;

namespace _02.Escaping
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            this.TextBoxResult.Text = this.TextBoxDangerousText.Text;
            this.LabelResult.Text = this.Server.HtmlEncode(this.TextBoxResult.Text);
        }
    }
}