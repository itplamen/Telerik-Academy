namespace Menu_Control
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    public partial class MenuOfLinks : UserControl
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.MenuDataList.Style.Add("font-family", this.FontFamily);
        }

        public MenuOfLinks()
        {
            this.FontFamily = "Comic Sans MS";
            this.FontColor = "black";
        }

        public string FontFamily { get; set; }

        public string FontColor { get; set; }

        public IEnumerable<MenuItem> DataSourse
        {
            get
            {
                return (IEnumerable<MenuItem>)this.MenuDataList.DataSource;
            }

            set
            {
                foreach (var item in value)
                {
                    if (string.IsNullOrWhiteSpace(item.FontColor))
                    {
                        item.FontColor = this.FontColor;
                    }
                }

                this.MenuDataList.DataSource = value;
            }
        }

        public override void DataBind()
        {
            this.MenuDataList.DataBind();

            base.DataBind();
        }
    }
}