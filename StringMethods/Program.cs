#region STRING METHODS
//string text = "Hello, World!";
//int textLength = text.Length;
//Console.WriteLine(textLength);

//string text = "Hello, World!";
//int firstIndex = text.IndexOf("l");
//int lastIndex = text.LastIndexOf("l");
//Console.WriteLine(firstIndex);
//Console.WriteLine(lastIndex);

//string text = "Today is 30th May 2024 Thursday";
//bool hasMay = text.Contains("May"); // may false olurdu
//Console.WriteLine(hasMay);

//string text = "Today is 30th May 2024 Thursday";
//bool hasMay = text.Contains("May", StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(hasMay);

//string text = "Today is 30th May 2024 Thursday";
//bool endsWithDay = text.EndsWith("day");
//bool startsWithDay = text.StartsWith("day");
//Console.WriteLine(endsWithDay);
//Console.WriteLine(startsWithDay);
//Console.ReadLine();

//string text = "Today";
//string allLower = text.ToLower();
//string allUpper = text.ToUpper();
//Console.WriteLine(allLower);
//Console.WriteLine(allUpper);
//Console.ReadLine();

//string text = "Today";
//string newText = text.Insert(text.Length, " is Thursday");
//Console.WriteLine(newText);
//string originalText = newText.Remove(text.Length, 12);
//Console.WriteLine(originalText);
//Console.ReadLine();

//string text = "Today is Monday";
//string replacedText = text.Replace("Mon", "Thurs");
//Console.WriteLine(replacedText);
//Console.ReadLine();

//string text = "Today is Monday";
//Console.WriteLine(text.Reverse().ToArray());
//Console.ReadLine();

//string text = "Today is Monday";
//string today = text.Substring(8, 7);
//Console.WriteLine(today);
//Console.WriteLine(today.Length);
//Console.WriteLine(today.Trim());
//Console.WriteLine(today.Trim().Length);
//Console.ReadLine();
#endregion

#region HOMEWORK

#region TASK 1
// TASK 1: Kullanıcıdan alınan metni kelimelere bölerek kelimeleri alt alta yazan program:
//Console.Write("Enter a text: ");
//string text = Console.ReadLine();

//if (text.Length > 0)
//{
//    text = text.Trim();
//    while (text.Contains(' '))
//    {
//        string word = text.Substring(0, text.IndexOf(' '));
//        Console.WriteLine(word);
//        text = text.Remove(0, word.Length + 1);

//    }

//    Console.WriteLine(text);
//}
//else
//{
//    Console.WriteLine("You did not enter text");
//}

#endregion

#region TASK 2
// TASK 2: "10 25 10 35 80 10 65 80 10 82 10 90 40 50 10" bu string'de kaç adet 10 olduğunu yazan program:
//string sampleText = "10 25 10 35 80 10 65 80 10 82 10 90 40 50 10";

//int total10 = 0;
//while (sampleText.Contains("10"))
//{
//    total10++;
//    sampleText = sampleText.Remove(sampleText.IndexOf("10"), 2);
//}
//Console.WriteLine(total10);
//Console.WriteLine(sampleText);
#endregion

#endregion

#region DateTime METHODS
// Bir tarih ya da zaman bilgisi ile çalışmak için kullanırız.

// Günün tarihini veya zamanını alan property'ler
//DateTime todayDate = DateTime.Today;
//DateTime todayTime = DateTime.Now;
//DateTime todayTimeUTC = DateTime.UtcNow;
//Console.WriteLine(todayDate);
//Console.WriteLine(todayTime);
//Console.WriteLine(todayTimeUTC);

// Zaman dilimi ekleme fonksiyonları
//DateTime time = DateTime.Now;
//DateTime dateWithNewHour = time.AddHours(8);
//DateTime dateWithNewDay = time.AddDays(2);
//DateTime dateWithNewYear = time.AddYears(3);
//Console.WriteLine(dateWithNewHour);
//Console.WriteLine(dateWithNewDay);
//Console.WriteLine(dateWithNewYear);

// Zaman parçalarını alabilmek için kullanılan property'ler
//DateTime time = DateTime.Now;
//Console.WriteLine($"Time: {time}");
//Console.WriteLine($"Year: {time.Year}");
//Console.WriteLine($"Month: {time.Month}");
//Console.WriteLine($"Day: {time.Day}");
//Console.WriteLine($"Hour: {time.Hour}");
//Console.WriteLine($"Minute: {time.Minute}");
//Console.WriteLine($"Second: {time.Second}");
//Console.WriteLine($"Millisecond: {time.Millisecond}");
//Console.WriteLine($"Day of week: {time.DayOfWeek}");
//Console.WriteLine($"Day of year: {time.DayOfYear}");

// Kısa ve Uzun Tarih & Zaman Formatı
//DateTime time = DateTime.Now;
//Console.WriteLine($"Short date format: {time.ToShortDateString()}");
//Console.WriteLine($"Long date format: {time.ToLongDateString()}");
//Console.WriteLine($"Short time format: {time.ToShortTimeString()}");
//Console.WriteLine($"Long time format: {time.ToLongTimeString()}");

// Custom Time Format kullanımı
//DateTime time = DateTime.Now;
//Console.WriteLine(time.ToString("yyyy-MM-dd"));
//Console.WriteLine(time.ToString("yyyy-MM-dd HH:mm:ss"));
//Console.WriteLine(time.ToString("yyyy-MM-dd hh:mm:ss"));
//Console.WriteLine(time.ToString("yyyy-MMM-dd HH:mm:ss"));
//Console.WriteLine(time.ToString("yyyy-MM-ddd HH:mm:ss"));
//Console.WriteLine(time.ToString("yyy-MM-ddd HH:mm:ss"));
//Console.WriteLine(time.ToString("yy-MM-ddd HH:mm:ss"));

//DateTime time = DateTime.Now.AddMonths(2);
//Console.WriteLine(time.Subtract(DateTime.Now));
//Console.WriteLine(time - (DateTime.Now));

//Console.ReadLine();
#endregion

#region Math METHODS
// Math kütüphanesi üzerinden erişilir.

//int numX = -24;
//int AbsNumX = Math.Abs(numX);
//Console.WriteLine(AbsNumX);

//double num = 14.5;
//double roundedNum = Math.Round(num);
//Console.WriteLine(roundedNum);

//double num = 14.8;
//double roundedNum = Math.Round(num);
//double ceiledNum = Math.Ceiling(num);
//double flooredNum = Math.Floor(num);
//Console.WriteLine(roundedNum);
//Console.WriteLine(ceiledNum);
//Console.WriteLine(flooredNum);

//Console.WriteLine(Math.PI);

//double num1 = 625;
//double sqrtNum1 = Math.Sqrt(num1);
//Console.WriteLine(sqrtNum1);

//double num2 = 3;
//double exponantiatedNum2 = Math.Pow(num2, 3);
//Console.WriteLine(exponantiatedNum2);

//int num1 = 24, num2 = 8;
//Console.WriteLine(Math.Max(num1, num2));
//Console.WriteLine(Math.Min(num1, num2));

#endregion