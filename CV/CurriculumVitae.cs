using System;
using System.Collections.Generic;

namespace CV
{
    public class CurriculumVitae
    {
        private Person Person { get; set; } = default!;
        private Education Education { get; set; } = default!;
        private List<Language>? Languages { get; set; }
        private List<Hobby>? Hobbies { get; set; }
        private List<Project>? Projects { get; set; }
        
        private List<Skill>? Skills { get; set; }
        private WorkExperience WorkExperience { get; set; } = default!;


        public void CreateCurriculumVitae()
        {
            var curriculumVitae = new CurriculumVitae()
            {
                Person = new Person()
                {
                    Name = "Raul Vesinurm",
                    DateOfBirth = "19.07.1990",
                    Phone = "56648916",
                    Email = "vesinurm.raul@gmail.com",
                    Address = "Mustamäe tee 175-86, Tallinn",
                    LinkedIn = "https://www.linkedin.com/in/raul-vesinurm-a4a036170",
                    Github = "https://github.com/raulves",
                    Personality = "Commitment to do things well, Fast learner, Adaptability - comfortable with changes," +
                                  " Never give up, Try again"
                },
                
                Education = new Education()
                {
                    Schools = new List<School>()
                    {
                        new School()
                        {
                            SchoolName = "Tallinn University of Technology",
                            Programme = "IT Systems Development",
                            StudyPeriod = "2018 - "
                        },
                        new School()
                        {
                            SchoolName = "Tallinn University of Technology",
                            Programme = "Accounting",
                            StudyPeriod = "2010 - 2014",
                            Degree = "Bachelor degree"
                        },
                        new School()
                        {
                            SchoolName = "Tallinna Vanalinna Täiskasvanute Gümnaasium",
                            Programme = "Gymnasium",
                            StudyPeriod = "2008 - 2010"
                        },
                        new School()
                        {
                            SchoolName = "Märjamaa Gymnasium",
                            Programme = "Basic school",
                            StudyPeriod = "1998 - 2007"
                        }
                    }
                },

                Skills = new List<Skill>()
                {
                    new Skill()
                    {
                        SkillName = "Java",
                        Experience = "Learned Java for two semesters. In the first semester I learned the basics of Java" +
                                     " and did a lot of logical exercises and built a game with graphical interface. " +
                                     "In the second semester I learned how to build Rest API in Java."
                    },
                    new Skill()
                    {
                        SkillName = "SQL",
                        Experience = "In the database course I learned how to create a ERD schema. I also took " +
                                     "Oracle SQL and PL/SQL course. I'm quite confident of making SQL sentences."
                    },
                    new Skill()
                    {
                        SkillName = "Python",
                        Experience = "Python was my first programming language I learned. Even now sometimes I write " +
                                     "some code in Python to make some tasks easier. In some subjects we are allowed " +
                                     "to use materials. I created a program that searches through .pdf files and finds " +
                                     "the files where the searchable string is."
                    },
                    new Skill()
                    {
                        SkillName = "C# and .NET",
                        Experience = "Experience in C# for two semesters. In the first year I studied the basics of C#." +
                                     "I built a simple web app and Connect4 game. This semester we are learning how to " +
                                     "build ASP.NET Web applications and Distributed Systems. At the beginning of the " +
                                     "semester we started discovering that how to make soft delete and soft update. It took " +
                                     "us couple of weeks to understand the system behind that. Thanks to the good SQL skills, " +
                                     "understanding about soft delete and update , made it easier."
                    }
                },
                
                WorkExperience = new WorkExperience()
                {
                    Workings = new List<Work>()
                    {
                        new Work()
                        {
                            Company = "Tieto Estonia AS",
                            JobTitle = "Intern",
                            WorkPeriod = "08.2019 - 09.2019",
                            Description = "I took part of Tieto Geek-Off Camp internship program. " +
                                          "It was based on Java."
                        },
                        new Work()
                        {
                            Company = "Rödl & Partner OÜ",
                            JobTitle = "Assistant Accountant",
                            WorkPeriod = "01.2014 - 07.2014",
                            Description = "My work involves working with bank statements by comparing " +
                                          "transactions to the general ledger, inserting invoices to accounting software, " +
                                          "preparing bank deposits."
                        }
                    }
                },
                
                Languages = new List<Language>()
                {
                    new Language()
                    {
                        LanguageName = "Estonian",
                        LanguageLevel = "Native"
                    },
                    new Language()
                    {
                        LanguageName = "English",
                        LanguageLevel = "Intermediate"
                    }
                },
                
                Hobbies = new List<Hobby>()
                {
                    new Hobby()
                    {
                        HobbyName = "Windsurfing"
                    },
                    new Hobby()
                    {
                        HobbyName = "Reading",
                        Comments = "This year I'm planning to read all" +
                                   "Harry Potter's books. I like to read books in the mornings, " +
                                   "so I usually wake up at 6 o'clock"
                    },
                    new Hobby()
                    {
                        HobbyName = "Travelling",
                        Comments = "I'm addicted to travel on islands. I have been living in Hawaii " +
                                   "for 4 months. I have been in Australia for 1,5 years. Recent trip was to Iceland."
                    }
                },
                
                Projects = new List<Project>()
                {
                    new Project()
                    {
                        ProjectName = "People to people equipment rental website",
                        Description = "Giving an opportunity to users where people can rent out their stuff " +
                                      "and earn some money.",
                        Repo = "https://github.com/raulves/EquipmentRentalResourcesProject",
                        Website = "rental.azurewebsites.net"
                    }
                }
                
            };
        }
    }
    
    
    
}