# Buying_a_ticket
Постановка задачи: Разработайте приложение с использованием элементов Label, Button, TextBox, ComboBox, Panel, GroupBox, LinkLabel, ErrorProvider, RadioButton, CheckBox. Приложение должно позволять добавлять, удалять и редактировать информацию. Информация должна храниться в одном или нескольких файлах. Переключение между объектами проводить кнопками «Вперед» и «Назад» с указанием текущего номера объекта (или с помощью TrackBar). Управление основными объектами реализовать с помощью классов или структур. Главное окно - проданный билет. В билете указывается ФИО, место, рейс, номер автобуса, точка начала, точка завершения. У каждого рейса есть список автобусов, которые курсируют, расписание (массив элементов: дата-время выезда и номер автобуса, ФИО водителя), набор остановочных пунктов и время движения между пунктами (время приезда и время выезда из каждого пункта).

*Входные данные:*
+ "Info.xml"

*Выходные данные:*
+ Данные записываются в файл "Info.XML"

*Рабочие переменные*
+ index
+ max
+ list
+ doc
+ xnode
+ xRoot
+ fio
+ startpoint
+ finishpoint
+ trip1
+ pointlist
+ childnode
+ tRip
+ ticket
+ xDoc
+ ticket
+ ticketElem
+ idElem
+ fioElem
+ tripElem
+ stPointElem
+ fPointElem
+ idText
+ fioText
+ tripText
+ stPointText
+ fPointText
+ date
+ time
+ bus
+ points
+ driver
+ tripLocations
+ bus1
+ driver
+ i
+ array
+ currentticket

*Описание стандартных функций и библиотек:*
+ Console.WriteLine() - вывод данных на экран
+ Console.Readline() - получение введенных данных

*Классы и процедуры:*
+ class Ticket
+ class Driver
+ class Trip
+ class MainForm
+ public TicketList();
+ public void AddTicket(Ticket ticket);
̶+ public void DeleteTicket(Ticket ticket);
̶+ public Ticket findById(int id);
̶+ public void ReplaceInfoTicket(Ticket ticket);
̶+ public Ticket GetPrevious(int id);
̶+ public Ticket GetNext(int id);
̶+ public int GetMaxID();
̶+ public List<Ticket> ReadTickets();
̶+ public void SaveTickets(List<Ticket> allTickets);
̶+ public TripList();
̶+ public void AddTrip(Trip trip);
̶+ public void DeleteTrip(Trip trip);
̶+ public Trip findBytripLocations(string tripLocations);
̶+ public List<Trip> ReadTrips();
̶+ public DriverList();
̶+ public void AddDriver(Driver driver);
̶+ public void DeleteDriver(Driver driver);
̶+ public Driver findByFio(string fio);
̶+ public List<Driver> ReadDriver();
̶+ public BusList();
̶+ public void AddBus(Autobus bus);
̶+ public void DeleteBus(Autobus bus);
̶+ public Autobus findByNumber(string busNumber);
̶+ public List<Autobus> ReadAutobus();
̶+ private void BuildtripBox();
̶+ private void MainForm_Load(object sender, EventArgs e);
̶+ public void FillForm(Ticket ticket);
̶+ private void tripBox_SelectedIndexChanged(object sender, EventArgs e);
̶+ private void prevButton_Click(object sender, EventArgs e);
̶+ private void nextButton_Click(object sender, EventArgs e);
̶+ private void newTicket_Click(object sender, EventArgs e);
̶+ private void saveButton_Click(object sender, EventArgs e);
̶+ private void deleteButton_Click(object sender, EventArgs e);

