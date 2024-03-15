
using Calculator_WebApplication.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace ASPNetCoreWebAPIDemo.Services
{
    public class CalculatorService : ICalculatorService
    {
        private AppDBContext _context;
        public CalculatorService(AppDBContext context)
        {
            _context = context;
        }

        ResponseModel ICalculatorService.Addition(NumberSet numberModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                int iSum = numberModel.Number1 + numberModel.Number2 + numberModel.Number3;

                
                    numberModel.Sum = iSum;
                

                _context.Add<NumberSet>(numberModel);
                _context.SaveChanges();


                model.Sum = iSum;
                model.IsSuccess = true;
                model.Message = "Addition successful";
            }
            catch(Exception ex) 
            {
                model.IsSuccess=false;
                model.Message = "Error :"+ ex.Message;
            }
                return model;
            
        }
    }
}
