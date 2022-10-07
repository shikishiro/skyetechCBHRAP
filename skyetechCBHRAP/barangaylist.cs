using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace skyetechCBHRAP
{
    public partial class barangaylist : Form
    {
        //Dataconnection
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\cbhrapdatatest.accdb");

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

        //TOTAL POPULATION QUERY

        string Tsqlquerycommand;
        string Tstrangeles = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_angeles";
        string Tstrbalubad = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_balubad";
        string Tstrbalugohin = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_balugohin";
        string Tstrbuhangin = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_buhangin";
        string Tstrcaridadibaba = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_caridad_ibaba";
        string Tstrcaridadilaya = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_caridad_ilaya";
        string Tstrhabingan = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_habingan";
        string Tstrinaclagan = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_inaclagan";
        string Tstrinalig = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_inalig";
        string Tstrkilait = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_kilait";
        string Tstrkulawit = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_kulawit";
        string Tstrlakip = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_lakip";
        string Tstrlubi = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_lubi";
        string Tstrlumutan = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_lumutan ";
        string Tstrmagsaysay = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_magsaysay";
        string Tstrmalinaoibaba = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_malinao_ibaba";
        string Tstrmalinaoilaya = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_malinao_ilaya";
        string Tstrmalusak = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_malusak";
        string Tstrmanggalayanbundok = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_manggalayan_bundok";
        string Tstrmanggalayanlabak = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_manggalayan_labak";
        string Tstrmatanag = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_matanag";
        string Tstrmontesbalaon = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_montes_balaon";
        string Tstrmonteskallagan = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_montes_kallagan";
        string Tstrponon = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_ponon";
        string Tstrrizal = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_rizal";
        string Tstrsanandresbundok = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_andres_bundok";
        string Tstrsanandreslabak = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_andres_labak";
        string Tstrsanisidro = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_isidro";
        string Tstrsanjosebalatok = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_jose_balatok";
        string Tstrsanrafael = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_rafael";
        string Tstrsantacatalina = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_santa_catalina";
        string Tstrsapaan = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_sapaan";
        string Tstrsokol = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_sokol";
        string Tstrtagbakin = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_tagbakin";
        string Tstrtalaba = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_talaba";
        string Tstrtinandog = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_tinandog";
        string Tstrvillaibaba = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_villa_ibaba";
        string Tstrvillailaya = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_villa_ilaya";
        string Tstrzonei = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_i_pob";
        string Tstrzoneii = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_ii_pob";
        string Tstrzoneiii = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_iii_pob";
        string Tstrzoneiv = "SELECT INFANT + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_iv_pob";

        public barangaylist()
        {
            InitializeComponent();
        }

        public void conditionalbranches()
        {
            switch (txt_barangay.Text)
            {
                case "Angeles":
                    sqlquerycommand = strangeles;
                    Tsqlquerycommand = Tstrangeles;
                    break;
                case "Balubad":
                    sqlquerycommand = strbalubad;
                    Tsqlquerycommand = Tstrbalubad;
                    break;
                case "Balugohin":
                    sqlquerycommand = strbalugohin;
                    Tsqlquerycommand = Tstrbalugohin;
                    break;
                case "Buhangin":
                    sqlquerycommand = strbuhangin;
                    Tsqlquerycommand = Tstrbuhangin;
                    break;
                case "Caridad Ibaba":
                    sqlquerycommand = strcaridadibaba;
                    Tsqlquerycommand = Tstrcaridadibaba;
                    break;
                case "Caridad Ilaya":
                    sqlquerycommand = strcaridadilaya;
                    Tsqlquerycommand = Tstrcaridadilaya;
                    break;
                case "Habingan":
                    sqlquerycommand = strhabingan;
                    Tsqlquerycommand = Tstrhabingan;
                    break;
                case "Inaclagan":
                    sqlquerycommand = strinaclagan;
                    Tsqlquerycommand = Tstrinaclagan;
                    break;
                case "Inalig":
                    sqlquerycommand = strinalig;
                    Tsqlquerycommand = Tstrinalig;
                    break;
                case "Kilait":
                    sqlquerycommand = strkilait;
                    Tsqlquerycommand = Tstrkilait;
                    break;
                case "Kulawit":
                    sqlquerycommand = strkulawit;
                    Tsqlquerycommand = Tstrkulawit;
                    break;
                case "Lakip":
                    sqlquerycommand = strlakip;
                    Tsqlquerycommand = Tstrlakip;
                    break;
                case "Lubi":
                    sqlquerycommand = strlubi;
                    Tsqlquerycommand = Tstrlubi;
                    break;
                case "Lumutan":
                    sqlquerycommand = strlumutan;
                    Tsqlquerycommand = Tstrlumutan;
                    break;
                case "Magsaysay":
                    sqlquerycommand = strmagsaysay;
                    Tsqlquerycommand = Tstrmagsaysay;
                    break;
                case "Malinao Ibaba":
                    sqlquerycommand = strmalinaoibaba;
                    Tsqlquerycommand = Tstrmalinaoibaba;
                    break;
                case "Malinao Ilaya":
                    sqlquerycommand = strmalinaoilaya;
                    Tsqlquerycommand = Tstrmalinaoilaya;
                    break;
                case "Malusak":
                    sqlquerycommand = strmalusak;
                    Tsqlquerycommand = Tstrmalusak;
                    break;
                case "Manggalayan Bundok":
                    sqlquerycommand = strmanggalayanbundok;
                    Tsqlquerycommand = Tstrmanggalayanbundok;
                    break;
                case "Manggalayan Labak":
                    sqlquerycommand = strmanggalayanlabak;
                    Tsqlquerycommand = Tstrmanggalayanlabak;
                    break;
                case "Matanag":
                    sqlquerycommand = strmatanag;
                    Tsqlquerycommand = Tstrmatanag;
                    break;
                case "Montes Balaon":
                    sqlquerycommand = strmontesbalaon;
                    Tsqlquerycommand = Tstrmontesbalaon;
                    break;
                case "Montes Kallagan":
                    sqlquerycommand = strmonteskallagan;
                    Tsqlquerycommand = Tstrmonteskallagan;
                    break;
                case "Ponon":
                    sqlquerycommand = strponon;
                    Tsqlquerycommand = Tstrponon;
                    break;
                case "Rizal":
                    sqlquerycommand = strrizal;
                    Tsqlquerycommand = Tstrrizal;
                    break;
                case "San Andres Bundok":
                    sqlquerycommand = strsanandresbundok;
                    Tsqlquerycommand = Tstrsanandresbundok;
                    break;
                case "San Andres Labak":
                    sqlquerycommand = strsanandreslabak;
                    Tsqlquerycommand = Tstrsanandreslabak;
                    break;
                case "San Isidro":
                    sqlquerycommand = strsanisidro;
                    Tsqlquerycommand = Tstrsanisidro;
                    break;
                case "San Jose Balatok":
                    sqlquerycommand = strsanjosebalatok;
                    Tsqlquerycommand = Tstrsanjosebalatok;
                    break;
                case "San Rafael":
                    sqlquerycommand = strsanrafael;
                    Tsqlquerycommand = Tstrsanrafael;
                    break;
                case "Sta. Catalina":
                    sqlquerycommand = strsantacatalina;
                    Tsqlquerycommand = Tstrsantacatalina;
                    break;
                case "Sapaan":
                    sqlquerycommand = strsapaan;
                    Tsqlquerycommand = Tstrsapaan;
                    break;
                case "Sokol":
                    sqlquerycommand = strsokol;
                    Tsqlquerycommand = Tstrsokol;
                    break;
                case "Tagbakin":
                    sqlquerycommand = strtagbakin;
                    Tsqlquerycommand = Tstrtagbakin;
                    break;
                case "Talaba":
                    sqlquerycommand = strtalaba;
                    Tsqlquerycommand = Tstrtalaba;
                    break;
                case "Tinandog":
                    sqlquerycommand = strtinandog;
                    Tsqlquerycommand = Tstrtinandog;
                    break;
                case "Villa Ibaba":
                    sqlquerycommand = strvillaibaba;
                    Tsqlquerycommand = Tstrvillaibaba;
                    break;
                case "Villa Ilaya":
                    sqlquerycommand = strvillailaya;
                    Tsqlquerycommand = Tstrvillailaya;
                    break;
                case "Zone I Poblacion":
                    sqlquerycommand = strzonei;
                    Tsqlquerycommand = Tstrzonei;
                    break;
                case "Zone II Poblacion":
                    sqlquerycommand = strzoneii;
                    Tsqlquerycommand = Tstrzoneii;
                    break;
                case "Zone III Poblacion":
                    sqlquerycommand = strzoneiii;
                    Tsqlquerycommand = Tstrzoneiii;
                    break;
                case "Zone IV Poblacion":
                    sqlquerycommand = strzoneiv;
                    Tsqlquerycommand = Tstrzoneiv;
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
            //THIS IS FOR THE CONTENTS
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sqlquerycommand, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                display_infant.Text = reader["INFANT"].ToString();
                display_adult.Text = reader["ADULT"].ToString();
                display_seniorcitizen.Text = reader["SENIOR CITIZEN"].ToString();
                display_male.Text = reader["MALE"].ToString();
                display_female.Text = reader["FEMALE"].ToString();
            }
            conn.Close();
        }

        private void totalpopulation()
        {
            //THIS IS FOR TOTAL POPULATION
            conditionalbranches();
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(Tsqlquerycommand, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                display_totalpopulation.Text = reader["TOTAL POPULATION"].ToString();
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
                //SHOW CONTENTS
                SearchData(txt_barangay.Text);

                //SHOW BARANGAY NAME IN TITLE
                display_barangayname.Text = txt_barangay.Text;

                //SHOW THE TOTAL POPULATION
                totalpopulation();
            }
        }
    }
}
