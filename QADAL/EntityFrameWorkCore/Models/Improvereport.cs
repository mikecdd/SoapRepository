using System;
using System.Collections.Generic;

namespace QADAL.EntityFrameWorkCore.Models
{
    public partial class ImproveReport : Modelbase
    {
        public Nullable<int> Id { get; set; }
        public int regmanid { get; set; }
        public string regman { get; set; }
        public Nullable<System.DateTime> regdate { get; set; }
        public Nullable<int> typeid { get; set; }
        public string title { get; set; }
        public string reportcontent { get; set; }
        public virtual Type type1 { get; set; }
    }
}
