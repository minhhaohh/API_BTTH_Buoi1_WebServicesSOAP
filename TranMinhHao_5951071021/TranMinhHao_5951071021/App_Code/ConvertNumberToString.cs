using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ConvertNumberToString
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ConvertNumberToString : System.Web.Services.WebService
{

    public ConvertNumberToString()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public string NumberToString(int number)
    {
        string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười",
                        "Mười Một", "Mười Hai", "Mười Ba", "Mười Bốn", "Mười Năm", "Mười Sáu", "Mười Bảy", "Mười Tám", "Mười Chín"};
        string[] Tens = { "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };

        string strWords = "";

        if (number > 999 && number < 10000)
        {
            int i = number / 1000;
            strWords = strWords + Ones[i - 1] + " Ngàn ";
            number = number % 1000;
        }

        if (number > 99 && number < 1000)
        {
            int i = number / 100;
            strWords = strWords + Ones[i - 1] + " Trăm ";
            number = number % 100;
        }

        if (number > 19 && number < 100)
        {
            int i = number / 10;
            strWords = strWords + Tens[i - 1] + " ";
            number = number % 10;
        }

        if (number > 0 && number < 20)
        {
            strWords = strWords + Ones[number - 1];
        }

        strWords = Convert.ToString(strWords);
        return strWords;
    }

}
