using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_SIR_GELLO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRoomRegistration_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            label51.Show(); label52.Hide(); label53.Hide(); label54.Hide();
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            label52.Show(); label51.Hide(); label53.Hide(); label54.Hide();
        }

        private void btnPaymentTransactions_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            label53.Show(); label51.Hide(); label52.Hide(); label54.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label54.Show(); label51.Hide(); label52.Hide(); label53.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label51.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBxNumberofOccupants.Text == "" && txtBxDownPayment.Text == "")
                {
                    MessageBox.Show("Please fill-up all information needed!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //    for (Array.increment = 0; Array.increment < 100; Array.increment++)
                    //   {
                    Array.getinfo[Array.increment, 0] = lblRoomName.Text;
                    Array.getinfo[Array.increment, 1] = lblRoomNum.Text;
                    Array.getinfo[Array.increment, 2] = lblRoomType.Text;
                    Array.getinfo[Array.increment, 3] = lblNumberofBed.Text.ToString();
                    Array.getinfo[Array.increment, 4] = lblRoomRate.Text.ToString();
                    Array.getinfo[Array.increment, 5] = comboCheckInDay.Text.ToString();
                    Array.getinfo[Array.increment, 6] = comboCheckInMonth.Text.ToString();
                    Array.getinfo[Array.increment, 7] = comboCheckInYear.Text.ToString();
                    Array.getinfo[Array.increment, 8] = comboCheckOutDay.Text.ToString();
                    Array.getinfo[Array.increment, 9] = comboCheckOutMonth.Text.ToString();
                    Array.getinfo[Array.increment, 10] = comboCheckOutYear.Text.ToString();
                    Array.getinfo[Array.increment, 11] = (txtBxLastName.Text + "," + txtBxFirstName.Text + " " + txtBxMiddleName.Text);
                    Array.getinfo[Array.increment, 12] = txtBxAddress.Text;
                    Array.getinfo[Array.increment, 13] = comboGender.Text;
                    Array.getinfo[Array.increment, 14] = txtBxAge.Text.ToString();
                    Array.getinfo[Array.increment, 15] = txtBxEmail.Text;
                    Array.getinfo[Array.increment, 16] = txtBxContact.Text.ToString();
                    Array.getinfo[Array.increment, 17] = txtBxEmergencyContact.Text.ToString();
                    Array.getinfo[Array.increment, 18] = lblTransactionNum.Text.ToString();
                    Array.getinfo[Array.increment, 19] = lblNumberofDays.Text.ToString();
                    Array.getinfo[Array.increment, 20] = txtBxNumberofOccupants.Text.ToString();
                    Array.getinfo[Array.increment, 21] = lblExcess.Text.ToString();
                    Array.getinfo[Array.increment, 22] = lblTotal.Text.ToString();
                    Array.getinfo[Array.increment, 23] = txtBxDownPayment.Text.ToString();
                    Array.getinfo[Array.increment, 24] = lblBalance.Text.ToString();
                    Array.getinfo[Array.increment, 25] = dateTimePicker1.Text.ToString();




                    //for (Array.increment2 = 0; Array.increment2 < 100; Array.increment2++)
                    //{
                    Array.getpayment[Array.increment2, 0] = (txtBxLastName.Text + "," + txtBxFirstName.Text + " " + txtBxMiddleName.Text);
                    Array.getpayment[Array.increment2, 1] = comboCheckInDay.Text.ToString();
                    Array.getpayment[Array.increment2, 2] = comboCheckInMonth.Text.ToString();
                    Array.getpayment[Array.increment2, 3] = comboCheckInYear.Text.ToString();
                    Array.getpayment[Array.increment2, 4] = lblRoomNum.Text.ToString();
                    Array.getpayment[Array.increment2, 5] = lblTotal.Text.ToString();
                    Array.getpayment[Array.increment2, 6] = txtBxDownPayment.Text.ToString();
                    Array.getpayment[Array.increment2, 7] = lblBalance.Text.ToString();
                    Array.getpayment[Array.increment2, 8] = dateTimePicker1.Text.ToString();
                    Array.increment2++;

                    //for (Array.increment = 0; Array.increment < 100; Array.increment++)
                    //{
                    Array.getbalance[Array.increment, 0] = (txtBxLastName.Text + "," + txtBxFirstName.Text + " " + txtBxMiddleName.Text);
                    Array.getbalance[Array.increment, 1] = comboCheckInDay.Text.ToString();
                    Array.getbalance[Array.increment, 2] = comboCheckInMonth.Text.ToString();
                    Array.getbalance[Array.increment, 3] = comboCheckInYear.Text.ToString();
                    Array.getbalance[Array.increment, 4] = lblRoomNum.Text.ToString();
                    Array.getbalance[Array.increment, 5] = lblTotal.Text.ToString();
                    Array.getbalance[Array.increment, 6] = lblBalance.Text.ToString();

                    

                    comboName.Items.Add(Array.getinfo[Array.increment, 11]);


                    Array.increment++;


                    MessageBox.Show("Registration Saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblRoomName.Text = "Terryl Room"; lblRoomNum.Text = "101"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                    btnSelect.Show(); comboCheckInDay.Text = "Day"; comboCheckInMonth.Text = "Month"; comboCheckInYear.Text = "Year"; comboCheckOutDay.Text = "Day"; 
                    comboCheckOutMonth.Text = "Month"; comboCheckOutYear.Text = "Year"; txtBxFirstName.Clear(); txtBxMiddleName.Clear(); txtBxLastName.Clear(); txtBxAddress.Clear(); 
                    comboGender.Text = ""; txtBxAge.Clear(); txtBxEmail.Clear(); txtBxContact.Clear(); txtBxEmergencyContact.Clear(); lblTransactionNum.Text = "0"; 
                    lblRoomRate2.Text = "0"; lblNumberofDays.Text = "0"; lblCost.Text = "0"; txtBxNumberofOccupants.Text = "0"; lblExcess.Text = "0"; lblAdditionalCharge.Text = "0";
                    lblTotal.Text = "0"; txtBxDownPayment.Text = "0"; lblBalance.Text = "0"; btnPrevious.Enabled = true; btnNext.Enabled = true; btnSearchRoom.Enabled = true;
                    comboSearchRoom.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }

       //




        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string roomnum;
                int dayin, monthin, yearin, dayout, monthout, yearout;
                int i = 0;

                roomnum = lblRoomNum.Text.ToString();
                dayin = int.Parse(comboCheckInDay.Text.ToString());
                dayout = int.Parse(comboCheckOutDay.Text.ToString());
                monthin = int.Parse(comboCheckInMonth.Text.ToString());
                monthout = int.Parse(comboCheckOutMonth.Text.ToString());
                yearin = int.Parse(comboCheckInYear.Text.ToString());
                yearout = int.Parse(comboCheckOutYear.Text.ToString());

                for (i = 0; i < 100; i++)
                {
                    if (roomnum == Array.getinfo[i, 1] && monthin == int.Parse(Array.getinfo[i, 6]) && yearin == int.Parse(Array.getinfo[i, 7]))
                    {
                        if ((dayin >= int.Parse(Array.getinfo[i, 5]) && dayin <= int.Parse(Array.getinfo[i, 8])) || (dayout >= int.Parse(Array.getinfo[i, 5]) && dayout <= int.Parse(Array.getinfo[i, 8])))
                        {
                            MessageBox.Show("Room is Already Reserved!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            comboCheckInDay.Text = ""; comboCheckInMonth.Text = ""; comboCheckInYear.Text = "";
                            comboCheckOutDay.Text = ""; comboCheckOutMonth.Text = ""; comboCheckOutYear.Text = "";
                            i = 101;
                        }

                    }
                    
                }
                if (i == 100)
                {
                    MessageBox.Show("Room is Available!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnProceed1.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }
        
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
                
            try
            {
                if (comboDay.Text == "Day" || comboMonth.Text == "Month" || comboYear.Text == "Year")
                {
                    MessageBox.Show("Invalid Input!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboDay.Text == "" || comboMonth.Text == "" || comboYear.Text == "")
                {
                    MessageBox.Show("Field/s can't be blank!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                int i, searchday;
                string searchmonth, searchyear;
                searchday = int.Parse(comboDay.Text);
                searchmonth = comboMonth.Text.ToString();
                searchyear = comboYear.Text.ToString();

                for (i = 0; i < 100; i++)
                {
                    if (Array.getinfo[i, 6] != "" && Array.getinfo[i, 7] != "")
                    {
                        if (searchmonth == (Array.getinfo[i, 6]) && searchyear == Array.getinfo[i, 7])
                        {
                            if (searchday >= int.Parse(Array.getinfo[i, 5]) && searchday <= int.Parse(Array.getinfo[i, 8]))
                            {

                                string checkin = (Array.getinfo[i, 5] + "-" + Array.getinfo[i, 6] + "-" + Array.getinfo[i, 7]).ToString();
                                string checkout = (Array.getinfo[i, 8] + "-" + Array.getinfo[i, 9] + "-" + Array.getinfo[i, 10]).ToString();

                                dataGridView1.Rows.Add(Array.getinfo[i, 1], Array.getinfo[i, 11], Array.getinfo[i, 20], checkin, checkout);

                                // i = 101;
                            }
                            else
                            {
                                MessageBox.Show("No records saved for this day.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No records saved.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }


        private void btnProceed1_Click(object sender, EventArgs e)
        {
            tabControl5.SelectedIndex = 1;
        }

        private void btnProceed2_Click(object sender, EventArgs e)
        {
            if (
               txtBxFirstName.Text != "" &&
               txtBxMiddleName.Text != "" &&
               txtBxLastName.Text != "" &&
               txtBxAddress.Text != "" &&
               txtBxAge.Text != "" &&
               comboGender.Text != "" &&
               txtBxEmail.Text != "" &&
               txtBxContact.Text != ""
               )
            {
                tabControl5.SelectedIndex = 2;
            }
            else if (
                txtBxFirstName.Text == "" &&
                txtBxMiddleName.Text == "" &&
                txtBxLastName.Text == "" &&
                txtBxAddress.Text == "" &&
                txtBxAge.Text == "" &&
                comboGender.Text == "" &&
                txtBxEmail.Text == "" &&
                txtBxContact.Text == ""
                )
            {
                MessageBox.Show("Please fill-up all information needed!", "Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            //transaction number, automatic + 1
            int num = 0;
            lblTransactionNum.Text = (num + 1).ToString();

            //ang room rate sa napili nga room automatic mabutang dri
            lblRoomRate2.Text = lblRoomRate.Text.ToString();

            //number of days
            lblNumberofDays.Text = (int.Parse(comboCheckOutDay.Text) - int.Parse(comboCheckInDay.Text)).ToString();
            //DateTime From = Convert.ToDateTime(comboCheckInDay.Text + comboCheckInMonth.Text + comboCheckInYear.Text);
            //DateTime To = Convert.ToDateTime(comboCheckOutDay.Text + comboCheckOutMonth.Text + comboCheckOutYear.Text);
            //TimeSpan TSpan = To - From;
            //Double Days = TSpan.TotalDays;
            //lblNumberofDays.Text = (Days / 365).ToString("0");

            //cost
            lblCost.Text = (int.Parse(lblNumberofDays.Text) * int.Parse(lblRoomRate.Text)).ToString();

           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            label2.Show(); label3.Show(); comboCheckInDay.Show(); comboCheckInMonth.Show(); comboCheckInYear.Show();
            comboCheckOutDay.Show(); comboCheckOutMonth.Show(); comboCheckOutYear.Show(); btnCheck.Show();
            btnReselect.Show(); btnSelect.Hide(); btnPrevious.Enabled = false; btnNext.Enabled = false; btnSearchRoom.Enabled = false; comboSearchRoom.Enabled = false;
        }

        private void btnReselect_Click(object sender, EventArgs e)
        {
            label2.Hide(); label3.Hide(); comboCheckInDay.Hide(); comboCheckInMonth.Hide(); comboCheckInYear.Hide();
            comboCheckOutDay.Hide(); comboCheckOutMonth.Hide(); comboCheckOutYear.Hide(); btnCheck.Hide();
            btnSelect.Show(); btnReselect.Hide(); btnPrevious.Enabled = true; btnNext.Enabled = true; btnSearchRoom.Enabled = true; comboSearchRoom.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            comboSearchRoom.Text = "";
            if (lblRoomNum.Text == "101")
            {
                lblRoomName.Text = "Terryl2 Room"; lblRoomNum.Text = "102"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "102")
            {
                lblRoomName.Text = "Terryl3 Room"; lblRoomNum.Text = "103"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "103")
            {
                lblRoomName.Text = "Terryl4 Room"; lblRoomNum.Text = "104"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "104")
            {
                lblRoomName.Text = "Dave1 Room"; lblRoomNum.Text = "105"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "105")
            {
                lblRoomName.Text = "Julina1 Room"; lblRoomNum.Text = "201"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "201")
            {
                lblRoomName.Text = "Julina2 Room"; lblRoomNum.Text = "202"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "202")
            {
                lblRoomName.Text = "Julina3 Room"; lblRoomNum.Text = "203"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "203")
            {
                lblRoomName.Text = "Julina4 Room"; lblRoomNum.Text = "204"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "204")
            {
                lblRoomName.Text = "Dave2 Room"; lblRoomNum.Text = "205"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "205")
            {
                lblRoomName.Text = "Crissha1 Room"; lblRoomNum.Text = "301"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "301")
            {
                lblRoomName.Text = "Crissha2 Room"; lblRoomNum.Text = "302"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "302")
            {
                lblRoomName.Text = "Crissha3 Room"; lblRoomNum.Text = "303"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "303")
            {
                lblRoomName.Text = "Crissha4 Room"; lblRoomNum.Text = "304"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "304")
            {
                lblRoomName.Text = "Dave3 Room"; lblRoomNum.Text = "305"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "305")
            {
                lblRoomName.Text = "Jexter1 Room"; lblRoomNum.Text = "401"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "401")
            {
                lblRoomName.Text = "Jexter2 Room"; lblRoomNum.Text = "402"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "402")
            {
                lblRoomName.Text = "Jexter3 Room"; lblRoomNum.Text = "403"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "403")
            {
                lblRoomName.Text = "Jexter4 Room"; lblRoomNum.Text = "404"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "404")
            {
                lblRoomName.Text = "Dave4 Room"; lblRoomNum.Text = "405"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "405")
            {
                lblRoomName.Text = "Terryl1 Room"; lblRoomNum.Text = "101"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            comboSearchRoom.Text = "";
            if (lblRoomNum.Text == "103")
            {
                lblRoomName.Text = "Terryl2 Room"; lblRoomNum.Text = "102"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "104")
            {
                lblRoomName.Text = "Terryl3 Room"; lblRoomNum.Text = "103"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "105")
            {
                lblRoomName.Text = "Terryl4 Room"; lblRoomNum.Text = "104"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "201")
            {
                lblRoomName.Text = "Dave1 Room"; lblRoomNum.Text = "105"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "202")
            {
                lblRoomName.Text = "Julina1 Room"; lblRoomNum.Text = "201"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "203")
            {
                lblRoomName.Text = "Julina2 Room"; lblRoomNum.Text = "202"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "204")
            {
                lblRoomName.Text = "Julina3 Room"; lblRoomNum.Text = "203"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "205")
            {
                lblRoomName.Text = "Julina4 Room"; lblRoomNum.Text = "204"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "301")
            {
                lblRoomName.Text = "Dave2 Room"; lblRoomNum.Text = "205"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "302")
            {
                lblRoomName.Text = "Crissha1 Room"; lblRoomNum.Text = "301"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "303")
            {
                lblRoomName.Text = "Crissha2 Room"; lblRoomNum.Text = "302"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "304")
            {
                lblRoomName.Text = "Crissha3 Room"; lblRoomNum.Text = "303"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "305")
            {
                lblRoomName.Text = "Crissha4 Room"; lblRoomNum.Text = "304"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "401")
            {
                lblRoomName.Text = "Dave3 Room"; lblRoomNum.Text = "305"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "402")
            {
                lblRoomName.Text = "Jexter1 Room"; lblRoomNum.Text = "401"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (lblRoomNum.Text == "403")
            {
                lblRoomName.Text = "Jexter2 Room"; lblRoomNum.Text = "402"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (lblRoomNum.Text == "404")
            {
                lblRoomName.Text = "Jexter3 Room"; lblRoomNum.Text = "403"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (lblRoomNum.Text == "405")
            {
                lblRoomName.Text = "Jexter4 Room"; lblRoomNum.Text = "404"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "101")
            {
                lblRoomName.Text = "Dave4 Room"; lblRoomNum.Text = "405"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (lblRoomNum.Text == "102")
            {
                lblRoomName.Text = "Terryl1 Room"; lblRoomNum.Text = "101"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            if (comboSearchRoom.Text == "")
            {
                MessageBox.Show("Field can't be blank!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboSearchRoom.Text == "101")
            {
                lblRoomName.Text = "Terryl1 Room"; lblRoomNum.Text = "101"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (comboSearchRoom.Text == "102")
            {
                lblRoomName.Text = "Terryl2 Room"; lblRoomNum.Text = "102"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (comboSearchRoom.Text == "103")
            {
                lblRoomName.Text = "Terryl3 Room"; lblRoomNum.Text = "103"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (comboSearchRoom.Text == "104")
            {
                lblRoomName.Text = "Terryl4 Room"; lblRoomNum.Text = "104"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (comboSearchRoom.Text == "105")
            {
                lblRoomName.Text = "Dave1 Room"; lblRoomNum.Text = "105"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (comboSearchRoom.Text == "201")
            {
                lblRoomName.Text = "Julina1 Room"; lblRoomNum.Text = "201"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (comboSearchRoom.Text == "202")
            {
                lblRoomName.Text = "Julina2 Room"; lblRoomNum.Text = "202"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (comboSearchRoom.Text == "203")
            {
                lblRoomName.Text = "Julina3 Room"; lblRoomNum.Text = "203"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (comboSearchRoom.Text == "204")
            {
                lblRoomName.Text = "Julina4 Room"; lblRoomNum.Text = "204"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (comboSearchRoom.Text == "205")
            {
                lblRoomName.Text = "Dave2 Room"; lblRoomNum.Text = "205"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (comboSearchRoom.Text == "301")
            {
                lblRoomName.Text = "Crissha1 Room"; lblRoomNum.Text = "301"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (comboSearchRoom.Text == "302")
            {
                lblRoomName.Text = "Crissha2 Room"; lblRoomNum.Text = "302"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (comboSearchRoom.Text == "303")
            {
                lblRoomName.Text = "Crissha3 Room"; lblRoomNum.Text = "303"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (comboSearchRoom.Text == "304")
            {
                lblRoomName.Text = "Crissha4 Room"; lblRoomNum.Text = "304"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (comboSearchRoom.Text == "305")
            {
                lblRoomName.Text = "Dave3 Room"; lblRoomNum.Text = "305"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (comboSearchRoom.Text == "401")
            {
                lblRoomName.Text = "Jexter1 Room"; lblRoomNum.Text = "401"; lblRoomType.Text = "Single"; lblNumberofBed.Text = "1"; lblRoomRate.Text = "1000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources._118761933;
            }
            else if (comboSearchRoom.Text == "402")
            {
                lblRoomName.Text = "Jexter2 Room"; lblRoomNum.Text = "402"; lblRoomType.Text = "Double"; lblNumberofBed.Text = "2"; lblRoomRate.Text = "2000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.double_room;
            }
            else if (comboSearchRoom.Text == "403")
            {
                lblRoomName.Text = "Jexter3 Room"; lblRoomNum.Text = "403"; lblRoomType.Text = "Family"; lblNumberofBed.Text = "3"; lblRoomRate.Text = "3500";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.family;
            }
            else if (comboSearchRoom.Text == "404")
            {
                lblRoomName.Text = "Jexter4 Room"; lblRoomNum.Text = "404"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else if (comboSearchRoom.Text == "405")
            {
                lblRoomName.Text = "Dave4 Room"; lblRoomNum.Text = "405"; lblRoomType.Text = "Deluxe"; lblNumberofBed.Text = "4"; lblRoomRate.Text = "5000";
                picture.Image = FINAL_SIR_GELLO.Properties.Resources.Ballsbridge_Hotel_Family_Room;
            }
            else
            {
                MessageBox.Show("Invalid Input!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); comboSearchRoom.Text = ""; comboSearchRoom.Focus();
            }
        }

        private void lblExcess_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(lblExcess.Text) != 0 && int.Parse(lblExcess.Text) > 0)
            {
                label9.Show(); lblAdditionalCharge.Show();
            }
            else if (int.Parse(lblExcess.Text) == 0 || lblExcess.Text == "")
            {
                label9.Hide(); lblAdditionalCharge.Hide();
            }
        }
        private void txtBxNumberofOccupants_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNumberofOccupants.Text == "")
            {
                MessageBox.Show("Field can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (int.Parse(txtBxNumberofOccupants.Text) >= int.Parse(lblNumberofBed.Text))
                {
                    //excess occupants
                    lblExcess.Text = (int.Parse(txtBxNumberofOccupants.Text) - int.Parse(lblNumberofBed.Text)).ToString();

                    //additional charge
                    lblAdditionalCharge.Text = (int.Parse(lblExcess.Text) * 250).ToString();
                    //total cost
                    lblTotal.Text = (int.Parse(lblCost.Text) + int.Parse(lblAdditionalCharge.Text)).ToString();
                }
                else if (int.Parse(txtBxNumberofOccupants.Text) < int.Parse(lblNumberofBed.Text))
                {
                    lblExcess.Text = "0";

                    //additional charge
                    lblAdditionalCharge.Text = (int.Parse(lblExcess.Text) * 250).ToString();
                    //total cost
                    lblTotal.Text = (int.Parse(lblCost.Text) + int.Parse(lblAdditionalCharge.Text)).ToString();
                }
            }
        }

        private void txtBxDownPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtBxDownPayment.Text == "")
            {
                MessageBox.Show("Field can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(lblTotal.Text) >= int.Parse(txtBxDownPayment.Text))
            {
                //balance
                lblBalance.Text = (int.Parse(lblTotal.Text) - int.Parse(txtBxDownPayment.Text)).ToString();
            }
            else if (int.Parse(lblTotal.Text) < int.Parse(txtBxDownPayment.Text))
            {
                MessageBox.Show("Down Payment must not exceed the Total Amount Cost!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBxDownPayment.Clear();
            }
            
        }

        private void txtBxNumberofOccupants_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxDownPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxEmergencyContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboSearchRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboCheckInDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboCheckOutDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboCheckInMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboCheckOutMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboCheckInYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboCheckOutYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxContact_TextChanged(object sender, EventArgs e)
        {

        }




        int indexfound = 0;
        private void btnSearch3_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                if ((comboDay2.Text == "Day" || comboMonth2.Text == "Month" || comboYear2.Text == "Year" && comboName.Text == "") || (comboDay2.Text == "Day" || comboMonth2.Text == "Month" || comboYear2.Text == "Year" && comboSearchRoom2.Text == ""))
                {
                    MessageBox.Show("Invalid Input!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((comboDay2.Text == "" && comboMonth2.Text == "" && comboYear2.Text == "" && comboName.Text == "") || (comboDay2.Text == "" && comboMonth2.Text == "" && comboYear2.Text == "" && comboSearchRoom2.Text == ""))
                {
                    MessageBox.Show("Field/s can't be blank!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int i;
                    string searchmonth, searchday, searchyear, searchroomnum, searchname;
                    bool result = false;

                    searchday = comboDay2.Text;
                    searchmonth = comboMonth2.Text.ToString();
                    searchyear = comboYear2.Text.ToString();
                    searchroomnum = comboSearchRoom2.Text.ToString();
                    searchname = comboName.Text;

                   dataGridView2.Rows.Clear();

                    for (i = 0; i < 100; i++)
                    {
                        if (Array.getpayment[i, 2] != "" && Array.getpayment[i, 3] != "")
                        {
                            if (searchmonth == (Array.getpayment[i, 2]) && searchday == Array.getpayment[i, 1] && searchyear == Array.getpayment[i, 3])
                            {
                                if (searchname == Array.getpayment[i, 0])
                                {
                                    string checkin = (Array.getpayment[i, 1] + "-" + Array.getpayment[i, 2] + "-" + Array.getpayment[i, 3]);
                                    dataGridView2.Rows.Add(Array.getpayment[i, 0], checkin, Array.getpayment[i, 4], Array.getpayment[i, 5], Array.getpayment[i, 6], Array.getpayment[i, 7], Array.getpayment[i, 8]);

                                    result = true;
                                }

                                else if (searchroomnum == Array.getpayment[i, 4])
                                {
                                    string checkin = (Array.getpayment[i, 1] + "-" + Array.getpayment[i, 2] + "-" + Array.getpayment[i, 3]);
                                    dataGridView2.Rows.Add(Array.getpayment[i, 0], checkin, Array.getpayment[i, 4], Array.getpayment[i, 5], Array.getpayment[i, 6], Array.getpayment[i, 7], Array.getpayment[i, 8]);

                                    result = true;
                                }

                            }
                        }

                    }





                    for (i = 0; i < 100; i++)
                    {
                        if (searchmonth == (Array.getbalance[i, 2]) && searchday == Array.getbalance[i, 1] && searchyear == Array.getbalance[i, 3])
                        {
                            if (searchname == Array.getbalance[i, 0])
                            {
                                lblBalance2.Text = Array.getbalance[i, 6];
                                result = true;

                                indexfound = i;
                            }

                            else if (searchroomnum == Array.getbalance[i, 4])
                            {
                                lblBalance2.Text = Array.getbalance[i, 6];
                                result = true;

                                indexfound = i;
                            }

                        }


                    }


                    if (result == false)
                    {
                        MessageBox.Show("No records saved.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    // for loop balance



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(lblBalance2.Text) >= int.Parse(txtBxNewPayment.Text))
                {
                    lblNewBalance.Text = (int.Parse(lblBalance2.Text) - int.Parse(txtBxNewPayment.Text)).ToString();
                }
                else if (int.Parse(lblBalance2.Text) < int.Parse(txtBxNewPayment.Text))
                {
                    lblNewBalance.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input", "Calculate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBxNewPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (MessageBox.Show("Do you want to update this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    label12.Show(); label15.Show(); label25.Show(); lblBalance2.Show(); txtBxNewPayment.Show(); lblNewBalance.Show(); btnCalculate.Show();

            //    int i;
            //    for (i = 0; i < 100; i++)
            //    {
            //        if (Array.getpayment[i, 7] != "")
            //        {
            //            lblBalance2.Text = Array.getpayment[i, 7];
            //        }
            //    }
            //}

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBxNewPayment.Text != "")
            {
                if (MessageBox.Show("Confirm Update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    Array.getbalance[indexfound, 6] = lblNewBalance.Text;




                    Array.getpayment[Array.increment2, 0] = Array.getbalance[indexfound, 0];
                    Array.getpayment[Array.increment2, 1] = comboDay2.Text.ToString();
                    Array.getpayment[Array.increment2, 2] = comboMonth2.Text.ToString();
                    Array.getpayment[Array.increment2, 3] = comboYear2.Text.ToString();
                    Array.getpayment[Array.increment2, 4] = Array.getbalance[indexfound, 4];
                    Array.getpayment[Array.increment2, 5] = Array.getbalance[indexfound, 5];
                    Array.getpayment[Array.increment2, 6] = txtBxNewPayment.Text.ToString();
                    Array.getpayment[Array.increment2, 7] = lblNewBalance.Text.ToString();
                    Array.getpayment[Array.increment2, 8] = dateTimePicker6.Text.ToString();
                    Array.increment2++;


                    displaydata();


                    txtBxNewPayment.Text = ""; lblNewBalance.Text = "";





                }
            }
            else
            {
                MessageBox.Show("Please Enter New Payment Amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();

            int i = 0;

                if (Array.getinfo[i, 1] == "")
                {
                    dataGridView4.Rows.Add("101", "Available"); dataGridView4.Rows.Add("102", "Available"); dataGridView4.Rows.Add("103", "Available"); dataGridView4.Rows.Add("104", "Available");
                    dataGridView4.Rows.Add("105", "Available"); dataGridView4.Rows.Add("201", "Available"); dataGridView4.Rows.Add("202", "Available"); dataGridView4.Rows.Add("203", "Available");
                    dataGridView4.Rows.Add("204", "Available"); dataGridView4.Rows.Add("205", "Available"); dataGridView4.Rows.Add("301", "Available"); dataGridView4.Rows.Add("302", "Available");
                    dataGridView4.Rows.Add("303", "Available"); dataGridView4.Rows.Add("304", "Available"); dataGridView4.Rows.Add("305", "Available"); dataGridView4.Rows.Add("401", "Available");
                    dataGridView4.Rows.Add("402", "Available"); dataGridView4.Rows.Add("403", "Available"); dataGridView4.Rows.Add("404", "Available"); dataGridView4.Rows.Add("405", "Available");
                }
                else
                {
                    
                        if (Array.getinfo[i, 1] == "101")
                        {
                                dataGridView4.Rows.Add("101", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "101")
                        {
                                dataGridView4.Rows.Add("101", "Available");
                        }
                        if (Array.getinfo[i, 1] == "102")
                        {
                                dataGridView4.Rows.Add("102", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "102")
                        {
                                dataGridView4.Rows.Add("102", "Available");
                        }
                        if (Array.getinfo[i, 1] == "103")
                        {
                                dataGridView4.Rows.Add("103", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "103")
                        {
                                dataGridView4.Rows.Add("103", "Available");
                        }
                        if (Array.getinfo[i, 1] == "104")
                        {
                                dataGridView4.Rows.Add("104", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "104")
                        {
                                dataGridView4.Rows.Add("104", "Available");
                        }
                        if (Array.getinfo[i, 1] == "105")
                        {
                                dataGridView4.Rows.Add("105", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "105")
                        {
                                dataGridView4.Rows.Add("105", "Available");
                        }
                        if (Array.getinfo[i, 1] == "201")
                        {
                                dataGridView4.Rows.Add("201", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "201")
                        {
                                dataGridView4.Rows.Add("201", "Available");
                        }
                        if (Array.getinfo[i, 1] == "202")
                        {
                                dataGridView4.Rows.Add("202", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "202")
                        {
                                dataGridView4.Rows.Add("202", "Available");
                        }
                        if (Array.getinfo[i, 1] == "203")
                        {
                                dataGridView4.Rows.Add("203", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "203")
                        {
                                dataGridView4.Rows.Add("203", "Available");
                        }
                        if (Array.getinfo[i, 1] == "204")
                        {
                                dataGridView4.Rows.Add("204", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "204")
                        {
                                dataGridView4.Rows.Add("204", "Available");
                        }
                        if (Array.getinfo[i, 1] == "205")
                        {
                                dataGridView4.Rows.Add("205", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "205")
                        {
                                dataGridView4.Rows.Add("205", "Available");
                        }
                        if (Array.getinfo[i, 1] == "301")
                        {
                            dataGridView4.Rows.Add("301", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "301")
                        {
                            dataGridView4.Rows.Add("301", "Available");
                        }
                        if (Array.getinfo[i, 1] == "302")
                        {
                            dataGridView4.Rows.Add("302", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "302")
                        {
                            dataGridView4.Rows.Add("302", "Available");
                        }
                        if (Array.getinfo[i, 1] == "303")
                        {
                            dataGridView4.Rows.Add("303", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "303")
                        {
                            dataGridView4.Rows.Add("303", "Available");
                        }
                        if (Array.getinfo[i, 1] == "304")
                        {
                            dataGridView4.Rows.Add("304", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "304")
                        {
                            dataGridView4.Rows.Add("304", "Available");
                        }
                        if (Array.getinfo[i, 1] == "305")
                        {
                            dataGridView4.Rows.Add("305", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "305")
                        {
                            dataGridView4.Rows.Add("305", "Available");
                        }
                        if (Array.getinfo[i, 1] == "401")
                        {
                            dataGridView4.Rows.Add("401", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "401")
                        {
                            dataGridView4.Rows.Add("401", "Available");
                        }
                        if (Array.getinfo[i, 1] == "402")
                        {
                            dataGridView4.Rows.Add("402", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "402")
                        {
                            dataGridView4.Rows.Add("402", "Available");
                        }
                        if (Array.getinfo[i, 1] == "403")
                        {
                            dataGridView4.Rows.Add("403", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "403")
                        {
                            dataGridView4.Rows.Add("403", "Available");
                        }
                        if (Array.getinfo[i, 1] == "404")
                        {
                            dataGridView4.Rows.Add("404", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "404")
                        {
                            dataGridView4.Rows.Add("404", "Available");
                        }
                        if (Array.getinfo[i, 1] == "405")
                        {
                            dataGridView4.Rows.Add("405", "Occupied");
                        }
                        if (Array.getinfo[i, 1] != "405")
                        {
                            dataGridView4.Rows.Add("405", "Available");
                        }
                        i++;
                    
            }
            
            
        }


        private void btnClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch4_Click(object sender, EventArgs e)
        {
            int i;
            string searchdate = "";
            bool result = false;

            for (i = 0; i < 100; i++)
            {
                if (Array.getpayment[i, 8] != "")
                {

                    if (searchdate == Array.getpayment[i, 8])
                    {

                        dataGridView2.Rows.Add(Array.getpayment[i, 4], Array.getpayment[i, 0], Array.getpayment[i, 5], Array.getpayment[i, 6]);

                        result = true;
                    }

                }

            }


            if (result == false)
            {
                MessageBox.Show("No records saved.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {

        }

        private void lblNewBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblBalance2_TextChanged(object sender, EventArgs e)
        {
            if (lblBalance2.Text == "0")
            {
                txtBxNewPayment.Enabled = false; btnCalculate.Enabled = false; btnUpdate.Enabled = false;
            }
            else
            {
                txtBxNewPayment.Enabled = true; btnCalculate.Enabled = true; btnUpdate.Enabled = true;
            }
        }

        private void btnSearch4_Click_1(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            int i;
            string searchdate = dateTimePicker2.Text;
            bool result = false;
            int profit = 0;

            for (i = 0; i < 100; i++) 
            {
                if (Array.getpayment[i, 8] != "")
                {

                    if (searchdate == Array.getpayment[i, 8])
                    {

                        dataGridView3.Rows.Add(Array.getpayment[i, 4], Array.getpayment[i, 0], Array.getpayment[i, 6]);

                        result = true;

                        profit += int.Parse(Array.getpayment[i, 6]);

                        lblProfit.Text = profit.ToString();
                    }

                }

            }


            if (result == false)
            {
                MessageBox.Show("No records saved.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }








    }
}
