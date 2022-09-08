namespace The_Do_Nothing_Project.Interfaces
{
    internal interface IDirectoryButtons
    {
        void Create(string path);
        void Delete(string path);
        void Move(string path, string destination);
    }
}
