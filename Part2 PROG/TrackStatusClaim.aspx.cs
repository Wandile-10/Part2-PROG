using System;

namespace Part2_PROG
{
    public partial class TrackStatusClaim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadClaimStatus();
            }
        }

        private void LoadClaimStatus()
        {
            // In a real application, retrieve claim status from a database
            // For this example, we'll use mock data
            string claimId = Request.QueryString["ClaimID"] ?? "1";  // For example purposes, using QueryString
            DateTime submissionDate = DateTime.Parse("2024-10-01");
            string status = "Pending";  // Status could be 'Pending', 'Approved', or 'Rejected'
            string notes = "Awaiting manager approval";

            // Set the retrieved details to the label controls
            lblClaimID.Text = claimId;
            lblSubmissionDate.Text = submissionDate.ToString("yyyy-MM-dd");
            lblStatus.Text = status;
            lblNotes.Text = notes;
        }
    }
}
