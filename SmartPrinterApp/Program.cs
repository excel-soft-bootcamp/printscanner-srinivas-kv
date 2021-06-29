using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPrinterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer _print = new Printer();
            _print.Print();
            Scanner _scan = new Scanner();
            _scan.Scan();

            PrintManager printing = new PrintManager();
            printing.PrintDocument(_print);

            ScanManager scanning = new ScanManager();
            scanning.ScanDocument(_scan);

            SmartPrinter printSmartPrinter = new SmartPrinter(new PrintManager());
            printSmartPrinter.Printing();

            SmartPrinter scanSmartPrinter = new SmartPrinter(new ScanManager());
            scanSmartPrinter.Scaning();

            SmartPrinter SmartPrinter = new SmartPrinter(new PrintManager(), new ScanManager());
            SmartPrinter.SmartPrint();
            Console.ReadLine();
        }
    }
}
