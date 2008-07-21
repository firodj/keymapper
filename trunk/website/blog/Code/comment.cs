﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public class Comment
{
    public int ID { get; set; }
    public int PostID { get; set; }
    public String Name { get; set; }
    public String URL { get; set; }
    public String Email { get; set; }
    public String Text { get; set; }
}

