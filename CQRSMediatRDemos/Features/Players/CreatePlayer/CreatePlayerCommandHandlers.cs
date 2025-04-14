using CQRSMediatRDemos.Data;
using MediatR;
using CQRSMediatRDemos.Models;

namespace CQRSMediatRDemos.Features.Players.CreatePlayer
{
    public class CreatePlayerCommandHandlers(AppDbContext _context) : IRequestHandler<CreatePlayerCommand, int>
    {
        public async Task<int> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
           var player = new Player
           {
               Name = request.Name,
               Level = request.Level
           };
            await _context.Players.AddAsync(player);
            await _context.SaveChangesAsync(cancellationToken);
            return player.Id;
        }
    }
}
