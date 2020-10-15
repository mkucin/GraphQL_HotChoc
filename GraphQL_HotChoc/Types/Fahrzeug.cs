using HotChocolate.Types;

namespace GeniaxApi.Types.TestTypes
{
    /// <summary>
    /// The Fahrzeug-Class is an ObjectType (HotChocolate) from the GraphQL-Schemata to describe the Fahrzeug-Object
    /// </summary>
    public class Fahrzeug
    {
        /// <summary>
        /// The ID property uniquely identifies a Fahrzeug-Object
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Name of the Fahrzeug-Object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An overloaded Constructor, 
        /// to set all Fahrzeug-Object properties with one call
        /// </summary>
        /// <param name="Id">The externally transmitted unique identifier for the Fahrzeug-Object</param>
        /// <param name="Name">The externally transmitted name for the Fahrzeug-Object</param>
        public Fahrzeug(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        /// <summary>
        /// The default Constructor
        /// (it´s needed for GraphQL-Mutations specially for the InputType FahrzeugInput)
        /// </summary>
        public Fahrzeug()
        {
            System.Console.WriteLine("Here OuT");
        }
    }

}