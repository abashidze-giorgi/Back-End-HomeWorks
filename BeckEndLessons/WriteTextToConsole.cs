namespace BeckEndLessons
{
    public static class WriteTextToConsole
    {
        #region Console decorations and voids

        /// <summary>
        /// show text to Console and make foreground and background colored.
        /// write first text (required parameter)
        /// write second text (default value - "")
        /// change text color (default - grey)
        /// change text background color (refault black)
        /// </summary>
        /// <param name="foreColor"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        public static void WriteColoredText(string text1, string text2 = "",
                                               ConsoleColor foreColor = ConsoleColor.Gray,
                                               ConsoleColor backColor = ConsoleColor.Black)
        {
            WriteLine(foreColor);
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
            Console.WriteLine(text1);
            //Console.BackgroundColor = ConsoleColor.Black;
            if (!string.IsNullOrEmpty(text2))
            {
                Console.WriteLine(text2);
            }
            WriteLine(foreColor);
        }

        /// <summary>
        /// paint line
        /// get parameters color and row count
        /// </summary>
        /// <param name="foreColor"></param>
        /// <param name="lineCount"></param>
        public static void WriteLine(ConsoleColor foreColor = ConsoleColor.Gray, int lineCount = 1)
        {
            Console.ForegroundColor = foreColor;
            for (int i = 0; i < lineCount; i++)
            {
                Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.ResetColor();
        }

        /// <summary>
        /// ითხოვს მომხმარებლისგან კონსოლში ტექსტის შეყვანას.
        /// პარამეტრად გადმოეცემა კითხვის ტექსტი.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static string GetTextFromUser(string question)
        {
            WriteColoredText(question, foreColor: ConsoleColor.DarkYellow);

            string fileName = Console.ReadLine();

            return fileName;
        }

        /// <summary>
        /// ითხოვს მომხმარებლისგან კონსოლში ტექსტის შეყვანას.
        /// პარამეტრად გადმოეცემა კითხვის ტექსტი და ტექსტის ფერი.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="foreColor"></param>
        /// <returns></returns>
        public static string GetTextFromUser(string question, ConsoleColor foreColor)
        {
            WriteColoredText(question, foreColor: foreColor);

            string fileName = Console.ReadLine();

            return fileName;
        }

        /// <summary>
        /// ითხოვს მომხმარებლისგან კონსოლში ტექსტის შეყვანას.
        /// პარამეტრად გადმოეცემა კითხვის ტექსტი, ტექსტის და უკანა ფონის ფერი.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="foreColor"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static string GetTextFromUser(string question, ConsoleColor foreColor, ConsoleColor backColor)
        {
            WriteColoredText(question, foreColor: foreColor, backColor: backColor);

            string fileName = Console.ReadLine();

            return fileName;
        }

        public static double GetNumberFromUser(string question, ConsoleColor foreColor)
        {
            double number;
            WriteColoredText(question, foreColor: foreColor);

        point1:
            var userText = Console.ReadLine();
            if (userText.ToLower() == "exit" || userText.ToLower() == "quit")
            {
                return 0;
            }
            bool isNumber = double.TryParse(userText, out number);
            if (!isNumber)
            {
                WriteColoredText("ERROR !!!", "Please, Enter Valid Number!!!", foreColor: ConsoleColor.Red);
                goto point1;
            }
            return number;
        }


        public static double GetNumberFromUser<T>(string question, ConsoleColor foreColor, ConsoleColor backColor)
        {
            double number;
            WriteColoredText(question, foreColor: foreColor, backColor: backColor);

        point1:
            var userText = Console.ReadLine();
            
            bool isNumber = double.TryParse(userText, out number);
            if (!isNumber)
            {
                goto point1;
            }
            else
            {
                WriteColoredText("ERROR !!!", "Please, Enter Valid Number!!!", foreColor: ConsoleColor.Red);
            }
            return number;
        }
        #endregion
    }
}
