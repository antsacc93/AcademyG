using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.ChainOfResp.Handler
{
    public class LionHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            if (request.Equals("Bistecca"))
            {
                return $"Sono un leone adoro la {request}";
            }
            return base.Handle(request);
        }
    }
}
