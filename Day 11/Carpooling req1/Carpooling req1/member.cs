using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpooling_req1
{
    public class Member
    {
        long _id;
        string _firstname;
        string _lastname;
        string _email;
        string _contactNumber;
        string _licenseNumber;
        DateTime _licenseStartdate;
        DateTime _licenseExpirydate;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }

        }
        public string Email
        {
            get { return _email; }
            set
            { _email = value; }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }
        public string licenseNumber
        {
            get { return _licenseNumber; }
            set
            {
                _licenseNumber = value;
            }
        }
        public DateTime licenseStartdate
        {
            get { return _licenseStartdate; }
            set
            {
                _licenseStartdate = value;
            }
        }
        public DateTime licenseExpirydate
        {
            get { return _licenseExpirydate; }
            set
            {
                _licenseExpirydate = value;
            }
        }
        public Member() { }
        public Member(long _id, string _firstname, string _lastname, string _email, string _contactNumber, string _licenseNumber, DateTime _licenseStartdate, DateTime _licenseExpirydate)
        {
            Id = _id;
            Firstname = _firstname;
            Lastname = _lastname;
            Email = _email;
            ContactNumber = _contactNumber;
            licenseNumber = _licenseNumber;
            licenseStartdate = _licenseStartdate;
            licenseExpirydate = _licenseExpirydate;
            
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Member m1 = (Member)obj;
            return Email.ToLower() == m1.Email.ToLower() && ContactNumber.ToLower() == m1.ContactNumber.ToLower();
        }
        public override string ToString()
        {
            return string.Format("Member :{0},{1}\n Member contact details:{2}{3}", _firstname, _lastname, Email, ContactNumber);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }
}
