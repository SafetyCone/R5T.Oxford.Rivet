using System;

using R5T.Ostrogothia;
using R5T.Ostrogothia.Rivet;


namespace R5T.Oxford.Rivet
{
    public class RivetOrganizationProvider : IOrganizationProvider
    {
        public IOrganization GetOrganization()
        {
            var organization = RivetOrganization.Instance.Value;
            return organization;
        }
    }
}
