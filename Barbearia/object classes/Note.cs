using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.object_classes
{
    class Note
    {
        public Int32 Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public string StartSchedule { get; set; }
        public string FinalSchedule { get; set; }    
    }
}
