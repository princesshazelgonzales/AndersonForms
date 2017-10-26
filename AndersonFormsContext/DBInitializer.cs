using AndersonFormsEntity;
using System.Collections.Generic;
using System.Data.Entity;

namespace AndersonFormsContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {
        }
        protected override void Seed(Context context)
        {
            IEnumerable<ETypeOfDevice> eTypeOfDevices;
            eTypeOfDevices = new List<ETypeOfDevice>()
            {
                new ETypeOfDevice
                {
                    Name = "Mobile Phone"
                },
                new ETypeOfDevice
                {
                    Name = "Laptop"
                }
            };
            context.TypeOfDevices.AddRange(eTypeOfDevices);
                   
            IEnumerable<ERequirement> eRequirements;
            eRequirements = new List<ERequirement>()
            {
                new ERequirement
                {
                    Name = "SSS"
                },
                new ERequirement
                {
                    Name = "Birth Certificate"
                },
                new ERequirement
                {
                    Name = "PAG-IBIG"
                },
                new ERequirement
                {
                    Name = "Phil-Health"
                }
            };
            context.Requirements.AddRange(eRequirements);
            context.SaveChanges();
        }
    }
}
