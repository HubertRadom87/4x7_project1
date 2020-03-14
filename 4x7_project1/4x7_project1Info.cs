using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace _4x7_project1
{
    public class x7_project1Info : GH_AssemblyInfo
  {
    public override string Name
    {
        get
        {
            return "FourBySeven";
        }
    }
    public override Bitmap Icon
    {
        get
        {
            //Return a 24x24 pixel bitmap to represent this GHA library.
            return null;
        }
    }
    public override string Description
    {
        get
        {
            //Return a short string describing the purpose of this GHA library.
            return "";
        }
    }
    public override Guid Id
    {
        get
        {
            return new Guid("dd715c30-cd60-4f77-9ca7-e4d0dc50f32e");
        }
    }

    public override string AuthorName
    {
        get
        {
            //Return a string identifying you or your company.
            return " ";
        }
    }
    public override string AuthorContact
    {
        get
        {
            //Return a string representing your preferred contact details.
            return "";
        }
    }
}
}
