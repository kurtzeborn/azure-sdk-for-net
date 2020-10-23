// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Monitor.OpenTelemetry.Exporter.Models
{
    public partial class MonitorBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseType))
            {
                writer.WritePropertyName("baseType");
                writer.WriteStringValue(BaseType);
            }
            if (Optional.IsDefined(BaseData))
            {
                writer.WritePropertyName("baseData");
                writer.WriteObjectValue(BaseData);
            }
            writer.WriteEndObject();
        }
    }
}