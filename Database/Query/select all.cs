using (SqlConnection sqlCon = new SqlConnection(connectionString))
      {
        sqlCon.Open();
        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StudentData", sqlCon);
        DataTable dtbl = new DataTable();
        sqlDa.Fill(dtbl);

        dataGridViewStudent.DataSource = dtbl;
      }
