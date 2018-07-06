using Optimal_Gaming_Class_Library.Model_Layer;
using Optimal_Gaming_Class_Library.Model_Layer.Components;
using Optimal_Gaming_Class_Library.Model_Layer.Components.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class ComponentController
    {
        public ComponentCaseController _ComponentCaseController = null;
        public ComponentGPUController _ComponentGPUController = null;
        public ComponentCPUController _ComponentCPUController = null;
        public ComponentMotherboardController _ComponentMotherboardController = null;
        public ComponentPSUController _ComponentPSUController = null;
        public ComponentSizeController _ComponentSizeController = null;
        public ComponentSSDController _ComponentSSDController = null;
        public ComponentHDDController _ComponentHDDController = null;
        public ComponentRamController _ComponentRamController = null;
        //Ram controller needed
        
        /// <summary>
        /// Constructor of the ComponentController class. Instanciate the different component controllers.
        /// </summary>
        public ComponentController()
        {
            _ComponentCaseController = new ComponentCaseController();
            _ComponentGPUController = new ComponentGPUController();
            _ComponentCPUController = new ComponentCPUController();
            _ComponentMotherboardController = new ComponentMotherboardController();
            _ComponentPSUController = new ComponentPSUController();
            _ComponentSizeController = new ComponentSizeController();
            _ComponentSSDController = new ComponentSSDController();
            _ComponentHDDController = new ComponentHDDController();
            _ComponentRamController = new ComponentRamController();
        }

             
    }
}
