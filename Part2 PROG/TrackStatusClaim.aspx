<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrackStatusClaim.aspx.cs" Inherits="Part2_PROG.TrackStatusClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Track Claim Status</title>
</head>
    <style>
    body {
        background-color: grey; /* Set the background color to red */
        color: white; /* Optional: Set text color to white for better visibility */
        font-family: Arial, sans-serif; /* Optional: Set a font family */
        padding: 20px; /* Optional: Add some padding */
    }
    a {
        color: white; /* Link color */
        text-decoration: none; /* Remove underline from links */
    }
    a:hover {
        text-decoration: underline; /* Add underline on hover */
    }
</style>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a href="AddClaims.aspx">Add Claims</a></li>
                <li><a href="UploadFiles.aspx">Upload Files</a></li>
                <li><a href="ClaimDetails.aspx">Claim Details</a></li>
                  <li><a href="TrackStatusclaim.aspx">Track Status</a></li>
                 <li><a href="PendingClaims.aspx">Pending Claims</a></li>
            </ul>
            <h2>Track Claim Status</h2>

            <label for="lblClaimID">Claim ID:</label>
            <asp:Label ID="lblClaimID" runat="server" Text=""></asp:Label><br />

            <label for="lblSubmissionDate">Submission Date:</label>
            <asp:Label ID="lblSubmissionDate" runat="server" Text=""></asp:Label><br />

            <label for="lblStatus">Current Status:</label>
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label><br />

            <label for="lblNotes">Manager's Notes:</label>
            <asp:Label ID="lblNotes" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>

