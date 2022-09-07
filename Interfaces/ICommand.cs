namespace The_Do_Nothing_Project.Interfaces
{
    internal interface ICommand
    {
        //Client client;
        //public void SetClient(Client client)
        //{
        //    this.client = client;
        //}
        string OnClick();
        void OnSpecialClick(string path);
        void SetClient(IClient client);
    }
}
