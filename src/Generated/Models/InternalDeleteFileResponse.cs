// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Files
{
    internal partial class InternalDeleteFileResponse
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalDeleteFileResponse(string id, bool deleted)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Deleted = deleted;
        }

        internal InternalDeleteFileResponse(string id, InternalDeleteFileResponseObject @object, bool deleted, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Deleted = deleted;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalDeleteFileResponse()
        {
        }

        public string Id { get; }
        public InternalDeleteFileResponseObject Object { get; } = InternalDeleteFileResponseObject.File;

        public bool Deleted { get; }
    }
}
