<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="_3layerInventorymanagemenr.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <h2>Welcome to Customer Page!!</h2>

    <br />

    <h2><span class="badge badge-info btn-lg btn-block">Enter a New Customer</span></h2>
    <br />
    <div class="form-group row">
        <label for="customerid" class="col-sm-2 col-form-label">Customer ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCustomerID" runat="server" placeholder="customerid"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="customerName" class="col-sm-2 col-form-label">Customer Name</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCustomerName" runat="server" placeholder="customerName"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="city" class="col-sm-2 col-form-label">City</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCity" runat="server" placeholder="city"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="Grade" class="col-sm-2 col-form-label">Grade</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtGrade" runat="server" placeholder="Grade"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="customerNo" class="col-sm-2 col-form-label">Salesman ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtSalemanID" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"></asp:Button>
        &nbsp; 
            <asp:Button CssClass="btn btn-primary" ID="UpdateCutomerBtn" runat="server" Text="Update" OnClick="UpdateCutomerBtn_Click1" ></asp:Button>
            &nbsp; 
            <asp:Button CssClass="btn btn-primary" ID="DeleteCutomerBtn" runat="server" Text="Delete" OnClick="DeleteCutomerBtn_Click" ></asp:Button>


            &nbsp;<asp:Label ID="lblCustomerResult" runat="server" Text="Label"></asp:Label>
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Customer</span></h1>

    <br />
    <asp:GridView ID="gvcustomer" runat="server"></asp:GridView>
</asp:Content>
