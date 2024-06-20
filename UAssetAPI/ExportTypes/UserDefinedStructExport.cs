﻿using System.Collections.Generic;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.UnrealTypes;
using UAssetAPI.Unversioned;

namespace UAssetAPI.ExportTypes
{
    public class UserDefinedStructExport : StructExport
    {
        public uint StructFlags;
        public List<PropertyData> StructData;

        public UserDefinedStructExport(Export super) : base(super)
        {

        }

        public UserDefinedStructExport(UAsset asset, byte[] extras) : base(asset, extras)
        {

        }

        public UserDefinedStructExport()
        {

        }

        public override void Read(AssetBinaryReader reader, int nextStarting)
        {
            base.Read(reader, nextStarting);

            if (reader.Asset.Mappings?.Schemas != null && this.ObjectName?.Value?.Value != null)
            {
                UsmapSchema newSchema = Usmap.GetSchemaFromStructExport(this);
                reader.Asset.Mappings.Schemas[this.ObjectName.Value.Value] = newSchema;
            }

            if (this.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject)) return;

            StructFlags = reader.ReadUInt32();

            StructData = new List<PropertyData>();
            PropertyData bit;

            var unversionedHeader = new FUnversionedHeader(reader);
            while ((bit = MainSerializer.Read(reader, null, this.ObjectName, unversionedHeader, true)) != null)
            {
                StructData.Add(bit);
            }
        }

        public override void ResolveAncestries(UnrealPackage asset, AncestryInfo ancestrySoFar)
        {
            var ancestryNew = (AncestryInfo)ancestrySoFar.Clone();
            ancestryNew.SetAsParent(this.ObjectName);

            if (StructData != null)
            {
                for (int i = 0; i < StructData.Count; i++) StructData[i]?.ResolveAncestries(asset, ancestryNew);
            }
            base.ResolveAncestries(asset, ancestrySoFar);
        }

        public override void Write(AssetBinaryWriter writer)
        {
            base.Write(writer);

            if (this.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject)) return;

            writer.Write(StructFlags);

            MainSerializer.GenerateUnversionedHeader(ref StructData, this.ObjectName, writer.Asset)?.Write(writer);
            for (int j = 0; j < StructData.Count; j++)
            {
                PropertyData current = StructData[j];
                MainSerializer.Write(current, writer, true);
            }
            if (!writer.Asset.HasUnversionedProperties) writer.Write(new FName(writer.Asset, "None"));
        }
    }
}