using System;

namespace CompanyHierarchy.Props
{
    class Projects
    {
        public Projects(string name,DateTime startDate,string details,ProjectState state)
        {
            this.ProjectName = name;
            this.ProjectStart = startDate;
            this.ProjectDetails = details;
            this.State = state;
        }

        public string ProjectName { get; set; }

        public DateTime ProjectStart { get; set; }

        public string ProjectDetails { get; set; }

        public ProjectState State { get; set; }

        public void CloseProject()
        {
            this.State = ProjectState.Close;
        }
    }
}
