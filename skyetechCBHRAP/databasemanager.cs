using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyetechCBHRAP
{
    public partial class databasemanager : Form
    {
        //Dataconnection
        // OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\cbhrapdatatest.accdb"); //TEST CONNECTION
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\cbhrapdatatest.accdb");

        //String Declaration

        //DISPLAY ALL INFORMATION QUERY

        string sqlquerycommand;
        string strangeles = "SELECT * FROM tbl_angeles";
        string strbalubad = "SELECT * FROM tbl_balubad";
        string strbalugohin = "SELECT * FROM tbl_balugohin";
        string strbuhangin = "SELECT * FROM tbl_buhangin";
        string strcaridadibaba = "SELECT * FROM tbl_caridad_ibaba";
        string strcaridadilaya = "SELECT * FROM tbl_caridad_ilaya";
        string strhabingan = "SELECT * FROM tbl_habingan";
        string strinaclagan = "SELECT * FROM tbl_inaclagan";
        string strinalig = "SELECT * FROM tbl_inalig";
        string strkilait = "SELECT * FROM tbl_kilait";
        string strkulawit = "SELECT * FROM tbl_kulawit";
        string strlakip = "SELECT * FROM tbl_lakip";
        string strlubi = "SELECT * FROM tbl_lubi";
        string strlumutan = "SELECT * FROM tbl_lumutan ";
        string strmagsaysay = "SELECT * FROM tbl_magsaysay";
        string strmalinaoibaba = "SELECT * FROM tbl_malinao_ibaba";
        string strmalinaoilaya = "SELECT * FROM tbl_malinao_ilaya";
        string strmalusak = "SELECT * FROM tbl_malusak";
        string strmanggalayanbundok = "SELECT * FROM tbl_manggalayan_bundok";
        string strmanggalayanlabak = "SELECT * FROM tbl_manggalayan_labak";
        string strmatanag = "SELECT * FROM tbl_matanag";
        string strmontesbalaon = "SELECT * FROM tbl_montes_balaon";
        string strmonteskallagan = "SELECT * FROM tbl_montes_kallagan";
        string strponon = "SELECT * FROM tbl_ponon";
        string strrizal = "SELECT * FROM tbl_rizal";
        string strsanandresbundok = "SELECT * FROM tbl_san_andres_bundok";
        string strsanandreslabak = "SELECT * FROM tbl_san_andres_labak";
        string strsanisidro = "SELECT * FROM tbl_san_isidro";
        string strsanjosebalatok = "SELECT * FROM tbl_san_jose_balatok";
        string strsanrafael = "SELECT * FROM tbl_san_rafael";
        string strsantacatalina = "SELECT * FROM tbl_santa_catalina";
        string strsapaan = "SELECT * FROM tbl_sapaan";
        string strsokol = "SELECT * FROM tbl_sokol";
        string strtagbakin = "SELECT * FROM tbl_tagbakin";
        string strtalaba = "SELECT * FROM tbl_talaba";
        string strtinandog = "SELECT * FROM tbl_tinandog";
        string strvillaibaba = "SELECT * FROM tbl_villa_ibaba";
        string strvillailaya = "SELECT * FROM tbl_villa_ilaya";
        string strzonei = "SELECT * FROM tbl_zone_i_pob";
        string strzoneii = "SELECT * FROM tbl_zone_ii_pob";
        string strzoneiii = "SELECT * FROM tbl_zone_iii_pob";
        string strzoneiv = "SELECT * FROM tbl_zone_iv_pob";

        //UPDATE QUERY

        string Usqlquerycommand;
        string Ustrangeles = "UPDATE tbl_angeles SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrbalubad = "UPDATE tbl_balubad SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrbalugohin = "UPDATE tbl_balugohin SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrbuhangin = "UPDATE tbl_buhangin SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrcaridadibaba = "UPDATE tbl_caridad_ibaba SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrcaridadilaya = "UPDATE tbl_caridad_ilaya SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrhabingan = "UPDATE tbl_habingan SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrinaclagan = "UPDATE tbl_inaclagan SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrinalig = "UPDATE tbl_inalig SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrkilait = "UPDATE tbl_kilait SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrkulawit = "UPDATE tbl_kulawit SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrlakip = "UPDATE tbl_lakip SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrlubi = "UPDATE tbl_lubi SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrlumutan = "UPDATE tbl_lumutan SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmagsaysay = "UPDATE tbl_magsaysay SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmalinaoibaba = "UPDATE tbl_malinao_ibaba SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmalinaoilaya = "UPDATE tbl_malinao_ilaya SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmalusak = "UPDATE tbl_malusak SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmanggalayanbundok = "UPDATE tbl_manggalayan_bundok SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmanggalayanlabak = "UPDATE tbl_manggalayan_labak SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmatanag = "UPDATE tbl_matanag SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmontesbalaon = "UPDATE tbl_montes_balaon SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrmonteskallagan = "UPDATE tbl_montes_kallagan SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrponon = "UPDATE tbl_ponon SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrrizal = "UPDATE tbl_rizal SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsanandresbundok = "UPDATE tbl_san_andres_bundok SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsanandreslabak = "UPDATE tbl_san_andres_labak SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsanisidro = "UPDATE tbl_san_isidro SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsanjosebalatok = "UPDATE tbl_san_jose_balatok SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsanrafael = "UPDATE tbl_san_rafael SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsantacatalina = "UPDATE tbl_santa_catalina SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsapaan = "UPDATE tbl_sapaan SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrsokol = "UPDATE tbl_sokol SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrtagbakin = "UPDATE tbl_tagbakin SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrtalaba = "UPDATE tbl_talaba SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrtinandog = "UPDATE tbl_tinandog SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrvillaibaba = "UPDATE tbl_villa_ibaba SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrvillailaya = "UPDATE tbl_villa_ilaya SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrzonei = "UPDATE tbl_zone_i_pob SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrzoneii = "UPDATE tbl_zone_ii_pob SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrzoneiii = "UPDATE tbl_zone_iii_pob SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";
        string Ustrzoneiv = "UPDATE tbl_zone_iv_pob SET INFANT = @INFANT, ADULT = @ADULT, [SENIOR CITIZEN] = [@SENIOR CITIZEN], MALE = @MALE, FEMALE = @FEMALE";

        public databasemanager()
        {
            InitializeComponent();
        }

        public void conditionalbranches()
        {
            switch (txt_barangay.Text)
            {
                case "Angeles":
                    sqlquerycommand = strangeles;
                    Usqlquerycommand = Ustrangeles;
                    break;
                case "Balubad":
                    sqlquerycommand = strbalubad;
                    Usqlquerycommand = Ustrbalubad;
                    break;
                case "Balugohin":
                    sqlquerycommand = strbalugohin;
                    Usqlquerycommand = Ustrbalugohin;
                    break;
                case "Buhangin":
                    sqlquerycommand = strbuhangin;
                    Usqlquerycommand = Ustrbuhangin;
                    break;
                case "Caridad Ibaba":
                    sqlquerycommand = strcaridadibaba;
                    Usqlquerycommand = Ustrcaridadibaba;
                    break;
                case "Caridad Ilaya":
                    sqlquerycommand = strcaridadilaya;
                    Usqlquerycommand = Ustrcaridadilaya;
                    break;
                case "Habingan":
                    sqlquerycommand = strhabingan;
                    Usqlquerycommand = Ustrhabingan;
                    break;
                case "Inaclagan":
                    sqlquerycommand = strinaclagan;
                    Usqlquerycommand = Ustrinaclagan;
                    break;
                case "Inalig":
                    sqlquerycommand = strinalig;
                    Usqlquerycommand = Ustrinalig;
                    break;
                case "Kilait":
                    sqlquerycommand = strkilait;
                    Usqlquerycommand = Ustrkilait;
                    break;
                case "Kulawit":
                    sqlquerycommand = strkulawit;
                    Usqlquerycommand = Ustrkulawit;
                    break;
                case "Lakip":
                    sqlquerycommand = strlakip;
                    Usqlquerycommand = Ustrlakip;
                    break;
                case "Lubi":
                    sqlquerycommand = strlubi;
                    Usqlquerycommand = Ustrlubi;
                    break;
                case "Lumutan":
                    sqlquerycommand = strlumutan;
                    Usqlquerycommand = Ustrlumutan;
                    break;
                case "Magsaysay":
                    sqlquerycommand = strmagsaysay;
                    Usqlquerycommand = Ustrmagsaysay;
                    break;
                case "Malinao Ibaba":
                    sqlquerycommand = strmalinaoibaba;
                    Usqlquerycommand = Ustrmalinaoibaba;
                    break;
                case "Malinao Ilaya":
                    sqlquerycommand = strmalinaoilaya;
                    Usqlquerycommand = Ustrmalinaoilaya;
                    break;
                case "Malusak":
                    sqlquerycommand = strmalusak;
                    Usqlquerycommand = Ustrmalusak;
                    break;
                case "Manggalayan Bundok":
                    sqlquerycommand = strmanggalayanbundok;
                    Usqlquerycommand = Ustrmanggalayanbundok;
                    break;
                case "Manggalayan Labak":
                    sqlquerycommand = strmanggalayanlabak;
                    Usqlquerycommand = Ustrmanggalayanlabak;
                    break;
                case "Matanag":
                    sqlquerycommand = strmatanag;
                    Usqlquerycommand = Ustrmatanag;
                    break;
                case "Montes Balaon":
                    sqlquerycommand = strmontesbalaon;
                    Usqlquerycommand = Ustrmontesbalaon;
                    break;
                case "Montes Kallagan":
                    sqlquerycommand = strmonteskallagan;
                    Usqlquerycommand = Ustrmonteskallagan;
                    break;
                case "Ponon":
                    sqlquerycommand = strponon;
                    Usqlquerycommand = Ustrponon;
                    break;
                case "Rizal":
                    sqlquerycommand = strrizal;
                    Usqlquerycommand = Ustrrizal;
                    break;
                case "San Andres Bundok":
                    sqlquerycommand = strsanandresbundok;
                    Usqlquerycommand = Ustrsanandresbundok;
                    break;
                case "San Andres Labak":
                    sqlquerycommand = strsanandreslabak;
                    Usqlquerycommand = Ustrsanandreslabak;
                    break;
                case "San Isidro":
                    sqlquerycommand = strsanisidro;
                    Usqlquerycommand = Ustrsanisidro;
                    break;
                case "San Jose Balatok":
                    sqlquerycommand = strsanjosebalatok;
                    Usqlquerycommand = Ustrsanjosebalatok;
                    break;
                case "San Rafael":
                    sqlquerycommand = strsanrafael;
                    Usqlquerycommand = Ustrsanrafael;
                    break;
                case "Sta. Catalina":
                    sqlquerycommand = strsantacatalina;
                    Usqlquerycommand = Ustrsantacatalina;
                    break;
                case "Sapaan":
                    sqlquerycommand = strsapaan;
                    Usqlquerycommand = Ustrsapaan;
                    break;
                case "Sokol":
                    sqlquerycommand = strsokol;
                    Usqlquerycommand = Ustrsokol;
                    break;
                case "Tagbakin":
                    sqlquerycommand = strtagbakin;
                    Usqlquerycommand = Ustrtagbakin;
                    break;
                case "Talaba":
                    sqlquerycommand = strtalaba;
                    Usqlquerycommand = Ustrtalaba;
                    break;
                case "Tinandog":
                    sqlquerycommand = strtinandog;
                    Usqlquerycommand = Ustrtinandog;
                    break;
                case "Villa Ibaba":
                    sqlquerycommand = strvillaibaba;
                    Usqlquerycommand = Ustrvillaibaba;
                    break;
                case "Villa Ilaya":
                    sqlquerycommand = strvillailaya;
                    Usqlquerycommand = Ustrvillailaya;
                    break;
                case "Zone I Poblacion":
                    sqlquerycommand = strzonei;
                    Usqlquerycommand = Ustrzonei;
                    break;
                case "Zone II Poblacion":
                    sqlquerycommand = strzoneii;
                    Usqlquerycommand = Ustrzoneii;
                    break;
                case "Zone III Poblacion":
                    sqlquerycommand = strzoneiii;
                    Usqlquerycommand = Ustrzoneiii;
                    break;
                case "Zone IV Poblacion":
                    sqlquerycommand = strzoneiv;
                    Usqlquerycommand = Ustrzoneiv;
                    break;
            }
        }

        private void dropdown_barangaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TO FILTER THE DROPDOWN STRINGS TO TEXTBOX STRINGS FOR EASIER CONVERSION
            txt_barangay.Text = dropdown_barangaylist.SelectedItem.ToString();
        }

        private void SearchData(string search)
        {
            conditionalbranches();
            //THIS IS TO SHOW DATA IN TEXT BOXES FOR EDITING
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sqlquerycommand, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                input_infant.Text = reader["INFANT"].ToString();
                input_adult.Text = reader["ADULT"].ToString();
                input_seniorcitizen.Text = reader["SENIOR CITIZEN"].ToString();
                input_male.Text = reader["MALE"].ToString();
                input_female.Text = reader["FEMALE"].ToString();
            }
            conn.Close();
        }

        private void btn_initiatedata_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_barangay.Text))
            {
                MessageBox.Show("Please select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //SHOW ALL CONTENTS
                SearchData(txt_barangay.Text);

                //SHOW BARANGAY NAME IN TITLE
                display_barangayname.Text = txt_barangay.Text;

                //ENABLE SUBMIT BUTTON
                btn_update.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //CHECK FOR ANY BLANK TEXTBOXES
            if (string.IsNullOrWhiteSpace(input_infant.Text) ||
                (string.IsNullOrWhiteSpace(input_adult.Text) ||
                (string.IsNullOrWhiteSpace(input_seniorcitizen.Text) ||
                (string.IsNullOrWhiteSpace(input_male.Text) ||
                (string.IsNullOrWhiteSpace(input_female.Text))))))
            {
                MessageBox.Show("Field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //THIS WILL UPDATE THE RECORD
                conditionalbranches();
                conn.Close();
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(Usqlquerycommand, conn))
                {
                    cmd.Parameters.AddWithValue("@INFANT", input_infant.Text);
                    cmd.Parameters.AddWithValue("@ADULT", input_adult.Text);
                    cmd.Parameters.AddWithValue("[@SENIOR CITIZEN]", input_seniorcitizen.Text);
                    cmd.Parameters.AddWithValue("@MALE", input_male.Text);
                    cmd.Parameters.AddWithValue("@FEMALE", input_female.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Total population updated", "Record Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //THIS WILL CLEAR ALL COMPONENTS AND RESTART THE FORM
                    this.Controls.Clear();
                    this.InitializeComponent();
                }
            }
        }
    }
}
