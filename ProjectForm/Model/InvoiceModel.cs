using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model
{
    public class InvoiceModel
    {
        public string GenerateInvoiceNumber()
        {
            return $"INV-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }
    }
}
