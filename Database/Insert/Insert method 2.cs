using (SqlConnection sqlCon = new SqlConnection(connectionString))
 {
  sqlCon.Open();
  SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[StudentData] VALUES('" + txtStudentID.Text + "', '" + txtSurname.Text + "', '" + txtFirstName.Text + "', '" + txtAddress.Text + "', '" + comboProgram.Text + "', '" + txtFaculty.Text + "', '" + txtDepartment.Text + "', '" + txtCountry.Text + "', '" + comboGender.Text +"' )", sqlCon);
  cmd.ExecuteNonQuery();
  MessageBox.Show("data inserted successfully");
  sqlCon.Close();
 }   
