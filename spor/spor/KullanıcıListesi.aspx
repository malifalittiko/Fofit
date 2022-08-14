<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KullanıcıListesi.aspx.cs" Inherits="spor.KullanıcıListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th style="height: 37px">Sporcu ID </th>
            <th style="height: 37px">Sporcu Ad </th>
            <th style="height: 37px">Sporcu Soyad </th>
            <th style="height: 37px">Sporcu Mail </th>       
            <th style="height: 37px">Sporcu Boy </th>
            <th style="height: 37px">Sporcu Kilo </th>
            <th style="height: 37px">Sporcu Yaş </th>
            <th style="height: 37px">Sporcu Cinsiyet </th>
            <th style="height: 37px">Sporcu Kan Grubu </th>
            <th style="height: 37px">Sporcu Yağ Oranı</th>
            <th style="height: 37px">İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("KID") %></td>
                <td><%#Eval("Ad") %></td>
                <td><%#Eval("Soyad") %></td>
                <td><%#Eval("Mail") %></td>             
                <td><%#Eval("Boy") %></td>
                <td><%#Eval("Kilo") %></td>
                <td><%#Eval("Yas") %></td>
                <td><%#Eval("Cinsiyet") %></td>
                <td><%#Eval("Kan") %></td>
                <td><%#Eval("Yag") %></td>
            
     
      
   
                <td>
                    <asp:HyperLink Visible='<%#Eval("Statu")%>' NavigateUrl='<%#"~/KullanıcıSil.aspx?KULLANICI_ID="+ Eval("KID")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    <asp:HyperLink Visible='<%#Eval("Statu")%>' NavigateUrl='<%#"~/KullanıcıGüncelle.aspx?KULLANICI_ID="+ Eval("KID")%>' ID="HyperLink2" CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink>
                </td>
   
       
  
                
            </tr>
                    </ItemTemplate>
             </asp:Repeater>
        </tbody>
    </table>
</asp:Content>


