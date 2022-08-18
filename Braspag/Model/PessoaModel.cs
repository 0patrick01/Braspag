using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Braspag.Model
{
    [Table("Pessoa")]
    public class PessoaModel
    {
        [Key]
        public int id { get; set; }
        public string adquirente { get; set; }
        public double valor { get; set; }
        public double valorLiquido { get; set; }
        public string bandeira { get; set; }
        public string tipotransacao { get; set; }
        public double valTaxa { get; set; }

    }


}
