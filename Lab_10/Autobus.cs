
using System.Collections.Generic;
using System.Xml;

namespace Lab_10
{ 
    class BusList//класс со списком автобусов
    {
        public List<Autobus> allBus;
        public BusList()
        {
            allBus = new List<Autobus>();
        }

        public void AddBus(Autobus bus)//функция для добавления автобуса
        {
            allBus.Add(bus);
        }
        public void DeleteBus(Autobus bus)//функция для удаления автобуса
        {
            allBus.Remove(bus);
        }
        public Autobus findByNumber(string busNumber)
        {
            return allBus.Find(x => x.BusNumber == busNumber);
        }
        public Autobus findById(int id)
        {
            return allBus.Find(x => x.ID == id);
        }

        public List<Autobus> ReadAutobus()
        {
            List<Autobus> list = new List<Autobus>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Info.xml");
            XmlElement xRoot = doc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {            
                if (xnode.Name == "Autobus")
                {
                    int id = 0; string busnumber = "";
                    // получаем атрибут id
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("id");
                        if (attr != null)
                            id = int.Parse(attr.Value);
                    }
                    // обходим все дочерние узлы элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "BusNumber") { busnumber = childnode.InnerText; }                 
                    }
                    Autobus autobus = new Autobus(id, busnumber);
                    list.Add(autobus);
                }                                
             }
            return list;
        }
            
        
    }
    class Autobus
    {
        public int ID { get { return id ; } set { id = value; } }
        public string BusNumber { get { return busNumber; } set { busNumber = value; } }
        private int id;//id автобуса
        private string busNumber;//номер автобуса
        
        public Autobus(int id, string busNumber)//конструктор для добавления информации
        {
            this.id = id;
            this.busNumber= busNumber;
        }
        public Autobus(int id)//конструктор с id
        {
            this.id = id;
        }
        public Autobus()//конструктор без параметров.вызываем его когда создается экземпляр с помощью оператора new без передачи аргументов
        {

        }       
    }   
}
