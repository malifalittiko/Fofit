<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="spor.Giris" %>

<!DOCTYPE html>
    <div class="container-fluid ps-md-0">
  <div class="row g-0">
    <div class="d-none d-md-flex col-md-4 col-lg-6 bg-image"></div>
    <div class="col-md-8 col-lg-6">
      <div class="login d-flex align-items-center py-5">
        <div class="container">
          <div class="row">
            <div class="col-md-9 col-lg-8 mx-auto">
              <h3 class="login-heading mb-4">FOFİT</h3>

             <form ID="Form1" runat="server">
                 <div class="d-grid"> 
                 <asp:TextBox ID="TextBox1" runat="server" Placeholder="Mail"></asp:TextBox>
            

                 <asp:TextBox ID="TextBox2" runat="server" Placeholder="Sifre"></asp:TextBox>
         
                    <asp:Button ID="Button2" runat="server" Text="Giriş" OnClick="Unnamed1_Click1" /> 
                    
                     <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Kaydol" />
                 </div>   
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>



