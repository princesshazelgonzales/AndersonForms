using AndersonFormsModel;
using System.Collections.Generic;

namespace AndersonFormsFunction
{

    public interface IFRequirement
    {
        #region Create
        Requirement Create(Requirement requirement);
        #endregion

        #region Read
        List<Requirement> Read();
        #endregion

        #region Update
        #endregion

        #region Delete
        void Delete(int requirementId);
        #endregion

    }
}