using Coravel.Invocable;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuartzTest2
{
    public class JobTest : IInvocable
    {
        public Task Invoke()
        {
            string filePath = $"D:\\BuildSchool\\Topic\\Test\\QuartzTest2\\QuartzTest2\\JobTest\\{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string headerRow = $"Time : {DateTime.Now:yyyyMMdd_HHmmss}";
            File.WriteAllText(filePath, headerRow, Encoding.UTF8);
            return Task.CompletedTask;
        }
    }
}
