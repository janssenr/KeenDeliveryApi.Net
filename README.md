# MyParcelApi.Net [![Build status](https://ci.appveyor.com/api/projects/status/heqg2l4f1mqtlrr0?svg=true)](https://ci.appveyor.com/project/janssenr/myparcelapi-net) [![NuGet version](https://badge.fury.io/nu/myparcelapi.svg)](https://badge.fury.io/for/nu/myparcelapi)
A C#/.net wrapper for the MyParcel.nl API

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
