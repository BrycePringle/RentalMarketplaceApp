using GeoPoint = NetTopologySuite.Geometries.Point;

namespace StarterApp.Database.Helpers;

public interface ILocationService
{
    Task<GeoPoint> GetCurrentLocationAsync();
}