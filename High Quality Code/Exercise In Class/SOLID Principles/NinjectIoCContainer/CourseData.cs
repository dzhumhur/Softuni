namespace NinjectIoCContainer
{
    using System.Collections.Generic;
    using Contracts;

    public class CourseData : ICourseData
    {
        public IEnumerable<string> GetCourseNames()
        {
            return new[] { "JS Applications", "High-Quality Code", "AngularJS" };
        }
    }
}
