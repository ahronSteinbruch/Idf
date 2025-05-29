using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodkodIdf.operationComand.helpersClasses.abstracts
{
    public abstract class Person
    {
        protected long ID {get; set;}
        private string _name;
        private bool _mail;
        private int _age;
        private DateTime _birthDey;
        private string _address;

        public Person(string name, bool mail, DateTime birthDey, string address)
        {
            _name = name;
            _mail = mail;
            _birthDey = birthDey;
            _age = DateTime.Now.Year - birthDey.Year;
            _address = address;
        }
    }
}
