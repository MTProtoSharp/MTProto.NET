using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests
{
    [MTObject(0xc1cd5ea9)]
    public class TLInitConnection : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc1cd5ea9;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int ApiId { get; set; }
        [MTParameter(Order = 2)]
        public string DeviceModel { get; set; }
        [MTParameter(Order = 3)]
        public string SystemVersion { get; set; }
        [MTParameter(Order = 4)]
        public string AppVersion { get; set; }
        [MTParameter(Order = 5)]
        public string SystemLangCode { get; set; }
        [MTParameter(Order = 6)]
        public string LangPack { get; set; }
        [MTParameter(Order = 7)]
        public string LangCode { get; set; }
        [MTParameter(Order = 8, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLInputClientProxy Proxy { get; set; }
        [MTParameter(Order = 9, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLAbsJSONValue Params { get; set; }
        [MTParameter(Order = 10)]
        public MTObject Query { get; set; }


    }
}
