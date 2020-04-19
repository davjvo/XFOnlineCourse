using Prism.Commands;
using Prism.Navigation;
using System.ComponentModel;
using XFOnlineCourses.Models;

namespace XFOnlineCourses.ViewModels
{
    public class CoursePageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public Course Course { get; set; }
        public DelegateCommand GoBackCommand { get; set; }
        readonly INavigationService _navigationService;

        public event PropertyChangedEventHandler PropertyChanged;

        public CoursePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new DelegateCommand(GoBack);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Course = parameters.GetValue<Course>("model");

        }

        async void GoBack()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
