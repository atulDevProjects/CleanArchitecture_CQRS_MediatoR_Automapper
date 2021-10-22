using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.DBEntities
{
    public partial class TblDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
    }
}
