// add method of employees
        private void AddEmployee()
        {
            DataClassesAWEDataContext emp = new DataClassesAWEDataContext();
            Employee em = new Employee()
            {
                EmpIdentity = txtEmpID.Text,
                EmpName = txtEmpName.Text,
                EmpDesig = txtEmpDesig.Text,
                EmpHire = txtEmpHire.Text,
                EmpNIC = txtEmpNIC.Text,
                EmpAddress = txtEmpAddress.Text,
                EmpEmail = txtEmpEmail.Text,
                EmpGender = txtEmpGender.Text,
                EmpFthName = txtEmpFth.Text,
                EmpAge = txtEmpAge.Text,
                EmpQual = txtEmpQual.Text
            };
            emp.Employees.InsertOnSubmit(em);
            emp.SubmitChanges();
        }

        // Add Employees records in database 
        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {
            AddEmployee();
            RefreshGridEmp();
            txtEmpID.Text = txtEmpName.Text = txtEmpNIC.Text = txtEmpQual.Text = txtEmpHire.Text = txtEmpDesig.Text = txtEmpAddress.Text =
              txtEmpEmail.Text =   txtEmpAge.Text = txtEmpGender.Text = txtEmpFth.Text = "";
        }