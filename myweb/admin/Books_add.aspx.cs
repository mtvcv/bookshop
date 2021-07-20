using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF.Model;
using YF.DAL;
using YF.BLL;
using System.IO;

public partial class admin_Books_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        YF.Model.Books books = new YF.Model.Books(); // 新建一个实体类
        books.Isbn = this.isbn.Text.Trim(); // trim方法去掉前导和末尾的空格
        books.Price = float.Parse(this.price.Text.Trim());
        books.Num = int.Parse(this.num.Text.Trim());
        books.Detail = this.detail.Text.Trim();
        books.State = int.Parse(this.state.Text);
        books.Adddate = DateTime.Now;
        books.Bookname = this.bookname.Text.Trim();
        // 图片上传之后，存到服务器目录img下面
        if (img.HasFile) // 首先保证用户已经取得图片
        { // 文件名字已当前时间命名，可以保证不重复
            string filename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + Path.GetFileName(img.FileName);
            //string filePath = filename; // 文件名加 路径名 变成一个完整的名字
            //img.SaveAs(MapPath(filePath)); // 上传
            string strpath = Server.MapPath("") + "//img//" + filename; // 取得将要保存图片的路径，其中//img//表示图片传入img文件夹
            img.PostedFile.SaveAs(strpath); // 把图片保存在此路径中
            books.Img = filename;
        }
        if (YF.BLL.Books.add(books))
        {
            YF.JsHelper.AlertAndRedirect("发布成功", "Books.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("发布失败", "Books_add.aspx");
        }

    }
}