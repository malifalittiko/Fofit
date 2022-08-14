<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DiyetListesiGüncelle.aspx.cs" Inherits="spor.DiyetListesiGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form2" runat="server">
        <div class="form-group">
            <div>
            <asp:Label for="TxtDiyetId" runat="server" Text="DiyetId" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtDiyetId" runat="server"></asp:TextBox>
                </div>
            <div>
            <asp:Label for="TxtVakit" runat="server" Text="Vakitler" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtVakit" runat="server"></asp:TextBox>
                </div>
            <br />
            <div>
            <asp:Label for="TxtPtesi" runat="server" Text="Pazartesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtPtesi" runat="server"></asp:TextBox>
        </div>
            <br />
            <div>
            <asp:Label for="TxtSali" runat="server" Text="Salı" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtSali" runat="server"></asp:TextBox>
          </div>
            <br />
             <div>
            <asp:Label for="TxtCars" runat="server" Text="Çarşamba" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtCars" runat="server"></asp:TextBox>
          </div>
            <br />
             <div>
            <asp:Label for="TxtPers" runat="server" Text="Perşembe" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtPers" runat="server"></asp:TextBox>
          </div>
            <br />
              <div>
            <asp:Label for="TxtCuma" runat="server" Text="Cuma" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtCuma" runat="server"></asp:TextBox>
          </div>
            <br />
              <div>
            <asp:Label for="TxtCtesi" runat="server" Text="Cumartesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtCtesi" runat="server"></asp:TextBox>
          </div>
            <br />
            <div>
            <asp:Label for="TxtPazar" runat="server" Text="Pazar" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtPazar" runat="server"></asp:TextBox>
          </div>
           
        </div>
    <asp:Button ID="Button1" runat="server" Text="Değişiklikleri Kaydet" OnClick="Unnamaed14_Click" />
    </form>
</asp:Content>
