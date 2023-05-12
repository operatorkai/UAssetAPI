# ColorMaterialInputPropertyData

Namespace: UAssetAPI.PropertyTypes.Structs

```csharp
public class ColorMaterialInputPropertyData : MaterialInputPropertyData`1, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PropertyData](./uassetapi.propertytypes.objects.propertydata.md) → [PropertyData&lt;ColorPropertyData&gt;](./uassetapi.propertytypes.objects.propertydata-1.md) → [MaterialInputPropertyData&lt;ColorPropertyData&gt;](./uassetapi.propertytypes.structs.materialinputpropertydata-1.md) → [ColorMaterialInputPropertyData](./uassetapi.propertytypes.structs.colormaterialinputpropertydata.md)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Fields

### **OutputIndex**

```csharp
public int OutputIndex;
```

### **InputName**

```csharp
public FString InputName;
```

### **ExpressionName**

```csharp
public FName ExpressionName;
```

### **Name**

The name of this property.

```csharp
public FName Name;
```

### **Ancestry**

The ancestry of this property. Contains information about all the classes/structs that this property is contained within. Not serialized.

```csharp
public AncestryInfo Ancestry;
```

### **DuplicationIndex**

The duplication index of this property. Used to distinguish properties with the same name in the same struct.

```csharp
public int DuplicationIndex;
```

### **PropertyGuid**

An optional property GUID. Nearly always null.

```csharp
public Nullable<Guid> PropertyGuid;
```

### **IsZero**

Whether or not this property is empty. If true, the body of this property will not be serialized in unversioned assets.

```csharp
public bool IsZero;
```

### **Offset**

The offset of this property on disk. This is for the user only, and has no bearing in the API itself.

```csharp
public long Offset;
```

### **Tag**

An optional tag which can be set on any property in memory. This is for the user only, and has no bearing in the API itself.

```csharp
public object Tag;
```

### **RawValue**

```csharp
public object RawValue;
```

## Properties

### **HasCustomStructSerialization**

```csharp
public bool HasCustomStructSerialization { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PropertyType**

```csharp
public FString PropertyType { get; }
```

#### Property Value

[FString](./uassetapi.unrealtypes.fstring.md)<br>

### **Value**

The main value of this property, if such a concept is applicable to the property in question. Properties may contain other values as well, in which case they will be present as other fields in the child class.

```csharp
public ColorPropertyData Value { get; set; }
```

#### Property Value

[ColorPropertyData](./uassetapi.propertytypes.structs.colorpropertydata.md)<br>

### **ShouldBeRegistered**

Determines whether or not this particular property should be registered in the property registry and automatically used when parsing assets.

```csharp
public bool ShouldBeRegistered { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **ColorMaterialInputPropertyData(FName)**

```csharp
public ColorMaterialInputPropertyData(FName name)
```

#### Parameters

`name` [FName](./uassetapi.unrealtypes.fname.md)<br>

### **ColorMaterialInputPropertyData()**

```csharp
public ColorMaterialInputPropertyData()
```

## Methods

### **Read(AssetBinaryReader, Boolean, Int64, Int64)**

```csharp
public void Read(AssetBinaryReader reader, bool includeHeader, long leng1, long leng2)
```

#### Parameters

`reader` [AssetBinaryReader](./uassetapi.assetbinaryreader.md)<br>

`includeHeader` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

`leng1` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`leng2` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **ResolveAncestries(UnrealPackage, AncestryInfo)**

```csharp
public void ResolveAncestries(UnrealPackage asset, AncestryInfo ancestrySoFar)
```

#### Parameters

`asset` [UnrealPackage](./uassetapi.unrealpackage.md)<br>

`ancestrySoFar` [AncestryInfo](./uassetapi.propertytypes.objects.ancestryinfo.md)<br>

### **Write(AssetBinaryWriter, Boolean)**

```csharp
public int Write(AssetBinaryWriter writer, bool includeHeader)
```

#### Parameters

`writer` [AssetBinaryWriter](./uassetapi.assetbinarywriter.md)<br>

`includeHeader` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>