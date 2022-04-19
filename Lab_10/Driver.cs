
using System.Collections.Generic;
using System.Xml;

namespace Lab_10
{
    class DriverList//класс списка водителей
    {
        public List<Driver> allDrivers;
        public DriverList()
        {
            allDrivers = new List<Driver>();
        }

        public void AddDriver(Driver driver)//функция реализущая добавление водителя
        {
            allDrivers.Add(driver);
        }
        public void DeleteDriver(Driver driver)//функция реализущая добавление водителя
        {
            allDrivers.Remove(driver);
        }
        public Driver findByFio(string fio)
        {
            return allDrivers.Find(x => x.FIO == fio);
        }
        public Driver findById(int id)
        {
            return allDrivers.Find(x => x.ID == id);
        }


        public List<Driver> ReadDriver()
        {
            List<Driver> list = new List<Driver>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Info.xml");
            XmlElement xRoot = doc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Driver")
                {
                    int id = 0; string fio = "";
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
                        if (childnode.Name == "Fio") { fio = childnode.InnerText; }
                    }
                    Driver driver = new Driver(id, fio);
                    list.Add(driver);
                }
            }
            return list;
        }
    }
    class Driver//класс водителя
    {
        public int ID { get { return id; } set { id = value; } }
        public string FIO { get { return fio; } set { fio = value; } }
        private int id;//id водителя
        private string fio;//ФИО водителя
        public Driver(int id, string fio)//конструктор для добавления информации
        {
            this.id = id;
            this.fio = fio;
        }
        public Driver(int id)//конструктор с id
        {
            this.id = id;
        }
    }
}
