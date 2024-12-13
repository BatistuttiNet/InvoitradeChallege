namespace InvoitradeChallage
{
    public class NegotiableDocumentService
    {
        public NegotiableDocumentService() { }

        public NegotiableDocument CreateNegotiableDocument(NegotiableDocument negotiableDocument)
        {
            negotiableDocument.Id = Guid.NewGuid();

            if (negotiableDocument.DocumentType == "FACTURA")
            {
                negotiableDocument.ExpirationDate = negotiableDocument.IssueDate.AddDays(30);
                negotiableDocument.DocumentStatus = "NEGOCIABLE";
            }
            else if (negotiableDocument.DocumentType == "ORDEN DE PAGO")
            {
                negotiableDocument.ExpirationDate = negotiableDocument.IssueDate.AddDays(15);
                negotiableDocument.DocumentStatus = "PENDIENTE";
            }
            else if (negotiableDocument.DocumentType == "PAGARE")
            {
                negotiableDocument.ExpirationDate = negotiableDocument.IssueDate.AddDays(90);
                negotiableDocument.DocumentStatus = "NEGOCIABLE";
            }
            else
            {
                negotiableDocument.DocumentStatus = "NO NEGOCIABLE";
            }


            return negotiableDocument;
        }

        public NegotiableDocument UpdateNegotiableDocument(string status)
        {
            throw new NotImplementedException();
        }

        public NegotiableDocument GetNegotiableDocument(Guid id)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateComision(Guid id)
        {

            var negotiableDocument = GetNegotiableDocument(id);

            if (negotiableDocument.DocumentType == "FACTURA")
            {
                return negotiableDocument.Amount * 0.01m;
            }
            else if (negotiableDocument.DocumentType == "ORDEN DE PAGO")
            {
                return negotiableDocument.Amount * 0.02m;
            }
            else if (negotiableDocument.DocumentType == "PAGARE")
            {
                return negotiableDocument.Amount * 0.5m;
            }

            return 0;
        }



    }
}
