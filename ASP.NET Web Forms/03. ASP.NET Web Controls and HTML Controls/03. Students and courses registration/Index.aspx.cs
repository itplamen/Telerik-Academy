namespace _03.Students_and_courses_registration
{
    using System;
    using System.Web.UI.HtmlControls;

    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.PanelRegistration.Visible = false;
            this.PanelRegistered.Visible = true;

            var studentFullName = new HtmlGenericControl("h2");
            studentFullName.InnerHtml = string.Format("Student: " + this.TextBoxFirstName.Text + " " + this.TextBoxLastName.Text);

            var facultyNumber = new HtmlGenericControl("i");
            facultyNumber.InnerHtml = string.Format("Faculty number: " + this.TextBoxFacultyNumber.Text);

            var university = new HtmlGenericControl("p");
            university.InnerHtml = string.Format("Student from: " + this.DropDownListUniversity.SelectedValue);

            var speciality = new HtmlGenericControl("h3");
            speciality.InnerHtml = string.Format("Speciality: " + this.DropDownListSpeciality.SelectedValue);

            var courses = new HtmlGenericControl("strong");
            courses.InnerHtml = string.Format("Courses: " + this.ListBoxCourses.SelectedValue);

            this.PanelRegistered.Controls.Add(studentFullName);
            this.PanelRegistered.Controls.Add(facultyNumber);
            this.PanelRegistered.Controls.Add(university);
            this.PanelRegistered.Controls.Add(speciality);
            this.PanelRegistered.Controls.Add(courses);
        }
    }
}