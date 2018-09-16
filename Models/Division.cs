using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace CRMIS.Models
{
    public class Division : BaseModel
    {
        #region -- Variable Declarations --
        
        public int ID { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        #endregion
    }
}