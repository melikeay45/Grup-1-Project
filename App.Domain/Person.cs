namespace App.Domain
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string PhoneNumber { get; set; }
        public string Tc {  get; set; }
        public string Gender { get; set; }


    }
}
