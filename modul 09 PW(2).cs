public interface IInternalDeliveryService;
{
   void  DeliverOrder(string orderId);
   void GetDeliveryStatus(string orderId);
}

public class InternalDeliveryService : IInternalDeliveryService
{
    public void DeliverOrder(string orderId)
    {
        public void DeliverOrder(string orderId)
        { 
            Console.Writeline("Order DeliverOrder" + orderId );

        }
        public string GetDeliveryStatus(string orderId)
        {
            return "Status for Order" + orderId;
        }
    }
}

public class GlovoLogisticsServiceA
{
    public void ShipItem(int itemId)
    {

    }

    public string TrackShipment(int shipmentId) 
    {
        return ""
    }
}

public class LogisticAdapterGlovo : IInternalDeliveryService
{
    private GlovoLogisticsServiceA glovoLogistic;

    public LogisticAdapterGlovo(GlovoLogisticsServiceA glovoLogistic)
    {
        this.glovoLogistic = glovoLogistic;
    }

    public void DeliverOrder(string orderId)
    {
        int item = int.Parse(orderId);
        glovoLogistic.ShipItem(item);
    }

    public string GetDeliveryStatus(string orderId)
    {
        int item = int.Parse(orderId);
        return glovoLogistic.TrackShipment(item);
    }
}


static void Main(string[] args)
{
    IInternalDeliveryService service = null;

    string typeDelivery = "Glovo";
    if(typeDelivery = "Glovo")
    {
        service = new LogisticAdapterGlovo(new GlovoLogisticsServiceA());

    }
    else
    {
        service = new IInternalDeliveryService();
    }
    service.DeliverOrder("dalflqe[");
    string st = service.GetDeliveryStatus("lksnglwkngr");
}