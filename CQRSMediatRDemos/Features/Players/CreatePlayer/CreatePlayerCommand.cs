using MediatR;

namespace CQRSMediatRDemos.Features.Players.CreatePlayer
{
    public record CreatePlayerCommand(string Name,int Level) : IRequest<int>;
}
