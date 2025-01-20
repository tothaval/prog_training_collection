namespace DelegateBasicExample
{
	
	class Porgram
	{

		delegate void LogDel(string text);

		//delegate void LogDel(string text, DateTime dateTime);


		public static void Main(string[] args)
		{
            Log log = new Log();

			//LogDel logdel = new LogDel(LogTextToScreen);
            LogDel logdel = new LogDel(log.LogTextToFile);

            LogDel LogTextToFileDel, LogTextToScreenDel;

            LogTextToFileDel = new LogDel(log.LogTextToFile);
            LogTextToScreenDel = new LogDel(log.LogTextToScreen);

            LogDel multiLogDel = LogTextToFileDel + LogTextToScreenDel;


            Console.WriteLine("Please enter your name:");
			
			var name = Console.ReadLine();

            //logdel(name);

            //multiLogDel(name);

            //logdel(name, DateTime.Now);

            LogText(multiLogDel, name);

            Console.ReadKey();
		}

        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

	}

	public class Log
	{
        public void LogTextToFile(string text)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            };
        }


        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        //void LogTextToScreen(string text, DateTime dateTime)
        //{
        //    Console.WriteLine($"{dateTime}: {text}");
        //}
    }

}