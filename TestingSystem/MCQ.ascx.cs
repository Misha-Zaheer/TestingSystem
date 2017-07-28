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

public partial class MCQ : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<TempData> data = new List<TempData>();
            ViewState["datalist"] = data;
        }
    }
    protected void SubmitQues_Click(object sender, EventArgs e)
    {
        MainData maindata = Session["Maindata"] as MainData; 
        List<TempData> data = ViewState["datalist"] as List<TempData>;
        TestingSystemEntities2 db = new TestingSystemEntities2();

        Question q = new Question();
        q.Qstate = txtofQstat.Text;
        q.point = maindata.Points;
        q.Tid = maindata.Topicid;
        q.hardness = maindata.Hardness;
        db.Questions.Add(q);

        int lindex = data.Count();
        MCQOption mq;
        for (int i = 0; i < lindex; i++)
        {
            mq = new MCQOption();
            mq.Qid = q.id;

            mq.MOption = data[i].Option;
            if (data[i].Status == true)
            {
                mq.correct = true;
            }
            else
            {
                mq.correct = false;
            }
            db.MCQOptions.Add(mq);
        }
        db.SaveChanges();

        Response.Redirect("Default.aspx");
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        List<TempData> data = ViewState["datalist"] as List<TempData>;
        TempData d = new TempData();
        if (textofOption != null)
            d.Option = textofOption.Text;
        textofOption.Text = null;
        if (CheckBox1.Checked == true)
        {
            d.Status = true;
        }
        else
        {
            d.Status = false;
        }
        CheckBox1.Checked = false;
        data.Add(d);
        ViewState["datalist"] = data;
        Repeater1.DataSource = data;
        Repeater1.DataBind();
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            Label l = e.Item.FindControl("lbrptopic") as Label;
            CheckBox c = e.Item.FindControl("cbrptopic") as CheckBox;
        }
    }
}

[Serializable]
class TempData
{
    string ooption;
    bool ccorrect;
    public string Option
    {
        set { ooption = value; }
        get { return ooption; }
    }
    public bool Status
    {
        set { ccorrect = value; }
        get { return ccorrect; }
    }
};