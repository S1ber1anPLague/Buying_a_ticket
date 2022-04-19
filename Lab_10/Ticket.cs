using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab_10
{
    class TicketList//класс списка билетов
    {
        public List<Ticket> allTicket;
        public TicketList()
        {
            allTicket = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)//функция для добавления билета
        {
            allTicket.Add(ticket);
        }
        public void DeleteTicket(Ticket ticket)//функция для удаления билета
        {
            allTicket.Remove(ticket);
        }
        public Ticket findById(int id)
        {
            return allTicket.Find(x => x.ID == id);
        }
        public Ticket findByTripId(int tripId)
        {
            return allTicket.Find(x => x.TripId == tripId);
        }
        public void ReplaceInfoTicket(Ticket ticket)//метод для обновленения информации
        {
            int index = allTicket.FindIndex(x => x.ID == ticket.ID);
            allTicket[index] = ticket;
        }
        public Ticket GetPrevious(int id)//получение предыдущего билета
        {
            int index = allTicket.FindIndex(x => x.ID == id);
            if (index > 0)
            {
                return allTicket[index - 1];
            }
            return null;
        }
        public Ticket GetNext(int id)//получение следующего билета
        {
            int index = allTicket.FindIndex(x => x.ID == id);
            if (index < allTicket.Count - 1)
            {
                return allTicket[index + 1];
            }
            return null; 
        }
        public int GetMaxID()//получение максимального значения id(конечный билет)
        {
            int max = 0;
            foreach (Ticket ticket in allTicket)
            {
                if (max < ticket.ID)
                { max = ticket.ID; }
            }
            return max;
        }
        public List<Ticket> ReadTickets()
        {
            List<Ticket> list = new List<Ticket>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Info.xml");
            XmlElement xRoot = doc.DocumentElement;
            // проход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Tickets")
                {
                    foreach (XmlNode node in xnode)
                    {
                        int id = 0; string fio = ""; int tripId = 0; int startPoint = 0; int finishPoint = 0; string date = ""; 
                        // проходим все дочерние узлы элемента

                        List<string> pointsList = new List<string>();
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "id") { id = Int32.Parse(childnode.InnerText); }
                            if (childnode.Name == "Fio") { fio = childnode.InnerText; }                            
                            if (childnode.Name == "Trip") { tripId = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "StartPoint") { startPoint = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "FinishPoint") { finishPoint = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "Date") { date = childnode.InnerText; }
                           
                        }
                        
                        Ticket ticket = new Ticket(id, fio, tripId, startPoint, finishPoint,date);
                        list.Add(ticket);
                    }
                }
            }
            return list;
        }

        public void SaveTickets(List<Ticket> allTickets)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Info.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
            {
                if (n.Name == "Tickets")
                {
                    xRoot.RemoveChild(n);
                }
            }
            XmlElement tickets = xDoc.CreateElement("Tickets");
            foreach (Ticket ticket in allTickets)
            {
                // создаем новый элемент ticket
                XmlElement ticketElem = xDoc.CreateElement("Ticket");
                // создаем элементы
                XmlElement idElem = xDoc.CreateElement("id");
                XmlElement fioElem = xDoc.CreateElement("Fio");
                XmlElement tripElem = xDoc.CreateElement("Trip");
                XmlElement stPointElem = xDoc.CreateElement("StartPoint");
                XmlElement fPointElem = xDoc.CreateElement("FinishPoint");
                XmlElement dateElem = xDoc.CreateElement("Date");
               
                // создаем текстовые значения для элементов и атрибута
                XmlText idText = xDoc.CreateTextNode(ticket.ID.ToString());
                XmlText fioText = xDoc.CreateTextNode(ticket.Fio);
                XmlText tripText = xDoc.CreateTextNode(ticket.TripId.ToString());
                XmlText stPointText = xDoc.CreateTextNode(ticket.Startpoint.ToString());
                XmlText fPointText = xDoc.CreateTextNode(ticket.FinishPoint.ToString());
                XmlText dateText = xDoc.CreateTextNode(ticket.Date);
            
                //добавляем узлы
                idElem.AppendChild(idText);
                fioElem.AppendChild(fioText);
                dateElem.AppendChild(dateText);
                tripElem.AppendChild(tripText);
                stPointElem.AppendChild(stPointText);
                fPointElem.AppendChild(fPointText);             
                ticketElem.AppendChild(idElem);
                ticketElem.AppendChild(fioElem);
                ticketElem.AppendChild(dateElem);
                ticketElem.AppendChild(tripElem);
                ticketElem.AppendChild(stPointElem);
                ticketElem.AppendChild(fPointElem);
                tickets.AppendChild(ticketElem);
            }
            xRoot.AppendChild(tickets);
            xDoc.Save("Info.xml");
        }
    }

    class Ticket//класс для билетов
    {
        public int ID { get { return id; } set { id = value; } }
        public string Fio { get { return fio; } set { fio = value; } }        
        public int TripId { get { return tripId; } set { tripId = value; } }
        public int Startpoint { get { return startPoint; } set { startPoint = value; } }
        public int FinishPoint { get { return finishPoint; } set { finishPoint = value; } }
        public string Date { get { return date; } set { date = value; } }
        

        private int id;//id билета
        private string fio;//фамилия         
        private int tripId;
        private int startPoint;//начальная точка поездки
        private int finishPoint;//последняя точка поездки
        private string date;
        
        public Ticket(int id, string fio, int trip, int startPoint, int finishPoint,string date)
        {                                                                                        //конструктор для заполнения информации
        
            this.id = id;
            this.fio = fio;            
            this.tripId = trip;
            this.startPoint = startPoint;
            this.finishPoint = finishPoint;
            this.date = date;
           
        }
        public Ticket(int id)//конструктор с id
        {
            this.id = id;
        }
    }
}
    



