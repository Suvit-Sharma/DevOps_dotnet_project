using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public String Index()
        {
            return "This is a calculator : \n\n" +
                "\tTo add       -> calculator/add/num1/num2\n" +
                "\tTo subtract  -> calculator/sub/num1/num2\n" +
                "\tTo multiply  -> calculator/mul/num1/num2\n" +
                "\tTo divide    -> calculator/div/num1/num2\n";
        }

        // This method will let the user add 2 numbers
        public string Add(String id1, String id2)
        {
            if (double.TryParse(id1, out double intNum1) && double.TryParse(id2, out double intNum2))
            {
                double ans = intNum1 + intNum2;
                return ans.ToString("F2");
            }
            else
            {
                return "Please enter valid numbers";
            }
        }


        // This method will let the user subtract 2 numbers
        public string sub(String id1, String id2)
        {
            if (double.TryParse(id1, out double intNum1) && double.TryParse(id2, out double intNum2))
            {
                double ans = intNum1 - intNum2;
                return ans.ToString("F2");
            }
            else
            {
                return "Please enter valid numbers";
            }
        }

        // This method will let the user multiply 2 numbers
        public string mul(String id1, String id2)
        {
            if (double.TryParse(id1, out double intNum1) && double.TryParse(id2, out double intNum2))
            {
                double ans = intNum1 * intNum2;
                return ans.ToString("F2");
            }
            else
            {
                return "Please enter valid numbers";
            }
        }


        // This method will let the user divide 2 numbers
        public string div(String id1, String id2)
        {
            if (double.TryParse(id1, out double intNum1) && double.TryParse(id2, out double intNum2))
            {
                double ans = intNum1 / intNum2;
                return ans.ToString("F2");
            }
            else
            {
                return "Please enter valid numbers";
            }
        }
    }
}
