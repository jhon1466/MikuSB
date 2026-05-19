namespace MikuSB.GameServer.Server.CallGS.Handlers.BossPvp;

[CallGSApi("BossPvpLogic_EnterLevel")]
public class BossPvpLogic_EnterLevel : ICallGSHandler
{
    public async Task Handle(Connection connection, string param, ushort seqNo)
    {
        var response = BossPvpShared.HandleEnterLevel(param);
        await CallGSRouter.SendScript(connection, "BossPvpLogic_EnterLevel", System.Text.Json.JsonSerializer.Serialize(response));
    }
}
