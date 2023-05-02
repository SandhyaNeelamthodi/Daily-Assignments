using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailreq2
{

    public class Mailfolder
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Mail> _maillist;
        public List<Mail> Maillist
        {
            get { return _maillist; }
            set { _maillist = value; }
        }
        public Mailfolder()
        { }
        public Mailfolder(string name, List<Mail> maillist)
        {
            _name = name;
            _maillist = maillist;
        }

        public void AddMailToFolder(Mail mail)
        {
            Maillist.Add(mail);
        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in Maillist)
            {
                if (item.Id == id)
                {
                    Maillist.Remove(item);
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayMails()
        {
            if (Maillist.Count > 0)
            {
                foreach (var item in Maillist)
                {
                    Console.WriteLine("mail{0}", Name);
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("no mails to show");
            }
        }
    }
}
