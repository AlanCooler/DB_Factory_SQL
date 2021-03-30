namespace Database_Factory.Models.DataResource
{
    public interface IResourceController
    {
        /// <summary>
        /// Trying to get value from Resources
        /// </summary>
        void TryGetValue();

        /// <summary>
        /// Add some value to the Resources place
        /// </summary>
        void Add();

        /// <summary>
        /// Add some information
        /// </summary>
        void CheckIfNotAdd();
    }
}