using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MainData
/// </summary>
public class MainData
{
    int hardness;
    int points;
    int topicid;

    public int Hardness
    {
        get
        {
            return hardness;
        }

        set
        {
            hardness = value;
        }
    }

    public int Points
    {
        get
        {
            return points;
        }

        set
        {
            points = value;
        }
    }

    public int Topicid
    {
        get
        {
            return topicid;
        }

        set
        {
            topicid = value;
        }
    }

    public MainData()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}