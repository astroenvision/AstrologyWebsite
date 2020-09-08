<%@ Application Language="C#" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.IO.Compression" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Linq" %>
<%@ Import Namespace="ASTROLOGY.classesoracle" %>

<script RunAt="server">

    private static string[] SQLKeywords = new string[]
      {
            // code to use it in the "Application_BeginRequest" method to prevent "ASCII Encoded/Binary String Automated SQL Injection Attack" on the Website     

            ";", "/*", "*/", "@@","sys", "sysobjects", "syscolumns", "EXECUTE ", "EXEC(", "SELECT ",  "UPDATE ", "DELETE ", "CREATE ",
            "TRUNCATE ", "DROP ", "ALTER TABLE ", "TABLE ", "DATABASE ", "WHERE ", "ORDER BY ", "GROUP BY ",
            "DECLARE ", "CAST(", "CONVERT(", "CHAR(", "NCHAR(", "VARCHAR(", "NVARCHAR(", "CURSOR", "FETCH"
      };

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
    {
        HttpApplication app = sender as HttpApplication;
        string acceptEncoding = app.Request.Headers["Accept-Encoding"];
        Stream prevUncompressedStream = app.Response.Filter;

        if (!(app.Context.CurrentHandler is Page) ||
        app.Request["HTTP_X_MICROSOFTAJAX"] != null)
            return;

        if (acceptEncoding == null || acceptEncoding.Length == 0)
            return;

        acceptEncoding = acceptEncoding.ToLower();

        if (acceptEncoding.Contains("deflate") || acceptEncoding == "*")
        {
            // defalte
            app.Response.Filter = new DeflateStream(prevUncompressedStream,
            CompressionMode.Compress);
            app.Response.AppendHeader("Content-Encoding", "deflate");
        }
        else if (acceptEncoding.Contains("gzip"))
        {
            // gzip
            app.Response.Filter = new GZipStream(prevUncompressedStream,
            CompressionMode.Compress);
            app.Response.AppendHeader("Content-Encoding", "gzip");
        }
    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {
        HttpRequest Request = (sender as HttpApplication).Context.Request;

        foreach (string key in Request.QueryString)
            CheckInput(Request.QueryString[key]);

        foreach (string key in Request.Cookies)
            CheckInput(Request.Cookies[key].Value);
        String strCurrentPath;
        string Stoid;
        strCurrentPath = Request.Path;
        //string getCategory_id = "";
        string[] segments = Request.Url.Segments;
        DataSet ds_new = new DataSet();
        DataSet ds_new2 = new DataSet();
        common com = new common();
        string GetCompleteUrl = "http://" + Request.ServerVariables["SERVER_NAME"] + Request.RawUrl.ToString();
        if (strCurrentPath.ToUpper().IndexOf(".JPEG") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".JPG") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".GIF") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".CSS") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".JS") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".AXD") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".SWF") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".XML") > 0 || strCurrentPath.ToString().ToUpper().IndexOf(".PNG") > 0)
            return;
        try
        {
            if (GetCompleteUrl =="http://localhost/astrology/")
            {
                //Context.Response.Redirect("~/index.html", true);
                HttpContext.Current.Response.Redirect("~/index.html");
            }
            //if (strCurrentPath.IndexOf("login.aspx") > -1)
            //{
            //    Context.Response.Redirect("~/index.html", true);
            //}
            if (strCurrentPath.IndexOf("/video/") > -1)
            {
                string Album_id = "", Group_id = "";
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (strCurrentPath.Contains("/natal/") == true)
                {
                    Group_id = "natal";
                }
                if (strCurrentPath.Contains("/horary/") == true)
                {
                    Group_id = "horary";
                }
                if (Stoid.IndexOf(".") > -1)
                {
                    string[] splString = Stoid.Split('.');
                    Album_id = splString[0];
                    Context.RewritePath("~/gallery/video_details.aspx?albumid=" + Album_id + "&groupid=" + Group_id + "", false);
                }
                return;
            }
            if (strCurrentPath.IndexOf("/videogallery/") > -1)
            {
                string Gall_id = "", Group_id = "";
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (strCurrentPath.Contains("/natal/") == true)
                {
                    Group_id = "natal";
                }
                if (strCurrentPath.Contains("/horary/") == true)
                {
                    Group_id = "horary";
                }
                if (Stoid.IndexOf(".") > -1)
                {
                    string[] splString = Stoid.Split('.');
                    Gall_id = splString[0];
                    Context.RewritePath("~/gallery/video_details.aspx?gallid=" + Gall_id + "&groupid=" + Group_id + "", false);
                }
                return;
            }
            if (strCurrentPath.IndexOf("/astrology/") > -1)
            {
                Regex Splitter = new Regex("astrology");
                string FullUrl = Splitter.Split(Request.RawUrl).Last();
                if (FullUrl.Split('/').Length > 3)
                {
                    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string CatId = "", ArticleId = "";
                        if (Stoid.IndexOf("-") > -1)
                        {
                            string[] splString = Stoid.Split('-');
                            CatId = splString[0];
                            string[] splArticleid = splString[1].Split('.');
                            ArticleId = splArticleid[0];
                            int num;
                            bool isNum1 = Int32.TryParse(CatId, out num);
                            bool isNum2 = Int32.TryParse(ArticleId, out num);
                            if (isNum1 == true && isNum2 == true)
                            {
                                dailyarticle dailyarticle_obj = new dailyarticle();
                                common obj_cm = new common();
                                DataSet ds = dailyarticle_obj.Get_Article_Data(CatId, "", ArticleId, "GET_ARTICLE_URL", "", "");
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    string url_val = ds.Tables[0].Rows[0]["URL"].ToString();
                                    string catname = ds.Tables[1].Rows[0]["CAT_NAME"].ToString();
                                    string caturl = obj_cm.ReplaceQuotes(catname);
                                    caturl = obj_cm.OptimizeURL(caturl);
                                    //Context.RewritePath("~/article/article.aspx?articleurl=" + url_val + "", false);
                                    HttpContext.Current.Response.Redirect("~/astrology/" + caturl + "/" + url_val.TrimStart('-').TrimEnd('-') + ".html");
                                }
                                else
                                {
                                    Context.RewritePath("~/article/article.aspx?catid=" + CatId + "&articleid=" + ArticleId + "", false);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                    if (Stoid.IndexOf(".") > -1)
                    {
                        if (Stoid.IndexOf("-") > -1)
                        {
                            string[] splArticleid = Stoid.Split('.');
                            string ArticleUrl = splArticleid[0];
                            //if (ArticleUrl == "1-20")
                            //{
                            //    HttpContext.Current.Response.Redirect("~/index.html"); //Redirect URL (http://astroenvision.com/astrology/horary-highlight/1-20.html)
                            //}
                            //if (ArticleUrl == "1-19")
                            //{
                            //     HttpContext.Current.Response.Redirect("~/index.html"); //Redirect URL (http://www.astroenvision.com/astrology/know-about-horary-astrology/what-are-the-dissimilarities-between-a-natal-and-horary-astrology/5-19.html)
                            //}
                            Context.RewritePath("~/article/article.aspx?articleurl=" + ArticleUrl.TrimStart('-').TrimEnd('-') + "", false);
                        }
                    }
                }
            }
            if (strCurrentPath.IndexOf("/horary_astrology/") > -1)
            {
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (Stoid.IndexOf(".") > -1)
                {
                    string CatId = "", ArticleId = "";
                    if (Stoid.IndexOf("-") > -1)
                    {
                        string[] splString = Stoid.Split('-');
                        CatId = splString[0];
                        string[] splArticleid = splString[1].Split('.');
                        ArticleId = splArticleid[0];
                        int num;
                        bool isNum1 = Int32.TryParse(CatId, out num);
                        bool isNum2 = Int32.TryParse(ArticleId, out num);
                        if (isNum1 == true && isNum2 == true)
                        {
                            Context.RewritePath("~/article/article_astrologer.aspx?catid=" + CatId + "&articleid=" + ArticleId + "", false);
                        }
                    }
                }
            }
            if (strCurrentPath.IndexOf("/category/") > -1)
            {
                if (strCurrentPath.IndexOf("/natal/") > -1)
                {
                    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("category"));
                    if (Stoid != "")
                    {
                        string[] a = Stoid.Split('/');
                        string CatName = a[1];
                        if (CatName == "money-wealth")
                        {
                            CatName = "money-wealth-luxuries";
                        }
                        else if (CatName == "manglik-dosha")
                        {
                            CatName = "manglik-dosha-compatibility";
                        }
                        else if (CatName == "love-sex-life")
                        {
                            CatName = "love-and-romance";
                        }
                        else if (CatName == "dosha-samya")
                        {
                            CatName = "dosha-samya-compatibility";
                        }
                        else if (CatName == "intelligence-self-expression")
                        {
                            CatName = "intelligence-self-expression-education";
                        }
                        else if (CatName == "fame-fortune")
                        {
                            CatName = "fame-fortune-and-wisdom";
                        }
                        else if (CatName == "political-career")
                        {
                            CatName = "political-success";
                        }
                        else if (CatName == "energy-vitality")
                        {
                            CatName = "energy-vitality-personality";
                        }
                        else if (CatName == "relatives-friends")
                        {
                            CatName = "relatives-friends-siblings";
                        }
                        if (CatName != "")
                        {
                            Response.Redirect("~/natal-astrology/" + CatName + ".html", false);
                            //Context.RewritePath("~/section/CategoryDetails.aspx?Category=" + CatName + "", false);
                        }
                    }
                    //Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                    //if (Stoid.IndexOf(".") > -1)
                    //{
                    //    string CatId = "", Cartid = "";
                    //    if (Stoid.IndexOf("-") > -1)
                    //    {
                    //        string groupid = "natal";
                    //        string[] splString = Stoid.Split('-');
                    //        CatId = splString[0];
                    //        string[] splcartid = splString[1].Split('.');
                    //        Cartid = splcartid[0];
                    //        int num;
                    //        long longnum;
                    //        bool isNum1 = Int32.TryParse(CatId, out num);
                    //        bool isNum2 = Int64.TryParse(Cartid, out longnum);
                    //        if (isNum1 == true && isNum2 == true)
                    //        {
                    //            Context.RewritePath("~/article/questions.aspx?groupid=" + groupid + "&catid=" + CatId + "&cartid=" + Cartid + "", false);
                    //        }
                    //    }
                    //}
                }
            }

            if (strCurrentPath.IndexOf("/payment/") > -1)
            {
                if (strCurrentPath.IndexOf("/natal/") > -1)
                {
                    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string Cartid = "";
                        if (Stoid.IndexOf(".") > -1)
                        {
                            string groupid = "natal";
                            string[] splString = Stoid.Split('.');
                            Cartid = splString[0];
                            long longnum;
                            bool isNum2 = Int64.TryParse(Cartid, out longnum);
                            if (isNum2 == true)
                            {
                                Context.RewritePath("~/article/finalquestions.aspx?groupid=" + groupid + "&cartid=" + Cartid + "", false);
                            }
                        }
                    }
                }
            }

            if (strCurrentPath.IndexOf("/registration/") > -1)
            {
                if (strCurrentPath.IndexOf("/natal/") > -1)
                {
                    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string Cartid = "";
                        if (Stoid.IndexOf(".") > -1)
                        {
                            string groupid = "natal";
                            string[] splString = Stoid.Split('.');
                            Cartid = splString[0];
                            long longnum;
                            bool isNum2 = Int64.TryParse(Cartid, out longnum);
                            if (isNum2 == true)
                            {
                                Context.RewritePath("~/user_registration.aspx?groupid=" + groupid + "&cartid=" + Cartid + "", false);
                            }
                        }
                    }
                }
            }
            if (strCurrentPath.IndexOf("/blog/") > -1)
            {
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (Stoid.IndexOf(".") > -1)
                {
                    string BlogURL = "";
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string[] splString = Stoid.Split('.');
                        BlogURL = splString[0];
                        if (BlogURL == "1")
                        {
                            BlogURL = "lagna-aries";
                            Response.Redirect("~/blog/" + BlogURL + ".html", false);
                        }
                        else if (BlogURL == "2")
                        {
                            BlogURL = "lagna-libra";
                            Response.Redirect("~/blog/" + BlogURL + ".html", false);
                        }
                        //long longnum;
                        //bool isNum2 = Int64.TryParse(Blogid, out longnum);
                        //if (isNum2 == true)
                        //{
                        Context.RewritePath("~/blog_details.aspx?blogid=" + BlogURL + "", false);
                        //}
                    }
                }
            }
            if (strCurrentPath.IndexOf("/natal-astrology/") > -1)
            {
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (Stoid.IndexOf(".") > -1)
                {
                    string Category = "";
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string[] splString = Stoid.Split('.');
                        Category = splString[0];
                        if (Category != "" && Category != "indexpage")
                        {
                            Context.RewritePath("~/section/CategoryDetails.aspx?Category=" + Category + "", false);
                        }
                    }
                }
            }

            if (strCurrentPath.IndexOf("/astrologer/") > -1)
            {
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (Stoid.IndexOf(".") > -1)
                {
                    string AstrologerName = "";
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string[] splString = Stoid.Split('.');
                        AstrologerName = splString[0];
                        if (AstrologerName != "" && AstrologerName != "indexpage")
                        {
                            Context.RewritePath("~/AstrologerDetails.aspx?q=" + AstrologerName.Replace("-", " ") + "", false);
                        }
                    }
                }
            }
            if (strCurrentPath.IndexOf("/product/") > -1)
            {
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (Stoid.IndexOf(".") > -1)
                {
                    string producturl = "";
                    if (Stoid.IndexOf(".") > -1)
                    {
                        string[] splString = Stoid.Split('.');
                        producturl = splString[0];
                        if (producturl != "" && producturl != "indexpage")
                        {
                            Context.RewritePath("~/product_details.aspx?q=" + producturl + "", false);
                        }
                    }
                }
            }

            if (Request.RawUrl.IndexOf("/photo-gallery/") > -1)
            {
                Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
                if (Stoid != "")
                {
                    Context.RewritePath("~/photogallery/showgallery.aspx?q=" + Stoid.Replace(".html", "") + "", false);
                }
            }

            if (strCurrentPath.IndexOf("/services.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology.html");
            }
            if (strCurrentPath.IndexOf("/registration.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/signup.html");
            }
            if (strCurrentPath.IndexOf("/videodetails.aspx") > -1)
            {
                HttpContext.Current.Response.Redirect("~/index.html");
            }
            if (Request.RawUrl.IndexOf("/indexpage.aspx") > -1)
            {
                HttpContext.Current.Response.Redirect("~/index.html");
            }
            if (Request.RawUrl.IndexOf("/signin.aspx") > -1)
            {
                HttpContext.Current.Response.Redirect("~/signin.html");
            }
            if (Request.RawUrl.IndexOf("/signup.aspx") > -1)
            {
                HttpContext.Current.Response.Redirect("~/signup.html");
            }
            if (Request.RawUrl.IndexOf("/freehoroscope.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/free-horoscope.html");
            }
            if (Request.RawUrl.IndexOf("/freecompatibilitymatching.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/free-kundli-matching.html");
            }
            if (Request.RawUrl.IndexOf("/compatibilitymatching.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/kundli-matching.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/compatibility-matching.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/kundli-matching.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/adventurous-in-life-.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/adventurous-in-life.html");
            }
            //if (strCurrentPath.IndexOf("/login.aspx") > -1)  //Deepak comment this line on 16-06-2020
            //{
            //    HttpContext.Current.Response.Redirect("~/index.html");
            //}
            if (Request.RawUrl.IndexOf("/photo-albums.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/photo-gallery.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/relatives-friends--siblings.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/relatives-friends-siblings.html");
            }
            if (Request.RawUrl.IndexOf("/horary-highlight/1-20.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/horary-features.html");
            }
            if (Request.RawUrl.IndexOf("/know-about-horary-astrology/what-are-the-dissimilarities-between-a-natal-and-horary-astrology/5-19.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/horary-features.html");
            }
            if (Request.RawUrl.IndexOf("/know-about-horary-astrology/what-is-horary-astrology/5-15.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/a-horary-glimpse.html");
            }
            if (Request.RawUrl.IndexOf("/know-about-horary-astrology/what-is-important-about-horary-query/5-17.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/a-horary-glimpse.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/manglik-dosha-compatibility.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/manglik-dosha.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/father.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/parents.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/mother.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/parents.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/negatives-in-life.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/negatives-setback-sufferings.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/set-back-losses.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/negatives-setback-sufferings.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/sufferings.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/negatives-setback-sufferings.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/kaal-Sarpa-dosha.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/kaal-sarpa-dosha.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/your-attributes-1.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/personality-traits.html");
            }
            if (Request.RawUrl.IndexOf("/photogallery/photoGallery.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/photo-gallery.html");
            }
            if (Request.RawUrl.IndexOf("/article/article.aspx?catid=10&articleid=34") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astro-reports.html");
            }
            if (Request.RawUrl.IndexOf("/natal-astrology/money-wealth--luxuries.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/natal-astrology/money-wealth-luxuries.html");
            }
            if (Request.RawUrl.IndexOf("/astrology/horary-highlight/horary-yogas.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/horary-features.html");
            }
            if (Request.RawUrl.IndexOf("/astrology/horary-highlight/horary-knowledge.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/horary-features.html");
            }
            if (Request.RawUrl.IndexOf("/astrology/natal-highlight/natal-predictive.html") > -1)
            {
                HttpContext.Current.Response.Redirect("~/astrology/highlights/natal-features.html");
            }
            //if (strCurrentPath.IndexOf("/indexpage.aspx") > -1)
            //{
            //    HttpContext.Current.Response.Redirect("~/index.html");
            //}
            //if (strCurrentPath.IndexOf("/natal-astrology.html") > -1)
            //{
            //    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
            //    if (Stoid.IndexOf(".") > -1)
            //    {

            //        if (Stoid.IndexOf(".") > -1)
            //        {
            //           Context.RewritePath("~/section/NatalCategory.aspx", false);
            //        }
            //    }
            //}
            //if(HttpContext.Current.Request.RawUrl.ToString().IndexOf("/astrology/blog.html") > -1)
            //{
            //    strCurrentPath = HttpContext.Current.Request.RawUrl.ToString();
            //    Stoid = strCurrentPath.Substring(strCurrentPath.LastIndexOf("/") + 1);
            //    if (Stoid.IndexOf(".") > -1)
            //    {
            //    }
            //}
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs
        // Code that runs when an unhandled error occurs
        //Exception ex = Server.GetLastError();
        //if (ex is HttpException)
        //{
        //    if (((HttpException)(ex)).GetHttpCode() == 404)
        //    {
        //        Server.Transfer("~/error.aspx");
        //        return;
        //    }
        //     if (((HttpException)(ex)).GetHttpCode() == 500)
        //    {
        //        Context.RewritePath("~/ErrorPages/500.aspx", false);
        //        return;
        //    }
        //}
        //else
        //{
        //    Server.Transfer("~/default.aspx");
        //    return;
        //}
    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started
    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
    }

    private void CheckInput(string parameter)
    {
        for (int i = 0; i < SQLKeywords.Length; i++)
        {
            if ((parameter.IndexOf(SQLKeywords[i], StringComparison.OrdinalIgnoreCase) >= 0))
            {
                //
                //Handle the discovery of suspicious Sql characters here
                //
                HttpContext.Current.Response.Redirect("~/ErrorPages/ErrorPage.aspx");  //generic error page on your site
            }
        }
    }

    public string replaceQoute(string input)
    {
        string strInput = input;
        string pattern = "'+";
        if (Regex.IsMatch(strInput, pattern))
        {
            foreach (Match m in Regex.Matches(strInput, pattern))
            {
                strInput = strInput.Replace(m.Value, "'");
            }
        }
        return strInput;
    }
    public string optimizeURL(string input)
    {
        string strInput = input.ToLower();
        strInput = Regex.Replace(strInput, @"[^\w\@-]", "-");
        string pattern = "-+";
        if (Regex.IsMatch(strInput, pattern))
        {
            foreach (Match m in Regex.Matches(strInput, pattern))
            {
                strInput = strInput.Replace(m.Value, "-");
            }
        }
        strInput = Regex.Replace(strInput, "-$", "");
        strInput = strInput.Replace("'", "");
        strInput = strInput.Replace("update", "updat");
        return strInput;
    }

</script>
