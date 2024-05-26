using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Simplex.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "";
        public void OnGet()
        {
            Message = "Ответ";
        }
        public void OnPost(double[][] data)
        {
            
            double[,] table_result;
            double[,] table = new double[5,3];
            double[] result = new double[2];

            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    table[i, k] = data[i][k];
                }
            }

            SimplexCalc S = new SimplexCalc(table);
            table_result = S.Calculate(result);

            Message = $"X[1] : {result[0]} X[2] : {result[1]}";
        }
    }
}
