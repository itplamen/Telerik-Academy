window.onload = function() {
    var courseTemplate = Handlebars.compile(document.getElementById('course-template').innerHTML),
        tableBody = document.getElementById('table-body');

    Handlebars.registerHelper('list', function(courses, options) {
        var html = '', course;

        for (var courseID in courses) {
            course = courses[courseID];
            html += options.fn({
                id: courseID,
                title: course.title,
                firstDate: course.firstDate,
                secondDate: course.secondDate
            });
        }

        return new Handlebars.SafeString(html);
    });

    tableBody.innerHTML = courseTemplate({
        courses: Courses
    });
};
