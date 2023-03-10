namespace WildBikesApi.Configuration
{
    public class MailSettings
    {
        public string MailFrom { get; set; } = "";
        public string MailTo { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public string Password { get; set; } = "";
        public string Host { get; set; } = "";
        public int Port { get; set; }
    }
}
