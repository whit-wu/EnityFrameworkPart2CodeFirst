namespace EntityFrameworkPart2CodeFirst
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TRANSACTIONS")]
    public partial class TRANSACTION
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANSACTION_ID { get; set; }

        //[Column(TypeName = "money")]
        public decimal? TRANSACTION_AMOUNT { get; set; }

        public int? CUSTOMER_ID { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
