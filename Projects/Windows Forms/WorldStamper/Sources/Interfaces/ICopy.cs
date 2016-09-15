namespace WorldStamper.Sources.Interfaces
{
    interface ICopy
    {
        /// <summary>
        /// Copy the current instance, including all of its properties into a new object and return it.
        /// </summary>
        /// <returns>IResource copy of the current instance.</returns>
        IResource Copy();

        /// <summary>
        /// Validates the current instance on any changes made.
        /// </summary>
        /// <returns>The status of changes.</returns>
        bool HasChanges();
    }
}
