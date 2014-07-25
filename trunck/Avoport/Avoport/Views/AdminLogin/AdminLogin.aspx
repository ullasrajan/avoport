<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Avoport.Models.AdminLoginModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    AdminLogin
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>AdminLogin</h2>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">

    <div>
        <% using(Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true,"Login wasunsuccessful, Please Try again.")  %>
        <div>
            <fieldset>
                <legend>Account Information</legend>
                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Username) %>
                </div>
                <div class="editor-field">
                    <%:Html.TextBoxFor(m=> m.Username)%>
                    <%:Html.ValidationMessageFor(m=>m.Username)%>
                </div>

                <div class="editoe-label">
                    <%:Html.LabelFor(m=>m.Password)%>
                </div>
                <div class="editor-field">
                    <%:Html.PasswordFor(m=>m.Password)%>
                    <%:Html.ValidationMessageFor(m=>m.Password)%>
                </div>

                <div class="editor-label">
                    <%:Html.CheckBoxFor(m=>m.RememberMe)%>
                    <%:Html.LabelFor(m=>m.RememberMe)%>
                </div>

                <p>
                    <input type="submit" value="Log In" />
                </p>
            </fieldset>
</div>
<%}%>
        </div>
</asp:Content>
