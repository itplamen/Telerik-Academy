namespace _01.Mobile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class Search : System.Web.UI.Page
    {
        private IList<Producer> producers = SeedProducers();
        private IList<Extra> extras = SeedExtas();
        private IList<string> engines = SeedEngines();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.ProducersDropDownList.DataSource = this.producers;
                this.ProducersDropDownList.DataBind();

                this.ModelsDropDownList.DataSource = this.producers[0].Models;
                this.ModelsDropDownList.DataBind();

                this.ExtrasCheckBoxList.DataSource = this.extras;
                this.ExtrasCheckBoxList.DataBind();

                this.EnginesRadioButtonList.DataSource = this.engines;
                this.EnginesRadioButtonList.DataBind();
            }
        }

        protected void ProducersDropDownList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProducer = this.producers[this.ProducersDropDownList.SelectedIndex];
            this.ModelsDropDownList.DataSource = selectedProducer.Models;
            this.ModelsDropDownList.DataBind();
        }

        protected void OnSearchButtonClick(object sender, EventArgs e)
        {
            var selectedProducer = this.ProducersDropDownList.SelectedValue;
            var selectedModel = this.ModelsDropDownList.SelectedValue;
            var selectedExtras = this.ExtrasCheckBoxList.Items
                                    .Cast<ListItem>()
                                    .Where(item => item.Selected)
                                    .Select(item => item.Text);
            var selectedEngine = this.EnginesRadioButtonList.SelectedValue;

            this.SearchResults.Controls.Add(new HtmlGenericControl()
            {
                TagName = "p",
                InnerText = "Producer: " + selectedProducer
            });

            this.SearchResults.Controls.Add(new HtmlGenericControl()
            {
                TagName = "p",
                InnerText = "Model: " + selectedModel
            });

            this.SearchResults.Controls.Add(new HtmlGenericControl()
            {
                TagName = "p",
                InnerText = "Extras: " + (selectedExtras.Any() ? string.Join(", ", selectedExtras) : "No extras")
            });

            this.SearchResults.Controls.Add(new HtmlGenericControl()
            {
                TagName = "p",
                InnerText = "Engine: " + selectedEngine
            });

            this.SearchResults.Visible = true;
        }


        private static IList<Producer> SeedProducers()
        {
            return new List<Producer>()
            {
                new Producer()
                {
                    Name = "Not Selected",
                    Models = new List<String>() { "Not selected" }
                },
                new Producer()
                {
                    Name = "Audi",
                    Models = new List<string>() { "R8", "Q7", "A3" }
                },
                new Producer()
                {
                    Name = "BMW",
                    Models = new List<string>() { "7 Sedan", "5 Sedan" }
                },
                new Producer()
                {
                    Name = "Ford",
                    Models = new List<string>() { "EcoBoost" }
                },
                new Producer()
                {
                    Name = "Volkswagen",
                    Models = new List<string>() { "Gol G5", "Golf", "Jetta", "Amarok", "CC" }
                }
            };
        }

        private static IList<Extra> SeedExtas()
        {
            return new List<Extra>()
            {
                new Extra()
                {
                    Name = "Navigation System" 
                },
                new Extra()
                {
                    Name = "Cameras"
                },
                new Extra()
                {
                    Name = "GPS"
                },
                new Extra()
                {
                    Name = "Sensors"
                }
            };
        }

        private static IList<string> SeedEngines()
        {
            return new List<String>()
            {
                "Diesel",
                "Petrol",
                "Electrical",
                "Hybrid"
            };
        }
    }
}