using NuGet.Protocol;

namespace Traversal.CQRS.Results.DestinationsResults
{
    public class GetDestinationByIDQueryResult
    {
        public int DestinationID {  get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
    }
}
