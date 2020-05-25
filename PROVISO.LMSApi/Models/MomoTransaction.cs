using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROVISO.LMSApi.Models
{
    public class MomoTransaction
    {
        public int EntryID { get; set; }

        [Required]
        public string RefNo { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        //[DataType(DataType.PhoneNumber]
        public string MomoNumber { get; set; }

        public string MNO { get; set; }

        public string TransactionID
        {
            get
            {
                string datepart = DateTime.Now.ToString("MMdd-yyyy-hhmmss");
                string momoLast4 = MomoNumber.Substring(MomoNumber.Length - 4);
                string refid = $"{datepart}-{momoLast4}";
                return refid;
            }
        }

        public string LastUpdated { get; set; }
    }
}