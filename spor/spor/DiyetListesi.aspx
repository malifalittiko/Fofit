<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DiyetListesi.aspx.cs" Inherits="spor.DiyetListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    

<table class="table table-bordered table-hover">
    <tbody>
        <tr>
           
            <th> Vakitler </th>
            <th> Pazartesi </th>
            <th> Salı </th>
            <th> Çarşamba </th>
            <th> Perşembe </th>
            <th> Cuma </th>
            <th> Cumartesi </th>
            <th>  Pazar </th>
            <th> İşlemler </th>  
        </tr>
    
   
        <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
              <tr>
               
                <td><%#Eval("Vakit") %></td>
                <td><%#Eval("Ptesi") %></td>
                <td><%#Eval("Sali") %></td>
                <td><%#Eval("Cars") %></td>
                <td><%#Eval("Pers") %></td>
                <td><%#Eval("Cuma") %></td>
                <td><%#Eval("Ctesi") %></td>
                <td><%#Eval("Pazar") %></td>

        <td>
            <asp:HyperLink NavigateUrl='<%#"~/DiyetListesiGüncelle.aspx?DIYET_ID="+ Eval("Did")%>' ID="HyperLink1" runat="server">Güncelle</asp:HyperLink>

        </td>

                </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
      </table>
       
</asp:Content>






