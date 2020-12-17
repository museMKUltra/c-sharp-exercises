using System;

namespace ConsoleApplication1
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdTime;
        private int _vote = 0;
        private bool _isCreated = false;

        private string Detail
        {
            get
            {
                return string.Format(@"title: {0}
description: {1}
time: {2}
vote: {3}", _title, _description, _createdTime, _vote);
            }
        }

        private void Create()
        {
            if (_isCreated)
            {
                Console.WriteLine("The post has created...");
                return;
            }

            _title = "title";
            _description = "description";
            _createdTime = DateTime.Now;
            _isCreated = true;
        }

        public void Run()
        {
            Console.WriteLine("Power On...");
            while (true)
            {
                Console.WriteLine("Enter 'create', 'check', 'up-vote' or 'down-vote' to command: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "create":
                        Create();
                        break;
                    case "check":
                        CheckDetail();
                        break;
                    case "up-vote":
                        GivenVote(1);
                        break;
                    case "down-vote":
                        GivenVote(-1);
                        break;
                    default:
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Thanks for your attention...");
                            return;
                        }

                        break;
                }
            }
        }

        private void CheckDetail()
        {
            Console.WriteLine(_isCreated ? Detail : "Please creat post first...");
        }

        private void GivenVote(int vote)
        {
            _vote += vote;
            _vote = _vote < 0 ? 0 : _vote;
        }
    }
}