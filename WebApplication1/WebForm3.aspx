<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <title></title>
    <script>

        $(function () {
            

            var selectChks = $("input[name='GcglCcfw']:checkbox:checked");
           
            alert(selectChks.length);
            
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div style="float: left; padding: 0 5px;">
                                    <input type="checkbox" name="GcglCcfw"  value="0" style="margin-bottom: 5px;" /> 高支模
                                </div>
                                <div style="float: left; padding: 0 5px;">
                                    <input type="checkbox" name="GcglCcfw" checked="checked"  value="1" style="margin-bottom: 5px;" /> 脚手架
                                </div>
                                <div style="float: left; padding: 0 5px;">
                                    <input type="checkbox" name="GcglCcfw" value="2" style="margin-bottom: 5px;" /> 防护栏杆
                                </div>
                                <div style="float: left; padding: 0 5px;">
                                    <input type="checkbox" name="GcglCcfw" value="3" style="margin-bottom: 5px;" /> 其他范围的模板支架、脚手架、防护栏杆
                                </div>
    </div>
    </form>
</body>
</html>
