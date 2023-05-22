using System.Net.Http.Headers;
using System.Windows.Controls;
using ToDo.core.ViewModels.Controllers;
using ToDo.core.ViewModels.Pages;

namespace ToDoWPF
{
    /// <summary>
    /// Logika interakcji dla klasy WorkTasksPage1.xaml
    /// </summary>
    public partial class WorkTasksPage1 : Page
    {
        public WorkTasksPage1()
        {
            InitializeComponent();

            DataContext = new WorkTaskPageViewModel();
        }
    }
}
