using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class ComponentController
    {
        private ComponentCaseController _ComponentCaseController = null;
        private ComponentGPUController _ComponentGPUController = null;
        private ComponentCPUController _ComponentCPUController = null;
        private ComponentMotherboardController _ComponentMotherboardController = null;
        private ComponentPSUController _ComponentPSUController = null;
        private ComponentSizeController _ComponentSizeController = null;
        private ComponentSSDController _ComponentSSDController = null;
        private ComponentHDDController _ComponentHDDController = null;
        
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
        }
    }
}
