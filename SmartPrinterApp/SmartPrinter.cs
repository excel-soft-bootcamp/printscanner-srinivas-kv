using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPrinterApp
{
    class SmartPrinter
    {
        IPrinter _print;
        IScanner _scan;
        public SmartPrinter (IPrinter print)
        {
            this._print = print;

        }

        public SmartPrinter(IScanner scan)
        {
            this._scan = scan;
        }

        public SmartPrinter(IPrinter print, IScanner scan)
        {
            this._print = print;
            this._scan = scan;
        }
        public void SmartPrint()
        {
            _print.Print();
            _scan.Scan();
        }
        public void Printing()
        {
            _print.Print();
        }
        public void Scaning()
        {
            _scan.Scan();
        }
    }
}
