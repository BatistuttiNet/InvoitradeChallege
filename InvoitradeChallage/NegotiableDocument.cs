namespace InvoitradeChallage
{
    public class NegotiableDocument
    {
        public Guid Id { get; set; }

        public String Owner { get; set; }

        public string Debtor { get; set; }

        public int Amount { get; set; }

        public int Currency { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string DocumentType { get; set; }
        public string DocumentStatus { get; set; }
    }


}
