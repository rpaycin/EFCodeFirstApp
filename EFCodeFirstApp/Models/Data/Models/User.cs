using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstApp.Models.Data.Models
{
    public class User
    {
        //Mutlaka her classta bir ID olmalı. Bu alan db de auto increment şekilde açılır.
        public int UserID { get; set; }

        [Required, StringLength(250)] // SQL de zorunlu ve max 250 karakter olmasını sağladık
        public string Name { get; set; }

        public bool IsLogin { get; set; }
        
        //Kullandığın classa ID li bir property oluşturmazsan SQL de kendisi otomatik alan açar. 
        //Burda RoleID eklemeseydim Role ile ilgili başka bir alan açılacaktı
        public int RoleID { get; set; }

        //başka bir classı kullanacaksan virtual eklenmeli
        public virtual Role Role { get; set; }
    }
}