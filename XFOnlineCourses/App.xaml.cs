using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using XFOnlineCourses.ViewModels;
using XFOnlineCourses.Views;

[assembly: ExportFont("FA5Regular900.otf", Alias = "FontAwesome")]

namespace XFOnlineCourses
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync(new Uri("/HomePage", UriKind.Absolute));
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<CoursePage, CoursePageViewModel>();
        }


    }
}
