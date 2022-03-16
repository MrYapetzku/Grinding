using System;

namespace Inharitance_task_2
{
    public class LinkViewer
    {
        public void ShowPayingLink(string link)
        {
            if (link == null)
                throw new ArgumentNullException(nameof(link));

            Console.WriteLine(link);
        }
    }
}
