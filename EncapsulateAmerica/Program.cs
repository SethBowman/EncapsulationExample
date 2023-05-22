using EncapsulateAmerica;

var seth = new Person();
seth.Name = "Seth";
seth.Age = 29;

seth.AddMoney(500.00);

var amountInWallet = seth.CheckWallet();

Console.WriteLine("Money in wallet:");
Console.WriteLine(amountInWallet);

Console.WriteLine("Adding money..");
seth.AddMoney(500.00);

amountInWallet = seth.CheckWallet();
Console.WriteLine(amountInWallet);

