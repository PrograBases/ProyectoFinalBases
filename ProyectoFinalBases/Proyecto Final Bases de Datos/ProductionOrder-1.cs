using System;
namespace Proyecto_Final_Bases_de_Datos
{
    public class ProductionOrder
    {
   
        private String noLote;
        private int idAsignedProduct;
        private DateTime creationDate;
        private DateTime finishedDate;
        private int status; //has to be changed to a Enum Status

        public ProductionOrder(String _noLote)
        {
            this.noLote = _noLote;
        }

        public ProductionOrder(String _noLote, int _id, DateTime _creationDate, DateTime _finishedDate,
                int _status)
        {
            this.noLote = _noLote;
            this.idAsignedProduct = _id;
            this.creationDate = _creationDate;
            this.finishedDate = _finishedDate;
            this.status = _status;
        }

        public String getNoLote() { return this.noLote; }

        public int getIdAsignedProd() { return this.idAsignedProduct; }
        public void setIdAsignedProd(int _id) { this.idAsignedProduct = _id; }

        public DateTime getCreationDate() { return this.creationDate; }

        public DateTime getFinishedDate() { return this.finishedDate; }
        public void setFinishedDate(DateTime _finishedDate) {
            this.finishedDate = _finishedDate;
        }

        public int getStatus() { return this.status; }
        public void setStatus(int _status) {
            this.status = _status;
        }

        
         
    }
}