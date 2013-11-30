using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo.Mvc.Grid.CRUD.Models
//namespace WebUI.ViewModels.Group
{
    public class GroupSearch
    {
        public int GroupID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}