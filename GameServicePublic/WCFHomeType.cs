﻿using System;
using System.Collections.Generic;

using System.Runtime.Serialization;
using System.Text;


namespace GameService
{
    [DataContract]
    public partial class WCFHomeType
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Terrain { get; set; }
    }
}
