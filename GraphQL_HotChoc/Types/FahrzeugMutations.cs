using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeniaxApi.Types
{
    using HotChocolate;
    using HotChocolate.Subscriptions;
    using HotChocolate.Types;
    using TestTypes;

    public partial class Mutation
    {
        /*
        public delegate Fahrzeug FahrzeugUpdatedEventHandler(object source, EventArgs args);
        public event FahrzeugUpdatedEventHandler FahrzeugUpdated;
        protected virtual void OnFahrzeugUpdated()
            => FahrzeugUpdated?.Invoke(this, EventArgs.Empty);
        */



        /// <summary>
        /// The UpdateFahrzeug-Method 
        ///     - CREATE a new Fahrzeug, if the ID is not set or the ID is not existing in the Fahrzeug-List
        ///     - UPDATE a existing Fahrzeug by using the ID for identification
        /// </summary>
        /// <param name="fahrzeug">The Fahrzeug-Object transferred from the outside that is to be created or updated</param>
        /// <returns>The Fahrzeug that was added or updated</returns>
        public async Task<Fahrzeug> UpdateFahrzeugAsync(Fahrzeug fahrzeug, [Service] ITopicEventSender eventsender)
        {
            Console.WriteLine("Hereee");
            await eventsender.SendAsync(nameof(Subscription.OnMessageReceived), fahrzeug);
            return fahrzeug;
        }

    }
}
