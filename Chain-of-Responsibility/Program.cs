using Chain_of_Responsibility;

Car car = new Car() { Model="Toyota Yaris"};
BasicCheck basicCheck = new BasicCheck();
MechanicCheck mechanicCheck = new MechanicCheck();
ElectrianCheck electrianCheck = new ElectrianCheck();
ExpertCheck expertCheck = new ExpertCheck();

basicCheck.SetNext(mechanicCheck);
mechanicCheck.SetNext(electrianCheck);
electrianCheck.SetNext(expertCheck);


basicCheck.HandleRequest(car);

if (car.HasMalfunction)
    Console.WriteLine($"{car.Model} {car.Error}");
else
    Console.WriteLine($"{car.Model} pass all checks");
