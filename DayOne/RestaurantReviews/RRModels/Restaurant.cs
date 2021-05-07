
/// <summary>
/// Namespace for the models/custom data structures involved in Restaurant Reviews
/// </summary>
namespace RRModels
{
    /// <summary>
    /// Datastructure used to define a restaurant
    /// </summary>
    public class Restaurant
    {
        // Class Members
        // 1. Constructor : used to create the instance of the class
        // 2. Fields    : defines the characteristics of a class
        // 3. Metjods - defines  behaviour of a class
        // 4. Properties : also known as smart fields, are accessr methods used to access private backing fields 
        //  # Note that properties are analogous to Java getter and setter
        // Property nameing conventons uses PascalCase (loke methods)

        public Restaurant(string name, string city, string state )
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        public Restaurant()
        {
            
        }
        /// <summary>
        /// This describes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; }
        /// <summary>
        /// This contains the city where the restaurant is located
        /// </summary>
        /// <value></value>
        public string City { get; }
        /// <summary>
        /// This contains the State where the restaurant is located
        /// </summary>
        /// <value></value>
        public string State { get; }

        /// <summary>
        /// This Descrives the Review of the restaurant is located
        /// </summary>
        /// <value></value>
        public string Review { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} \n Location: {City}, {State} \n Review: {Review.ToString()}";
        }
    }
}