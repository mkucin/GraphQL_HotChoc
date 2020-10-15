using System;
using System.Collections.Generic;

namespace GeniaxApi.Types.TestTypes
{
    public class Maschine
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Maschine(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
