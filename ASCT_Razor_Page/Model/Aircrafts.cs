using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASCT_Razor_Page.Model
{
    public partial class Aircrafts
    {
        [Column("TAIL_NUM")]
        [StringLength(50)]
        public string TailNum { get; set; }
        [Column("LRU_NAME")]
        [StringLength(50)]
        public string LruName { get; set; }
        [Column("LRU_PN")]
        [StringLength(50)]
        public string LruPn { get; set; }
        [Column("SOFTWARE_NAME")]
        [StringLength(50)]
        public string SoftwareName { get; set; }
        [Column("SOFTWARE_PN")]
        [StringLength(50)]
        public string SoftwarePn { get; set; }
        [Column("FLEET_TYPE")]
        [StringLength(50)]
        public string FleetType { get; set; }
        [Column("EC_NUM")]
        [StringLength(50)]
        public string EcNum { get; set; }
        [Column("PRE")]
        [StringLength(50)]
        public string Pre { get; set; }
        [Column("POST")]
        [StringLength(50)]
        public string Post { get; set; }
        [Column("CURR_STATE")]
        [StringLength(50)]
        public string CurrState { get; set; }
    }
}
