using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0xdf969c2d)]
    public class TLExportedAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdf969c2d;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Bytes { get; set; }


    }
}
