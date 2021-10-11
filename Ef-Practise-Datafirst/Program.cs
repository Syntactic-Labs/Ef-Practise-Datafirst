using Ef_Practise_Datafirst.Controllers;
using System;
using System.Threading.Tasks;

namespace Ef_Practise_Datafirst
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var majCtrl = new MajorsController();
            //var majors = await majCtrl.GetAll();
            //majors.ForEach(m => Console.WriteLine(m));
            
            var major = await majCtrl.GetByPk(2);
            Console.WriteLine(major);
        }
    }
}
