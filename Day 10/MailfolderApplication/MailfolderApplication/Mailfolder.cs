using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailfolderApplication
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
        public List<Mail> Maillist;
        {
            get { return _maillist; }
            set { _maillist = value; } 
        }
        public Mailfolder()
        { }
        public Mailfolder(string name,List<Mail> maillist)
        {
            _name = name;
            _maillist = maillist;
        }
        public static Mail CreateMail(string details)
        {
            string[] maildata = details.Split(',');
            DateTime dt= DateTime.Parse(s[5],"dd-MM-YYYY"),mail;
            Mail m1 = new Mail(long.Parse(s[0], s[1], s[2], s[3], s[4], dt, double.Parse s[6]);
            return m1;
        }
        


    }
}
