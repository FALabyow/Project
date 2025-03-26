using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model
{
    public class ReferenceModel
    {
        private static readonly Random rnd = new Random();

        public string GenerateReferenceNumber()
        {
            return rnd.Next(100000, 999999).ToString(); 
        }
    }
}
