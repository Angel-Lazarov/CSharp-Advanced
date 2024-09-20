using System.Text;
using System.Xml;

namespace MailClient
{
    public class MailBox
    {
        private int capacity;
        private List<Mail> inbox;
        private List<Mail> archive;

        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<Mail> Inbox
        {
            get { return inbox; }
            set { inbox = value; }
        }


        public List<Mail> Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
           return inbox.Remove(Inbox.FirstOrDefault(m => m.Sender == sender)) ;
        }

        public int ArchiveInboxMessages()
        {
            int moved = 0;
            foreach (var mail in Inbox)
            {
                moved++;
                Archive.Add(mail);
            }
            Inbox.Clear();
            return moved;
        }

        public string GetLongestMessage() 
        {
            Mail longestMail = Inbox.MaxBy(m => m.Body);
            return longestMail.ToString();
        }
        public string InboxView() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");

            foreach (var mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }

            return sb.ToString().Trim();
        }

    }
}
