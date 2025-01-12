//Ex 1 : afficher le temps qui reste avant la pause de midi ("Il reste ...");

DateTime today = DateTime.Now;
DateTime lunchTime = DateTime.Today.AddHours(12);
TimeSpan remainingTime = lunchTime - today;
Console.WriteLine(remainingTime);

DateTime pause = new DateTime(2024, 12, 23, 15, 0, 0);
TimeSpan diff = pause - today;
string pauseFormat = diff.ToString("c");
Console.WriteLine($"{diff.Hours:D2}:{diff.Minutes:D2}:{diff.Seconds:D2}");
