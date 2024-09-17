using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Portfolio.Models;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Web;
using Azure;
using Humanizer;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        private const string OwnerName = "Vaishnavi Reddy";

        public HomeController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var viewModel = new PortfolioViewModel
            {
                About = new AboutViewModel
                {
                    Name = OwnerName,
                    Title = "Full Stack Software Developer",
                    Description = "I am deeply passionate about computer science and has great expertise in full stack development, cloud computing. My proficiency extends effortlessly across various domains, driven by a strong zeal for innovation." +
                    "I am particularly excited by emerging technologies and enjoy exploring the business and product aspects of tech development and currently seeking opportunities to learn and grow. Outside of my professional pursuits, I find joy in dancing, reading, and discovering new places.",
                    Skills = new List<Skill>
                    {
                        new Skill { Name = "HTML/CSS", Percentage = 90 },
                        new Skill { Name = "JavaScript", Percentage = 85 },
                        new Skill { Name = "Python", Percentage = 95 },
                        new Skill { Name = "Angular", Percentage = 85 },
                        new Skill { Name = "React", Percentage = 80 },
                        new Skill { Name = "ASP.NET Core", Percentage = 80 },
                        new Skill { Name = "C#", Percentage = 80 },
                        new Skill { Name = "SQL Server", Percentage = 90 },
                        new Skill { Name = "NOSQL", Percentage = 85 },
                        new Skill { Name = "AWS", Percentage = 95 },
                        new Skill { Name = "Azure", Percentage = 80 },


                    }
                },
                Experience = new List<ExperienceItem>
                {
                    new ExperienceItem
                    {
                        JobTitle = "Full Stack Software Developer",
                        Company = "Vitosha Inc",
                        Period = "April 2022 - Present",
                        Description = "Engineered a high-performance online dashboard using a Python (Django) backend and React frontend, " +
                        "significantly enhancing user engagement and overall user experience. " +
                        "Implemented comprehensive data management solutions with both relational (MySQL) and NoSQL databases, " +
                        "including the development of stored procedures and functions tailored to diverse data needs. " +
                        "Actively participated in Agile SCRUM practices to deliver a highly interactive UI that drove increased sales and optimized server load. " +
                        "Developed and refined ETL tools with Python and SQL to streamline data management processes and integrated AWS Lambda functions with services such as S3, DynamoDB, " +
                        "and API Gateway to create seamless and efficient workflows."
                    },
                    new ExperienceItem
                    {
                        JobTitle = "Software Engineer",
                        Company = "Proxforce",
                        Period = "Dec 2020 - Dec 2021",
                        Description = "Developed a comprehensive dashboard for an e-commerce platform, " +
                        "enhancing the front end with HTML forms and Spring MVC controllers to create an intuitive user interface. " +
                        "Reduced troubleshooting time by 50% through precise log file generation, " +
                        "and improved project delivery by 30% by adopting an Agile sprint system and integrating Apollo GraphQL for optimized data management. " +
                        "Engineered scalable backend systems with Node.js and MongoDB, increasing data processing efficiency"
                    }
                },
                Projects = new List<Models.Project>
                {
                    new Models.Project
                    {
                        Title = "My Portfolio",
                        Description = "My Portfolio application is built using ASP.NET Core MVC, leveraging the Model - View - Controller design pattern to separate concerns and enhance maintainability. " +
                        "The front-end is developed with Razor views, HTML, CSS, and JavaScript, ensuring a responsive and user - friendly interface. " +
                        "The back-end is powered by.NET Core, utilizing controllers to handle user input, route requests, and return appropriate views. " +
                        "Entity Framework Core is used for data management, allowing seamless interaction with the database. " +
                        "The application follows best practices in security and performance, ensuring scalability and a smooth user experience.",
                        ImageUrl = "/images/My_Portfolio.png",
                        GitHubLink = "https://github.com/yourusername/portfolio-project"
                   },
                   new Models.Project
                   {
                       Title = "Banking System",
                       Description = "The Banking System is a web-based financial management application built with Flask, designed to provide users with a secure and intuitive platform for managing their bank accounts. " +
                       "Users can perform essential banking operations such as account creation, login, fund deposits, transfers, balance checks, and transaction history viewing. " +
                       "This application features a straightforward user interface with HTML and CSS styling, while leveraging Flask's robust server-side capabilities to handle user interactions and data management.",
                       ImageUrl = "/images/Bankingsystem.png",
                       GitHubLink = "https://github.com/Vaishnavipeddinti/Banking-system.git"
                   },
                   new Models.Project
                   {
                       Title = "Rabbit Gold Rush",
                       Description = "The Rabbit Race Game is an immersive 2D canvas-based racing adventure where players guide a rabbit through a series of increasingly challenging levels. " +
                       "The game boasts smooth animations and dynamic gameplay elements, including various obstacles and collectibles like speed-boosting power-ups and coins. " +
                       "A sophisticated state management system transitions between different game states—such as start, playing, game over, and winning screens—while handling user inputs and collision detection. " +
                       "Particle effects and responsive controls further enhance the gaming experience. This project highlights expertise in JavaScript, canvas manipulation, and event-driven programming, demonstrating a solid grasp of game development principles.",
                       ImageUrl = "/images/Rabbit_Logo.png",
                       GitHubLink = "https://github.com/Vaishnavipeddinti/GoldRush.git"
                   }
                },

                Certifications = new List<Certification>
                {
                    new Certification
                    {
                        Name = "Docker for Developer",
                        IssuingOrganization = "Linkedin",
                        IssueDate = "September 2024",
                        Link = "https://www.linkedin.com/learning/certificates/bf907061f3813078a582e565850f9961d9f9881d01c80fc2bde66400ca6defcf?trk=share_certificate",
                        ImageUrl = "/images/LinkedinLogo.png"
                    },
                    new Certification
                    {
                        Name = "Python Programming",
                        IssuingOrganization = "Hacker Rank",
                        IssueDate = "September 2024",
                        Link ="https://www.hackerrank.com/certificates/4d9563c8ce7a",
                        ImageUrl = "/images/HackerRank.png"
                    },
                    new Certification
                    {
                        Name = "Advanced SQL",
                        IssuingOrganization = "Linkedin",
                        IssueDate = "September  2024",
                        Link = "https://www.linkedin.com/learning/certificates/9ffe8d06b908967bea013f60a48808e23ac478f39fd87d4af8d9978453250bb6?trk=share_certificate",
                        ImageUrl = "/images/linkedinLogo.png"
                    },

                     new Certification
                    {
                        Name = "Bash Mastery",
                        IssuingOrganization = "Udemy",
                        IssueDate = "March 2023",
                        Link = "https://www.udemy.com/certificate/UC-27dc619f-1a01-4a97-9468-cc07b2c431f5/",
                        ImageUrl = "/images/Udemy3.png"
                    },
                },

                Education = new List<Education>
                {

                new Education
                {
                    Degree = "Master of Science in Computer Information Systems",
                    Institution = "New England College",
                    Year = "May 2023"
                },

                new Education
                {
                    Degree = "Bachelor of technology in Mechanical Engineering",
                    Institution = "Mallareddy Engineering College",
                    Year = "July 2021"
                },

               },

                ContactInfo = new ContactInfoViewModel
                {
                    Email = "vaishu17sai@gmail.com",
                    Phone = "(708) 774 3034",
                    Address = "Boston MA"
                }

            };

            return View(viewModel);
        }


        public IActionResult DownloadCV()
        {

            ViewBag.OwnerName = OwnerName;

            var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                                        "wwwroot", "files", "Vaishnavi Reddy.pdf");

            if (System.IO.File.Exists(filePath))
            {
                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "application/pdf", "Vaishnavi Reddy.pdf");
            }
            else
            {
                return NotFound("CV file not found.");
            }
        }

        public IActionResult ViewCV()
        {

            ViewBag.OwnerName = OwnerName;

            var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                                        "wwwroot", "files", "Vaishnavi Reddy.pdf");

            if (System.IO.File.Exists(filePath))
            {
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                return File(fileStream, "application/pdf");
            }
            else
            {
                return NotFound("CV file not found.");
            }
        }


        public IActionResult Awards()
        {
            ViewBag.OwnerName = OwnerName;

            var awardsViewModel = new AwardsViewModel
            {

                About = new AboutViewModel
                {
                    Name = OwnerName
                },

                Awards = new List<Award>
                {
                    new Award
                    {
                        Name = "Kuchipudi Dance Award",
                        Description = "Participated and received the Kuchipudi Dance Award at the Tirumala Devasthanam TTD in 2021. This award is not only a significant milestone in my dance career but also a dream come true, as performing at such a revered venue and being recognized for my dedication to Kuchipudi is a profound honor and a cherished achievement.",
                        Date = "Dec 2020",
                        PresentedBy = "Tirumala Devasthanam TTD"
                    },

                    new Award
                    {
                        Name = "Technical Seminar Participation",
                        Description = "Attended and actively participated in a technical seminar at MCEME, gaining insights into cutting-edge technologies and advancements in the field of electronics and mechanical engineering.",
                        Date = "March 2020",
                        PresentedBy = "Military College of Electronics and Mechanical Engineering (MCEME)"
                    },

                     new Award
                     {
                        Name = "Paper Presentation: Recent Trends in Automation & Digital Marketing",
                        Description = "Presented a research paper on recent trends in automation and digital marketing, highlighting innovative approaches and emerging technologies in these fields.",
                        Date = "Sep 2019",
                        PresentedBy = "Indian Institution of Engineers, Telangana State Centre",
                     },

                      new Award
                      {
                        Name = "Certified Kuchipudi Dancer",
                        Description = "Recognized as a Certified Kuchipudi Dancer by the Limca Book of Records in 2019 for outstanding proficiency and dedication to the classical Indian dance form of Kuchipudi.",
                        Date = "Aug 2019",
                        PresentedBy = "Limca Book Of Records 2019"
                      },


                      new Award
                      {
                        Name = "ISO Certified AUTOCAD Certification",
                        Description = "Earned a certification in Mechanical CAD AutoCAD from ISO CADDESK, acquiring advanced skills in design and drafting for mechanical engineering applications.",
                        Date = "July 2019",
                        PresentedBy = "CADDESK"
                      },

                       new Award
                       {
                        Name = "Certificate of Participation : Various Seminars and Workshops",
                        Description = "Attended and received participation certificates for 3D Printing, Technical Hunt, Mock Placement and other various seminars and workshops, reflecting a commitment to continuous learning and professional development.",
                        Date = "2017 - 2021",
                        PresentedBy = "MREC"
                       },

                    new Award
                    {
                        Name = "Kuchipudi Dance Certification",
                        Description = "Completed a certified course in Kuchipudi, showcasing my passion for Indian classical dance and commitment to learning.",
                        Date = "May 2014",
                        PresentedBy = "Potti Sreeramulu Telugu University"

                    },


                    new Award
                    {
                        Name = "Hindi Certifications: Prathamic & Madhyama",
                        Description = "Successfully completed both Prathamic and Madhyama level Hindi certifications, demonstrating proficiency and dedication to mastering the Hindi language.",
                        Date = "Nov 2011 - Apr 2012",
                        PresentedBy = "Dakshina Bharat Hindi Prachar Sabha, Madras",
                    },





                }

            };

            return View(awardsViewModel);
        }

        public IActionResult CourseWork()
        {
            ViewBag.OwnerName = OwnerName;

            var courseWorkViewModel = new CourseWorkViewModel
            {
                About = new AboutViewModel
                {
                    Name = OwnerName
                },
                Courses = new List<Course>
                {
                    new Course
                    {
                        Name = "CT5230 | Cloud Computing Concepts",
                        Period = "Spring I 2023",
                        Grade = "A (4.0)",
                        Description = "This course provides the basic skills required to analyze, design, and implement cloud-based solutions in a multitude of organizational structures. " +
                        "It focuses on the integration of scalable, reliable platforms, utilizing such fundamental concepts as: private vs. public clouds, migration, virtualization, debugging, development and performance metrics, and disaster recovery. " +
                        "Additional tools and topics, such as the use of Amazon Web Servers, are also explored."
                    },

                    new Course
                    {
                        Name = "CT6540 | Python for Data Science&Anlytc",
                        Period = "Spring I 2023",
                        Grade = "A (4.0)",
                        Description = "The course begins with a review of basic Python syntax, concepts and operation. " +
                        "The course will explore using JSON and SQL for data exchange and database access. " +
                        "Students will learn to work with the Python libraries that are used for mathematical calculations and data analysis, including: Pandas, NumPy, and SciPy. " +
                        "Once familiar with data generation, analysis and visualization techniques, the class will use Matplotlib to analyze data, and develop data-driven decisions."
                    },

                    new Course
                    {
                        Name = "CT 6560 | Web Programming with PHP/MySQL",
                        Period = "Spring II 2023",
                        Grade = "A (4.0)",
                        Description = "Server-Side Web Programming introduces the student to the core concepts of creating dynamic web pages using the PHP programming language and the MySQL database server. " +
                        "Students will learn to create and maintain their own databases and to execute the SQL required to access those structures using PHP. " +
                        "Students will acquire the skills and templates required to construct web-based, content management oriented platforms. "
                    },
                    new Course
                    {
                        Name = "CT 6670 | Network Communications",
                        Period = "Spring II 2023",
                        Grade = "A (4.0)",
                        Description = "In this course you will study data communication networks focusing on the layered network structure and basic protocol functions. " +
                        "The course covers issues such as addressing, multiplexing, routing, forwarding, flow control, error control, congestion response, and reliability. " +
                        "It includes wired, wireless, and mobile networks. Multimedia, security, and network management topics will be introduced. " +
                        "Brief coverage is provided of the history of the Internet and the development of communication standards "
                    },
                    new Course
                    {
                        Name = "CT 5000 | Graduate & Prof Skill Devlopment",
                        Period = "Summer I 2022",
                        Grade = "A (4.0)",
                        Description = "The course introduces students to the tools needed to complete an advanced degree in Computer Information Systems at New England College. " +
                        "Students review the basic English level skills required to conduct scholarly and professional research and to report their results in a standard recognized format. " +
                        "The class also focuses on the tools needed to participate successfully in an intercultural, professional IT environment, including job procurement techniques, resume preparation and employment interviewing techniques."
                    },
                    new Course
                    {
                        Name = "CT 5610 | Database Design",
                        Period = "Fall I 2022",
                        Grade = "A (4.0)",
                        Description = "This course introduces database design and creation. Emphasis is on data dictionaries, normalization, data integrity, data modeling, and creation of simple tables, queries, reports, and forms. " +
                        "Students should be able to design and implement normalized database structures by creating database tables, queries, reports, and forms. Students will use MS Access and MS SQL Server and the SQL programming language. " +
                        "They will also work with Visio to create database diagrams."
                    },
                    new Course
                    {
                        Name = "CT 6110 | IT Project Management",
                        Period = "Fall II 2022",
                        Grade = "B+ (3.84)",
                        Description = "This course is designed to apply the principles and methodologies of project management to plan and manage IT projects. " +
                        "Throughout the course, students use technology applications and address real-world problems. " +
                        "Students will learn the skills necessary to define project scope, create workable project plans, and manage projects with quality, budget, and schedule in mind."
                    },
                    new Course
                    {
                        Name = "CT 6111 | Information Security",
                        Period = "Fall II 2022",
                        Grade = "A (4.0)",
                        Description = "Cybersecurity is a growing field that deals with threats to hardware and software in both public and private environments. " +
                        "This course is designed to prepare the software professional for a wide range of security challenges, including reviews of: cryptography, web security, network attacks, malware, operating systems, cloud processing and physical security. " +
                        "A wide range of security tools and procedures will be considered."
                    },
                    new Course
                    {
                        Name = "CT 6530 | Python Programming",
                        Period = "Fall I 2022",
                        Grade = "B+ (3.84)",
                        Description = "This course provides an introduction to computer programming in Python, a popular, easy-to-learn, cross-platform language with extensive libraries. " +
                        "Programs can be written for immediate interpretation or for compilation. The language, libraries and development environments are open-source and free. " +
                        "Students will learn to recognize problems appropriate for computer program solutions, to determine the requirements of those solutions, and to translate those requirements into procedural programming constructs. " +
                        "Object-oriented programming methodology will also be covered."
                    }
                }

            };

            return View(courseWorkViewModel);
        }



        [HttpPost]
        public IActionResult SubmitContact(string Name, string Email, string Message)
        {
            try
            {
                SendEmail(Name, Email, Message);
                TempData["Message"] = "Thank you for your message. We'll get back to you soon!";
            }
            catch (Exception)
            {
                TempData["Message"] = "Sorry, there was an error sending your message. Please try again later.";
            }

            return RedirectToAction("Index");

        }


        private void SendEmail(string name, string email, string message)
        {
            var smtpServer = _configuration["EmailSettings:SmtpServer"];
            var smtpPort = int.Parse(_configuration["EmailSettings:SmtpPort"]);
            var smtpUsername = _configuration["EmailSettings:SmtpUsername"];
            var smtpPassword = _configuration["EmailSettings:SmtpPassword"];
            var recipientEmail = _configuration["EmailSettings:RecipientEmail"];

            using (var client = new SmtpClient(smtpServer, smtpPort))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                client.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(smtpUsername),
                    Subject = "Mail Received From Portfolio",
                    Body = $@"<html><body>
                              <p><strong>Name</strong>: {HttpUtility.HtmlEncode(name)}</p>
                              <p><strong>Email</strong>: {HttpUtility.HtmlEncode(email)}</p>
                              <p><strong>Message</strong>: {HttpUtility.HtmlEncode(message)}</p>
                              </body></html>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(recipientEmail);

                client.Send(mailMessage);
            }
        }

        public IActionResult ProfilePhoto()
        {
            var imagePath = Path.Combine(_environment.WebRootPath, "images", "Vaishanvi.jpeg");
            if (System.IO.File.Exists(imagePath))
            {
                return PhysicalFile(imagePath, "image/jpeg");
            }
            else
            {
                return NotFound("Profile photo not found.");
            }
        }

    }
}
