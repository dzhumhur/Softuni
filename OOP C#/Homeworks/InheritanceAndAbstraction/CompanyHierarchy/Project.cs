namespace CompanyHierarchy
{
    using Enums;
    using System;

    public class Project
    {
        private string name;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Project(string name, DateTime startDate, string details, ProjectState state)
        {
            this.Name = name;
            this.startDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get { return this.name;  }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Project name cannot be empty, null or whitespaces");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate;}
            set
            {
                this.startDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Details cannot be empty, null or whitespaces");
                }

                this.details = value;
            }
        }

        public ProjectState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}",
                                 this.Name,
                                 this.StartDate,
                                 this.Details,
                                 this.State);
        }
    }
}
