using AndersonFormsContext;
using AndersonFormsEntity;
using BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonFormsData
{
    public class DRequirement : DBase, IDRequirement
    {
        public DRequirement() : base(new Context())
        {
        }
    }
}
