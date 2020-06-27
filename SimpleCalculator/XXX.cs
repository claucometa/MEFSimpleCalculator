using SimpleCalculator.Domain;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace SimpleCalculator
{
    class XXX
    {
        [Import(typeof(ICalculator))]
        public ICalculator Calculator { get; set; }

        private readonly CompositionContainer _container;

        public XXX()
        {

            // An aggregate catalog that combines multiple catalogs.
            var catalog = new AggregateCatalog();
            // Adds all the parts found in the same assembly as the Program class.
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(@"..\..\Extensions"));

            // Create the CompositionContainer with the parts in the catalog.
            _container = new CompositionContainer(catalog);

            // Fill the imports of this object.
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
    }
}
