using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class MainUserControl : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MCQPlaceHolder.Visible = false;
            CodePlaceHolder.Visible = false;

            TestingSystemEntities2 db = new TestingSystemEntities2();
            var ListofSubjects = db.Subs.ToList();
            ddl1.DataSource = ListofSubjects;
            ddl1.DataTextField = "name";
            ddl1.DataValueField = "id";
            ddl1.DataBind();
            ddl1.Items.Insert(0, new ListItem("Select Subject", ""));
        }
    }

    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TestingSystemEntities2 db = new TestingSystemEntities2();
        int SelectedSubject = Convert.ToInt32(ddl1.SelectedValue);
        var ListofTopics = db.Topics.Where(w =>w.subId == SelectedSubject).ToList();
        ddl2.DataSource = ListofTopics;
        ddl2.DataTextField = "Tname";
        ddl2.DataValueField = "id";
        ddl2.DataBind();
        ddl2.Items.Insert(0, new ListItem("Select Topic", ""));
    }
    protected void AddSubjectAndTopic_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewEntry.aspx");
    }
    protected void ddlTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
    {
        int num = Convert.ToInt32(ddlTypeSelection.SelectedItem.Value);

        MainData maindata = new MainData();
        maindata.Hardness = Convert.ToInt32(RadioButtonList1.SelectedValue);
        maindata.Points = Convert.ToInt32(txtofPoints.Text);
        maindata.Topicid = Convert.ToInt32(ddl2.SelectedItem.Value);
        Session["Maindata"] = maindata;

        if (num == 1)
            MCQPlaceHolder.Visible = true;
        else
            CodePlaceHolder.Visible = true;
    }
}