namespace BeckEndLessons.Lecture7
{
    public class FileWorkerChild : FileWorker
    {
        string fileExtenshion = "";

        public override string FileExtenshion { get => fileExtenshion; set => fileExtenshion = value; }

        public override void Delete(FileWorker fWorker)
        {
            WriteTextToConsole.WriteColoredText(
                    $"I Can delete from {fWorker.FileExtenshion} file with max storage" +
                    $" {fWorker.MaxSize}", foreColor: ConsoleColor.Cyan);
        }

        public override void Edit(FileWorker fWorker)
        {
            WriteTextToConsole.WriteColoredText(
                    $"I Can edit {fWorker.FileExtenshion} file with max storage" +
                    $" {fWorker.MaxSize}", foreColor: ConsoleColor.Cyan);
        }


        public override void Read(FileWorker fWorker)
        {
            WriteTextToConsole.WriteColoredText(
                    $"I Can read from {fWorker.FileExtenshion} file with max storage" +
                    $" {fWorker.MaxSize}", foreColor: ConsoleColor.Cyan);
        }

        public override void Write(FileWorker fWorker)
        {
            WriteTextToConsole.WriteColoredText(
                    $"I Can write to {fWorker.FileExtenshion} file with max storage" +
                    $" {fWorker.MaxSize}", foreColor: ConsoleColor.Cyan);
        }
    }
}
