using System;
using System.Collections.Generic;

public class Video
{
    public string _title = "";
    public string _author = "";
    public double _length;
    public List<Comment> _comment = new List<Comment>();

    //constructor for initializing title like author etc..
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

     public void Addcomment(Comment comment)
    {
        _comment.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comment;
    }

    public int GetCommentCount()
    {
        return _comment.Count;
    }
   
}
