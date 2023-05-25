using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemorizeNumbers
{
    [Table("Results")]
    public class Result
    {
        [Key]
        public int Result_id { get; set; }
        public int Attempt_number { get; set; }
        public string Player_name { get; set; } = null!;
        public float Accuracy { get; set; }
        public string Difficulty { get; set; } = null!;
        public DateTime DateTime { get; set; }

    }
}
