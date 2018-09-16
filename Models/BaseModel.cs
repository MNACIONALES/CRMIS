using System;

namespace CRMIS.Models
{
    public class BaseModel
    {
        #region -- Variable Declarations --
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
        #endregion
    }
}