namespace ConsoleApplication1.Polymorphism
{
    public static class Program
    {
        public static void Run()
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode();
        }
    }
}