using BeckEndLessons.classes;
using BeckEndLessons.Lecture3;
using BeckEndLessons.Lecture4;
using BeckEndLessons.Lecture7;

namespace BeckEndLessons.Program
{
    public class Welcome
    {
        ClassAndHomeWorks chw = new ClassAndHomeWorks();

        Dictionary<int, string> descriptions = new Dictionary<int, string>();
        Dictionary<string, int> Exercises = new Dictionary<string, int>();

        public void RunProgram()
        {
            descriptions = chw.ExerciseDescriptions();
            Exercises = chw.ListOfExercises();
            WriteTextToConsole.WriteColoredText("Hello User", "This is my program for Class and Home works.\n" +
                "You can choose any works by enter corresponding number.\n" +
                "for EXIT - enter 'exit' or 'quit'", foreColor: ConsoleColor.DarkCyan);
            WriteWorks();
        }

        private void WriteWorks()
        {
            Point1:

            foreach(KeyValuePair<string, int> kvp in Exercises)
            {
                WriteTextToConsole.WriteColoredText($"Work: {kvp.Key} - {kvp.Value}", foreColor: ConsoleColor.White);
            }
            string userAnswer = WriteTextToConsole.GetTextFromUser("Please, enter num: ", foreColor: ConsoleColor.DarkYellow);

            CheckUserEntryText(userAnswer);

            goto Point1;
        }

        private void CheckUserEntryText(string userAnswer)
        {
            int i = 0;
            bool isInteger = int.TryParse(userAnswer, out i);
            if (!isInteger)
            {
                switch (userAnswer.ToLower())
                {
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 31: RunHomeWork3(i); break;
                    case 32: RunHomeWork3(i); break;
                    case 33: RunHomeWork3(i); break;
                    case 71: RunHomeWork7(i); break;
                    case 72: RunHomeWork7(i); break;
                    case 41: RunHomeWork4(i); break;
                    case 42: RunHomeWork4(i); break;
                }
            }
        }      


        private void RunHomeWork3(int i)
        {
            WriteTextToConsole.WriteColoredText($"Description: {descriptions[i]}", foreColor: ConsoleColor.DarkCyan);
            switch (i)
            {
                case 31: HomeWork3.HomeWork3_1(); break;
                case 32: HomeWork3.HomeWork3_2(); break;
                case 33: HomeWork3.HomeWork3_3(); break;
            }
        }

        private void RunHomeWork7(int i)
        {
            HomeWork7 hw = new HomeWork7();
            switch (i)
            {
                case 71: hw.HomeWork_7_1(); break;
                case 72: hw.HomeWork_7_2(); break;
            }
        }

        private void RunHomeWork4(int i)
        {
            HomeWork4 hw4 = new HomeWork4();
            switch (i)
            {
                case 41: hw4.HomeWork_4_1(); ; break;
                case 42: hw4.HomeWork_4_2(); break;
            }
           
        }
    }
}
