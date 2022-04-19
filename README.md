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
