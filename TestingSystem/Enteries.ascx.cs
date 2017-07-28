using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Enteries : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int num = Convert.ToInt32(RadioButtonList1.SelectedValue);
        if (num == 2)
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
        }
        if (num == 1)
        {
            Panel3.Visible = true;
            Panel1.Visible = false;
        }
    }
    protected void SubmitBtn1_Click(object sender, EventArgs e)
    {
        int num = Convert.ToInt32(RadioButtonList1.SelectedValue);
        if (num == 2)
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
        }
        if (num == 1)
        {
            Panel3.Visible = true;
            Panel1.Visible = false;
        }
    }
    protected void AddMoreTopicBtn_Click(object sender, EventArgs e)
    {
        int data = 1;
        TestingSystemEntities2 ts = new TestingSystemEntities2();
        Topic t = new Topic();
        Sub s = new Sub();
        if (data == 1)
        {
          
                if (ts.Subs.Any(a => a.name == SubTxt1.Text))
                {
                    ScriptManager.RegisterStartupScript(Page, typeof(Page), "key", "alert('Subject Name already exist')", true);
                }
                else
                {
                    s.name = SubTxt1.Text;
                    ts.Subs.Add(s);
                    ts.SaveChanges();

                    ViewState["subjectid"] = s.id;
                    if (TopicTxt1.Text != null)
                    {
                        t.Tname = TopicTxt1.Text;
                        t.subId = s.id;
                        ts.Topics.Add(t);
                        ts.SaveChanges();
                    }
                    TopicTxt1.Text = "";              
            }
            data = 5;
        }
        else
        {
            int id = Convert.ToInt32(ViewState["subjectid"]);
            if (TopicTxt1.Text != null)
            {
                t.Tname = TopicTxt1.Text;
                t.subId = id;
                ts.Topics.Add(t);
                ts.SaveChanges();
            }
            TopicTxt1.Text = "";
        }
    }
    protected void SubmitBtn2_Click(object sender, EventArgs e)
    {
        TestingSystemEntities2 ts = new TestingSystemEntities2();
        Topic t = new Topic();
        int id = Convert.ToInt32(ViewState["subjectid"]);
        if (TopicTxt1.Text != null)
        {
            t.Tname = TopicTxt1.Text;
            t.subId = id;
            ts.Topics.Add(t);
            ts.SaveChanges();
        }
        TopicTxt1.Text = "";
        Response.Redirect("MCQPage.aspx");
    }

    protected void SubmitBtn3_Click(object sender, EventArgs e)
    {
        TestingSystemEntities2 ts = new TestingSystemEntities2();
        Sub s = new Sub();
        Topic t = new Topic();
        if (SubTxt2.Text != "")
        {
            if (ts.Subs.Any(a => a.name == SubTxt2.Text))
            {
                ScriptManager.RegisterStartupScript(Page, typeof(Page), "key", "alert('Subject Name already exist')", true);
            }
            else
            {
                if (SubTxt2.Text != null && TopicTxt2.Text != null)
                {
                    s.name = SubTxt2.Text;
                    ts.Subs.Add(s);
                    ts.SaveChanges();
                    t.Tname = TopicTxt2.Text;
                    t.subId = s.id;
                    ts.Topics.Add(t);
                    ts.SaveChanges();
                    Response.Redirect("MCQPage.aspx");
                }
            }
        }
    }
}