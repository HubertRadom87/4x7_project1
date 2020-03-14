using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

// In order to load the result of this wizard, you will also need to
// add the output bin/ folder of this project to the list of loaded
// folder in Grasshopper.
// You can use the _GrasshopperDeveloperSettings Rhino command for that.

namespace project1_4x7
{
    public class MakeSolidMesh : GH_Component
    {
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public MakeSolidMesh()
          : base("SolidMesh", "solid",
              "Make solid from flat mesh",
              "Meshing", "SolidMesh")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("numberinput", "ni",
                "number which is an input to component", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("numberoutput", "no",
            "number which is an output to component", GH_ParamAccess.item);
            pManager.AddGenericParameter("meshClass", "mc",
                "our own class", GH_ParamAccess.item); //1
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double number1 = 0;
            //inputs
            DA.GetData(0, ref number1);

            int id = Convert.ToInt32(number1);
            //create  new object of class
            MeshClass mc1 = new MeshClass(id);
            mc1.listOfElementID = new List<int>() { 0, 1, 2, 3 };
            mc1.numberOfElements = 15;
            


            //outputs
            DA.SetData(0, number1);
            DA.SetData(1, mc1);

        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("2ee9a030-e5f5-4f70-830f-d501677db07e"); }
        }
    }
}
