using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab_10
{
    class PointsList
    {
        public List<Points> allPoints;

        public PointsList()
        {
            allPoints = new List<Points>();
        }

        public void AddPointsAndLocations(Points points)//PointsAndLocations pointsAndLocations
        {
            allPoints.Add(points);
        }
        public void DeletePointsAndLocations(Points points)//функция для удаления рейса
        {
            allPoints.Remove(points);
        }
        
        public Points findBypoint(string point)
        {
            return allPoints.Find(x => x.Point == point);
        }
        public Points findById(int id)
        {
            return allPoints.Find(x => x.ID == id);
        }
   
        public List<Points> ReadPoints()
        {
            List<Points> list = new List<Points>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Info.xml");
            XmlElement xRoot = doc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Points")
                {
                    foreach (XmlNode node in xnode)
                    {
                        int id = 0; bool status = false ; string name = "";
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "Name")
                            {
                                name = childnode.InnerText;
                            }
                            if(childnode.Name == "Status")
                            {
                                status = bool.Parse(childnode.InnerText);
                            }
                            if (childnode.Name == "id")
                            {
                                id = Int32.Parse(childnode.InnerText);
                            }                        
                        }
                        Points points = new Points(id, name,status);
                        list.Add(points);
                    }
                }
            }
            return list;
        }

    }
    class Points
    {
        public int ID { get { return id; } set { id = value; } }
        public string Point { get { return point; } set { point = value; } }
        public bool Status { get { return status; }set { status = value; } }
        

        private int id;
        
        private string point;
        private bool status;
        public Points(int id,string point,bool status)
        {
            this.id = id;
            this.point = point;
            this.status = status;
            
        }
        public Points (int id)
        {
            this.id = id;
        }
    }
}
