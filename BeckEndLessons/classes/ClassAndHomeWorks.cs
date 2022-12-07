namespace BeckEndLessons.classes
{
    public class ClassAndHomeWorks
    {
        public Dictionary<string, int> ListOfExercises()
        {
            Dictionary<string, int> exercises = new Dictionary<string, int>();
            exercises.Add("Home work 3_1:", 31);
            exercises.Add("Home work 3_2:", 32);
            exercises.Add("Home work 3_3:", 33);
            exercises.Add("Home work 4_1:", 41);
            exercises.Add("Home work 4_2:", 42);
            exercises.Add("Home Work 7_1:", 71);
            exercises.Add("Home Work 7_2:", 72);

            return exercises;
        }

        public Dictionary<int, string> ExerciseDescriptions()
        {
            Dictionary <int, string> descriptions = new Dictionary<int, string>();
            descriptions.Add(31, "shevamotsmot, ikopha tu ara useris mier shekvanili ricxvi 5-ze unashtod.\n" +
                                "pasukhi gamovitanot konsolshi.");
            descriptions.Add(32, "Write a program that performs sum, difference," +
                "\r\noperations of multiplication and division." +
                "\r\nNote\r\n1. When dividing and subtracting, choose the largest and it\r\n" +
                "Subtract the smallest\r\n" +
                "2. If the smallest number is 0, the program should output\r\nError 0 cannot be divided.");
            descriptions.Add(33, "Swap the values of the two variables");

            return descriptions;
        }
    }
}
