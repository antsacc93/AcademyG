using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.ChainOfResp.Handler
{
    public class ElephantHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            if (request.Equals("Noccioline"))
            {
                return $"Grazie per queste {request}!";
            }
            return base.Handle(request);
        }
    }
}
