using GeniaxApi.Types.TestTypes;
using HotChocolate;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GeniaxApi.Types
{

    public class Subscription
    {

        [Subscribe]
        [Topic]
        public Fahrzeug OnMessageReceived([EventMessage] Fahrzeug updatedFahrzeug, ITopicEventReceiver receiver, CancellationToken cancellationToken)
            => updatedFahrzeug;


        /*
        [SubscribeAndResolve]
        public Fahrzeug OnFahrzeugUpdated([EventMessage] Fahrzeug updatedFahrzeug, CancellationToken cancellationToken)
        {
            Console.WriteLine("OnFahrzeugUpdated Subscritpion triggered....");
            return updatedFahrzeug;
        }*/

    }

}
