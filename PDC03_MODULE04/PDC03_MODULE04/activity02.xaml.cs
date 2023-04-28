using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employee; } }
        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employee;

            employee.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employee.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "Vice President" });
            employee.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "Director" });
            employee.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "Supervisor" });
        }
    


        private void Add_item(object sender, EventArgs e)
        {

        }
        private void Edit_item(object sender, EventArgs e)
        {
        }        
        private void Delete_item(object sender, EventArgs e)
            { 
           }
        }
    }