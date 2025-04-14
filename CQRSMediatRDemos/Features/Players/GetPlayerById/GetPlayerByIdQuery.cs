using CQRSMediatRDemos.Models;
using MediatR;

namespace CQRSMediatRDemos.Features.Players.GetPlayerById
{
    public record GetPlayerByIdQuery(int id) : IRequest<Player?>;
}
