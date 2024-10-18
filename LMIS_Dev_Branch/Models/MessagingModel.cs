namespace LMIS_Dev_Branch.Models
{
    public class MessagingModel : IModel
    {
        public string MessageResponce { get; set; }
        public MessagingModel(string messageResponce)
        {
            MessageResponce = messageResponce;
        }
    }
}
