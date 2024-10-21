using System;
using System.Collections.Generic;

namespace AirlineReservationSystem
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Customer()
        {
            Reservations = new List<Reservation>();
        }
        public void MakeReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }
    }
    public class RetailCustomer : Customer
    {
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
    }

    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public int FrequentFlyerPoints { get; set; }
        public string BillingAccountNo { get; set; }
    }

    public class Reservation
    {
        public int ReservationNo { get; set; }
        public DateTime Date { get; set; }
        public List<Seat> Seats { get; set; }
        public Flight Flight { get; set; }

        public Reservation()
        {
            Seats = new List<Seat>();
        }

        public void AddSeat(Seat seat)
        {
            Seats.Add(seat);
        }
    }

    public class Seat
    {
        public int RowNo { get; set; }
        public int SeatNo { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }

    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int SeatingCapacity { get; set; }
        public List<Seat> Seats { get; set; }

        public Flight()
        {
            Seats = new List<Seat>();
        }

        public void AddSeat(Seat seat)
        {
            if (Seats.Count < SeatingCapacity)
            {
                Seats.Add(seat);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Flight flight = new Flight
            {
                FlightId = 105,
                Date = DateTime.Now,
                Origin = "New York",
                Destination = "Los Angeles",
                DepartureTime = new TimeSpan(10, 30, 0),
                ArrivalTime = new TimeSpan(13, 45, 0),
                SeatingCapacity = 150
            };

            Seat seat1 = new Seat
            {
                RowNo = 1,
                SeatNo = 1,
                Price = 200,
                Status = "Available"
            };

            Seat seat2 = new Seat
            {
                RowNo = 1,
                SeatNo = 2,
                Price = 200,
                Status = "Available"
            };

            flight.AddSeat(seat1);
            flight.AddSeat(seat2);

            RetailCustomer customer = new RetailCustomer
            {
                CustomerId = 1,
                FirstName = "Abdullah",
                LastName = "Nadeem",
                Email = "abdullah.doe@example.com",
                CreditCardType = "Visa",
                CreditCardNo = "1234-5678-9876-5432"
            };

            Reservation reservation = new Reservation
            {
                ReservationNo = 1001,
                Date = DateTime.Now,
                Flight = flight
            };

            reservation.AddSeat(seat1);
            reservation.AddSeat(seat2);
            customer.MakeReservation(reservation);

            Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} has made a reservation for Flight {flight.FlightId}");
        }
    }
}