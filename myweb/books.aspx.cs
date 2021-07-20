using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

public partial class books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取id
        string id = Request["id"];
        YF.Model.Books books = YF.BLL.Books.GetBooks(int.Parse(id));
        this.isbn.Text = books.Isbn;
        this.price.Text = books.Price.ToString();
        this.num.Text = books.Num.ToString();
        this.detail.Text = books.Detail.ToString();
        this.img.ImageUrl = "admin/img/" +books.Img.ToString();
        this.img.Width = 180;
        this.bookname.Text = books.Bookname.ToString();
    }
}