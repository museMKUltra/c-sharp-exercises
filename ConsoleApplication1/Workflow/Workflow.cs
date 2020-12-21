using System.Collections.Generic;

namespace ConsoleApplication1.Workflow
{
    public class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void Run()
        {
            foreach (var activity in _activities) activity.Execute();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}