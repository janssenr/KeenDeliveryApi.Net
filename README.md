# KeenDeliveryApi.Net [![Build status](https://ci.appveyor.com/api/projects/status/m1c22rca95pl5o21?svg=true)](https://ci.appveyor.com/project/janssenr/keendeliveryapi-net) [![NuGet version](https://badge.fury.io/nu/keendeliveryapi.svg)](https://badge.fury.io/nu/keendeliveryapi)
A C#/.net wrapper for the KeenDelivery API

# Installation

KeenDeliveryApi.Net can easily be installed using the NuGet package

```
Install-Package KeenDeliveryApi
```

# Getting started
Just create a new `KeenDeliveryApiClient` with your own API key.
API keys are available on [KeenDelivery](https://www.keendelivery.com/). Check the API documentation [here](https://github.com/keendelivery/snelweg/wiki)

```
var client = new KeenDeliveryApiClient("FILL IN KEY HERE");
```

## Create a shipment
Default shipment
```
var shipment = new CreateShipment
{
    CompanyName = "KeenDelivery",
    ContactPerson = "J. van Mourik",
    StreetLine1 = "Wiltonstraat",
    NumberLine1 = "41",
    ZipCode = "3905 KW",
    City = "Veenendaal",
    Country = "NL",
    Product = "DHL",
    Service = "EUROPLUS",
    Amount = 1,
    Reference = "Shipment reference",
    Weight = 10,
    Label = new CreateShipmentLabel
    {
        Type = "PDF",
        Size = "DEFAULT"
    }
};
var response = await client.CreateShipment(shipment);
if (response != null)
{
    File.WriteAllBytes("labels.pdf", Convert.FromBase64String(response.Label));
}
```
