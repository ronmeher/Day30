using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class Ride_Repository
    {

        Dictionary<string, List<RideCab>> userRides = null; // used Dictionary 

        public Ride_Repository() //constructor to create dictionary
        {
            userRides = new Dictionary<string, List<RideCab>>();
        }

        public void AddRide(string userId, RideCab[] rides) //Add ride
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<RideCab> list = new List<RideCab>();
                    list.AddRange(rides);
                    userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are null");
            }
        }

        public RideCab[] GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid UserId");
            }
        }
    }
}
