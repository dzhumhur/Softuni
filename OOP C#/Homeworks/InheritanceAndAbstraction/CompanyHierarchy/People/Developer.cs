namespace CompanyHierarchy
{
    using Enums;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects = new List<Project>();

        public Developer(int id, string firstName, string lastName, decimal salary, Department department)
                           : base(id, firstName, lastName, salary, department)
        {

        }

        public IEnumerable<Project> Projects
        {
            get { return this.projects; }
        }

        public void AddProject(Project project)
        {
            this.projects.Add(project);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
