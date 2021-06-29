using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPrinterApp 
{
    class ScanManager : Scanner
    {
        public void ScanDocument(Scanner scanner)
        {
            scanner.Scan();
        }

}
}
