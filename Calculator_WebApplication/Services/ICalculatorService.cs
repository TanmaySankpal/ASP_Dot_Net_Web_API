using Calculator_WebApplication.Model;

namespace ASPNetCoreWebAPIDemo.Services
{
    public interface ICalculatorService
    {
        
        ResponseModel Addition(NumberSet numberModel);

        
    }
}
