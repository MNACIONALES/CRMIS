using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace CRMIS.Models
{
    public class User
    {
        #region "-- User --"
        public int ID { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }
        
        #endregion
        
    }
}