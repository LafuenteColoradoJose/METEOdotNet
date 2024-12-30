//using Microsoft.JSInterop;
//using System.Threading.Tasks;

//namespace METEOdotNet.Services

//{
//    public class GeolocationService
//    {
//        private readonly IJSRuntime _jsRuntime;
//        public GeolocationService(IJSRuntime jsRuntime)
//        {
//            _jsRuntime = jsRuntime;
//        }

//        public async Task<(double Latitude, double Longitude)> GetGeolocationAsync()
//        {
//            var result = await _jsRuntime.InvokeAsync<dynamic>("getGeolocation");
//            return ((double)result.latitude, (double)result.longitude);
//        }
//    }
//}
