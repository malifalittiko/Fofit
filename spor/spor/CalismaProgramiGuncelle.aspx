<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CalismaProgramiGuncelle.aspx.cs" Inherits="spor.CalismaProgramiGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form3" runat="server">
        <div class="form-group">
            <div>
            <asp:Label for="TxtCID" runat="server" Text="Çalışma No" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TextCID" runat="server"></asp:TextBox>
                </div>
            <div>
            <asp:Label for="TxtSid" runat="server" Text="Sporcu No" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtSid" runat="server"></asp:TextBox>
                </div>
            <div>
            <asp:Label for="TxtGogus" runat="server" Text="Göğüs Bölgesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtGogus" runat="server"></asp:TextBox>
                </div>
            <br />
            <div>
            <asp:Label for="TxtSirt" runat="server" Text="Sırt Bölgesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtSirt" runat="server"></asp:TextBox>
        </div>
            <br />
            <div>
            <asp:Label for="TxtKol" runat="server" Text="Kol Bölgesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtKol" runat="server"></asp:TextBox>
          </div>
            <br />
             <div>
            <asp:Label for="TxtBacak" runat="server" Text="Bacak Bölgesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtBacak" runat="server"></asp:TextBox>
          </div>
            <br />
             <div>
            <asp:Label for="TxtKarin" runat="server" Text="Karın Bölgesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtKarin" runat="server"></asp:TextBox>
          </div>
            <br />
              <div>
            <asp:Label for="TxtOmuz" runat="server" Text="Omuz Bölgesi" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOmuz" runat="server"></asp:TextBox>
          </div>
            <br />
              <div>
            <asp:Label for="TxtFull" runat="server" Text="Tüm Vücut" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtFull" runat="server"></asp:TextBox>
          </div>
            <br />
        </div>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    </form>
</asp:Content>
