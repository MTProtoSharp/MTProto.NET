using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x1c3db333)]
    public class TLUploadTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c3db333;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputFile File { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsInputFile Thumb { get; set; }
        [MTParameter(Order = 3)]
        public string FileName { get; set; }
        [MTParameter(Order = 4)]
        public string MimeType { get; set; }


    }
}
