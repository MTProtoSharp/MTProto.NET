using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x8fdf1920)]
    public class TLConfirmPasswordEmail : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8fdf1920;
            }
        }

        [MTParameter(Order = 0)]
        public string Code { get; set; }


    }
}
