### Information

This folder contains the different openapi specification, each one should be improving as we go

## Swagger_V1

The original file, before any optimisation

## Swagger_V2

We added the following code to the Controllers : 

`[Produces("application/json")]`

`[Consumes("application/json")]`

The file is now shorter, and the following sections are gone 

`"text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "type": "string"
                  }
                }
              }`

`"text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "type": "string"
                  }
                }`

## Swagger_V3

Added the following code to the Shop Controller : 

`[ApiConventionType(typeof(DefaultApiConventions))]`

The openapi specification now includes standard response code by default (400,404, etc)

## Swagger_V4

Added the OperationId to each Method: 

`[HttpGet(Name = nameof(GetShops))]`

OperationId is defined as an optional unique string used to identify an operation
