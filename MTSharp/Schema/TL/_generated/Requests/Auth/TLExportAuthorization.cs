using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0xe5bfffcd)]
    public class TLExportAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5bfffcd;
            }
        }

        [MTParameter(Order = 0)]
        public int DcId { get; set; }


    }
}
