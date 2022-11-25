using Grpc.Core;
using ProjectToggle.Main.Grpc;

namespace ProjectToggle.Main.Services;

public class ToggleService : Toggle.ToggleBase
{
    public override Task<InsertToggleReply> InsertToggle(InsertToggleRequest request, ServerCallContext context)
    {
        return Task.FromResult(new InsertToggleReply
        {
            Id = "123456"
        });
    }
}