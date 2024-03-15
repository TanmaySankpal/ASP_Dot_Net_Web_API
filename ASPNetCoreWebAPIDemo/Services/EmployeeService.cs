using ASPNetCoreWebAPIDemo.Model;
using ASPNetCoreWebAPIDemo.ViewModel;

namespace ASPNetCoreWebAPIDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmpContext _context;
        public EmployeeService(EmpContext context)
        {
            _context = context;
        }

        ///<summary>
        ///get list of all employee
        ///</summary>
        ///<returns></returns>
        ///

        List<Employee> IEmployeeService.GetEmployeesList()
        {
            List<Employee> empList;
            try
            {
                empList = _context.Set<Employee>().ToList();
            }
            catch (Exception ex) 
            { 
                throw; 
            }
            return empList;
        }
        /// <summary>
        /// get employee details by employee id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public Employee GetEmployeeDetailsById(int empId)
        {
            Employee emp;
            try
            {
                emp = _context.Find<Employee>(empId);
            }
            catch (Exception)
            {
                throw;
            }
            return emp;
        }

        /// <summary>
        ///  add edit employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        /// 

        public ResponseModel SaveEmployee(Employee employeeModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employee _temp = GetEmployeeDetailsById(employeeModel.EmployeeId);
                if (_temp != null)
                {
                    _temp.Designation = employeeModel.Designation;
                    _temp.EmployeeFirstName = employeeModel.EmployeeFirstName;
                    _temp.EmployeeLastName = employeeModel.EmployeeLastName;
                    _temp.Salary = employeeModel.Salary;
                    _context.Update<Employee>(_temp);
                    model.Messsage = "Employee Update Successfully";
                }
                else
                {
                    _context.Add<Employee>(employeeModel);
                    model.Messsage = "Employee Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
       

        /// <summary>
        /// delete employees
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// 
        
        public ResponseModel DeleteEmployee(int employeeId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employee _temp = GetEmployeeDetailsById(employeeId);
                if (_temp != null)
                {
                    _context.Remove<Employee>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Employee Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Employee Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
       

      
    }
}
