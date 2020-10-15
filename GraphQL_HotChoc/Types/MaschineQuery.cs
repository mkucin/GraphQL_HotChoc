using System;
using System.Collections.Generic;

namespace GeniaxApi.Types
{
    using TestTypes;

    public partial class Query
    {
        /// <summary>
        ///
        /// </summary>
        public List<Maschine> Maschinen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Maschine Maschine { get => Maschinen[0]; }

    }
}
