<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BILL.aspx.vb" Inherits="TEST_NEW.BILL" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
   <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>B & R ELECTRICAL WORKS (POPULATION)</title>
    <link href="content/bootstrap.min.css" rel="stylesheet">
     <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <script src="Scripts/jquery-2.1.4.js"></script>
    <script src="Scripts/bootstrap.js"></script>
     <style type="text/css">
    body
    {
        font-family: Arial;
        font-size: 10pt;
    }
    .modalBackground
    {
        background-color: Black;
        filter: alpha(opacity=40);
        opacity: 0.4;
    }
    .modalPopup
    {
        background-color: #FFFFFF;
        border: 3px solid #0DA9D0;
        width :50%;
        float :left 
    }
    .modalPopup .header
    {
        background-color: #2FBDF1;
        height: 30px;
        color: White;
        line-height: 30px;
        text-align: center;
        font-weight: bold;
    }
    .modalPopup .body
    {
        min-height: 50px;
        line-height: 30px;
        text-align: center;
        padding:5px
    }
    .modalPopup .footer
    {
        padding: 3px;
    }
    .modalPopup .button
    {
        height: 23px;
        color: White;
        line-height: 23px;
        text-align: center;
        font-weight: bold;
        cursor: pointer;
        background-color: #9F9F9F;
        border: 1px solid #5C5C5C;
    }
    .modalPopup td
    {
        text-align:left;
    }   
</style>
</head>
<body>
    <form id="form1" runat="server">
         <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>

            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="main.aspx">Home <span class="sr-only">(current)</span></a></li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Services <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="POP.aspx">POPULATION</a></li>
                            <li><a href="pmr.aspx">PM / COMPLAINT</a></li>
                            <li><a href="Rmtracker.aspx">R & M TRACKER</a></li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a  class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Our Services <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">OUR OFFICE</a></li>
                            <li><a href="#">OUR WORKSHOP</a></li>
                            <li><a href="#">ACB & VCB's</a></li>
                        </ul>
                    </li> 
                </ul>
                <div class=" navbar-form navbar-right" role="status">
                        <asp:Label ID="uname1" runat="server" CssClass="label label-success" />
                        <asp:LoginStatus ID="LoginStatus1" runat="server" />
                    </div>
            </div>
        </div>
    </nav>
    <div style="width: 98%; margin-right: 1%; margin-left: 1%; text-align: center; height :220px; overflow :auto; padding :0px; margin :0px ">
        <asp:Panel ID="pnlAddEdit" runat="server"  CssClass ="modalPopup ">
            <div class="header">
               Accounting Details
            </div>
            <table>
                <tr>
                    <td>
                         <asp:Label ID="lblbdate" runat ="server" Text ="Bill Date" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtbdate" runat ="server" placeholder="Bill Date" />
                        <asp:RadioButton ID="cash" runat ="server" Text ="CASH" />
                         <asp:RadioButton ID="credit" runat ="server" Text ="CREDIT" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lblbno" runat ="server" Text ="Bill No" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtbno" runat ="server" placeholder="Bill No" Width ="100%" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lblcname" runat ="server" Text ="Customer Name" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtcname" runat ="server" placeholder="Customer Name" Width ="100%" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lbladdr" runat ="server" Text ="Address" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtaddr" runat ="server" placeholder="Address" Width ="100%" />
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="lblsname" runat ="server" Text ="Site Name" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtsname" runat ="server" placeholder="Site Name" Width ="100%" />
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="lblbal" runat ="server" Text ="Current Balance" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtbal" runat ="server" placeholder="Current Balance" Width ="100%" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lblvno" runat ="server" Text ="VAT / TIN No" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtvno" runat ="server" placeholder="VAT / TIN No" Width ="100%" />
                    </td>
                </tr>
            </table>
        </asp:Panel>

         <asp:Panel ID="Panel1" runat="server"  CssClass ="modalPopup ">
         <div class="header">
               Inventory Details
            </div>
            <table>
                 <tr>
                    <td>
                         <asp:Label ID="lblptname" runat ="server" Text ="Product Name" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtptname" runat ="server" placeholder="Product Name" Width ="100%" />
                    </td>
                      <td>
                         <asp:Label ID="lblqty" runat ="server" Text ="QTY" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtqty" runat ="server" placeholder="Item Quantity" Width ="100%" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lblptno" runat ="server" Text ="Part No" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtptno" runat ="server" placeholder="Part No" />
                    </td>
                      <td>
                         <asp:Label ID="lbltval" runat ="server" Text ="Tax Value" />
                    </td>
                   <td>
                         <asp:TextBox ID="txttval" runat ="server" placeholder="Tax Value" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lblmrp" runat ="server" Text ="MRP" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtmrp" runat ="server" placeholder="MRP" />
                    </td>
                      <td>
                         <asp:Label ID="lblitot" runat ="server" Text ="Item Total" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtitot" runat ="server" placeholder="Item Total" />
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="lblrate" runat ="server" Text ="Rate" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtrate" runat ="server" placeholder="Rate" />
                    </td>
                      <td>
                         <asp:Label ID="lblgtot" runat ="server" Text ="Grand Total" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtgtot" runat ="server" placeholder="Grand Total" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lblinstock" runat ="server" Text ="In Stock" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtinstock" runat ="server" placeholder="In Stock" />
                    </td>
                      <td>
                         <asp:Label ID="lvlntval" runat ="server" Text ="Net Tax Value" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtntval" runat ="server" placeholder="Net Tax Value" />
                    </td>
                </tr>
                 <tr>
                    <td>
                         <asp:Label ID="lbltrate" runat ="server" Text ="Tax Rate" />
                    </td>
                   <td>
                         <asp:TextBox ID="txttrate" runat ="server" placeholder="Tax Rate" />
                    </td>
                      <td>
                         <asp:Label ID="lblround" runat ="server" Text ="Round Off" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtround" runat ="server" placeholder="Round Off" />
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="lbtunit" runat ="server" Text ="Unit" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtunit" runat ="server" placeholder="Unit" />
                    </td>
                      <td>
                         <asp:Label ID="lblntot" runat ="server" Text ="Net Total" />
                    </td>
                   <td>
                         <asp:TextBox ID="txtntot" runat ="server" placeholder="Net Total" />
                    </td>
                </tr>
            </table>
     </asp:Panel>
    </div>
        <div style="width: 98%; margin-right: 1%; margin-left: 1%; text-align: center; padding :0px; margin :0px ">
            <asp:Button ID="NEW_BILL" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="New Bill" />
            <asp:Button ID="edit_bill" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Edit Bill" />
            <asp:Button ID="Del_bill" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Delete Bill" />
            <asp:Button ID="Find_bill" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Find Bill" />
            <asp:Button ID="add_item" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Add Item" />
            <asp:Button ID="Edit_item" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Edit Item" />
            <asp:Button ID="Del_item" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Delete Item" />
            <asp:Button ID="challan" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Challan" />
            <asp:Button ID="Print_bill" runat ="server" CssClass ="btn btn-danger  btn-xs " Text ="Print Bill" />
        </div>
        <div style="width: 98%; margin-right: 1%; margin-left: 2%; text-align: center; height :305px; overflow :auto; padding :0px; margin :0px ">
             <asp:Panel ID="pnldg" runat="server"  CssClass ="modalPopup " Width ="100%">
                  <div class="header">
               Invoice Details
            </div>
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="PART_NO" HeaderText="PART_NO" SortExpression="PART_NO" ItemStyle-Width ="200px" />
                    <asp:BoundField DataField="PARTI" HeaderText="PARTI" SortExpression="PARTI" ItemStyle-Width ="500px" />
                    <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" ItemStyle-Width ="100px" />
                    <asp:BoundField DataField="MRP" HeaderText="MRP" SortExpression="MRP" ItemStyle-Width ="100px" />
                    <asp:BoundField DataField="SPRICE" HeaderText="SPRICE" SortExpression="SPRICE" ItemStyle-Width ="100px" />
                    <asp:BoundField DataField="TOTAL" HeaderText="TOTAL" SortExpression="TOTAL" ItemStyle-Width ="100px" />
                    <asp:BoundField DataField="STOT" HeaderText="STOT" SortExpression="STOT" ItemStyle-Width ="100px" />
                    <asp:BoundField DataField="UNIT" HeaderText="UNIT" SortExpression="UNIT" ItemStyle-Width ="100px" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle ForeColor="#8C4510" BackColor="#FFF7E7" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [PART_NO], [PARTI], [QTY], [MRP], [SPRICE], [TOTAL], [STOT], [UNIT] FROM [BILL]"></asp:SqlDataSource>
             </asp:Panel>
        </div>
    </form>
</body>
</html>
