using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass5
{
    class Order
    {
        public int Number { get; }
        public string PurschasedForm { get; set; }
        public string ShipTo { get; set; }
        public DateTime Date { get; set; }
        public int UnitPrice { get; set; }
        public string Description { get; set; }
        public int Ordered { get; set; }
        public string Unit { get; set; }


        public Order(string id, string purschasedForm, string shipto, DateTime date, string price, string problems,int order, string notes)
        {
            if (!String.IsNullOrEmpty(id))
            {
                Number = int.Parse(id);
            }
            else
            {
                throw new Exception("Number is required and cannot be empty or null.");
            }

            if (!String.IsNullOrEmpty(purschasedForm))
            {
                PurschasedForm = purschasedForm;
            }
            else
            {
                throw new Exception("Purschased Form is required and cannot be empty or null.");
            }

            if (!String.IsNullOrEmpty(shipto))
            {
                ShipTo = shipto;
            }
            else
            {
                throw new Exception("Ship To is required and cannot be empty or null.");
            }

            if (date <= DateTime.Now)
            {
                Date = date;
            }
            else
            {
                throw new Exception("Date cannot be in the future.");
            }

            if (!String.IsNullOrEmpty(price))
            {
                UnitPrice = int.Parse(price);
            }
            else
            {
                throw new Exception("Unit Price is required and cannot be empty or null.");
            }

            //Problems = problems;

        }
        public string ToString()
        {
            //return ID.ToString() + "|" + Patientname + "|" + DateCreated.ToString() + "|" + Problems + "|" + Notes;
        }
    }
}
