using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebApi.Models;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configuration
                .Formatters
                .JsonFormatter
                .SerializerSettings
                .ContractResolver = new CamelCasePropertyNamesContractResolver();


            GlobalConfiguration.Configuration
                .Formatters
                .JsonFormatter
                .SerializerSettings
                .NullValueHandling = NullValueHandling.Ignore;

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Websites"] =  new List<Website>
            {
                new Website
                {
                    Id = 1,
                    Name = "Blogger",
                    Description =
                        "Blogger is a blog publishing service that allows multi-user blogs with time-stamped entries. It was developed by Prya Labs, which wa bought by Google in 2003. generally the blogs are hosted by google in a subdomain of blogger.com. Bloggs can also be hsoted in the registered custom domain of the blogger (like www.example.com) A user can have up to 100 blogs per account",
                    CreatedDate = new DateTime(2003, 9, 26),
                    CreatedTime = "10:00 am",
                    MembershipFee = 12.99,
                    ImageUrl = "/app/assets/images/blogger-logo.png",
                    OwnerAddress = new OwnerAddress
                    {
                        Address = "1 First Street",
                        City = "Boston",
                        Country = "US"
                    },
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Peter Darwin",
                            Title = "Editor",
                            Years = 1,
                            Level = "Junior",
                            Bio = "Some description 1",
                            Mentors = new List<string> {"bradblack", "igorminar", "martinfowler"}

                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Jeff Gomez",
                            Title = "Writer",
                            Years = 1,
                            Level = "Junior",
                            Bio = "Another description ",
                            Mentors = new List<string> { "johnpapadapolis", "bradblack", "igorminar", "martinfowler" }

                        },
                        new Employee
                        {
                            Id = 3,
                            Name = "Rob Stanza",
                            Title = "Manager",
                            Years = 2,
                            Level = "Advanced",
                            Bio = "A description for Rob",
                            Mentors = new List<string>()

                        },
                        new Employee
                        {
                            Id = 4,
                            Name = "Brad Black",
                            Title = "Director",
                            Years = 2,
                            Level = "Advanced",
                            Bio = "Bio for Bradb",
                            Mentors = new List<string>()

                        },
                        new Employee
                        {
                            Id = 5,
                            Name = "John Papadapolis",
                            Title = "Developer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "Bio for John",
                            Mentors = new List<string> {"bradblack", "igorminar" }
                        }
                    }

                },
                new Website {
                    Id = 2,
                    Name = "YouTube",
                    Description =
                        "YouTube is an American video-sharing website headquartered in San Bruno, California. The service was created by three former PayPal employees — Chad Hurley, Steve Chen, and Jawed Karim — in February 2005.",
                    CreatedDate = new DateTime(2005, 2, 14),
                    CreatedTime = "10:00 am",
                    MembershipFee = 12.99,
                    ImageUrl = "/app/assets/images/youtube-logo.jpeg",
                    OwnerAddress = new OwnerAddress
                    {
                        Address = "22 Fisher ave",
                        City = "Boston",
                        Country = "US"
                    },
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Christoph Precht",
                            Title = "Developer",
                            Years = 4,
                            Level = "Beginner",
                            Bio = "Bio for this",
                            Mentors = new List<string> {"bradblack", "igorminar"}

                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "David East",
                            Title = "Developer",
                            Years = 3,
                            Level = "Junior",
                            Bio = "In this workshop, David East will show you how to use Angular with the new ultra-real-time 5D Firebase back end, hosting platform, and wine recommendation engine.",
                            Mentors = new List<string> { "johnpapadapolis", "bradblack", "igorminar" }

                        },
                        new Employee
                        {
                            Id = 3,
                            Name = "Patrick Stapleton",
                            Title = "Writer",
                            Years = 2,
                            Level = "Junior",
                            Bio = "Angular 4's source code may be over 25 million lines of code, but it's really a lot easier to read and understand then you may think. Patrick Stapleton will talk about his secretes for keeping up with the changes, and navigating around the code.",
                            Mentors = new List<string> { "martinfowler" }

                        },
                        new Employee
                        {
                            Id = 4,
                            Name = "Lukas Ruebbelke",
                            Title = "Writer",
                            Years = 1,
                            Level = "Beginner",
                            Bio = "Bio for Bradb",
                            Mentors = new List<string>()

                        },
                        new Employee
                        {
                            Id = 5,
                            Name = "John Papadapolis",
                            Title = "Developer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "In this session, Lukas will present the secret to being awesome, and how he became the President of the United States through his amazing programming skills, showing how you too can be success with just attitude.",
                            Mentors = new List<string> {"bradblack" }
                        }
                    }

                },
                new Website {
                    Id = 3,
                    Name = "Google",
                    Description =
                        "Google Inc. is an American multinational technology company that specializes in Internet-related services and products. These include online advertising technologies, search, cloud computing, software, and hardware",
                    CreatedDate = new DateTime(1998, 9, 4),
                    CreatedTime = "9:00 am",
                    MembershipFee = 2.99,
                    ImageUrl = "/app/assets/images/google-logo.jpeg",
                    OwnerAddress = new OwnerAddress
                    {
                        Address = "62 Mozart ave",
                        City = "salt Lake city",
                        Country = "US"
                    },
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Murphy Randle",
                            Title = "Writer",
                            Years = 2,
                            Level = "Junior",
                            Bio = "We all know that Angular is written in Elm, but did you know how the source code is really written? In this exciting look into the internals of Angular 4, we'll see exactly how Elm powers the framework, and what you can do to take advantage of this knowledge.",
                            Mentors = new List<string> {"bradblack", "igorminar", "martinfowler" }

                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Jamison Dance",
                            Title = "Writer",
                            Years = 2,
                            Level = "Junior",
                            Bio = "React v449.6 has just been released. Let's see how to use this new version with Angular to create even more impressive applications.",
                            Mentors = new List<string> { "bradblack", "martinfowler" }

                        },
                        new Employee
                        {
                            Id = 3,
                            Name = "Rob Wormald",
                            Title = "Writer",
                            Years = 1,
                            Level = "Junior",
                            Bio = "Everyone is using Redux for everything from Angular to React to Excel macros, but you're still having trouble grasping it? We'll take a look at how farmers use Redux when harvesting grain as a great introduction to this game changing technology.",
                            Mentors = new List<string> { "bradblack","martinfowler" , "johnpapadapolis" }

                        },
                        new Employee
                        {
                            Id = 4,
                            Name = "Shai Reznik",
                            Title = "Writer",
                            Years = 1,
                            Level = "Beginner",
                            Bio = "Let's take a look at some of the stranger pieces of Angular 4, including neural net nets, Android in Androids, and using pipes with actual pipes.",
                            Mentors = new List<string> { "bradblack","martinfowler" , "johnpapadapolis", "igorminar" }

                        },
                        new Employee
                        {
                            Id = 5,
                            Name = "Ward Bell",
                            Title = "Writer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "Being a developer in 2037 is about more than just writing bug-free code. You also have to look the part. In this amazing expose, Ward will talk you through how to pick out the right clothes to make your coworkers and boss not only respect you, but also want to be your buddy.",
                            Mentors = new List<string> {"bradblack", "martinfowler" }
                        },
                        new Employee
                        {
                            Id = 6,
                            Name = "John Papa",
                            Title = "Writer",
                            Years = 2,
                            Level = "Junior",
                            Bio = "Coinciding with the release of Star Wars Episode 18, this talk will show how to use directives in your Angular 4 development while drawing lessons from the new movie, featuring all your favorite characters like Han Solo's ghost and Darth Jar Jar.",
                            Mentors = new List<string> {"bradblack", "martinfowler" }
                        }
                    }

                },
                new Website {
                    Id = 4,
                    Name = "Yahoo",
                    Description =
                        "Yahoo! is a web services provider, wholly owned by Verizon Communications through Oath Inc. and headquartered in Sunnyvale, California.",
                    CreatedDate = new DateTime(1995, 3, 2),
                    CreatedTime = "10:00 am",
                    MembershipFee = 2.99,
                    ImageUrl = "/app/assets/images/yahoo-logo.png",
                    OnlineUrl = "http://www.yahoo.com",
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Nancy Smith",
                            Title = "Developer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "Bio",
                            Mentors = new List<string> {"bradblack", "igorminar" }

                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Zach Galifi",
                            Title = "QA Engineer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "Zach's bio",
                            Mentors = new List<string> { "bradblack", "igorminar", "johnpapadapolis" }

                        },
                        new Employee
                        {
                            Id = 3,
                            Name = "Dan Hurry",
                            Title = "Manager",
                            Years = 3,
                            Level = "Advanced",
                            Bio = "Dan likes andriods",
                            Mentors = new List<string> { "igorminar" , "johnpapadapolis" }

                        },
                        new Employee
                        {
                            Id = 4,
                            Name = "Shai Reznik",
                            Title = "Writer",
                            Years = 1,
                            Level = "Beginner",
                            Bio = "Let's take a look at some of the stranger pieces of Angular 4, including neural net nets, Android in Androids, and using pipes with actual pipes.",
                            Mentors = new List<string> { "bradblack","martinfowler" , "johnpapadapolis", "igorminar" }

                        },
                        new Employee
                        {
                            Id = 5,
                            Name = "Ward Bell",
                            Title = "Writer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "Being a developer in 2037 is about more than just writing bug-free code. You also have to look the part. In this amazing expose, Ward will talk you through how to pick out the right clothes to make your coworkers and boss not only respect you, but also want to be your buddy.",
                            Mentors = new List<string> {"bradblack", "martinfowler" }
                        },
                        new Employee
                        {
                            Id = 6,
                            Name = "John Papa",
                            Title = "Writer",
                            Years = 2,
                            Level = "Junior",
                            Bio = "Coinciding with the release of Star Wars Episode 18, this talk will show how to use directives in your Angular 4 development while drawing lessons from the new movie, featuring all your favorite characters like Han Solo's ghost and Darth Jar Jar.",
                            Mentors = new List<string> {"bradblack", "martinfowler" }
                        }
                    }

                },
                new Website {
                    Id = 5,
                    Name = "Nfl.com",
                    Description =
                        "Nfl.com is popular this time of year",
                    CreatedDate = new DateTime(2013, 9,26),
                    CreatedTime = "8:00 am",
                    MembershipFee = 222.99,
                    ImageUrl = "",
                    OwnerAddress = new OwnerAddress
                    {
                        Address = "The Excaliber",
                        City = "Las Vegas",
                        Country = "US"
                    },
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "John Papadapolis",
                            Title = "Developer",
                            Years = 2,
                            Level = "Beginner",
                            Bio = "Bio for John",
                            Mentors = new List<string> {"bradblack", "igorminar" }

                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Dan Hurrying",
                            Title = "Manager",
                            Years = 3,
                            Level = "Advanced",
                            Bio = "Dan likes andriods",
                            Mentors = new List<string> { "igorminar" , "johnpapadapolis" }

                        }
                    }

                }
            };
        }
    }
}
