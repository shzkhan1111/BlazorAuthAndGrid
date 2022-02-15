using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTut.Configuration
{
    public class ColumnDefination
    {
        public ColumnDefination()
        {
            this.dataType = DataType.Notset;
            this.alignment = Alignment.NotSet;
        }

        public string DataFeild { get; set; }
        public string Caption { get; set; }
        public DataType dataType { get; set; }
        public string Format { get; set; }
        public Alignment alignment { get; set; }
    }
}
