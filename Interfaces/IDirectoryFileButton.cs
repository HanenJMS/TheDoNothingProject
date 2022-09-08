namespace The_Do_Nothing_Project.Interfaces
{
    internal interface IDirectoryFileButton
    {
        void Create(string path);
        void Delete(string path);
        void Move(string path, string destination);
    }
}
