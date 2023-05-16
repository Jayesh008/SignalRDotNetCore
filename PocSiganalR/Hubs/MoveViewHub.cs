using Microsoft.AspNetCore.SignalR;

namespace PocSiganalR.Hubs
{
    public class MoveViewHub:Hub
    {
        public async Task MoveView(string name, string amount)
        {
            await Clients.Others.SendAsync("PU9vgKcfYm1ozi9FRtao", "You have received "+amount+" Rs from "+name+" on Merchant App");
        }
    }
}
