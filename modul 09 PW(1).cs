public interface IReport{
    string Generate();
}

public class SalesReport : IReport
{
    public string Generate()
    {
        return "SalesReport";
    }
}

public class UserReport : IReport
{
    public string Generate()
    {
        return "UserReport";
    }
}

public abstract class ReportDecorator : IReport
{
    private IReport report;

    protected ReportDecorator(IReport report)
    {
        this.report = report;
    }
    public string Generate();
    {
        return report.Generate();
    }
} 

public class DateFilterDecorator : ReportDecorator
{
    private DataTIme startData;
    private DataTIme endData;

    public DateFilterDecorator(IReport report,
    DataTIme startData,
    DataTIme endData) :base(report)
    {
        this.startData = startData;
        this.endData = endData;
    }

    public override string Generate();
    {
        var data = base.Generate();
        return "Filter from " + startData + "" + data;
    }
}


public class Program
{
    static void Main(string[] args)
  {
    IReport report = new SalesReport();
    report = new DateFilterDecorator(report,
     DataTIme.Now.AddYears(-1), DataTIme.Now); 
    
     IReport report = new SalesReport();
    report = new DateFilterDecorator(report,
     DataTIme.Now.AddYears(2), DataTIme.Now); 

   }
}