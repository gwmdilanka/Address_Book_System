using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Class Name : EnterDetails
 * Description: All the setter and getters of the name, address, suburb, city, phone and country
 * Author: G.W. Madushani Dilanka
 * Date: 09/04/2015 
 */
namespace ctlAddressLib
{
    class EnterDetails
    {
        string sName;
        string sAddress;
        string sSuburb;
        string sCity;
        string sPhone;
        string sCountry;

        //@return sName
        public string getName()
        {
            return sName;
        }

        //@return sAddress
        public string getAddress()
        {
            return sAddress;
        }

        //@return sSuburb
        public string getSuburb()
        {
            return sSuburb;
        }

        //@return sCity
        public string getCity()
        {
            return sCity;
        }

        //@return sPhone
        public string getPhone()
        {
            return sPhone;
        }

        //@return sCountry
        public string getCountry()
        {
            return sCountry;
        }

        //Set sName
        public void setName(string sName)
        {
            this.sName = sName;
        }

        //Set sAddress
        public void setAddress(string sAddress)
        {
            this.sAddress = sAddress;
        }

        //Set sSuburb
        public void setSuburb(string sSuburb)
        {
            this.sSuburb = sSuburb;
        }

        //Set sCity
        public void setCity(string sCity)
        {
            this.sCity = sCity;
        }

        //Set sPhone
        public void setPhone(string sPhone)
        {
            this.sPhone = sPhone;
        }

        //Set sCountry
        public void setCountry(string sCountry)
        {
            this.sCountry = sCountry;
        }
    }
}
