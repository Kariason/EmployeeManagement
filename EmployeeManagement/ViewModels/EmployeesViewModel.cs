using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.ViewModels
{
    public class EmployeesViewModel
    {
        private EmployeeRepository _employeeRepository { get; set; }
        public EmployeesViewModel()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return new ObservableCollection<Employee>
                    (_employeeRepository.GetAll());
            }
        }


    }
}
