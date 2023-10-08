using EFModrelCreateApp;

using (ApplicationContext context = new())
{
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();

    //Company yandex = new() { Title = "Yandex" };
    //Company ozon = new() { Title = "Ozon" };

    //Employee bob = new() { FirstName = "Bob"
    //                     , LastName = "Smith"
    //                     , Age = 26
    //                     , Company = yandex };
    //Employee joe = new() { Name = "Joe", Age = 31, Company = ozon };
    //Employee sam = new() { Name = "Sam", Age = 38, Company = yandex };

    //context.Employees.Add(bob);
    //context.Employees.AddRange(new[] { bob, joe, sam });
    //await context.SaveChangesAsync();


    //var employees = context.Employees.ToList();
    //foreach(var e in employees)
    //    Console.WriteLine($"Name: {e.Name}, Age: {e.Age}, Company: {e.Company?.Title}");


    
}

void AddressAdd()
{
    //context.Address.Add(new Address("Moscow"));
    //context.Address.Add(new Address("St. Peterburg"));
    //await context.SaveChangesAsync();
}

void AddressLoad(ApplicationContext context)
{
    //var adds = context.Address.ToList();
    //foreach (var item in adds)
    //    Console.WriteLine(item);
}