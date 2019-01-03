using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Models
{
    public class RelationProjectEmployee
    {
        public string NameOfProject { get; set; }
        public int Oib { get; set; }
        public int HoursOfWork { get; set; }

        public RelationProjectEmployee(string nameOfProject, int oib, int hoursOfWork)
        {
            NameOfProject = nameOfProject;
            Oib = oib;
            HoursOfWork = hoursOfWork;
        }
    }
}
