//1
// Console.WriteLine($"Year: {DateTime.Now.Year}");
// Console.WriteLine($"Month: {DateTime.Now.Month}");
// Console.WriteLine($"Day: {DateTime.Now.Day}");
// Console.WriteLine($"Hour: {DateTime.Now.Hour}");
// Console.WriteLine($"Minute: {DateTime.Now.Minute}");
// Console.WriteLine($"Second: {DateTime.Now.Second}");
// Console.WriteLine($"Millisecond: {DateTime.Now.Millisecond}");

//2
// Console.WriteLine("Write: ");
// int cnt = 0;
// Console.Write(">");
// while (true)
// {
//     var a = Console.ReadLine();
//     if (a == "end")break;
//     cnt++;
//     if (a == "end" && cnt == 0)
//     {
//         cnt = 0;
//     }
//     Console.Write(">");
// }
// Console.WriteLine(cnt); 

//3
// Gauge gauge = new Gauge()
// {
//     Value = 0
// };
// gauge.Increase();
// gauge.Increase();
// gauge.Decrease();
// Console.WriteLine(gauge.Full());
// Console.WriteLine(gauge.Value);

//4
// Counter counter = new Counter()
// {
//     Value = 5,
// };
// counter.Increase();
// counter.Decrease();
// counter.Increase(2);
// counter.Decrease(7);
// Console.WriteLine(counter.Value);

//5
// PaymentCatd card = new PaymentCatd(0);
// PaymentTerminal terminal = new  PaymentTerminal();

// card.AddMoney(50);
// card.TakeMoney(10);

// terminal.Lunch(card,20);
// terminal.Add(card,10);

// Console.WriteLine($"Balance: {card.Balance}");