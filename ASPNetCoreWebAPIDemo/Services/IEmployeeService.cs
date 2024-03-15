using ASPNetCoreWebAPIDemo.Model;
using ASPNetCoreWebAPIDemo.ViewModel;

namespace ASPNetCoreWebAPIDemo.Services
{
    public interface IEmployeeService
    {
        ///<summary>
        ///get list of all employee
        ///</summary>
        ///<returns></returns>
        List<Employee> GetEmployeesList();

        ///<summary>
        ///get employee details by employee id
        ///</summary>
        ///<param name="empId"></param>
        ///<returns></returns>
        Employee GetEmployeeDetailsById(int empId);

        ///<summary>
        ///add or update employee
        ///</summary>
        ///<param name="employeeModel"></param>
        ///<returns></returns>
        ResponseModel SaveEmployee(Employee employeeModel);

        ///<summary>
        ///delete employee
        ///</summary>
        ///<param name="employeeId"></param>
        ///<returns></returns>
        ResponseModel DeleteEmployee(int employeeId);
    }
}
