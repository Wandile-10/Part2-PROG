using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Part2_PROG
{
    public partial class AcademicManager : System.Web.UI.Page
    {
        private DataTable claimsTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Claims"] == null)
                {
                    // Initialize the DataTable for storing claims
                    claimsTable = new DataTable();
                    claimsTable.Columns.Add("ClaimNo");
                    claimsTable.Columns.Add("LecturerName");
                    claimsTable.Columns.Add("ProgramCode");
                    claimsTable.Columns.Add("ModuleCode");
                    claimsTable.Columns.Add("Rate");
                    claimsTable.Columns.Add("Hours");
                    claimsTable.Columns.Add("ClaimAmount");
                    claimsTable.Columns.Add("AttachedDocuments");
                    claimsTable.Columns.Add("Status");

                    // Add some sample claims
                    AddSampleClaims();

                    // Store in ViewState to persist the data across postbacks
                    ViewState["Claims"] = claimsTable;
                }
                else
                {
                    // Retrieve the table from ViewState
                    claimsTable = (DataTable)ViewState["Claims"];
                }

                // Bind data to the GridView
                BindClaimsGrid();
            }
        }
        
        private void AddSampleClaims()
        {
            claimsTable.Rows.Add("C001", "Asanda", "PROG6212", "Programming 2A", 100, 10, 1000, "doc1.pdf", "Pending");
            claimsTable.Rows.Add("C002", "Landile", "HCIN6212", "Human Computer Interaction", 150, 5, 750, "doc2.pdf", "Pending");
            claimsTable.Rows.Add("C003", "Senzo", "DATA622", "Database (Intermediate)", 120, 8, 960, "doc3.pdf", "Pending");
            claimsTable.Rows.Add("C004", "Nolwazi", "IPMA6212", "IT Project Management", 110, 12, 1320, "doc4.pdf", "Pending");
        }

        private void BindClaimsGrid()
        {
            gvClaims.DataSource = claimsTable;
            gvClaims.DataBind();
        }

        protected void gvClaims_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Retrieve the DataTable from ViewState
            claimsTable = ViewState["Claims"] as DataTable;
            if (claimsTable == null) return;

            if (e.CommandName == "Approve" || e.CommandName == "Reject")
            {
                // Find the row index from CommandArgument
                string claimNo = e.CommandArgument.ToString();
                DataRow[] rows = claimsTable.Select($"ClaimNo = '{claimNo}'");

                // Ensure the row exists before proceeding
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];

                    // Update the status based on the command name
                    row["Status"] = e.CommandName == "Approve" ? "Approved" : "Rejected";

                    // Update ViewState with the modified DataTable
                    ViewState["Claims"] = claimsTable;

                    // Rebind the GridView to reflect changes
                    BindClaimsGrid();
                }
            }
        }
    }
}