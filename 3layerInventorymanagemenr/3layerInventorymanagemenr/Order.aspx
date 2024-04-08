<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="_3layerInventorymanagemenr.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <h2>Welcome to Order Page!!</h2>

    <br />

    <h2><span class="badge badge-info btn-lg btn-block">Enter a New Order details</span></h2>
    <br />
    <div class="form-group row">
        <label for="order_no" class="col-sm-2 col-form-label">order_no</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtOrderNo" runat="server" placeholder="order_no"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="PurchaseAmt" class="col-sm-2 col-form-label">Purchase Amount</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtPurchAmt" runat="server" placeholder="PurchaseAmt"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="OrderDate" class="col-sm-2 col-form-label">Order Date</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtOrderDate" runat="server" placeholder="OrderDate"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="customerid" class="col-sm-2 col-form-label">Customer ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCustomerID" runat="server" placeholder="customerid"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="id" class="col-sm-2 col-form-label">Salesman ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtSalemanID" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnInsert" runat="server" Text="Insert"></asp:Button>
        &nbsp; 
            <asp:Button CssClass="btn btn-primary" ID="UpdateBtn" runat="server" Text="Update" ></asp:Button>
            &nbsp; 
            <asp:Button CssClass="btn btn-primary" ID="DeleteBtn" runat="server" Text="Delete" ></asp:Button>


            &nbsp;<asp:Label ID="lblSalesmanResult" runat="server" Text="Label"></asp:Label>
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>

    <br />
    <asp:GridView ID="gvcustomer" runat="server"></asp:GridView>
</asp:Content>
