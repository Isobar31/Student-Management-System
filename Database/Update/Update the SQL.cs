con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.[Table] SET studentName='" + txtSurname.Text +"',Address='" + txtFirstName.Text + "',class='" + txtAddress.Text +"' WHERE studentID='" + txtStudentID.Text +"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            con.Close();
