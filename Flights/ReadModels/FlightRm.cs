namespace Flights.ReadModels
{
    public record FlightRm(
        Guid Id,
        string Airline,
        int Price,
        TimePlaceRm Departure,
        TimePlaceRm Arrival,
        int RemainingNumberOfSeats
        );
}
