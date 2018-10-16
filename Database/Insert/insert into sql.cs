con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[StudentData] VALUES('" + txtStudentID.Text + "', '" + txtSurname.Text + "', '" + txtFirstName.Text + "', '" + txtAddress.Text + "', '" + comboProgram.Text +"', '" + txtFaculty.Text + "', '" + txtDepartment.Text +"', '" + txtCountry.Text +"', '" + comboGender.Text +"', '" + pictureStudent.Image + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted successfully");
            con.Close();
