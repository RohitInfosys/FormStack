using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vale.FormStackDataCollectionService.Models
{
    public class Form
    {
        private long FormId { get; set; }
        private string FormName { get; set; }
        private DateTime CreatedDate { get; set; }
        private DateTime ImportedDate { get; set; }
        private DateTime LastSubmissionDate { get; set; }
           
    }
}