using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

/**
 * Class Name : ctlAddress
 * Description: All the control functions of the address book
 * Author: G.W. Madushani Dilanka
 * Date: 02/04/2015 
 */
namespace ctlAddressLib
{
    public partial class ctlAddress : UserControl
    {
        private EnterDetails enterDetails;

        //Default constructor
        public ctlAddress()
        {
            InitializeComponent();
            //Create object of the EnterDetails class
            enterDetails = new EnterDetails();
        }

        //Load address book
        private void ctlAddress_Load(object sender, EventArgs e)
        {
            //Load all the countries to the combo box
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
            Select(p => new RegionInfo(p.Name).EnglishName).
            Distinct().OrderBy(s => s).ToList();            
            cboCountry.DataSource = list;
            

            //Select default country as New Zealand
            cboCountry.SelectedItem = "New Zealand";

            //Load already listed address to the data grid view
            ReadAndShowData();           
        }

        //Check whether the all of the fields are filled
        private bool validateEmptyFields()
        {
            if (TxtAdd.Text == "" || TxtCity.Text == "" || 
                TxtName.Text == "" || TxtPhone.Text == "" 
                || TxtSuburb.Text == "")
            {
                errorProvider1.SetError(TxtAdd, "Must Enter Address");
                errorProvider1.SetError(TxtCity, "Must Enter City");
                errorProvider1.SetError(TxtName, "Must Enter Name");
                errorProvider1.SetError(TxtPhone, "Must Enter Phone");
                errorProvider1.SetError(TxtSuburb, "Must Enter Suburb");
                return true;
            }
            else
            {
                errorProvider1.SetError(TxtAdd, "");
                errorProvider1.SetError(TxtName, "");
                errorProvider1.SetError(TxtPhone, "");
                errorProvider1.SetError(TxtCity, "");
                errorProvider1.SetError(TxtSuburb, "");
                return false;
            }
        }

        //Display message when press add button with empty fields and add details to the grid view
        private void createNewAddress()
        {
            if (validateEmptyFields() == true)
            {
                MessageBox.Show("Must Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int n;
                n = dgv_Records.Rows.Add();
                enterDetails.setName(TxtName.Text);
                dgv_Records.Rows[n].Cells["FullName"].Value = enterDetails.getName();
                enterDetails.setAddress(TxtAdd.Text);
                dgv_Records.Rows[n].Cells["Address"].Value = enterDetails.getAddress();
                enterDetails.setSuburb(TxtSuburb.Text);
                dgv_Records.Rows[n].Cells["Suburb"].Value = enterDetails.getSuburb();
                enterDetails.setCity(TxtCity.Text);
                dgv_Records.Rows[n].Cells["City"].Value = enterDetails.getCity();
                enterDetails.setPhone(TxtPhone.Text);
                dgv_Records.Rows[n].Cells["Phone"].Value = enterDetails.getPhone();
                enterDetails.setCountry(cboCountry.Text);
                dgv_Records.Rows[n].Cells["Country"].Value = enterDetails.getCountry();
                dgv_Records.Rows[n].DefaultCellStyle.ForeColor = Color.Blue;

                //Write to the text file
                writeToTheFile();
            }
        }

        //Clear all the fiels
        private void clearfields()
        {
            TxtName.Clear();
            TxtPhone.Clear();
            TxtAdd.Clear();
            TxtCity.Clear();
            TxtSuburb.Clear();            
        }

        //Writing to the text file
        private void writeToTheFile()
        {
            using (StreamWriter objWriter = new StreamWriter("AddressBook.txt", true))
            {
                objWriter.WriteLine(enterDetails.getName()+ "," + enterDetails.getAddress()+ 
                    "," + enterDetails.getSuburb() + "," + enterDetails.getCity() + 
                    "," + enterDetails.getPhone() + "," + enterDetails.getCountry());
                MessageBox.Show("Details have been saved");
            }
        }

        //Add details to the datagridview and save to the text file
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                createNewAddress();
                clearfields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Read AddressBook.txt file and load to the data grid
        private void ReadAndShowData()
        {
            try
            {
                using (StreamReader sr = new StreamReader("AddressBook.txt"))
                {
                    int row = 0;
                    string line;                   

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] col = line.Split(',');
                        row = dgv_Records.Rows.Add();
                        for (int i = 0; i < col.Length; i++)
                        {
                            dgv_Records[i, row].Value = col[i];
                            dgv_Records.Rows[row].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("The file don't exist!", "Problems!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(e);
            }
        }

        //Control the text field and allow to enter numbers only
        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }  
        }

        //Mark in red remove item
        private void markDeleteRecord()
        {
            if (dgv_Records.SelectedRows.Count == 0)
            {
                return;
            }
            dgv_Records.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
        }

        //Delete address
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record!!!?", 
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    markDeleteRecord();
                    MessageBox.Show("Please Click on save button to save to the file", "Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Edit address details
        private void edit()
        {
            if (dgv_Records.SelectedRows.Count == 0)
            {
                return;
            }
            
            if (btnEdit.Text == "Edit")
            {
                //get the values of the datagridview to the text fields
                TxtName.Text = dgv_Records.SelectedRows[0].Cells["FullName"].Value.ToString();
                TxtAdd.Text = dgv_Records.SelectedRows[0].Cells["Address"].Value.ToString();
                TxtSuburb.Text = dgv_Records.SelectedRows[0].Cells["Suburb"].Value.ToString();
                TxtCity.Text = dgv_Records.SelectedRows[0].Cells["City"].Value.ToString();
                TxtPhone.Text = dgv_Records.SelectedRows[0].Cells["Phone"].Value.ToString();
                cboCountry.Text = dgv_Records.SelectedRows[0].Cells["Country"].Value.ToString();
                dgv_Records.Enabled = false;
                btnEdit.Text = "Update";
            }
            else
            {
                if (validateEmptyFields() == true)
                {
                    MessageBox.Show("Must Fill All Fields", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Enter edited details to the datagridview
                    enterDetails.setName(TxtName.Text);
                    dgv_Records.SelectedRows[0].Cells["FullName"].Value = enterDetails.getName();
                    enterDetails.setAddress(TxtAdd.Text);
                    dgv_Records.SelectedRows[0].Cells["Address"].Value = enterDetails.getAddress();
                    enterDetails.setSuburb(TxtSuburb.Text);
                    dgv_Records.SelectedRows[0].Cells["Suburb"].Value = enterDetails.getSuburb();
                    enterDetails.setCity(TxtCity.Text);
                    dgv_Records.SelectedRows[0].Cells["City"].Value = enterDetails.getCity();
                    enterDetails.setPhone(TxtPhone.Text);
                    dgv_Records.SelectedRows[0].Cells["Phone"].Value = enterDetails.getPhone();
                    enterDetails.setCountry(cboCountry.Text);
                    dgv_Records.SelectedRows[0].Cells["Country"].Value = enterDetails.getCountry();
                    dgv_Records.Enabled = true;
                    btnEdit.Text = "Edit";
                    MessageBox.Show("Please Click on save button to save changes to the file", "Message");
                }
            }
            dgv_Records.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Blue;
        }

        //Edit button actions
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                edit();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Save changes of the address book
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save the changes to file?", 
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //Remove red colored records.
                try
                {
                    foreach (DataGridViewRow row in dgv_Records.Rows)
                    {
                        if (row.DefaultCellStyle.ForeColor == Color.Red)
                            dgv_Records.Rows.Remove(row);//it is to just remove from datagrid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                using (StreamWriter objWriter = new StreamWriter("AddressBook.txt"))
                {
                    int rowcount = dgv_Records.Rows.Count;
                    int colcount = dgv_Records.Columns.Count;
                    string lines = "";
                    for (int i = 0; i < rowcount; i++)
                    {
                        lines = "";//Clear the line before saving new row
                        for (int k = 0; k < colcount; k++)
                        {
                            lines += dgv_Records.Rows[i].Cells[k].Value;
                            if (k != dgv_Records.Columns.Count - 1)
                            {
                                //A comma is added as a text delimiter in order
                                //to separate each field in the text file.
                                lines += ",";
                            }
                        }
                        objWriter.WriteLine(lines);
                    }
                    objWriter.Close();
                }
                MessageBox.Show("Data Saved successfully", "Confirmation");
            }
        }

        //Search address from address book from any given field detail
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int rowcount = dgv_Records.Rows.Count;
            int colcount = dgv_Records.Columns.Count;
            string lines = "";  
            Boolean searchRes = false;
            for (int i = 0; i < rowcount; i++)
            {
                for (int k = 0; k < colcount; k++)
                {
                    lines = dgv_Records.Rows[i].Cells[k].Value.ToString();
                    if (cbosearch.Text.Equals(lines, StringComparison.InvariantCultureIgnoreCase))//Ignore case
                    {
                        searchRes = true;
                        LstDetails.Items.Clear();
                        for (int c = 0; c < colcount; c++)
                        {
                            LstDetails.Items.Add(dgv_Records[c, i].Value.ToString());
                        }
                    }
                }
            }

            //Display message if search item not in the datagridview
            if (searchRes == false)
            {
                MessageBox.Show("Search address not in the address book!", 
                    "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }                  
        }

        //Close the top level window
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the address book?", 
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        //Clear list when click on the search field
        private void cbosearch_MouseClick(object sender, MouseEventArgs e)
        {
            LstDetails.Items.Clear();            
        }
    }
}
