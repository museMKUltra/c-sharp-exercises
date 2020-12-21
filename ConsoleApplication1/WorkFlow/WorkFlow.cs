using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Workflow
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }

    public class WorkFlow : IWorkFlow
    {
        private readonly IList<IActivity> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }


        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}