namespace WorldStamper.Sources.Interfaces
{
    interface ICopy
    {
        // Creates new copy of the current object
        void Copy();

        // Validates current object with the copy on any changes
        bool HasChanges();
    }
}
