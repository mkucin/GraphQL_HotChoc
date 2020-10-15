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
        public List<Fahrzeug> Fahrzeuge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Fahrzeug Fahrzeug { get => Fahrzeuge[0]; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="name_contains"></param>
        /// <returns></returns>
        public IEnumerable<Fahrzeug> GetFuhrpark(int? fid, string name_contains)
        {
            List<Fahrzeug> filtered = this.Fahrzeuge;
            if (fid.HasValue)
            {
                filtered = filtered.FindAll(f => f.Id == fid);
            }
            if (name_contains != null && !name_contains.Equals(""))
            {
                filtered = filtered.FindAll(f => f.Name.Contains(name_contains));
            }
            return filtered;
        }
    }
}
