using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace project1_4x7
{
    public class ReadClass : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the MyComponent1 class.
        /// </summary>
        public ReadClass()
          : base("ReadClass", "read",
              "Read MeshClass",
              "Meshing", "SolidMesh")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("MeshClass", "MC", "MeschClass object", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddIntegerParameter("ID","I","ID of mesh class",GH_ParamAccess.item);
            pManager.AddIntegerParameter("listIDs", "Is", "list of elemet ids", GH_ParamAccess.list);
            pManager.AddNumberParameter("size", "s", "size of the list", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            MeshClass mc1 = new MeshClass();
            DA.GetData(0, ref mc1);

            DA.SetData(0, mc1.ID);
            DA.SetDataList(1, mc1.listOfElementID);
            DA.SetData(2, mc1.numberOfElements);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("c5638edd-70be-4b88-b5ad-079b754366d8"); }
        }
    }
}