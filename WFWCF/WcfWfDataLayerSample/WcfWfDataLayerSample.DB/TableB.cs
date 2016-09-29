using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfWfDataLayerSample.DB
{
    [DataContract()]
    public class TableB
    {
        [DataMember()]
        public string RowID
        { set; get; }

         [DataMember()]
        public string ID
        { set; get; }

         [DataMember()]
        public string Value
        { set; get; }
    }
}
