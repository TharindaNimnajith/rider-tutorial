namespace RdTips1
{
    public partial class Address
    {
        public Address(string address1, string address2, string address3)
        {
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
        }

        public string Address1 { get; }
        public string Address2 { get; }
        public string Address3 { get; }

        public string FullAddress => $"{Address1} {Address2} {Address3}";

    }
}