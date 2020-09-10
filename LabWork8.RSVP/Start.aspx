<%@ Page MasterPageFile="~/Site.master" Language="C#" AutoEventWireup="true" CodeFile="Start.aspx.cs" Inherits="Start" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="rek">
            <h1>Приглашение на семинар</h1>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            <p>Вы приглашены на наш семинар</p>
            <p>Подтвердите свое согласие, пройдя регистрацию</p>
        </div>
        <div class="info">
            Семинар состоится 1 января 2021 года в 09:00
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000"></asp:Timer>
                    <% DateTime dataseminar = new DateTime(2021,1,1,9,0,0);
                        DateTime dnow = DateTime.Now;
                        int rd = (dataseminar - dnow).Days;
                        int rh = (dataseminar - dnow).Hours;
                        int rm = (dataseminar - dnow).Minutes;
                        int rsec = (dataseminar - dnow).Seconds; %>
                    <h3>До семинара осталось <%=rd.ToString()%> дн., <%=rh.ToString()%> ч. <%=rm.ToString()%> мин. и <%=rsec.ToString()%> с.</h3>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>  
</asp:Content>
