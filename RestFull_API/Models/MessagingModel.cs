namespace StockSense_DotNET_API.Models
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
