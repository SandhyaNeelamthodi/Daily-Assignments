﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailfolderApplication
{
    
    class Mail
    {
        private long _id;
        private string _to;
        private string _from;
        private string _subject;
        private string _content;
        private DateTime _receivedDate;
        private double _size;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }

        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }

        }
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set
            {
                _receivedDate = value;
            }
        }
        public double Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
        public Mail()
        {

        }
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size, long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;

        }
        public override string ToString()
        {
            return ($"id:{_id}\nTo:{_to}\nFrom{_from}\nSubject:{_subject}\nContent:{_content}\nReceivedDate:{_receivedDate}\nSize:{_size}");
        }
        

    }
}
