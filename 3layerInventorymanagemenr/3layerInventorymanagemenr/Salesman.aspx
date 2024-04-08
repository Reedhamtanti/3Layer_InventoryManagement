﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="_3layerInventorymanagemenr.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
   <h2>Welcome to Salesman Page!!</h2>

    <br />

    <h2><span class="badge badge-info btn-lg btn-block">Enter a New Salesman</span></h2>
    <br />
    <div class="form-group row">
        <label for="id" class="col-sm-2 col-form-label">Salesman Number</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtID" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="salesmanName" class="col-sm-2 col-form-label">Salesman Name</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtSalesmanName" runat="server" placeholder="salesmanName"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="city" class="col-sm-2 col-form-label">City</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCity" runat="server" placeholder="city"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="commission" class="col-sm-2 col-form-label">Commission</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCommission" runat="server" placeholder="Commission"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-10">
            
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Insert" OnClick="btnSubmit_Click"></asp:Button>
        &nbsp; 
            <asp:Button CssClass="btn btn-primary" ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" ></asp:Button>
            &nbsp; 
            <asp:Button CssClass="btn btn-primary" ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteBtn_Click" ></asp:Button>


            &nbsp;<asp:Label ID="lblSalesmanResult" runat="server" Text="Label"></asp:Label>
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Salesman</span></h1>

    <br />
    <asp:GridView ID="gvSalesman" runat="server"></asp:GridView>
</asp:Content>
