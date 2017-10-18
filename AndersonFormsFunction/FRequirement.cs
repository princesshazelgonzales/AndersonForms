using AndersonFormsData;
using AndersonFormsEntity;
using AndersonFormsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AndersonFormsFunction
{
     public class FRequirement: IFRequirement
     {
        private IDRequirement _iDRequirement;

        public FRequirement()
        {
            _iDRequirement = new DRequirement();
        }

        #region Create
        public Requirement Create(Requirement requirement)
        {
            ERequirement eRequirement = ERequirement(requirement);
            eRequirement.CreatedDate = DateTime.Now;
            eRequirement = _iDRequirement.Create(eRequirement);
            return Requirement(eRequirement);
        }
        #endregion

        #region Read
        public List<Requirement> Read()
        {
            List<ERequirement> eRequirements = _iDRequirement.Read<ERequirement>(a => true, "RequirementId");
            return Requirements(eRequirements);
        }
        #endregion

        #region Update
        #endregion

        #region Delete
        public void Delete(int requirementId)
        {
            _iDRequirement.Delete<ERequirement>(a => a.RequirementId == requirementId);
        }
        #endregion

        #region Other Function
        private ERequirement ERequirement(Requirement requirement)
        {
            return new ERequirement
            {
                RequirementId = requirement.RequirementId,

                Name = requirement.Name
            };
        }

        private Requirement Requirement(ERequirement eRequirement)
        {
            return new Requirement
            {
                RequirementId = eRequirement.RequirementId,

                Name = eRequirement.Name
            };
        }

        private List<Requirement> Requirements(List<ERequirement> eRequirements)
        {
            return eRequirements.Select(a =>
                new Requirement
                {
                    RequirementId = a.RequirementId,

                    Name = a.Name
                }
                ).ToList();
        }
        #endregion
    }
}