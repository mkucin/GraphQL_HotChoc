using System.Collections.Generic;
using System.Threading.Tasks;
using GeniaxApi.Types.TestTypes;

namespace GeniaxApi.Types
{

    public partial class Query
    {
        /// <summary>
        /// 
        /// </summary>
        public Query()
        {
            #region DummyDataForTestSchema
            /************ Dummy-Values to Work with... *********************/
            Fahrzeuge = new List<Fahrzeug>
            {
                new Fahrzeug(1, "Audi A7"),
                new Fahrzeug(2, "BMW M8 Grand Coupe"),
                new Fahrzeug(3, "Porsche Panamera GT"),
                new Fahrzeug(4, "Mercedez Benz AMG63GT 4-Door")
            };

            Maschinen = new List<Maschine>
            {
                new Maschine(1, "Bagger GT"),
                new Maschine(2, "Schlepper")
            };
            /************** END Dummy-Values *****************************/
            #endregion


        }

    }
}