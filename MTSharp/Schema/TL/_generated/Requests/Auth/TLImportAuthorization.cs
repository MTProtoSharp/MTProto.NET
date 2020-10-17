using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0xe3ef9613)]
    public class TLImportAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe3ef9613;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Bytes { get; set; }


    }
}
