namespace WorldStamper.Sources.Interfaces
{
    interface IResource
    {
        /// <summary>
        /// Loads a file into the current object from disk.
        /// </summary>
        /// <param name="fileName"></param>
        void LoadFile(string fileName);
        /// <summary>
        /// Saves current object to a file on disk.
        /// </summary>
        /// <param name="fileName"></param>
        void SaveFile(string fileName);
    }
}
