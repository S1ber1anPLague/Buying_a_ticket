using System;
using System.Windows.Forms;


namespace Lab_10
{
    internal partial class MainForm : MetroFramework.Forms.MetroForm
    {
       internal static TripList triplist = new TripList();
       internal static TicketList ticketlist = new TicketList();
       internal static DriverList driverlist = new DriverList();
       internal static BusList buslist = new BusList();
       internal static PointsList pointslist = new PointsList();
       int currentId;//текущий id
       

        public MainForm()
        {
            InitializeComponent();
            pointslist.allPoints = pointslist.ReadPoints();
            buslist.allBus = buslist.ReadAutobus();
            driverlist.allDrivers = driverlist.ReadDriver();
            triplist.allTrip = triplist.ReadTrips();
            ticketlist.allTicket = ticketlist.ReadTickets();
            currentId = ticketlist.allTicket[0].ID;
            
        }

        private void BuildtripBox()
        {
           
           foreach(Points points in pointslist.allPoints)
            {
              if(points.Status)
                {
                    tripBox.Items.Add(points.Point);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)//при загрузке формы заполняем базовую информацию
        {
            BuildtripBox();
            FillForm(ticketlist.findById(currentId));
        }

        public void FillForm(Ticket ticket)//заполняем text/combo box'ы
        {
            this.Text = $"Билет №{currentId} ";

            currentId = ticket.ID;
            FIObox.Text = ticket.Fio;
            Trip currenttrip = triplist.findById(ticket.TripId);
            placeBox.Items.Clear();
            FinishBox.Items.Clear();
                for (int i = 0; i < currenttrip.Points.Length / 3; i++)
                {
                    placeBox.Items.Add(pointslist.findById(Int32.Parse(currenttrip.Points[i, 0])).Point);
                    FinishBox.Items.Add(pointslist.findById(Int32.Parse(currenttrip.Points[i, 0])).Point);
                }        
            placeBox.Text = pointslist.findById(ticket.Startpoint).Point;
            FinishBox.Text = pointslist.findById(ticket.FinishPoint).Point;
            string loc = pointslist.findById(Int32.Parse(currenttrip.TripLocationsId)).Point;
            tripBox.Text = loc;                     
            AutoBusbox.Text = buslist.findById(currenttrip.BusesId).BusNumber;
            DateBox.Items.Clear();                      
            foreach(string elem in currenttrip.Date)
            {
                DateBox.Items.Add(elem);

            }
            DateBox.Text = ticket.Date;
            for (int i = 0; i < currenttrip.Points.Length / 3; i++)
            {
                if(Int32.Parse(currenttrip.Points[i, 0])==ticket.Startpoint)
                {
                    TimeBox.Text = currenttrip.Points[i, 2];
                }              
            }           
            Driverbox.Text = driverlist.findById(currenttrip.DriverId).FIO;
            PriceBox.Text = ((pointslist.findById(ticket.FinishPoint).ID - pointslist.findById(ticket.Startpoint).ID) * currenttrip.Price).ToString();
        }

        private void tripBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            placeBox.Items.Clear();//при каждой смене рейса очищаем поля
            FinishBox.Items.Clear();
            Trip trip = triplist.findBytripLocationsId(pointslist.findBypoint(tripBox.Text).ID.ToString());                    
            metroGrid1.Rows.Clear();
            metroGrid1.Rows.Add(5);//формируем расписание
                for (int i = 0; i < trip.Points.Length / 3; i++)
                {
                    int j = 0;

                    placeBox.Items.Add(pointslist.findById(int.Parse(trip.Points[i, 0])).Point);
                    FinishBox.Items.Add(pointslist.findById(int.Parse(trip.Points[i, 0])).Point);
                metroGrid1.Rows[i].Cells[j].Value = (pointslist.findById(int.Parse(trip.Points[i, 0])).Point);
                    j++;
                    metroGrid1.Rows[i].Cells[j].Value = trip.Points[i, 1];
                    j++;
                    metroGrid1.Rows[i].Cells[j].Value = trip.Points[i, 2];
                }
            DateBox.Items.Clear();
            foreach (string elem in trip.Date)
            {
                DateBox.Items.Add(elem);
            }         
            try
            {
                placeBox.Text = pointslist.findById(ticketlist.findById(currentId).Startpoint).Point;
                FinishBox.Text = pointslist.findById(ticketlist.findById(currentId).FinishPoint).Point;
                PriceBox.Text = ((pointslist.findBypoint(FinishBox.Text).ID - pointslist.findBypoint(placeBox.Text).ID) * trip.Price).ToString();

            }
            catch
            {
                placeBox.SelectedIndex = 1;
                FinishBox.SelectedIndex = 1;
                PriceBox.Text = ((pointslist.findBypoint(FinishBox.Text).ID - pointslist.findBypoint(placeBox.Text).ID) * trip.Price).ToString();
            }
            AutoBusbox.Text = buslist.findById(trip.BusesId).BusNumber;
            DateBox.SelectedIndex = 0;
            TimeBox.Text = trip.Points[0, 2];
            Driverbox.Text = driverlist.findById(trip.DriverId).FIO;

        }

        private void prevButton_Click(object sender, EventArgs e)//переходим на предыдущий билет
        {
            if(ticketlist.GetPrevious(currentId)!=null)
            {
                Ticket currentticket = ticketlist.GetPrevious(currentId);
                currentId = currentticket.ID;
                FillForm(currentticket);
                this.Height = 455;
                this.Height = 454;
            }

        }

        private void nextButton_Click(object sender, EventArgs e)//переходим на следующий билет
        {
            if(ticketlist.GetNext(currentId)!=null)
            { 
                Ticket currentticket = ticketlist.GetNext(currentId);
                currentId = currentticket.ID;
                FillForm(currentticket);
                this.Height = 455;
                this.Height = 454;
            }        
        }

        private void newTicket_Click(object sender, EventArgs e)//при нажатии на кнопку создается новый билет
        {
            
            if (FIObox.Text != "")
            {
                Ticket currentticket = new Ticket(ticketlist.GetMaxID() + 1);
                ticketlist.AddTicket(currentticket);
                currentId = currentticket.ID;
                this.Text = "Билет №" + currentId;
                tripBox.SelectedIndex = 0;
                FIObox.Text = "";
                placeBox.SelectedIndex = 0;
                FinishBox.SelectedIndex = 0;
                AutoBusbox.Text = "";
                TimeBox.Text = "";
                DateBox.Text = "";
                Driverbox.Text = "";
                tripBox_SelectedIndexChanged(sender, e);

            }
            else
            {
                MessageBox.Show("Для добавления нового билета заполните данные");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)//при нажатии кнопки сохраняем правки в документ
        {
            if(FIObox.Text!="" && placeBox.Text!=""&&FinishBox.Text!="")
            {
                
                Ticket ticket = new Ticket(currentId);               
                ticket.Fio = FIObox.Text;
                ticket.Date = DateBox.Text;
                ticket.TripId = triplist.findBytripLocationsId(pointslist.findBypoint(tripBox.Text).ID.ToString()).ID;
                ticket.Startpoint = pointslist.findBypoint(placeBox.Text).ID;
                ticket.FinishPoint = pointslist.findBypoint(FinishBox.Text).ID;
                                             
                ticketlist.ReplaceInfoTicket(ticket);
                ticketlist.SaveTickets(ticketlist.allTicket);
                MessageBox.Show("Сохранение прошло успешно");
            }
            else
            {
                MessageBox.Show("Вы не заполнили информацию");//контролируем заполнение информации
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)//кнопка для удаления билета
        {
            if (MessageBox.Show(this, "Вы точно хотите удалить билет?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)//просим потверждение действия
            {
                ticketlist.DeleteTicket(ticketlist.findById(currentId));
                currentId = ticketlist.GetMaxID();
                FillForm(ticketlist.findById(currentId));
            }

        }

        private void placeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Trip trip = triplist.findBytripLocationsId(pointslist.findBypoint(tripBox.Text).ID.ToString());
                FinishBox.Items.Clear();
                int id = pointslist.findBypoint(placeBox.Text).ID;
                for (int i = 0; i < trip.Points.Length / 3; i++)
                {
                    if (Int32.Parse(trip.Points[i, 0]) == pointslist.findBypoint(placeBox.Text).ID)
                    {
                        TimeBox.Text = trip.Points[i, 2];
                    }
                    if(Int16.Parse(trip.Points[i,0])>id)
                    {
                        FinishBox.Items.Add(pointslist.findById(Int32.Parse(trip.Points[i, 0])).Point);
                    }
                }
                PriceBox.Text = ((pointslist.findBypoint(FinishBox.Text).ID - pointslist.findBypoint(placeBox.Text).ID) * triplist.findBytripLocationsId(pointslist.findBypoint(tripBox.Text).ID.ToString()).Price).ToString();
               
            }
            catch
            {

            }
        }

        private void FinishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PriceBox.Text = ((pointslist.findBypoint(FinishBox.Text).ID - pointslist.findBypoint(placeBox.Text).ID) * triplist.findBytripLocationsId(pointslist.findBypoint(tripBox.Text).ID.ToString()).Price).ToString();
            }
            catch {
            }

        }
    }
}
