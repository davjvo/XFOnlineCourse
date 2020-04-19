using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFOnlineCourses.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseContainer : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
           "Title",
           typeof(string),
           typeof(CourseContainer),
           string.Empty);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
           "Description",
           typeof(string),
           typeof(CourseContainer),
           string.Empty);

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
           "Image",
           typeof(string),
           typeof(CourseContainer),
           string.Empty);

        public string Image
        {
            get => (string)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        public CourseContainer()
        {
            InitializeComponent();
        }


    }
}