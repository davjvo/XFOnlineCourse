using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using XFOnlineCourses.Models;

namespace XFOnlineCourses.ViewModels
{
    public class HomePageViewModel
    {
        public List<Course> Courses { get; set; }
        public DelegateCommand<Course> NavigateToCourseCommand { get; set; }
        readonly INavigationService _navigationService;

        public HomePageViewModel(INavigationService navigationService)
        {
            Courses = new List<Course>
            {
                new Course
                {
                    Title = "Development",
                    Description = "19 Courses",
                    Image = "development",
                    Background = "#F2F6FF" ,
                    Price = 40,
                    Content = new List<Content>
                    {
                        new Content
                        {
                            Description = "Introduction to Logic",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "C# Fundamentals",
                            Duration = new TimeSpan(0,5,20)
                        },
                        new Content
                        {
                            Current = true,
                            Description = "Xamarin Layouts",
                            Duration = new TimeSpan(0,15,20)
                        },
                        new Content
                        {
                            Description = "Models, ViewModels and Controls",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "App architecture",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "Dependency Injection with Xamarin Forms",
                            Duration = new TimeSpan(0,10,20)
                        },
                    }
                },
                new Course
                {
                    Title = "Design",
                    Description = "15 Courses",
                    Image = "design",
                    Background = "#FFF3E5",
                    Price = 40,
                    Content = new List<Content>
                    {
                        new Content
                        {
                            Description = "Manipularion of content",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "Visual and Information Design",
                            Duration = new TimeSpan(0,5,20)
                        },
                        new Content
                        {
                            Current = true,
                            Description = "Experiments",
                            Duration = new TimeSpan(0,15,20)
                        },
                    }
                },
                new Course
                {
                    Title = "Marketing",
                    Description = "11 Courses",
                    Image = "marketing",
                    Background = "#FFEDED",
                    Price = 40,
                    Content = new List<Content>
                    {
                        new Content
                        {
                            Current = true,
                            Description = "Market Research Intro",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "How to Get Responses to Your Surveys",
                            Duration = new TimeSpan(0,5,20)
                        },
                        new Content
                        {
                            Description = "How to Analyse Your Survey Results",
                            Duration = new TimeSpan(0,15,20)
                        },
                        new Content
                        {
                            Description = "Market Research Intro",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "Why Market Your Business with Em",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "Collect Emails Without a Website",
                            Duration = new TimeSpan(0,10,20)
                        },
                    }
                },
                new Course
                {
                    Title = "Photography",
                    Description = "10 Courses",
                    Image = "photography",
                    Background = "#DFFFF4",
                    Price = 40,
                    Content = new List<Content>
                    {
                        new Content
                        {
                            Description = "Understanding Light, Part 1",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Current = true,
                            Description = "Understanding Light, Part 2",
                            Duration = new TimeSpan(0,5,20)
                        },
                        new Content
                        {
                            Description = "Camera and Lens Terms/Jargon Explained",
                            Duration = new TimeSpan(0,15,20)
                        },
                        new Content
                        {
                            Description = "What's an Exposure? How Does Exposure Work?",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "How Cameras Try to Determine Exposure",
                            Duration = new TimeSpan(0,10,20)
                        },
                        new Content
                        {
                            Description = "Learning Basic Composition- The Rule of Thirds",
                            Duration = new TimeSpan(0,10,20)
                        },
                    }
                },
            };
            _navigationService = navigationService;
            NavigateToCourseCommand = new DelegateCommand<Course>(NavigateToCourse);
        }

        async void NavigateToCourse(Course course)
        {
            var navParams = new NavigationParameters
            {
                { "model", course }
            };
            await _navigationService.NavigateAsync("CoursePage", navParams);
        }
    }
}
