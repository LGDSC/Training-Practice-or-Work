namespace RRModels
{
    public class Review
    {
        /// <summary>
        /// This descries the overall numeric rating of a restaturant
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }
        /// <summary>
        /// Verbose description of the dining experinece
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description:{Description}";
        }
    }
}