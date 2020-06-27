using SimpleCalculator.Domain;
using System.ComponentModel.Composition;

namespace SimpleCalculator
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '+')]
    class Add : IOperation
    {
        public int Operate(int left, int right)
        {
            return left + right;
        }
    }
}
