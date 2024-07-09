namespace StudentWebApplication.Models
{
    public class Student
    {
        /*
         * id int primary key,
	name varchar(30),
	email varchar(30),
	mobileno varchar(10),
	address varchar(50),
	admission_date date,
	fees double(9,2),
	status varchar(20)
         */
		public int id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string mobileno { get; set; }
		public string address { get; set; }
		public DateTime admission_date { get; set; }
		public double fees {  get; set; }
		public string status { get; set; }

		public Student()
		{ }
    }
}
