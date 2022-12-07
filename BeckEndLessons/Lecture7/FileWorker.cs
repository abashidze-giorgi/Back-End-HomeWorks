namespace BeckEndLessons.Lecture7
{
    public abstract class FileWorker
    {
        public double MaxSize { get; set; }

        public abstract string FileExtenshion { get; set; }

        public abstract void Read(FileWorker fWorker);

        public abstract void Write(FileWorker fWorker);

        public abstract void Edit(FileWorker fWorker);
        public abstract void Delete(FileWorker fWorker);
    }
}
