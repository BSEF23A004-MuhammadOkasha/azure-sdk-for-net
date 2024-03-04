// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;
using Azure.Storage.Files.Shares;

namespace Azure.Storage.Files.Shares.Models
{
    public partial class ShareProtocolSettings : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "ProtocolSettings");
            if (Optional.IsDefined(Smb))
            {
                writer.WriteObjectValue(Smb, "SMB");
            }
            writer.WriteEndElement();
        }

        internal static ShareProtocolSettings DeserializeShareProtocolSettings(XElement element)
        {
            ShareSmbSettings smb = default;
            if (element.Element("SMB") is XElement smbElement)
            {
                smb = ShareSmbSettings.DeserializeShareSmbSettings(smbElement);
            }
            return new ShareProtocolSettings(smb);
        }
    }
}
