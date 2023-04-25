using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.core.ViewModels.Controllers;

namespace ToDo.core.ViewModels.Pages
{
    public  class WorkTaskPageViewModel : BaseViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();
        public string  NewWorkTaskTitle { get; set; }

        public string NewWorkTaskDescription { get;set; }

        public ICommand AddNewTaskCommand { get; set; }// Icommmand fucnkcja odpowiedzialna za łączenie buttonów z metodami
        public ICommand DeleteSelectedTaskCommand { get; set; }
        public WorkTaskPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddnewTask);
            DeleteSelectedTaskCommand = new RelayCommand(DeleteSelectedTask);
        }


        private void AddnewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
             };

            WorkTaskList.Add(newTask);

            NewWorkTaskTitle = string.Empty; 
            NewWorkTaskDescription = string.Empty;
            
            //OnPropertyChanged(nameof(NewWorkTaskTitle));
            //OnPropertyChanged(nameof(NewWorkTaskDescription));
        }

        private void DeleteSelectedTask() 
        {
            var selectedTasks = WorkTaskList.Where(x => x.IsSelected).ToList();

            foreach(var task in selectedTasks)
            {
                WorkTaskList.Remove(task);
            }
        }
    }
}
