using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Travel_Agency.Dal;
using Travel_Agency.Models;
using Travel_Agency.ViewModel;

namespace Travel_Agency.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FlightsPage()
        {         
            FlightDal dal = new FlightDal();
            FlightViewModel svm = new FlightViewModel();
            List<Flight> flights1 = dal.flights.ToList();
            svm.flight = new Flight();
            svm.flightsList = flights1;
            return View(svm);
        }
        public ActionResult AddFlight()
        {
            /*FlightDal dal = new FlightDal();
            FlightViewModel svm = new FlightViewModel();
            if (ModelState.IsValid)
            {
                dal.flights.Add(fl);
                dal.SaveChanges();
                svm.flight = fl;
                svm.flightsList = dal.flights.ToList<Flight>();
                return View("FlightsPage", svm);
            }
            else
            {
                return View("FlightsPage", svm);
            }*/

            FlightViewModel svm = new FlightViewModel();
            FlightDal dal = new FlightDal();
            if (ModelState.IsValid)
            {
                dal.flights.Add(GetFlight()); //in memory adding
                dal.SaveChanges();
                svm.flight = new Flight();
            }
            else
                svm.flight = GetFlight();

            svm.flightsList = dal.flights.ToList<Flight>();
            return View("FlightsPage", svm);
        }

        public Flight GetFlight()
        {
            Flight fl = new Flight();
            fl.id = Request.Form["flight.id"].ToString();
            fl.originCountry = Request.Form["flight.originCountry"].ToString();
            fl.destination = Request.Form["flight.destination"].ToString();
            fl.Date = Request.Form["flight.Date"].ToString();
            fl.time = Request.Form["flight.time"].ToString();
            fl.price = Request.Form["flight.price"].ToString();
            fl.type = Request.Form["flight.type"].ToString();
            fl.oneWayOrTwo = Request.Form["flight.oneWayOrTwo"].ToString();
            fl.tickets = Request.Form["flight.tickets"].ToString();
            return fl;
        }

        public ActionResult RemoveFlight()
        {
            FlightViewModel svm = new FlightViewModel();
            FlightDal dal = new FlightDal();
            if (ModelState.IsValid)
            {
                dal.flights.Remove(GetFlightById()); //in memory adding
                dal.SaveChanges();
                svm.flight = new Flight();
            }
            else
                svm.flight = GetFlight();

            svm.flightsList = dal.flights.ToList<Flight>();
            return View("FlightsPage", svm);
        }

        public Flight GetFlightById()
        {
            string myQuery = Request.Form["searchQuery"].ToString();
            FlightViewModel svm = new FlightViewModel();
            FlightDal dal = new FlightDal();

            svm.flight = new Flight();
            svm.flightsList = 
                (from x in dal.flights where x.id.Contains(myQuery) select x).ToList<Flight>();
            return svm.flights;
        }

        //1111111111111111111111111

    }
}