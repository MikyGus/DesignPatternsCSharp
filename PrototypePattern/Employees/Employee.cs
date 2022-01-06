namespace PrototypePattern.Employees
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }

        public Employee(int id, string name, EmployeeAddress employeeAddress)
        {
            Id = id;
            Name = name;
            EmployeeAddress = employeeAddress;
        }

        //Demo 4
        public Employee(Employee originalEmployee)
        {
            Id=originalEmployee.Id;
            Name=originalEmployee.Name;
            EmployeeAddress = (EmployeeAddress)originalEmployee.EmployeeAddress.CloneAddress();

        }

        public override String ToString()
        {
            return string.Format("Employee Id is: {0}, Employee name is: {1}, Employee Address is: {2}", Id, Name, EmployeeAddress);
        }

        public object Clone()
        {
            // Shallow copy
            //return this.MemberwiseClone();


            // Deep Copy
            Employee employee = (Employee)MemberwiseClone();
            employee.EmployeeAddress = (EmployeeAddress)EmployeeAddress.CloneAddress();
            return employee;

        }
    }
}
