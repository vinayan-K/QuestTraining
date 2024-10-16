using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Address
{
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Addressline> Addresslines  { get; set; }
        public override string ToString()
        {
            string addresses = string.Join(Environment.NewLine, Addresslines);
            return $"Name: {Name}, Email:{Email} , Addresses:{addresses}";
        }
    }
  class Addressline
    {
    public string Addresstype { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string Pincode { get; set; }

      public override string ToString()
      {
         return $"Addresstype: {Addresstype},AddressLine1: {AddressLine1},AddressLine2: {AddressLine2}, Pincode: {Pincode}";
      }
    }
}
