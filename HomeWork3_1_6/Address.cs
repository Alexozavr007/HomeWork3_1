using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_6 {

    internal class Address {
        string index, country, city, street, house, apartment;

        public string Index { 
            get { 
                return index; 
            } 
            set { 
                index = value; 
            } 
        }

        public string Country {
            get {
                return country; 
            }
            set {
                country = value;
            }
        }

        public string City {
            get {
                return city;
            }
            set {
                city = value;
            }
        }

        public string Street {
            get {
                return street;
            }
            set {
                street = value;
            }
        }

        public string House {
            get {
                return house;
            }
            set {
                house = value;
            }
        }

        public string Apartament {
            get {
                return apartment;
            }
            set {
                apartment = value;
            }
        }

        public string FullAddress() {
            return $"вул. {Street}, буд.{House}, кв. {Apartament}, м.{City}, {Index}, {Country}";
        }
    }
    
}
