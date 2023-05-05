namespace demoprojectAPI.Models
{
    public class Document
    {
        public int ID { get; set; }
        public int documentID { get; set; }
        public int templateID { get; set; }
        public string documentReference { get; set; }
        public bool waitingforAdminApproval { get; set; }
        public string contributor { get; set; }
        public string creator { get; set; }
        public string description{ get; set; }

        public DateTime date { get; set; } 
    }

}
