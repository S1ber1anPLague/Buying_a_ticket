
using System.Collections.Generic;
using System.Xml;

namespace Lab_10
{
    class TripList//класс списка рейсов
    {
        
        public List<Trip> allTrip;
        
        public TripList()
        {
            allTrip = new List<Trip>();
        }

        public void AddTrip(Trip trip)//функция для добавления рейса
        {
            allTrip.Add(trip);
        }
        public void DeleteTrip(Trip trip)//функция для удаления рейса
        {
            allTrip.Remove(trip);
        }
      
        
        public Trip findById(int id)
        {
            return allTrip.Find(x => x.ID == id);
        }
        public Trip findBytripLocationsId(string tripLocationsId)
        {
            return allTrip.Find(x => x.TripLocationsId == tripLocationsId);
        }

        public List<Trip> ReadTrips()
        {
            List<Trip> list = new List<Trip>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Info.xml");
            XmlElement xRoot = doc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Trip")
                {
                    int id = 0;List<string> date = new List<string>(); int bus = 0; ; string[,] points ; int driver = 0; string tripLocationId = ""; decimal price = 0;
                    // получаем атрибут id
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("id");
                        if (attr != null)
                        {
                            id = int.Parse(attr.Value);
                        }
                    }
                    // обходим все дочерние узлы элемента
                    
                    List<string> pointsList = new List<string>();
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        
                        if (childnode.Name == "Date") { date.Add(childnode.InnerText); }
                        if (childnode.Name == "Bus") { bus = int.Parse(childnode.InnerText); }
                       
                        if (childnode.Name == "Point")
                        {
                            pointsList.Add(childnode.InnerText);
                        }
                        if (childnode.Name == "Driver")
                        {
                            driver = int.Parse(childnode.InnerText);
                        }
                        if (childnode.Name == "TripLocations") { tripLocationId = (childnode.InnerText); }
                        if (childnode.Name == "Price") { price = int.Parse(childnode.InnerText); }
                    }
                            
                    points = new string[pointsList.Count, 3];                   
                    for(int i = 0;i<pointsList.Count;i++)
                    {
                        string[] array = pointsList[i].Split(',');
                        points[i, 0] = array[0];
                        points[i, 1] = array[1];
                        points[i, 2] = array[2];
                    }
                    Trip trip = new Trip(id, date, bus, points, driver, tripLocationId,price);
                    list.Add(trip);
                }
            }
            return list;
        }
      
    }
    class Trip//класс рейсов
    {
        
        
        public int ID { get { return id; } set { id = value; } }
        
       
        public int BusesId { get { return busId;} set { busId = value; } }
         
        public string[,] Points { get { return points; } set { points = value; } }
        public int DriverId { get { return driverId; } set { driverId = value; } }
        public string TripLocationsId { get { return tripLocationsId; } set { tripLocationsId = value; } }
        public List<string> Date { get { return date; } set { date = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        private int id;//id поездки
        
       
        private int busId;
        private string[,] points;//двумерный массив с остановками и временем прибытия/отбытия
        private int driverId;//водитель автобуса
        private string tripLocationsId;//проезжаемые места
        private List<string> date;
        private decimal price;
        
      
        public Trip(int id, List<string> date,  int busId,  string [,] points, int driverId, string tripLocationsId,decimal price)//конструктор для заполнения информации
        {
            this.id = id;
            this.date = date;
            this.busId = busId;           
            this.points = points;
            this.driverId = driverId;
            this.tripLocationsId = tripLocationsId;
            this.price = price;
        }
        public Trip (int id)//конструктор с id
        {
            this.id = id;
        }
    }
}
