using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Recibo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reciboID { get; set; }
        [ForeignKey("proveedorID")]
        public int proveedorID { get; set; }
        
        //public virtual Proveedor proveedor { get; set; }
        [ForeignKey("monedaID")]
        public int monedaID { get; set; }
        
        //public virtual  Moneda moneda { get; set; }
        [ForeignKey("userID")]
        public int userID { get; set; }
        
        //public virtual User user { get; set; }

        public DateTime date { get; set;} 

        public string comentario { get; set; }

        public float monto { get; set; }


    }
}
