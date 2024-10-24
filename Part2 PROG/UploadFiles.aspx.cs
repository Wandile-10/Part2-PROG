using System;
using System.IO;
using System.Web.UI;

namespace Part2_PROG
{
    public partial class UploadFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            // Check if file is selected
            if (fileUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(fileUpload.FileName).ToLower();
                string[] allowedExtensions = { ".pdf", ".docx", ".xlsx" };

                // Check if the file type is allowed
                if (Array.Exists(allowedExtensions, ext => ext == fileExtension))
                {
                    try
                    {
                        // Get the claim ID
                        string claimId = txtClaimID.Text;

                        // Set the path to save the file (modify the folder path as needed)
                        string folderPath = Server.MapPath("~/UploadedFiles/");
                        string filePath = folderPath + claimId + "_" + fileUpload.FileName;

                        // Ensure the directory exists
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Save the file to the server
                        fileUpload.SaveAs(filePath);

                        // Display success message
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "File uploaded successfully!";
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that may have occurred during file saving
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Error: " + ex.Message;
                    }
                }
                else
                {
                    // Invalid file type
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Only .pdf, .docx, and .xlsx files are allowed.";
                }
            }
            else
            {
                // No file selected
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please select a file to upload.";
            }
        }
    }
}
