// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Person turkPerson = new Person("Sadi Enis", "Güçlüer", 2004, 123);
Person foreignerPerson = new Person(firstName: "Anders", lastName: "Hejlsberg", birthYear: 1960);

PTTManager ptt1 = new PTTManager(new PersonManager());
ptt1.GiveMask(turkPerson);
ptt1.GiveMask(foreignerPerson);

Console.WriteLine("\n--------------\n");

PTTManager ptt2 = new PTTManager(new ForeignerManager());
ptt2.GiveMask(foreignerPerson);

Console.ReadKey();
