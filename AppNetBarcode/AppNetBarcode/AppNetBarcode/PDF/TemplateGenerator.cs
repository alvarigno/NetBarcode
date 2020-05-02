using System;
using System.Text;

namespace AppNetBarcode.PDF
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString(string image64)
        {

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                    </tr>");


                sb.AppendFormat(@"<tr>
                                    <td></td>
                                  </tr>", image64);


            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
