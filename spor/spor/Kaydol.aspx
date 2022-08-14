<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kaydol.aspx.cs" Inherits="spor.Kaydol" %>


    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
            <asp:Label for="TxtAd" runat="server" Text="Ad" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtAd" runat="server"></asp:TextBox>
                </div>
            <br />
            <div>
            <asp:Label for="TxtSoyad" runat="server" Text="Soyad" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtSoyad" runat="server"></asp:TextBox>
        </div>
            <br />
            <div>
            <asp:Label for="TxtMail" runat="server" Text="Mail" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtMail" runat="server"></asp:TextBox>
          </div>
            <br />
             <div>
            <asp:Label for="TxtSifre" runat="server" Text="Şifre" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtSifre" runat="server"></asp:TextBox>
          </div>
            <br />
             <div>
            <asp:Label for="TxtBoy" runat="server" Text="Boy" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtBoy" runat="server"></asp:TextBox>
          </div>
            <br />
              <div>
            <asp:Label for="TxtKilo" runat="server" Text="Kilo" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtKilo" runat="server"></asp:TextBox>
          </div>
            <br />
              <div>
            <asp:Label for="TxtCinsiyet" runat="server" Text="Cinsiyet" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtCinsiyet" runat="server"></asp:TextBox>
          </div>
            <br />
            <div>
            <asp:Label for="TxtYas" runat="server" Text="Yaş" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtYas" runat="server"></asp:TextBox>
          </div>
            <br />
                <div>
            <asp:Label for="TxtKan" runat="server" Text="Kan Grubu" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtKan" runat="server"></asp:TextBox>
            </div>
            <br />
                 <div>
            <asp:Label for="TxtYag" runat="server" Text="Yağ Oranı" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtYag" runat="server"></asp:TextBox>
            </div>
        </div>
        <asp:Button runat="server" Text="Kaydol" OnClick="Unnamed11_Click" />
       
    </form>

