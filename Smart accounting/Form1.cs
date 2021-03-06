﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // values
        double dr1 = 0;
        double dr2 = 0;
        double cr1 = 0;
        double cr2 = 0;

        // heads
        string d1 = "";
        string d2 = "";
        string c1 = "";
        string c2 = "";

        string data = "";

        //=========================================================================================================================

        List<double> cashdr = new List<double>();
        List<double> acrecdr = new List<double>();
        List<double> acpaydr = new List<double>();
        List<double> noterecdr = new List<double>();
        List<double> notepaydr = new List<double>();
        List<double> expdr = new List<double>();
        List<double> serdr = new List<double>();
        List<double> divdr = new List<double>();
        List<double> bandr = new List<double>();
        List<double> dradr = new List<double>();
        List<double> capdr = new List<double>();
        List<double> assdr = new List<double>();
        List<double> landr = new List<double>();
        List<double> buidr = new List<double>();
        List<double> eqidr = new List<double>();
        List<double> supdr = new List<double>();
        List<double> merdr = new List<double>();
        List<double> vehdr = new List<double>();
        List<double> saldr = new List<double>();

        List<double> cashcr = new List<double>();
        List<double> acreccr = new List<double>();
        List<double> acpaycr = new List<double>();
        List<double> notereccr = new List<double>();
        List<double> notepaycr = new List<double>();
        List<double> expcr = new List<double>();
        List<double> sercr = new List<double>();
        List<double> divcr = new List<double>();
        List<double> bancr = new List<double>();
        List<double> dracr = new List<double>();
        List<double> capcr = new List<double>();
        List<double> asscr = new List<double>();
        List<double> lancr = new List<double>();
        List<double> buicr = new List<double>();
        List<double> eqicr = new List<double>();
        List<double> supcr = new List<double>();
        List<double> mercr = new List<double>();
        List<double> vehcr = new List<double>();
        List<double> salcr = new List<double>();


        //=========================================================================================================================

        double cashtotal = 0;
        string cash = "";
        double acrectotal = 0;
        string acrec = "";
        double acpaytotal = 0;
        string acpay = "";
        double noterectotal = 0;
        string noterec = "";
        double notepaytotal = 0;
        string notepay = "";
        double exptotal = 0;
        string exp = "";
        double sertotal = 0;
        string ser = "";
        double divtotal = 0;
        string div = "";
        double bantotal = 0;
        string ban = "";
        double dratotal = 0;
        string dra = "";
        double captotal = 0;
        string cap = "";
        double asstotal = 0;
        string ass = "";
        double lantotal = 0;
        string lan = "";
        double buitotal = 0;
        string bui = "";
        double eqitotal = 0;
        string eqi = "";
        double suptotal = 0;
        string sup = "";
        double mertotal = 0;
        string mer = "";
        double vehtotal = 0;
        string veh = "";
        double saltotal = 0;
        string sal = "";


        //=========================================================================================================================

        // Income statement

        List<double> incomerevenue = new List<double>();
        List<double> incomeExpence = new List<double>();
        string incomedata = "                   Income statement \n\n";




        //=========================================================================================================================

        // Balance sheet

        List<double> balanceassest = new List<double>();
        List<double> balanceliability = new List<double>();
        List<double> balanceowner = new List<double>();
        string balancesheetdata = "                      Balance sheet\n\n";




        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;



            data += " ________________________________________________________________________\n";
            data += "|  Date         |                Particulars                                                   |   Debit          |  Credit        |\n";
            data += "|_________|__________________________________________|___________|_________|\n\n\n\n";
            richTextBox1.Text = data;


            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("A/C Receivable");
            comboBox1.Items.Add("A/C Payable");
            comboBox1.Items.Add("Note Payable");
            comboBox1.Items.Add("Note Receivable");
            comboBox1.Items.Add("Expence");
            comboBox1.Items.Add("Service");
            comboBox1.Items.Add("Divideds");
            comboBox1.Items.Add("Bank");
            comboBox1.Items.Add("Drawing");
            comboBox1.Items.Add("Capital stock");
            comboBox1.Items.Add("Assit");
            comboBox1.Items.Add("Land");
            comboBox1.Items.Add("Building");
            comboBox1.Items.Add("Equipments");
            comboBox1.Items.Add("Supplies");
            comboBox1.Items.Add("Merchandise");
            comboBox1.Items.Add("Vehicle");
            comboBox1.Items.Add("Salaries expence");

            //=========================================================================================================================

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("A/C Receivable");
            comboBox2.Items.Add("A/C Payable");
            comboBox2.Items.Add("Note Payable");
            comboBox2.Items.Add("Note Receivable");
            comboBox2.Items.Add("Expence");
            comboBox2.Items.Add("Service");
            comboBox2.Items.Add("Divideds");
            comboBox2.Items.Add("Bank");
            comboBox2.Items.Add("Drawing");
            comboBox2.Items.Add("Capital stock");
            comboBox2.Items.Add("Assit");
            comboBox2.Items.Add("Land");
            comboBox2.Items.Add("Building");
            comboBox2.Items.Add("Equipments");
            comboBox2.Items.Add("Supplies");
            comboBox2.Items.Add("Merchandise");
            comboBox2.Items.Add("Vehicle");
            comboBox2.Items.Add("Salaries expence");

            //=========================================================================================================================

            comboBox3.Items.Add("Cash");
            comboBox3.Items.Add("A/C Receivable");
            comboBox3.Items.Add("A/C Payable");
            comboBox3.Items.Add("Note Payable");
            comboBox3.Items.Add("Note Receivable");
            comboBox3.Items.Add("Expence");
            comboBox3.Items.Add("Service");
            comboBox3.Items.Add("Divideds");
            comboBox3.Items.Add("Bank");
            comboBox3.Items.Add("Drawing");
            comboBox3.Items.Add("Capital stock");
            comboBox3.Items.Add("Assit");
            comboBox3.Items.Add("Land");
            comboBox3.Items.Add("Building");
            comboBox3.Items.Add("Equipments");
            comboBox3.Items.Add("Supplies");
            comboBox3.Items.Add("Merchandise");
            comboBox3.Items.Add("Vehicle");
            comboBox3.Items.Add("Salaries expence");


            //=========================================================================================================================


            comboBox4.Items.Add("Cash");
            comboBox4.Items.Add("A/C Receivable");
            comboBox4.Items.Add("A/C Payable");
            comboBox4.Items.Add("Note Payable");
            comboBox4.Items.Add("Note Receivable");
            comboBox4.Items.Add("Expence");
            comboBox4.Items.Add("Service");
            comboBox4.Items.Add("Divideds");
            comboBox4.Items.Add("Bank");
            comboBox4.Items.Add("Drawing");
            comboBox4.Items.Add("Capital stock");
            comboBox4.Items.Add("Assit");
            comboBox4.Items.Add("Land");
            comboBox4.Items.Add("Building");
            comboBox4.Items.Add("Equipments");
            comboBox4.Items.Add("Supplies");
            comboBox4.Items.Add("Merchandise");
            comboBox4.Items.Add("Vehicle");
            comboBox4.Items.Add("Salaries expence");


            comboBox2.Enabled = false;
            comboBox4.Enabled = false;

            textBox3.Enabled = false;
            textBox5.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            comboBox2.Enabled = true;

            textBox3.Enabled = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;

            textBox5.Enabled = true;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox4.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Enter values");
                }
                else
                {
                    

                        d1 = "";
                        d2 = "";
                        c1 = "";
                        c2 = "";

                        dr1 = 0;
                        dr2 = 0;
                        cr1 = 0;
                        cr2 = 0;

                        // values
                        dr1 = Convert.ToDouble(textBox2.Text);
                        cr1 = Convert.ToDouble(textBox4.Text);

                        // heads
                        d1 = comboBox1.SelectedItem.ToString();
                        c1 = comboBox3.SelectedItem.ToString();



                        if (checkBox1.Checked == true)
                        {
                            dr2 = Convert.ToDouble(textBox3.Text);
                            d2 = comboBox2.SelectedItem.ToString();
                        }
                        if (checkBox2.Checked == true)
                        {
                            cr2 = Convert.ToDouble(textBox5.Text);
                            c2 = comboBox4.SelectedItem.ToString();
                        }

                        //  MessageBox.Show("  dr 1  = " + dr1 + "    cr 1  = " + cr1 + "   dr 2  = " + dr2 + "    cr 2 = " + cr2);


                        data += " " + textBox1.Text + "                     " + d1 + "                                      " + dr1 + "           \n";
                        if (checkBox1.Checked == true)
                        {
                            data += "                               " + d2 + "                                      " + dr2 + "           \n";
                        }
                        data += "\n                                                   " + c1 + "                                         " + cr1 + "            \n";

                        if (checkBox2.Checked == true)
                        {

                            data += "                                                   " + c2 + "                                         " + cr2 + "            \n";
                        }
                        data += "\n";
                        data += " ________________________________________________________________________\n\n\n\n";

                        richTextBox1.Text = data;







                        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





                        if (d1 == "Cash")
                        {
                            cashdr.Add(dr1);
                        }
                        else if (d1 == "A/C Receivable")
                        {
                            acrecdr.Add(dr1);
                        }
                        else if (d1 == "A/C Payable")
                        {
                            acpaydr.Add(dr1);
                        }
                        else if (d1 == "Note Receivable")
                        {
                            noterecdr.Add(dr1);
                        }
                        else if (d1 == "Note Payable")
                        {
                            notepaydr.Add(dr1);
                        }
                        else if (d1 == "Expence")
                        {
                            expdr.Add(dr1);
                        }
                        else if (d1 == "Service")
                        {
                            serdr.Add(dr1);
                        }
                        else if (d1 == "Divideds")
                        {
                            divdr.Add(dr1);
                        }
                        else if (d1 == "Bank")
                        {
                            bandr.Add(dr1);
                        }
                        else if (d1 == "Drawing")
                        {
                            dradr.Add(dr1);
                        }
                        else if (d1 == "Capital stock")
                        {
                            capdr.Add(dr1);
                        }
                        else if (d1 == "Assit")
                        {
                            assdr.Add(dr1);
                        }
                        else if (d1 == "Land")
                        {
                            landr.Add(dr1);
                        }
                        else if (d1 == "Building")
                        {
                            buidr.Add(dr1);
                        }
                        else if (d1 == "Equipments")
                        {
                            eqidr.Add(dr1);
                        }
                        else if (d1 == "Supplies")
                        {
                            supdr.Add(dr1);
                        }
                        else if (d1 == "Merchandise")
                        {
                            merdr.Add(dr1);
                        }
                        else if (d1 == "Vehicle")
                        {
                            vehdr.Add(dr1);
                        }
                        else if (d1 == "Salaries expence")
                        {
                            saldr.Add(dr1);
                        }




                        //=========================================================================================================================




                        if (c1 == "Cash")
                        {
                            cashcr.Add(cr1);
                        }
                        else if (c1 == "A/C Receivable")
                        {
                            acreccr.Add(cr1);
                        }
                        else if (c1 == "A/C Payable")
                        {
                            acpaycr.Add(cr1);
                        }
                        else if (c1 == "Note Receivable")
                        {
                            notereccr.Add(cr1);
                        }
                        else if (c1 == "Note Payable")
                        {
                            notepaycr.Add(cr1);
                        }
                        else if (c1 == "Expence")
                        {
                            expcr.Add(cr1);
                        }
                        else if (c1 == "Service")
                        {
                            sercr.Add(cr1);
                        }
                        else if (c1 == "Divideds")
                        {
                            divcr.Add(cr1);
                        }
                        else if (c1 == "Bank")
                        {
                            bancr.Add(cr1);
                        }
                        else if (c1 == "Drawing")
                        {
                            dracr.Add(cr1);
                        }
                        else if (c1 == "Capital stock")
                        {
                            capcr.Add(cr1);
                        }
                        else if (c1 == "Assit")
                        {
                            asscr.Add(cr1);
                        }
                        else if (c1 == "Land")
                        {
                            lancr.Add(cr1);
                        }
                        else if (c1 == "Building")
                        {
                            buicr.Add(cr1);
                        }
                        else if (c1 == "Equipments")
                        {
                            eqicr.Add(cr1);
                        }
                        else if (c1 == "Supplies")
                        {
                            supcr.Add(cr1);
                        }
                        else if (c1 == "Merchandise")
                        {
                            mercr.Add(cr1);
                        }
                        else if (c1 == "Vehicle")
                        {
                            vehcr.Add(cr1);
                        }
                        else if (c1 == "Salaries expence")
                        {
                            salcr.Add(cr1);
                        }

                        //=========================================================================================================================

                        if (checkBox1.Checked == true)
                        {
                            if (d2 == "Cash")
                            {
                                cashdr.Add(dr2);
                            }
                            else if (d2 == "A/C Receivable")
                            {
                                acrecdr.Add(dr2);
                            }
                            else if (d2 == "A/C Payable")
                            {
                                acpaydr.Add(dr2);
                            }
                            else if (d2 == "Note Receivable")
                            {
                                noterecdr.Add(dr2);
                            }
                            else if (d2 == "Note Payable")
                            {
                                notepaydr.Add(dr2);
                            }
                            else if (d2 == "Expence")
                            {
                                expdr.Add(dr2);
                            }
                            else if (d2 == "Service")
                            {
                                serdr.Add(dr2);
                            }
                            else if (d2 == "Divideds")
                            {
                                divdr.Add(dr2);
                            }
                            else if (d2 == "Bank")
                            {
                                bandr.Add(dr2);
                            }
                            else if (d2 == "Drawing")
                            {
                                dradr.Add(dr2);
                            }
                            else if (d2 == "Capital stock")
                            {
                                capdr.Add(dr2);
                            }
                            else if (d2 == "Assit")
                            {
                                assdr.Add(dr2);
                            }
                            else if (d2 == "Land")
                            {
                                landr.Add(dr2);
                            }
                            else if (d2 == "Building")
                            {
                                buidr.Add(dr2);
                            }
                            else if (d2 == "Equipments")
                            {
                                eqidr.Add(dr2);
                            }
                            else if (d2 == "Supplies")
                            {
                                supdr.Add(dr2);
                            }
                            else if (d2 == "Merchandise")
                            {
                                merdr.Add(dr2);
                            }
                            else if (d2 == "Vehicle")
                            {
                                vehdr.Add(dr2);
                            }
                            else if (d2 == "Salaries expence")
                            {
                                saldr.Add(dr2);
                            }
                        }

                        //=======================================================================================================================

                        if (checkBox2.Enabled == true)
                        {
                            if (c2 == "Cash")
                            {
                                cashcr.Add(cr2);
                            }
                            else if (c2 == "A/C Receivable")
                            {
                                acreccr.Add(cr2);
                            }
                            else if (c2 == "A/C Payable")
                            {
                                acpaycr.Add(cr2);
                            }
                            else if (c2 == "Note Receivable")
                            {
                                notereccr.Add(cr2);
                            }
                            else if (c2 == "Note Payable")
                            {
                                notepaycr.Add(cr2);
                            }
                            else if (c2 == "Expence")
                            {
                                expcr.Add(cr2);
                            }
                            else if (c2 == "Service")
                            {
                                sercr.Add(cr2);
                            }
                            else if (c2 == "Divideds")
                            {
                                divcr.Add(cr2);
                            }
                            else if (c2 == "Bank")
                            {
                                bancr.Add(cr2);
                            }
                            else if (c2 == "Drawing")
                            {
                                dracr.Add(cr2);
                            }
                            else if (c2 == "Capital stock")
                            {
                                capcr.Add(cr2);
                            }
                            else if (c2 == "Assit")
                            {
                                asscr.Add(cr2);
                            }
                            else if (c2 == "Land")
                            {
                                lancr.Add(cr2);
                            }
                            else if (c2 == "Building")
                            {
                                buicr.Add(cr2);
                            }
                            else if (c2 == "Equipments")
                            {
                                eqicr.Add(cr2);
                            }
                            else if (c2 == "Supplies")
                            {
                                supcr.Add(cr2);
                            }
                            else if (c2 == "Merchandise")
                            {
                                mercr.Add(cr2);
                            }
                            else if (c2 == "Vehicle")
                            {
                                vehcr.Add(cr2);
                            }
                            else if (c2 == "Salaries expence")
                            {
                                salcr.Add(cr2);
                            }
                        }


                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        button2.Enabled = true;

                    }
                }
            
            catch
            {
                MessageBox.Show("Select the name of head");
            }


            //=========================================================================================================================
        }

        private void button2_Click(object sender, EventArgs e)
        {




            button3.Enabled = true;
            



            //============================================================================================================================
            //============================================================================================================================


            // Cash
            double cashcountdr = 0;
            double cashcountcr = 0;


            for (int i = 0; i < cashdr.Count; i++)
            {
                cashcountdr += cashdr[i];
            }
            for (int i = 0; i < cashcr.Count; i++)
            {
                cashcountcr += cashcr[i];
            }

            

            if(cashcountcr > cashcountdr)
            {
                cashtotal = cashcountcr - cashcountdr;
                cash = "cr";
            }
            if(cashcountdr > cashcountcr)
            {
                cashtotal = cashcountdr - cashcountcr;
                cash = "dr";
            }




            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // ac rec
            double acreccountdr = 0;
            double acreccountcr = 0;

            

            for (int i = 0; i < acrecdr.Count; i++)
            {
                acreccountdr += acrecdr[i];
            }
            for (int i = 0; i < acreccr.Count; i++)
            {
                acreccountcr += acreccr[i];
            }


            if (acreccountcr > acreccountdr)
            {
                acrectotal = acreccountcr - acreccountdr;
                acrec = "cr";
            }
            if (acreccountdr > acreccountcr)
            {
                acrectotal = acreccountdr - acreccountcr;
                acrec = "dr";
            }




            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // ac payable
            double acpaycountdr = 0;
            double acpaycountcr = 0;



            for (int i = 0; i < acpaydr.Count; i++)
            {
                acpaycountdr += acpaydr[i];
            }
            for (int i = 0; i < acpaycr.Count; i++)
            {
                acpaycountcr += acpaycr[i];
            }


            if (acpaycountcr > acpaycountdr)
            {
                acpaytotal = acpaycountcr - acpaycountdr;
                acpay = "cr";
            }
            if (acpaycountdr > acpaycountcr)
            {
                acpaytotal = acpaycountdr - acpaycountcr;
                acpay = "dr";
            }




            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // note rec
            double notereccountdr = 0;
            double notereccountcr = 0;

            

            for (int i = 0; i < noterecdr.Count; i++)
            {
                notereccountdr += noterecdr[i];
            }
            for (int i = 0; i < notereccr.Count; i++)
            {
                notereccountcr += notereccr[i];
            }


            if (notereccountcr > notereccountdr)
            {
                noterectotal = notereccountcr - notereccountdr;
                noterec = "cr";
            }
            if (notereccountdr > notereccountcr)
            {
                noterectotal = notereccountdr - notereccountcr;
                noterec = "dr";
            }



            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // note payable
            double notepaycountdr = 0;
            double notepaycountcr = 0;

            

            for (int i = 0; i < notepaydr.Count; i++)
            {
                notepaycountdr += notepaydr[i];
            }
            for (int i = 0; i < notepaycr.Count; i++)
            {
                notepaycountcr += notepaycr[i];
            }


            if (notepaycountcr > notepaycountdr)
            {
                notepaytotal = notepaycountcr - notepaycountdr;
                notepay = "cr";
            }
            if (notepaycountdr > notepaycountcr)
            {
                notepaytotal = notepaycountdr - notepaycountcr;
                notepay = "dr";
            }



            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Expence
            double expcountdr = 0;
            double expcountcr = 0;

           

            for (int i = 0; i < expdr.Count; i++)
            {
                expcountdr += expdr[i];
            }
            for (int i = 0; i < expcr.Count; i++)
            {
                expcountcr += expcr[i];
            }


            if (expcountcr > expcountdr)
            {
                exptotal = expcountcr - expcountdr;
                exp = "cr";
            }
            if (expcountdr > expcountcr)
            {
                exptotal = expcountdr - expcountcr;
                exp = "dr";
            }



            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Services
            double sercountdr = 0;
            double sercountcr = 0;

            

            for (int i = 0; i < serdr.Count; i++)
            {
                sercountdr += serdr[i];
            }
            for (int i = 0; i < sercr.Count; i++)
            {
                sercountcr += sercr[i];
            }


            if (sercountcr > sercountdr)
            {
                sertotal = sercountcr - sercountdr;
                ser = "cr";
            }
            if (sercountdr > sercountcr)
            {
                sertotal = sercountdr - sercountcr;
                ser = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Divideds
            double divcountdr = 0;
            double divcountcr = 0;

            

            for (int i = 0; i < divdr.Count; i++)
            {
                divcountdr += divdr[i];
            }
            for (int i = 0; i < divcr.Count; i++)
            {
                divcountcr += divcr[i];
            }


            if (divcountcr > divcountdr)
            {
                divtotal = divcountcr - divcountdr;
                div = "cr";
            }
            if (divcountdr > divcountcr)
            {
                divtotal = divcountdr - divcountcr;
                div = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Bank
            double bancountdr = 0;
            double bancountcr = 0;

            


            for (int i = 0; i < bandr.Count; i++)
            {
                bancountdr += bandr[i];
            }
            for (int i = 0; i < bancr.Count; i++)
            {
                bancountcr += bancr[i];
            }


            if (bancountcr > bancountdr)
            {
                bantotal = bancountcr - bancountdr;
                ban = "cr";
            }
            if (bancountdr > bancountcr)
            {
                bantotal = bancountdr - bancountcr;
                ban = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Drawing
            double dracountdr = 0;
            double dracountcr = 0;

            


            for (int i = 0; i < dradr.Count; i++)
            {
                dracountdr += dradr[i];
            }
            for (int i = 0; i < dracr.Count; i++)
            {
                dracountcr += dracr[i];
            }


            if (dracountcr > dracountdr)
            {
                dratotal = dracountcr - dracountdr;
                dra = "cr";
            }
            if (dracountdr > dracountcr)
            {
                dratotal = dracountdr - dracountcr;
                dra = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Captial Stock
            double capcountdr = 0;
            double capcountcr = 0;

            


            for (int i = 0; i < capdr.Count; i++)
            {
                capcountdr += capdr[i];
            }
            for (int i = 0; i < capcr.Count; i++)
            {
                capcountcr += capcr[i];
            }


            if (capcountcr > capcountdr)
            {
                captotal = capcountcr - capcountdr;
                cap = "cr";
            }
            if (capcountdr > capcountcr)
            {
                captotal = capcountdr - capcountcr;
                cap = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Assest
            double asscountdr = 0;
            double asscountcr = 0;

            


            for (int i = 0; i < assdr.Count; i++)
            {
                asscountdr += assdr[i];
            }
            for (int i = 0; i < asscr.Count; i++)
            {
                asscountcr += asscr[i];
            }


            if (asscountcr > asscountdr)
            {
                asstotal = asscountcr - asscountdr;
                ass = "cr";
            }
            if (asscountdr > asscountcr)
            {
                asstotal = asscountdr - asscountcr;
                ass = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Land
            double lancountdr = 0;
            double lancountcr = 0;

           


            for (int i = 0; i < landr.Count; i++)
            {
                lancountdr += landr[i];
            }
            for (int i = 0; i < lancr.Count; i++)
            {
                lancountcr += lancr[i];
            }


            if (lancountcr > lancountdr)
            {
                lantotal = lancountcr - lancountdr;
                lan = "cr";
            }
            if (lancountdr > lancountcr)
            {
                lantotal = lancountdr - lancountcr;
                lan = "dr";
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // building
            double buicountdr = 0;
            double buicountcr = 0;

            


            for (int i = 0; i < buidr.Count; i++)
            {
                buicountdr += buidr[i];
            }
            for (int i = 0; i < buicr.Count; i++)
            {
                buicountcr += buicr[i];
            }


            if (buicountcr > buicountdr)
            {
                buitotal = buicountcr - buicountdr;
                bui = "cr";
            }
            if (buicountdr > buicountcr)
            {
                buitotal = buicountdr - buicountcr;
                bui = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // equipments
            double eqicountdr = 0;
            double eqicountcr = 0;

            


            for (int i = 0; i < eqidr.Count; i++)
            {
                eqicountdr += eqidr[i];
            }
            for (int i = 0; i < eqicr.Count; i++)
            {
                eqicountcr += eqicr[i];
            }


            if (eqicountcr > eqicountdr)
            {
                eqitotal = eqicountcr - eqicountdr;
                eqi = "cr";
            }
            if (eqicountdr > eqicountcr)
            {
                eqitotal = eqicountdr - eqicountcr;
                eqi = "dr";
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // supplies
            double supcountdr = 0;
            double supcountcr = 0;

            


            for (int i = 0; i < supdr.Count; i++)
            {
                supcountdr += supdr[i];
            }
            for (int i = 0; i < supcr.Count; i++)
            {
                supcountcr += supcr[i];
            }


            if (supcountcr > supcountdr)
            {
                suptotal = supcountcr - supcountdr;
                sup = "cr";
            }
            if (supcountdr > supcountcr)
            {
                suptotal = supcountdr - supcountcr;
                sup = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // merchandise
            double mercountdr = 0;
            double mercountcr = 0;

          


            for (int i = 0; i < merdr.Count; i++)
            {
                mercountdr += merdr[i];
            }
            for (int i = 0; i < mercr.Count; i++)
            {
                mercountcr += mercr[i];
            }


            if (mercountcr > mercountdr)
            {
                mertotal = mercountcr - mercountdr;
                mer = "cr";
            }
            if (mercountdr > mercountcr)
            {
                mertotal = mercountdr - mercountcr;
                mer = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // vehciles
            double vehcountdr = 0;
            double vehcountcr = 0;

            


            for (int i = 0; i < vehdr.Count; i++)
            {
                vehcountdr += vehdr[i];
            }
            for (int i = 0; i < vehcr.Count; i++)
            {
                vehcountcr += vehcr[i];
            }


            if (vehcountcr > vehcountdr)
            {
                vehtotal = vehcountcr - vehcountdr;
                veh = "cr";
            }
            if (vehcountdr > vehcountcr)
            {
                vehtotal = vehcountdr - vehcountcr;
                veh = "dr";
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // salaries
            double salcountdr = 0;
            double salcountcr = 0;

            


            for (int i = 0; i < saldr.Count; i++)
            {
                salcountdr += saldr[i];
            }
            for (int i = 0; i < salcr.Count; i++)
            {
                salcountcr += salcr[i];
            }


            if (salcountcr > salcountdr)
            {
                saltotal = salcountcr - salcountdr;
                sal = "cr";
            }
            if (salcountdr > salcountcr)
            {
                saltotal = salcountdr - salcountcr;
                sal = "dr";
            }


            string show = "              T-Accounts Solution\n\n\n";

            show += ("Cash                            =  " + cashtotal + "    " + cash)+"\n";
            show += ("Note payable             =  " + notepaytotal + "    " + notepay)+"\n";
            show += ("Note receivable         =  " + noterectotal + "    " + noterec)+"\n";
            show += ("Account payable       =  " + acpaytotal + "    " + acpay)+"\n";
            show += ("Account receivable    =  " + acrectotal + "    " + acrec) + "\n";
            show += ("Expences                      =  " + exptotal + "    " + exp)+"\n";
            show += ("Services                       =  " + sertotal + "    " + ser)+"\n";
            show += ("divided                        =  " + divtotal + "    " + div)+"\n";
            show += ("Bank                            =  " + bantotal + "    " + ban) + "\n";
            show += ("Drawing                      =  " + dratotal + "    " + dra) + "\n";
            show += ("Capital stock              =  " + captotal + "    " + cap) + "\n";
            show += ("Assest                         =  " + asstotal + "    " + ass) + "\n";
            show += ("Land                            =  " + lantotal + "    " + lan) + "\n";
            show += ("Building                      =  " + buitotal + "    " + bui) + "\n";
            show += ("Equipments                =  " + eqitotal + "    " + eqi) + "\n";
            show += ("Supplies                      =  " + suptotal + "    " + sup) + "\n";
            show += ("Merchandise              =  " + mertotal + "    " + mer) + "\n";
            show += ("Vehciles                       =  " + vehtotal + "    " + veh) + "\n";
            show += ("Salaries                        =  " + saltotal + "    " + sal) + "\n";

            MessageBox.Show(show);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double totaldr = 0;
            double totalcr = 0;

            string traildata = "                                                    Trail balance         \n";
            traildata += "__________________________________________________________________________\n";
            traildata += "    Particulars                      Debit                              Credit\n";
            traildata += "__________________________________________________________________________\n";




            //===============================================================================================================================


            balancesheetdata += "      Assests:           \n";


            //===============================================================================================================================

            if(cash=="dr")
            {
                traildata += "    Cash                                "+cashtotal+"                    \n";
                totaldr += cashtotal;

                balancesheetdata += "                 Cash  =  " +cashtotal+"\n";
                balanceassest.Add(cashtotal);
            }
            else
            {
                traildata += "    Cash                                                                              "+cashtotal+"    \n";
                totalcr += cashtotal;

                balancesheetdata += "                 Cash  =  " + cashtotal + "\n";
                balanceassest.Add(cashtotal);
            }


            //===============================================================================================================================

            if (acrec == "dr")
            {
                traildata += "    Account receiveable                " + acrectotal + "                    \n";
                totaldr += acrectotal;

                balancesheetdata += "                 Account receiable  =  " + acrectotal + "\n";
                balanceassest.Add(acrectotal);
            }
            else
            {
                traildata += "    Account receiveable                                                   " + acrectotal + "    \n";
                totalcr += acrectotal;

                balancesheetdata += "                 Account receiable  =  " + acrectotal + "\n";
                balanceassest.Add(acrectotal);
            }



            //===============================================================================================================================

            if (noterec == "dr")
            {
                traildata += "    Note receiveable                      " + noterectotal + "                    \n";
                totaldr += noterectotal;

                balancesheetdata += "                 Note receiable  =  " + noterectotal + "\n";
                balanceassest.Add(noterectotal);
            }
            else
            {
                traildata += "    Note receiveable                                                         " + noterectotal + "    \n";
                totalcr += noterectotal;

                balancesheetdata += "                 Note receiable  =  " + noterectotal + "\n";
                balanceassest.Add(noterectotal);
            }

            //===============================================================================================================================
            incomedata += "      Revenue:          \n";

            if (ser == "dr")
            {
                traildata += "    Services                      " + sertotal + "                    \n";
                totaldr += sertotal;

                incomedata += "                  Revenue      =    " + sertotal + "\n";
                incomerevenue.Add(sertotal);
            }
            else
            {
                traildata += "    Service                                                                          " + sertotal + "    \n";
                totalcr += sertotal;

                incomedata += "                  Revenue      =    " + sertotal + "\n";
                incomerevenue.Add(sertotal);
            }

            //===============================================================================================================================
            incomedata += "  less  Expence:          \n";

            if (exp == "dr")
            {
                traildata += "    Expence                         " + exptotal + "                    \n";
                totaldr += exptotal;

                incomedata += "                  Expences     =    " + exptotal + "\n";
                incomeExpence.Add(exptotal);
            }
            else
            {
                traildata += "    Expence                                                                        " + exptotal + "    \n";
                totalcr += exptotal;

                incomedata += "                  Expences     =    " + exptotal + "\n";
                incomeExpence.Add(exptotal);
            }

            //===============================================================================================================================

            if (div == "dr")
            {
                traildata += "    Dividend                       " + divtotal + "                    \n";
                totaldr += divtotal;
            }
            else
            {
                traildata += "    Dividend                                                                       " + divtotal + "    \n";
                totalcr += divtotal;
            }

            // =============================================================================================================================

            if (ban == "dr")
            {
                traildata += "    Bank                                " + bantotal + "                    \n";
                totaldr += bantotal;

                balancesheetdata += "                 Bank  =  " + bantotal + "\n";
                balanceassest.Add(bantotal);
            }
            else
            {
                traildata += "    Bank                                                                              " + bantotal + "    \n";
                totalcr += bantotal;

                balancesheetdata += "                 Bank  =  " + bantotal + "\n";
                balanceassest.Add(bantotal);

            }

            //===============================================================================================================================



            if (dra == "dr")
            {
                traildata += "    Drawing                               " + dratotal + "                    \n";
                totaldr += dratotal;
            }
            else
            {
                traildata += "    Drawing                                                                        " + dratotal + "    \n";
                totalcr += dratotal;
            }



            //===============================================================================================================================


            if (ass == "dr")
            {
                traildata += "    Assest                                " + asstotal + "                    \n";
                totaldr += asstotal;

                balancesheetdata += "                 Assest  =  " + asstotal + "\n";
                balanceassest.Add(asstotal);
            }
            else
            {
                traildata += "    Assest                                                                            " + asstotal + "    \n";
                totalcr += asstotal;

                balancesheetdata += "                 Assest  =  " + asstotal + "\n";
                balanceassest.Add(asstotal);
            }

            //===============================================================================================================================



            if (lan == "dr")
            {
                traildata += "    Land                                " + lantotal + "                    \n";
                totaldr += lantotal;

                balancesheetdata += "                 Land  =  " + lantotal + "\n";
                balanceassest.Add(lantotal);
            }
            else
            {
                traildata += "    Land                                                                              " + lantotal + "    \n";
                totalcr += lantotal;

                balancesheetdata += "                 Land  =  " + lantotal + "\n";
                balanceassest.Add(lantotal);
            }

            //===============================================================================================================================


            if (bui == "dr")
            {
                traildata += "    Building                             " + buitotal + "                    \n";
                totaldr += buitotal;

                balancesheetdata += "                 Building  =  " + buitotal + "\n";
                balanceassest.Add(buitotal);
            }
            else
            {
                traildata += "    Building                                                                        " + buitotal + "    \n";
                totalcr += buitotal;

                balancesheetdata += "                 Building  =  " + buitotal + "\n";
                balanceassest.Add(buitotal);
            }

            //===============================================================================================================================

            if (eqi == "dr")
            {
                traildata += "    Equipments                           " + eqitotal + "                    \n";
                totaldr += eqitotal;

                balancesheetdata += "                 Equipments  =  " + eqitotal + "\n";
                balanceassest.Add(eqitotal);
            }
            else
            {
                traildata += "    Equipments                                                                  " + eqitotal + "    \n";
                totalcr += eqitotal;

                balancesheetdata += "                 Equipments  =  " + eqitotal + "\n";
                balanceassest.Add(eqitotal);
            }

            //===============================================================================================================================

            if (sup == "dr")
            {
                traildata += "    Supplies                                " + suptotal + "                    \n";
                totaldr += suptotal;

                balancesheetdata += "                 Supplies  =  " + suptotal + "\n";
                balanceassest.Add(suptotal);
            }
            else
            {
                traildata += "    Supplies                                                                        " + suptotal + "    \n";
                totalcr += suptotal;

                balancesheetdata += "                 Supplies  =  " + suptotal + "\n";
                balanceassest.Add(suptotal);
            }



            //===============================================================================================================================

            if (mer == "dr")
            {
                traildata += "    Merchandise                            " + mertotal + "                    \n";
                totaldr += mertotal;

                balancesheetdata += "                 Merchandise  =  " + mertotal + "\n";
                balanceassest.Add(mertotal);
            }
            else
            {
                traildata += "    Merchandise                                                                 " + mertotal + "    \n";
                totalcr += mertotal;

                balancesheetdata += "                 Merchandise  =  " + mertotal + "\n";
                balanceassest.Add(mertotal);
            }

            //===============================================================================================================================


            if (veh == "dr")
            {
                traildata += "    Vechiles                             " + vehtotal + "                    \n";
                totaldr += vehtotal;

                balancesheetdata += "                 Vechiles  =  " + vehtotal + "\n";
                balanceassest.Add(vehtotal);
            }
            else
            {
                traildata += "    Vechiles                                                                         " + vehtotal + "    \n";
                totalcr += vehtotal;

                balancesheetdata += "                 Vechiles  =  " + vehtotal + "\n";
                balanceassest.Add(vehtotal);
            }

            //===============================================================================================================================

            if (sal == "dr")
            {
                traildata += "    Salaries                                " + saltotal + "                    \n";
                totaldr += saltotal;

                incomedata += "                  Salaries Expences     =    " + saltotal + "\n";
                incomeExpence.Add(saltotal);
            }
            else
            {
                traildata += "    Salaries                                                                          " + saltotal + "    \n";
                totalcr += saltotal;

                incomedata += "                  Salaries Expences     =    " + saltotal + "\n";
                incomeExpence.Add(saltotal);
            }




            //===============================================================================================================================


            balancesheetdata += "\n\n      Liabilities:           \n";


            //===============================================================================================================================

            if (acpay == "dr")
            {
                traildata += "    Account payable                   " + acpaytotal + "                    \n";
                totaldr += acpaytotal;

                balancesheetdata += "                 Account payable  =  " + acpaytotal + "\n";
                balanceliability.Add(acpaytotal);
            }
            else
            {
                traildata += "    Account payable                                                         " + acpaytotal + "    \n";
                totalcr += acpaytotal;

                balancesheetdata += "                 Account payable  =  " + acpaytotal + "\n";
                balanceliability.Add(acpaytotal);
            }


            //===============================================================================================================================

            if (notepay == "dr")
            {
                traildata += "    Note payable                     " + notepaytotal + "                    \n";
                totaldr += notepaytotal;

                balancesheetdata += "                 Note payable  =  " + notepaytotal + "\n";
                balanceliability.Add(notepaytotal);
            }
            else
            {
                traildata += "    Note payable                                                               " + notepaytotal + "    \n";
                totalcr += notepaytotal;

                balancesheetdata += "                 Note payable  =  " + notepaytotal + "\n";
                balanceliability.Add(notepaytotal);
            }



            //===============================================================================================================================

            balancesheetdata += "\n\n      Capital stock:           \n";

            //===============================================================================================================================


            if (cap == "dr")
            {
                traildata += "    Capital stock                                " + captotal + "                    \n";
                totaldr += captotal;

                balancesheetdata += "                 Capital stock  =  " + captotal + "\n";
                balanceowner.Add(captotal);
            }
            else
            {
                traildata += "    Capital stock                                                                " + captotal + "    \n";
                totalcr += captotal;

                balancesheetdata += "                 Capital stock  =  " + captotal + "\n";
                balanceowner.Add(captotal);
            }






            traildata += "\n\n    Balance                                "+totaldr+"                                      "+totalcr+"\n";
            MessageBox.Show(traildata);



            //===============================================================================================================================
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double re = 0;
            double ex = 0;
            double net = 0;

            for (int i = 0; i < incomeExpence.Count; i++)
            {
                ex += incomeExpence[i];
            }
            for (int i = 0; i < incomerevenue.Count; i++)
            {
                re += incomerevenue[i];
            }


            if(re > ex )
            {
                net = re - ex;
                incomedata += "\n\n Net Income  =  " + net + "    Profit";
            }
            if(ex > re)
            {
                net = ex - re;
                incomedata += "\n\n Net Income  =  " + net + "    Loss";
            }

            MessageBox.Show(incomedata);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            double asseststotal = 0;
            double liabilitytotal = 0;
            double ownerequitytotal = 0;
            double combine = 0;


            //=========================================================================================================================


            for (int i = 0; i < balanceassest.Count; i++)
            {
                asseststotal += balanceassest[i];
            }


            balancesheetdata += "\n                                 Assest total =  " + asseststotal + "\n";







            for (int i = 0; i < balanceliability.Count; i++)
            {
                liabilitytotal += balanceliability[i];
            }

            
            balancesheetdata += "\n                           Liabilty total =  " + liabilitytotal + "\n";







            for (int i = 0; i < balanceowner.Count; i++)
            {
                ownerequitytotal += balanceowner[i];
            }


            balancesheetdata += "\n                           Owner equity =  " + ownerequitytotal + "\n";


            combine = liabilitytotal + ownerequitytotal;

            balancesheetdata += "\n                                   Value =  " + combine + "\n";


            MessageBox.Show(balancesheetdata);
        }
    }
}
