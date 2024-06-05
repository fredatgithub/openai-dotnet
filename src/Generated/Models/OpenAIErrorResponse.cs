// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal
{
    internal partial class OpenAIErrorResponse
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal OpenAIErrorResponse(OpenAIError error)
        {
            Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }

        internal OpenAIErrorResponse(OpenAIError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal OpenAIErrorResponse()
        {
        }

        public OpenAIError Error { get; }
    }
}