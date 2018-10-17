using (SqlConnection sqlCon = new SqlConnection(connectionString))
 {
   sqlCon.Open();
   SqlCommand cmd = new SqlCommand("UPDATE dbo.[StudentData] SET surname='" + txtSurname.Text + "',firstName='" + txtFirstName.Text + "',address='" + txtAddress.Text + "',program='" + comboProgram.Text + "',faculty='" + txtFaculty.Text + "',department='" + txtDepartment.Text + "',country='" + txtCountry.Text + "',gender='" + comboGender.Text + "' WHERE studentID='" + txtStudentID.Text + "'", sqlCon);
   cmd.ExecuteNonQuery();
   MessageBox.Show("data updated successfully");
   sqlCon.Close();
 }
