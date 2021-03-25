namespace logical_exercise.DesignPatterns.SOLID.ISP
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }

    public interface IFaxTasks
    {
        void Fax(string content);
    }

    public interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }

}