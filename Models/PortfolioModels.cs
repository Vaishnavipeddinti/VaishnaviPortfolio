namespace Portfolio.Models
{

    public class PortfolioViewModel
    {
        public AboutViewModel About { get; set; }
        public List<ExperienceItem> Experience { get; set; }
        public List<Project> Projects { get; set; }
        public List<Education> Education { get; set; }
        public List<Certification> Certifications { get; set; }
        public ContactInfoViewModel ContactInfo { get; set; }
    }

    public class CourseWorkViewModel
    {
        public List<Course> Courses { get; set; }
        public AboutViewModel About { get; set; }
    }


    public class AwardsViewModel
    {
        public List<Award> Awards { get; set; }

        public AboutViewModel About { get; set; }
    }

    public class AboutViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Percentage { get; set; }
    }

    public class ExperienceItem
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }
    }

    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GitHubLink { get; set; }

    }

    public class Certification
    {
        public string Name { get; set; }
        public string IssuingOrganization { get; set; }
        public string IssueDate { get; set; }
        public string Link { get; set; }

        public string ImageUrl { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Year { get; set; }
    }

    public class ContactInfoViewModel
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class Award
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string PresentedBy { get; set; }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Period { get; set; }
        public string Grade { get; set; }
        public string Description { get; set; }
    }
}
