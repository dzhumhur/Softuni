namespace CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IDeveloper
    {
        IEnumerable<Project> Projects { get; }

        void AddProject(Project project);
    }
}
