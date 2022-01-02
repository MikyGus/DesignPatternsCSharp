namespace PrototypePattern.Employees
{
    internal class EmployeeAddress
    {
        public string Address { get; set; }
        public EmployeeAddress(string address)
        {
            Address = address;
        }

        public override String ToString()
        {
            return this.Address;
        }

        public object CloneAddress()
        {
            // Shallow copy
            return this.MemberwiseClone();
        }
    }
}
