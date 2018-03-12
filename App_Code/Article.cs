﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Article
/// </summary>
public class Article
{
    DBServices db;
    int id;
    string title, link;
    List<User> users;
    List<Keyword> keywords;


    public int Id { get { return id; } }
    public string Title { get { return title; } }
    public string Link { get { return link; } }
    

    public List<User> Users
    {
        get
        {
            if (users==null)
            {
                users = db.GetArticleUsers(id);
            }
            return users;
        }
    }
    public List<Keyword> Keywords
    {
        get
        {
            if (keywords==null)
            {
                keywords = db.GetArticleKeywords(id);
            }
            return keywords;
        }
    }

    public Article()
    {
     
        db = new DBServices();
    }

    public Article(int id, string title, string link) 
    {

        db = new DBServices();
        this.id = id;
        this.title = title;
        this.link = link;
    }

    public List<Article> GetAllArticles()
    {
        return db.GetAllArticles();
    }
    public Article GetArticleById(int aId)
    {
        return db.GetArticleById(aId);
    }

   

    public override string ToString()
    {
        string info = "Id: " + id + "<br>";
        info += "Title: " + title + "<br>";
        info += "Link: " + link + "<br>";
        return info;
    }

    
}