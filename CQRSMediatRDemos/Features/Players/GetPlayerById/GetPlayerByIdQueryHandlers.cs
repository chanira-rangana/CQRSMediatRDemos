using CQRSMediatRDemos.Data;
using CQRSMediatRDemos.Models;
using MediatR;

namespace CQRSMediatRDemos.Features.Players.GetPlayerById
{
    public class GetPlayerByIdQueryHandlers(AppDbContext _context) : IRequestHandler<GetPlayerByIdQuery, Player?>
    {
        public async Task<Player?> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            var player = await _context.Players.FindAsync(request.id);
            return player;
        }
    }
}
