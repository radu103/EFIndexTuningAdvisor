namespace WideWorldImportersDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Application.PaymentMethods_Archive")]
    public partial class PaymentMethods_Archive
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentMethodID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PaymentMethodName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LastEditedBy { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }
    }
}
