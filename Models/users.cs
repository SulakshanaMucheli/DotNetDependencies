namespace DotNetDependencies.Models
{
    public class Users
    {
        public int userId{get; set;}
        public string Firstname{get; set;}
        public string Lastname{get; set;}
        public string PASSWORD{get; set;}

        public Users()
        {
            if(Firstname==null)
            {
                Firstname = " ";
            }
            if(Lastname==null)
            {
                Lastname = " ";
            }
            if(PASSWORD==null)
            {
                PASSWORD = " ";
            }
        }
    };
}