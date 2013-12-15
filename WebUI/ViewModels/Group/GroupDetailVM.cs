using System;
using System.Linq;

namespace WebUI.ViewModels.Group
{
    public class GroupDetailVM
    {
        public GroupDetail GroupDetail { get; set; }
        public ViewModels.Address.AddressDetail AddressDetail { get; set; }
        public DropDownLists.AddressDropDown addressDropDown { get; set; }

    public GroupDetailVM()
        {
            addressDropDown = new DropDownLists.AddressDropDown();
        }
    }


}