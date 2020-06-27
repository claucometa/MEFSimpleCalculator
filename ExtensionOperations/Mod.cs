using SimpleCalculator.Domain;
using System.ComponentModel.Composition;

namespace ExtensionOperations
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '%')]
    public class Mod : IOperation
    {
        public int Operate(int left, int right)
        {
            return left % right;
        }
    }
}
