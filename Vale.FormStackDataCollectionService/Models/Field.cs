using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vale.FormStackDataCollectionService.Models
{
    public class Field
    {

        private long FieldKey { get; set; }
        private long FormstackFieldId { get; set; }
        private long FormId { get; set; }
        private string FieldName { get; set; }
        private string FieldType { get; set; }
        private DateTime ImportedDate { get; set; }
        private DateTime DeletedDate { get; set; }
        private DateTime LastSubmissionDate { get; set; }
        private long ParentFieldKey { get; set; }
       
          
           

    }
}