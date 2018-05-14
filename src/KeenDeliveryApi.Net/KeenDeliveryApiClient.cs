using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using KeenDeliveryApi.Net.Errors;
using KeenDeliveryApi.Net.Helpers;
using KeenDeliveryApi.Net.Models.DeliverySchedules;
using KeenDeliveryApi.Net.Models.Labels;
using KeenDeliveryApi.Net.Models.ParcelShops;
using KeenDeliveryApi.Net.Models.Shipments;
using KeenDeliveryApi.Net.Models.ShippingMethods;
using KeenDeliveryApi.Net.Models.Timeframes;
using KeenDeliveryApi.Net.Wrappers;

namespace KeenDeliveryApi.Net
{
    public class KeenDeliveryApiClient
    {
        private const string ApiBaseUrl = "https://portal.keendelivery.com/api/v2/";
        //private const string ApiBaseUrl = "http://testportal.keendelivery.com/api/v2/";
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Instantiates a new MyParcelApiClient
        /// </summary>
        /// <param name="apiKey">API key which can be generated on myparcel.nl</param>
        public KeenDeliveryApiClient(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("Parameter apiKey needs a value");

            _apiKey = apiKey;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiBaseUrl)
            };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Shipment> CreateShipment(CreateShipment shipment)
        {
            var content = new StringContent(JsonHelper.Serialize(shipment, "yyyy-MM-dd"), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"shipment?api_token={_apiKey}", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<Shipment>(jsonResult);
            }
            HandleResponseError(response);
            return null;
        }

        public async Task<Label> CreateLabels(CreateLabel label)
        {
            var content = new StringContent(JsonHelper.Serialize(label), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"label?api_token={_apiKey}", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<Label>(jsonResult);
            }
            HandleResponseError(response);
            return null;
        }

        public async Task<ShipmentStatus> GetShipmentStatus(int shipmentId)
        {
            var response = await _httpClient.GetAsync($"shipment/{shipmentId}?api_token={_apiKey}").ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<ShipmentStatus>(jsonResult);
            }
            HandleResponseError(response);
            return null;
        }

        public async Task<Dictionary<string, ParcelShop[]>> FindParcelShop(FindParcelShop searchData)
        {
            var content = new StringContent(JsonHelper.Serialize(searchData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"parcel-shop/search?api_token={_apiKey}", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<DataWrapper>(jsonResult).ParcelShops;
            }
            HandleResponseError(response);
            return null;
        }

        public async Task<Dictionary<string, Dictionary<string, DeliverySchedule[]>>> FindDeliverySchedule(FindDeliverySchedule searchData)
        {
            var content = new StringContent(JsonHelper.Serialize(searchData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"delivery-schedule/search?api_token={_apiKey}", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<DataWrapper>(jsonResult).DeliverySchedules;
            }
            HandleResponseError(response);
            return null;
        }

        public async Task<TimeframeData> FindPostNlTimeFrame(FindTimeFrame searchData)
        {
            var content = new StringContent(JsonHelper.Serialize(searchData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"postnl/timeframes?api_token={_apiKey}", content).ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<DataWrapper>(jsonResult, "dd-MM-yyyy").Timeframes;
            }
            HandleResponseError(response);
            return null;
        }

        public async Task<ShippingMethod[]> GetShippingMethods()
        {
            var response = await _httpClient.GetAsync($"shipping_methods?api_token={_apiKey}").ConfigureAwait(false);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return JsonHelper.Deserialize<DataWrapper>(jsonResult).ShippingMethods;
            }
            HandleResponseError(response);
            return null;
        }

        private async void HandleResponseError(HttpResponseMessage response)
        {
            string message = string.Empty;
            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    message = "Page not found";
                    break;
                default:
                    var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    try
                    {
                        var result = JsonHelper.Deserialize<KeenDeliveryError>(responseBody);
                        message = !string.IsNullOrEmpty(result.Message) ? result.Message : result.Error;
                    }
                    catch
                    {
                        var result = JsonHelper.Deserialize<Dictionary<string, string[]>>(responseBody);
                        foreach (var key in result.Keys)
                        {
                            message += $"{key}: {string.Join(" - ", result[key])}\n";
                        }
                    }
                    break;
            }
            throw new KeenDeliveryException(message);
        }
    }
}
