using DatatAccessLayer.Concrete;
using Traversal.CQRS.Queries.DestinatonQueries;
using Traversal.CQRS.Results.DestinationsResults;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                Daynight = values.DayNight
            };
        }
    }
}
