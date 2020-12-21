namespace ConsoleApplication1.Workflow
{
    public static class Program
    {
        public static void Run()
        {
            var workflow = new WorkFlow();
            workflow.Add(new VideoUploader());
            workflow.Add(new VideoEncoder());
            workflow.Add(new MailSender());
            workflow.Add(new StatusChanger());
            var engine = new WorkFlowEngine();
            engine.Run(workflow);
        }
    }
}