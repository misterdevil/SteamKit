//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Option: light framework (CF/Silverlight) enabled
    
// Generated from: steammessages_partnerapps.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_RequestUploadToken_Request")]
  public partial class CPartnerApps_RequestUploadToken_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_RequestUploadToken_Request() {}
    

    private string _filename;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string filename
    {
      get { return _filename?? ""; }
      set { _filename = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool filenameSpecified
    {
      get { return _filename != null; }
      set { if (value == (_filename== null)) _filename = value ? this.filename : (string)null; }
    }
    private bool ShouldSerializefilename() { return filenameSpecified; }
    private void Resetfilename() { filenameSpecified = false; }
    

    private uint? _appid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint appid
    {
      get { return _appid?? default(uint); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (uint?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_RequestUploadToken_Response")]
  public partial class CPartnerApps_RequestUploadToken_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_RequestUploadToken_Response() {}
    

    private ulong? _upload_token;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"upload_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong upload_token
    {
      get { return _upload_token?? default(ulong); }
      set { _upload_token = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool upload_tokenSpecified
    {
      get { return _upload_token != null; }
      set { if (value == (_upload_token== null)) _upload_token = value ? this.upload_token : (ulong?)null; }
    }
    private bool ShouldSerializeupload_token() { return upload_tokenSpecified; }
    private void Resetupload_token() { upload_tokenSpecified = false; }
    

    private string _location;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string location
    {
      get { return _location?? ""; }
      set { _location = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool locationSpecified
    {
      get { return _location != null; }
      set { if (value == (_location== null)) _location = value ? this.location : (string)null; }
    }
    private bool ShouldSerializelocation() { return locationSpecified; }
    private void Resetlocation() { locationSpecified = false; }
    

    private ulong? _routing_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"routing_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong routing_id
    {
      get { return _routing_id?? default(ulong); }
      set { _routing_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool routing_idSpecified
    {
      get { return _routing_id != null; }
      set { if (value == (_routing_id== null)) _routing_id = value ? this.routing_id : (ulong?)null; }
    }
    private bool ShouldSerializerouting_id() { return routing_idSpecified; }
    private void Resetrouting_id() { routing_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUpload_Request")]
  public partial class CPartnerApps_FinishUpload_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUpload_Request() {}
    

    private ulong? _upload_token;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"upload_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong upload_token
    {
      get { return _upload_token?? default(ulong); }
      set { _upload_token = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool upload_tokenSpecified
    {
      get { return _upload_token != null; }
      set { if (value == (_upload_token== null)) _upload_token = value ? this.upload_token : (ulong?)null; }
    }
    private bool ShouldSerializeupload_token() { return upload_tokenSpecified; }
    private void Resetupload_token() { upload_tokenSpecified = false; }
    

    private ulong? _routing_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"routing_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong routing_id
    {
      get { return _routing_id?? default(ulong); }
      set { _routing_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool routing_idSpecified
    {
      get { return _routing_id != null; }
      set { if (value == (_routing_id== null)) _routing_id = value ? this.routing_id : (ulong?)null; }
    }
    private bool ShouldSerializerouting_id() { return routing_idSpecified; }
    private void Resetrouting_id() { routing_idSpecified = false; }
    

    private uint? _app_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint app_id
    {
      get { return _app_id?? default(uint); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (uint?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUploadKVSign_Response")]
  public partial class CPartnerApps_FinishUploadKVSign_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUploadKVSign_Response() {}
    

    private string _signed_installscript;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"signed_installscript", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string signed_installscript
    {
      get { return _signed_installscript?? ""; }
      set { _signed_installscript = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool signed_installscriptSpecified
    {
      get { return _signed_installscript != null; }
      set { if (value == (_signed_installscript== null)) _signed_installscript = value ? this.signed_installscript : (string)null; }
    }
    private bool ShouldSerializesigned_installscript() { return signed_installscriptSpecified; }
    private void Resetsigned_installscript() { signed_installscriptSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUploadLegacyDRM_Request")]
  public partial class CPartnerApps_FinishUploadLegacyDRM_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUploadLegacyDRM_Request() {}
    

    private ulong? _upload_token;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"upload_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong upload_token
    {
      get { return _upload_token?? default(ulong); }
      set { _upload_token = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool upload_tokenSpecified
    {
      get { return _upload_token != null; }
      set { if (value == (_upload_token== null)) _upload_token = value ? this.upload_token : (ulong?)null; }
    }
    private bool ShouldSerializeupload_token() { return upload_tokenSpecified; }
    private void Resetupload_token() { upload_tokenSpecified = false; }
    

    private ulong? _routing_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"routing_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong routing_id
    {
      get { return _routing_id?? default(ulong); }
      set { _routing_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool routing_idSpecified
    {
      get { return _routing_id != null; }
      set { if (value == (_routing_id== null)) _routing_id = value ? this.routing_id : (ulong?)null; }
    }
    private bool ShouldSerializerouting_id() { return routing_idSpecified; }
    private void Resetrouting_id() { routing_idSpecified = false; }
    

    private uint? _app_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint app_id
    {
      get { return _app_id?? default(uint); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (uint?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    

    private uint? _flags;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint flags
    {
      get { return _flags?? default(uint); }
      set { _flags = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool flagsSpecified
    {
      get { return _flags != null; }
      set { if (value == (_flags== null)) _flags = value ? this.flags : (uint?)null; }
    }
    private bool ShouldSerializeflags() { return flagsSpecified; }
    private void Resetflags() { flagsSpecified = false; }
    

    private string _tool_name;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tool_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string tool_name
    {
      get { return _tool_name?? ""; }
      set { _tool_name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool tool_nameSpecified
    {
      get { return _tool_name != null; }
      set { if (value == (_tool_name== null)) _tool_name = value ? this.tool_name : (string)null; }
    }
    private bool ShouldSerializetool_name() { return tool_nameSpecified; }
    private void Resettool_name() { tool_nameSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUploadLegacyDRM_Response")]
  public partial class CPartnerApps_FinishUploadLegacyDRM_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUploadLegacyDRM_Response() {}
    

    private string _file_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string file_id
    {
      get { return _file_id?? ""; }
      set { _file_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool file_idSpecified
    {
      get { return _file_id != null; }
      set { if (value == (_file_id== null)) _file_id = value ? this.file_id : (string)null; }
    }
    private bool ShouldSerializefile_id() { return file_idSpecified; }
    private void Resetfile_id() { file_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUpload_Response")]
  public partial class CPartnerApps_FinishUpload_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUpload_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FindDRMUploads_Request")]
  public partial class CPartnerApps_FindDRMUploads_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FindDRMUploads_Request() {}
    

    private int? _app_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int app_id
    {
      get { return _app_id?? default(int); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (int?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_ExistingDRMUpload")]
  public partial class CPartnerApps_ExistingDRMUpload : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_ExistingDRMUpload() {}
    

    private string _file_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string file_id
    {
      get { return _file_id?? ""; }
      set { _file_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool file_idSpecified
    {
      get { return _file_id != null; }
      set { if (value == (_file_id== null)) _file_id = value ? this.file_id : (string)null; }
    }
    private bool ShouldSerializefile_id() { return file_idSpecified; }
    private void Resetfile_id() { file_idSpecified = false; }
    

    private uint? _app_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint app_id
    {
      get { return _app_id?? default(uint); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (uint?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    

    private int? _actor_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"actor_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int actor_id
    {
      get { return _actor_id?? default(int); }
      set { _actor_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool actor_idSpecified
    {
      get { return _actor_id != null; }
      set { if (value == (_actor_id== null)) _actor_id = value ? this.actor_id : (int?)null; }
    }
    private bool ShouldSerializeactor_id() { return actor_idSpecified; }
    private void Resetactor_id() { actor_idSpecified = false; }
    

    private string _supplied_name;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"supplied_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string supplied_name
    {
      get { return _supplied_name?? ""; }
      set { _supplied_name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool supplied_nameSpecified
    {
      get { return _supplied_name != null; }
      set { if (value == (_supplied_name== null)) _supplied_name = value ? this.supplied_name : (string)null; }
    }
    private bool ShouldSerializesupplied_name() { return supplied_nameSpecified; }
    private void Resetsupplied_name() { supplied_nameSpecified = false; }
    

    private uint? _flags;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint flags
    {
      get { return _flags?? default(uint); }
      set { _flags = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool flagsSpecified
    {
      get { return _flags != null; }
      set { if (value == (_flags== null)) _flags = value ? this.flags : (uint?)null; }
    }
    private bool ShouldSerializeflags() { return flagsSpecified; }
    private void Resetflags() { flagsSpecified = false; }
    

    private string _mod_type;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"mod_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string mod_type
    {
      get { return _mod_type?? ""; }
      set { _mod_type = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool mod_typeSpecified
    {
      get { return _mod_type != null; }
      set { if (value == (_mod_type== null)) _mod_type = value ? this.mod_type : (string)null; }
    }
    private bool ShouldSerializemod_type() { return mod_typeSpecified; }
    private void Resetmod_type() { mod_typeSpecified = false; }
    

    private uint? _timestamp;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint timestamp
    {
      get { return _timestamp?? default(uint); }
      set { _timestamp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool timestampSpecified
    {
      get { return _timestamp != null; }
      set { if (value == (_timestamp== null)) _timestamp = value ? this.timestamp : (uint?)null; }
    }
    private bool ShouldSerializetimestamp() { return timestampSpecified; }
    private void Resettimestamp() { timestampSpecified = false; }
    

    private string _orig_file_id;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"orig_file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string orig_file_id
    {
      get { return _orig_file_id?? ""; }
      set { _orig_file_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool orig_file_idSpecified
    {
      get { return _orig_file_id != null; }
      set { if (value == (_orig_file_id== null)) _orig_file_id = value ? this.orig_file_id : (string)null; }
    }
    private bool ShouldSerializeorig_file_id() { return orig_file_idSpecified; }
    private void Resetorig_file_id() { orig_file_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FindDRMUploads_Response")]
  public partial class CPartnerApps_FindDRMUploads_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FindDRMUploads_Response() {}
    
    private readonly global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload> _uploads = new global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload>();
    [global::ProtoBuf.ProtoMember(1, Name=@"uploads", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload> uploads
    {
      get { return _uploads; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_Download_Request")]
  public partial class CPartnerApps_Download_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_Download_Request() {}
    

    private string _file_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string file_id
    {
      get { return _file_id?? ""; }
      set { _file_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool file_idSpecified
    {
      get { return _file_id != null; }
      set { if (value == (_file_id== null)) _file_id = value ? this.file_id : (string)null; }
    }
    private bool ShouldSerializefile_id() { return file_idSpecified; }
    private void Resetfile_id() { file_idSpecified = false; }
    

    private int? _app_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int app_id
    {
      get { return _app_id?? default(int); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (int?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_Download_Response")]
  public partial class CPartnerApps_Download_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_Download_Response() {}
    

    private string _download_url;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"download_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string download_url
    {
      get { return _download_url?? ""; }
      set { _download_url = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool download_urlSpecified
    {
      get { return _download_url != null; }
      set { if (value == (_download_url== null)) _download_url = value ? this.download_url : (string)null; }
    }
    private bool ShouldSerializedownload_url() { return download_urlSpecified; }
    private void Resetdownload_url() { download_urlSpecified = false; }
    

    private int? _app_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int app_id
    {
      get { return _app_id?? default(int); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (int?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IPartnerApps
    {
      CPartnerApps_RequestUploadToken_Response RequestKVSignUploadToken(CPartnerApps_RequestUploadToken_Request request);
    CPartnerApps_RequestUploadToken_Response RequestDRMUploadToken(CPartnerApps_RequestUploadToken_Request request);
    CPartnerApps_RequestUploadToken_Response RequestCEGUploadToken(CPartnerApps_RequestUploadToken_Request request);
    CPartnerApps_FinishUploadKVSign_Response FinishUploadKVSign(CPartnerApps_FinishUpload_Request request);
    CPartnerApps_FinishUploadLegacyDRM_Response FinishUploadDRMUpload(CPartnerApps_FinishUploadLegacyDRM_Request request);
    CPartnerApps_FinishUpload_Response FinishUploadCEGUpload(CPartnerApps_FinishUpload_Request request);
    CPartnerApps_FindDRMUploads_Response FindDRMUploads(CPartnerApps_FindDRMUploads_Request request);
    CPartnerApps_Download_Response Download(CPartnerApps_Download_Request request);
    
    }
    
    
}
#pragma warning restore 1591
