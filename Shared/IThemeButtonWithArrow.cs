
using Microsoft.VisualBasic;
  
namespace IDE.UI
{

  

    public interface IThemeButtonWithArrow {

#region Interface Properties
        
        System.Web.UI.WebControls.Image ArrowImage {get;}
                
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  