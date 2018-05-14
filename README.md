# KeenDeliveryApi.Net [![Build status](https://ci.appveyor.com/api/projects/status/m1c22rca95pl5o21?svg=true)](https://ci.appveyor.com/project/janssenr/keendeliveryapi-net) [![NuGet version](https://badge.fury.io/nu/keendelivery.svg)](https://badge.fury.io/nu/keendelivery)
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
