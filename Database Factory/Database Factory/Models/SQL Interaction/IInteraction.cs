namespace Database_Factory.Models.SQL_Interaction
{
    public interface IInteraction
    {
        /// <summary>
        /// Connect to the SQL Database
        /// </summary>
        void Connect();

        /// <summary>
        /// Disconnect from connected Database
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Send the request to the SQL Server
        /// </summary>
        void SendRequest();

        /// <summary>
        /// Get result after sending the request
        /// </summary>
        void GetResult();
    }
}