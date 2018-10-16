con.Open();
SqlCommand cmd = new SqlCommand("DELETE dbo.[Table] WHERE studentID='" + txtStudentID.Text + "'", con);
cmd.ExecuteNonQuery();
MessageBox.Show("Data deleted successfully");
con.Close();
