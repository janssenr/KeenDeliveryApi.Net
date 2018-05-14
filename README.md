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

Overwrite sender data
```
var shipment = new CreateShipment
{
    CompanyName = "Reciever",
    StreetLine1 = "Street",
    NumberLine1 = "1",
    ZipCode = "3905 KW",
    City = "Example",
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
    },
    Sender = new Address
    {
        CompanyName = "KeenDelivery",
        ContactPerson = "J. van Mourik",
        StreetLine1 = "Wiltonstraat",
        NumberLine1 = "41",
        ZipCode = "3905KW",
        City = "Veenendaal",
        Country = "NL",
    }
};
var response = await client.CreateShipment(shipment);
if (response != null)
{
    File.WriteAllBytes("labels.pdf", Convert.FromBase64String(response.Label));
}
```

## Get labels
Get the BAT file for two different products. Both BAT and ZPL use the same request.
```
var label = new CreateLabel
{
    Shipments = new[] { ID, ID },
    Type = "BAT"
};
var response = await client.CreateLabels(label);
if (response != null)
{
    File.WriteAllBytes("labels.bat", Convert.FromBase64String(response.Labels));
}
```

Get the PDF file for different shipments
```
var label = new CreateLabel
{
    Shipments = new[] { ID, ID },
    Type = "PDF"
};
var response = await client.CreateLabels(label);
if (response != null)
{
    File.WriteAllBytes("labels.pdf", Convert.FromBase64String(response.Labels));
}
```

## Shipment status
```
var response = await client.GetShipmentStatus(ID);
```

## Parcel Shop finder
Search parcel shops for multiple products
```
var searchData = new FindParcelShop
{
    StreetLine1 = "Wiltonstraat",
    NumberLine1 = "41",
    ZipCode = "3905 KW",
    City = "Veenendaal",
    Country = "NL",
    Products = new[] { "DPD", "DHL" }
};
var response = await client.FindParcelShop(searchData);
```

Search parcel shops for one product
```
var searchData = new FindParcelShop
{
    StreetLine1 = "Wiltonstraat",
    NumberLine1 = "41",
    ZipCode = "3905 KW",
    City = "Veenendaal",
    Country = "NL",
    Products = new[] { "DHL" }
};
var response = await client.FindParcelShop(searchData);
```

Search parcel shops on GEO location
```
var searchData = new FindParcelShop
{
    Latitude = "52.04037940000001",
    Longitude = "5.564982699999973",
    Products = new[] { "DPD", "DHL" }
};
var response = await client.FindParcelShop(searchData);
```

## Delivery Schedule finder
Find the delivery schedule for mutliple products
```
var searchData = new FindDeliverySchedule
{
    ZipCode = "3905 KW",
    Products = new[] { "DPD", "DHL" }
};
var response = await client.FindDeliverySchedule(searchData);
```

Find the delivery schedule for one product
```
var searchData = new FindDeliverySchedule
{
    ZipCode = "3905 KW",
    Products = new[] { "DHL" }
};
var response = await client.FindDeliverySchedule(searchData);
```

