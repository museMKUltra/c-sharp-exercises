namespace ConsoleApplication1.Workflow
{
    public static class Program
    {
        public static void Run()
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new VideoUploader());
            workflow.RegisterActivity(new VideoEncoder());
            workflow.RegisterActivity(new MailSender());
            workflow.RegisterActivity(new StatusChanger());
            workflow.Run();
        }
    }
}