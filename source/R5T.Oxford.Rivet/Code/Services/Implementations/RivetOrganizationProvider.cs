using System;

using R5T.Ostrogothia;
using R5T.Ostrogothia.Rivet;

using R5T.T0064;


namespace R5T.Oxford.Rivet
{
    [ServiceImplementationMarker]
    public class RivetOrganizationProvider : IOrganizationProvider, IServiceImplementation
    {
        public IOrganization GetOrganization()
        {
            var organization = RivetOrganization.Instance;
            return organization;
        }
    }
}
