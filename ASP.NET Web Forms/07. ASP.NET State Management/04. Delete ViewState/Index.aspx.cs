namespace _04.Delete_ViewState
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.ViewState["values"] == null)
            {
                this.ViewState.Add("values", new List<string>());
            }
        }

        protected void OnShowViewStateBtnClick(object sender, EventArgs e)
        {
            var list = (List<string>)this.ViewState["values"];
            list.Add(this.TextBox.Text);
            this.DisplayViewStateLiteral.Text = string.Empty;

            foreach (var item in list)
            {
                this.DisplayViewStateLiteral.Text += "<br/>" + item;
            }

            this.TextBox.Text = string.Empty;
        }
    }
}