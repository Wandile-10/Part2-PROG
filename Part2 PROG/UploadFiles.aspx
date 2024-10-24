<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFiles.aspx.cs" Inherits="Part2_PROG.UploadFiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Supporting Documents</title>
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
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <ul>
                <li><a href="AddClaims.aspx">Add Claims</a></li>
                <li><a href="UploadFiles.aspx">Upload Files</a></li>
                <li><a href="ClaimDetails.aspx">Claim Details</a></li>
                 <li><a href="TrackStatusclaim.aspx">Track Status</a></li>
                  <li><a href="PendingClaims.aspx">Pending Claims</a></li>
            </ul>
            <h2>Upload Supporting Document for Monthly Claim</h2>

            <label for="claimID">Claim ID:</label>
            <asp:TextBox ID="txtClaimID" runat="server" required="true"></asp:TextBox><br />

            <label for="fileUpload">Upload Supporting Document (PDF, DOCX, XLSX):</label>
            <asp:FileUpload ID="fileUpload" runat="server" /><br />

            <asp:Button ID="btnUpload" runat="server" Text="Upload File" OnClick="btnUpload_Click" />
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>

