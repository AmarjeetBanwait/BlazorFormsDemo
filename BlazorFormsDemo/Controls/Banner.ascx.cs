using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace BlazorFormsDemo.Controls;

public partial class Banner : UserControl
{
    protected Label lbl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl.Text = "Not Postback";
        }
        else
        {
            lbl.Text = "Yes Postback";
        }

    }
}