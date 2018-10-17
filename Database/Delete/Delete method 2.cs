using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("DELETE dbo.[StudentData] WHERE studentID='" + txtStudentID.Text + "'", sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data deleted successfully");
                sqlCon.Close();
            }
