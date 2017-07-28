using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Code : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        TestingSystemEntities2 db = new TestingSystemEntities2();
        MainData maindata = Session["Maindata"] as MainData;

        Question q = new Question();
        q.point = maindata.Points;
        q.Tid = maindata.Topicid;
        q.Qstate = txtBoxQuestion.Text;
        q.hardness = maindata.Hardness;
        db.Questions.Add(q);

        Program p = new Program();
        p.Qid = q.id;
        p.code = txtBoxCode.Text;
        db.Programs.Add(p);
        db.SaveChanges();

        txtBoxCode.Text = "";
        txtBoxQuestion.Text = "";

        Response.Redirect("Default.aspx");
    }
}