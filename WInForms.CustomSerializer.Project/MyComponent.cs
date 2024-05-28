using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace WInForms.CustomSerializer.Project
{
    [DesignerSerializer(typeof(MySerializer), typeof(CodeDomSerializer))]
    internal class MyComponent : Component
    {
    }
}
