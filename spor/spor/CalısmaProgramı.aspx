<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ÇalışmaProgramıaspx.aspx.cs" Inherits="spor.CalısmaProgramıaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

  <table class="table table-bordered table-hover">
    <tbody>
        <tr>
           
            <th> Sporcu No </th>
            <th> Göğüs Bölgesi </th>
            <th> Sırt Bölgesi </th>
            <th> Kol Bölgesi </th>
            <th> Bacak Bölgesi </th>
            <th> Karın Bölgesi </th>
            <th> Omuz Bölgesi </th>
            <th> Tam Vücut </th>
            <th> İşlemler </th>  
        </tr>
    
        <asp:Repeater ID="Repeater1" runat="server">
        
        <ItemTemplate>
              <tr>
               
                <td><%#Eval("Sid") %></td>
                <td><%#Eval("Gogus") %></td>
                <td><%#Eval("Sirt") %></td>
                <td><%#Eval("Kol") %></td>
                <td><%#Eval("Bacak") %></td>
                <td><%#Eval("Karin") %></td>
                <td><%#Eval("Omuz") %></td>
                <td><%#Eval("Full") %></td>

        <td>
            <asp:HyperLink NavigateUrl='<%#"~/CalismaProgramiGuncelle.aspx?CALISMA_ID="+ Eval("CID")%>' ID="HyperLink1" runat="server">Program Ata</asp:HyperLink>
        </td>
                  
                </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
      </table>
       
</asp:Content>