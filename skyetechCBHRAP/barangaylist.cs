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
using System.Runtime.InteropServices;

namespace skyetechCBHRAP
{
    public partial class barangaylist : Form
    {
        //Dataconnection
        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\cbhrapdatatest.accdb"); //TEST CONNECTION
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

        //TOTAL POPULATION QUERY

        string Tsqlquerycommand;
        string Tstrangeles = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_angeles";
        string Tstrbalubad = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_balubad";
        string Tstrbalugohin = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_balugohin";
        string Tstrbuhangin = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_buhangin";
        string Tstrcaridadibaba = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_caridad_ibaba";
        string Tstrcaridadilaya = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_caridad_ilaya";
        string Tstrhabingan = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_habingan";
        string Tstrinaclagan = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_inaclagan";
        string Tstrinalig = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_inalig";
        string Tstrkilait = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_kilait";
        string Tstrkulawit = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_kulawit";
        string Tstrlakip = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_lakip";
        string Tstrlubi = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_lubi";
        string Tstrlumutan = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_lumutan ";
        string Tstrmagsaysay = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_magsaysay";
        string Tstrmalinaoibaba = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_malinao_ibaba";
        string Tstrmalinaoilaya = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_malinao_ilaya";
        string Tstrmalusak = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_malusak";
        string Tstrmanggalayanbundok = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_manggalayan_bundok";
        string Tstrmanggalayanlabak = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_manggalayan_labak";
        string Tstrmatanag = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_matanag";
        string Tstrmontesbalaon = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_montes_balaon";
        string Tstrmonteskallagan = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_montes_kallagan";
        string Tstrponon = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_ponon";
        string Tstrrizal = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_rizal";
        string Tstrsanandresbundok = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_andres_bundok";
        string Tstrsanandreslabak = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_andres_labak";
        string Tstrsanisidro = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_isidro";
        string Tstrsanjosebalatok = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_jose_balatok";
        string Tstrsanrafael = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_san_rafael";
        string Tstrsantacatalina = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_santa_catalina";
        string Tstrsapaan = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_sapaan";
        string Tstrsokol = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_sokol";
        string Tstrtagbakin = "SELECT IINFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN]AS [TOTAL POPULATION] FROM tbl_tagbakin";
        string Tstrtalaba = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_talaba";
        string Tstrtinandog = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_tinandog";
        string Tstrvillaibaba = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_villa_ibaba";
        string Tstrvillailaya = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_villa_ilaya";
        string Tstrzonei = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_i_pob";
        string Tstrzoneii = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_ii_pob";
        string Tstrzoneiii = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_iii_pob";
        string Tstrzoneiv = "SELECT INFANT + TODDLER + CHILD + ADULT + [SENIOR CITIZEN] AS [TOTAL POPULATION] FROM tbl_zone_iv_pob";

        //TOTAL MALE QUERY

        string TMsqlquerycommand;
        string TMstrangeles = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_angeles";
        string TMstrbalubad = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_balubad";
        string TMstrbalugohin = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_balugohin";
        string TMstrbuhangin = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_buhangin";
        string TMstrcaridadibaba = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_caridad_ibaba";
        string TMstrcaridadilaya = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_caridad_ilaya";
        string TMstrhabingan = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_habingan";
        string TMstrinaclagan = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_inaclagan";
        string TMstrinalig = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_inalig";
        string TMstrkilait = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_kilait";
        string TMstrkulawit = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_kulawit";
        string TMstrlakip = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_lakip";
        string TMstrlubi = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_lubi";
        string TMstrlumutan = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_lumutan ";
        string TMstrmagsaysay = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_magsaysay";
        string TMstrmalinaoibaba = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_malinao_ibaba";
        string TMstrmalinaoilaya = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_malinao_ilaya";
        string TMstrmalusak = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_malusak";
        string TMstrmanggalayanbundok = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_manggalayan_bundok";
        string TMstrmanggalayanlabak = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_manggalayan_labak";
        string TMstrmatanag = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_matanag";
        string TMstrmontesbalaon = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_montes_balaon";
        string TMstrmonteskallagan = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_montes_kallagan";
        string TMstrponon = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_ponon";
        string TMstrrizal = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_rizal";
        string TMstrsanandresbundok = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_san_andres_bundok";
        string TMstrsanandreslabak = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_san_andres_labak";
        string TMstrsanisidro = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_san_isidro";
        string TMstrsanjosebalatok = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_san_jose_balatok";
        string TMstrsanrafael = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_san_rafael";
        string TMstrsantacatalina = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_santa_catalina";
        string TMstrsapaan = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_sapaan";
        string TMstrsokol = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_sokol";
        string TMstrtagbakin = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_tagbakin";
        string TMstrtalaba = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_talaba";
        string TMstrtinandog = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_tinandog";
        string TMstrvillaibaba = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_villa_ibaba";
        string TMstrvillailaya = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_villa_ilaya";
        string TMstrzonei = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_zone_i_pob";
        string TMstrzoneii = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_zone_ii_pob";
        string TMstrzoneiii = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_zone_iii_pob";
        string TMstrzoneiv = "SELECT [INFANT MALE] + [TODDLER MALE] + [CHILD MALE] + [ADULT MALE] + [SENIOR CITIZEN MALE] AS [TOTAL MALE] FROM tbl_zone_iv_pob";

        //TOTAL FEMALE QUERY

        string TFsqlquerycommand;
        string TFstrangeles = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_angeles";
        string TFstrbalubad = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_balubad";
        string TFstrbalugohin = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_balugohin";
        string TFstrbuhangin = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_buhangin";
        string TFstrcaridadibaba = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_caridad_ibaba";
        string TFstrcaridadilaya = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_caridad_ilaya";
        string TFstrhabingan = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_habingan";
        string TFstrinaclagan = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_inaclagan";
        string TFstrinalig = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_inalig";
        string TFstrkilait = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_kilait";
        string TFstrkulawit = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_kulawit";
        string TFstrlakip = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_lakip";
        string TFstrlubi = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_lubi";
        string TFstrlumutan = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_lumutan ";
        string TFstrmagsaysay = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_magsaysay";
        string TFstrmalinaoibaba = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_malinao_ibaba";
        string TFstrmalinaoilaya = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_malinao_ilaya";
        string TFstrmalusak = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_malusak";
        string TFstrmanggalayanbundok = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_manggalayan_bundok";
        string TFstrmanggalayanlabak = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_manggalayan_labak";
        string TFstrmatanag = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_matanag";
        string TFstrmontesbalaon = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_montes_balaon";
        string TFstrmonteskallagan = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_montes_kallagan";
        string TFstrponon = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_ponon";
        string TFstrrizal = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_rizal";
        string TFstrsanandresbundok = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_san_andres_bundok";
        string TFstrsanandreslabak = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_san_andres_labak";
        string TFstrsanisidro = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_san_isidro";
        string TFstrsanjosebalatok = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_san_jose_balatok";
        string TFstrsanrafael = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_san_rafael";
        string TFstrsantacatalina = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_santa_catalina";
        string TFstrsapaan = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_sapaan";
        string TFstrsokol = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_sokol";
        string TFstrtagbakin = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_tagbakin";
        string TFstrtalaba = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_talaba";
        string TFstrtinandog = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_tinandog";
        string TFstrvillaibaba = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_villa_ibaba";
        string TFstrvillailaya = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_villa_ilaya";
        string TFstrzonei = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_zone_i_pob";
        string TFstrzoneii = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_zone_ii_pob";
        string TFstrzoneiii = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_zone_iii_pob";
        string TFstrzoneiv = "SELECT [INFANT FEMALE] + [TODDLER FEMALE] + [CHILD FEMALE] + [ADULT FEMALE] + [SENIOR CITIZEN FEMALE] AS [TOTAL FEMALE] FROM tbl_zone_iv_pob";

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
                    TMsqlquerycommand = TMstrangeles;
                    TFsqlquerycommand = TFstrangeles;

                    break;
                case "Balubad":
                    sqlquerycommand = strbalubad;
                    Tsqlquerycommand = Tstrbalubad;
                    TMsqlquerycommand = TMstrbalubad;
                    TFsqlquerycommand = TFstrbalubad;

                    break;
                case "Balugohin":
                    sqlquerycommand = strbalugohin;
                    Tsqlquerycommand = Tstrbalugohin;
                    TMsqlquerycommand = TMstrbalugohin;
                    TFsqlquerycommand = TFstrbalugohin;

                    break;
                case "Buhangin":
                    sqlquerycommand = strbuhangin;
                    Tsqlquerycommand = Tstrbuhangin;
                    TMsqlquerycommand = TMstrbuhangin;
                    TFsqlquerycommand = TFstrbuhangin;

                    break;
                case "Caridad Ibaba":
                    sqlquerycommand = strcaridadibaba;
                    Tsqlquerycommand = Tstrcaridadibaba;
                    TMsqlquerycommand = TMstrcaridadibaba;
                    TFsqlquerycommand = TFstrcaridadibaba;

                    break;
                case "Caridad Ilaya":
                    sqlquerycommand = strcaridadilaya;
                    Tsqlquerycommand = Tstrcaridadilaya;
                    TMsqlquerycommand = TMstrcaridadilaya;
                    TFsqlquerycommand = TFstrcaridadilaya;

                    break;
                case "Habingan":
                    sqlquerycommand = strhabingan;
                    Tsqlquerycommand = Tstrhabingan;
                    TMsqlquerycommand = TMstrhabingan;
                    TFsqlquerycommand = TFstrhabingan;

                    break;
                case "Inaclagan":
                    sqlquerycommand = strinaclagan;
                    Tsqlquerycommand = Tstrinaclagan;
                    TMsqlquerycommand = TMstrinaclagan;
                    TFsqlquerycommand = TFstrinaclagan;

                    break;
                case "Inalig":
                    sqlquerycommand = strinalig;
                    Tsqlquerycommand = Tstrinalig;
                    TMsqlquerycommand = TMstrinalig;
                    TFsqlquerycommand = TFstrinalig;

                    break;
                case "Kilait":
                    sqlquerycommand = strkilait;
                    Tsqlquerycommand = Tstrkilait;
                    TMsqlquerycommand = TMstrkilait;
                    TFsqlquerycommand = TFstrkilait;

                    break;
                case "Kulawit":
                    sqlquerycommand = strkulawit;
                    Tsqlquerycommand = Tstrkulawit;
                    TMsqlquerycommand = TMstrkulawit;
                    TFsqlquerycommand = TFstrkulawit;

                    break;
                case "Lakip":
                    sqlquerycommand = strlakip;
                    Tsqlquerycommand = Tstrlakip;
                    TMsqlquerycommand = TMstrlakip;
                    TFsqlquerycommand = TFstrlakip;

                    break;
                case "Lubi":
                    sqlquerycommand = strlubi;
                    Tsqlquerycommand = Tstrlubi;
                    TMsqlquerycommand = TMstrlubi;
                    TFsqlquerycommand = TFstrlubi;

                    break;
                case "Lumutan":
                    sqlquerycommand = strlumutan;
                    Tsqlquerycommand = Tstrlumutan;
                    TMsqlquerycommand = TMstrlumutan;
                    TFsqlquerycommand = TFstrlumutan;

                    break;
                case "Magsaysay":
                    sqlquerycommand = strmagsaysay;
                    Tsqlquerycommand = Tstrmagsaysay;
                    TMsqlquerycommand = TMstrmagsaysay;
                    TFsqlquerycommand = TFstrmagsaysay;

                    break;
                case "Malinao Ibaba":
                    sqlquerycommand = strmalinaoibaba;
                    Tsqlquerycommand = Tstrmalinaoibaba;
                    TMsqlquerycommand = TMstrmalinaoibaba;
                    TFsqlquerycommand = TFstrmalinaoibaba;

                    break;
                case "Malinao Ilaya":
                    sqlquerycommand = strmalinaoilaya;
                    Tsqlquerycommand = Tstrmalinaoilaya;
                    TMsqlquerycommand = TMstrmalinaoilaya;
                    TFsqlquerycommand = TFstrmalinaoilaya;

                    break;
                case "Malusak":
                    sqlquerycommand = strmalusak;
                    Tsqlquerycommand = Tstrmalusak;
                    TMsqlquerycommand = TMstrmalusak;
                    TFsqlquerycommand = TFstrmalusak;

                    break;
                case "Manggalayan Bundok":
                    sqlquerycommand = strmanggalayanbundok;
                    Tsqlquerycommand = Tstrmanggalayanbundok;
                    TMsqlquerycommand = TMstrmanggalayanbundok;
                    TFsqlquerycommand = TFstrmanggalayanbundok;

                    break;
                case "Manggalayan Labak":
                    sqlquerycommand = strmanggalayanlabak;
                    Tsqlquerycommand = Tstrmanggalayanlabak;
                    TMsqlquerycommand = TMstrmanggalayanlabak;
                    TFsqlquerycommand = TFstrmanggalayanlabak;

                    break;
                case "Matanag":
                    sqlquerycommand = strmatanag;
                    Tsqlquerycommand = Tstrmatanag;
                    TMsqlquerycommand = TMstrmatanag;
                    TFsqlquerycommand = TFstrmatanag;

                    break;
                case "Montes Balaon":
                    sqlquerycommand = strmontesbalaon;
                    Tsqlquerycommand = Tstrmontesbalaon;
                    TMsqlquerycommand = TMstrmontesbalaon;
                    TFsqlquerycommand = TFstrmontesbalaon;

                    break;
                case "Montes Kallagan":
                    sqlquerycommand = strmonteskallagan;
                    Tsqlquerycommand = Tstrmonteskallagan;
                    TMsqlquerycommand = TMstrmonteskallagan;
                    TFsqlquerycommand = TFstrmonteskallagan;

                    break;
                case "Ponon":
                    sqlquerycommand = strponon;
                    Tsqlquerycommand = Tstrponon;
                    TMsqlquerycommand = TMstrponon;
                    TFsqlquerycommand = TFstrponon;

                    break;
                case "Rizal":
                    sqlquerycommand = strrizal;
                    Tsqlquerycommand = Tstrrizal;
                    TMsqlquerycommand = TMstrrizal;
                    TFsqlquerycommand = TFstrrizal;

                    break;
                case "San Andres Bundok":
                    sqlquerycommand = strsanandresbundok;
                    Tsqlquerycommand = Tstrsanandresbundok;
                    TMsqlquerycommand = TMstrsanandresbundok;
                    TFsqlquerycommand = TFstrsanandresbundok;

                    break;
                case "San Andres Labak":
                    sqlquerycommand = strsanandreslabak;
                    Tsqlquerycommand = Tstrsanandreslabak;
                    TMsqlquerycommand = TMstrsanandreslabak;
                    TFsqlquerycommand = TFstrsanandreslabak;

                    break;
                case "San Isidro":
                    sqlquerycommand = strsanisidro;
                    Tsqlquerycommand = Tstrsanisidro;
                    TMsqlquerycommand = TMstrsanisidro;
                    TFsqlquerycommand = TFstrsanisidro;

                    break;
                case "San Jose Balatok":
                    sqlquerycommand = strsanjosebalatok;
                    Tsqlquerycommand = Tstrsanjosebalatok;
                    TMsqlquerycommand = TMstrsanjosebalatok;
                    TFsqlquerycommand = TFstrsanjosebalatok;

                    break;
                case "San Rafael":
                    sqlquerycommand = strsanrafael;
                    Tsqlquerycommand = Tstrsanrafael;
                    TMsqlquerycommand = TMstrsanrafael;
                    TFsqlquerycommand = TFstrsanrafael;

                    break;
                case "Sta. Catalina":
                    sqlquerycommand = strsantacatalina;
                    Tsqlquerycommand = Tstrsantacatalina;
                    TMsqlquerycommand = TMstrsantacatalina;
                    TFsqlquerycommand = TFstrsantacatalina;

                    break;
                case "Sapaan":
                    sqlquerycommand = strsapaan;
                    Tsqlquerycommand = Tstrsapaan;
                    TMsqlquerycommand = TMstrsapaan;
                    TFsqlquerycommand = TFstrsapaan;
                    break;
                case "Sokol":
                    sqlquerycommand = strsokol;
                    Tsqlquerycommand = Tstrsokol;
                    TMsqlquerycommand = TMstrsokol;
                    TFsqlquerycommand = TFstrsokol;

                    break;
                case "Tagbakin":
                    sqlquerycommand = strtagbakin;
                    Tsqlquerycommand = Tstrtagbakin;
                    TMsqlquerycommand = TMstrtagbakin;
                    TFsqlquerycommand = TFstrtagbakin;

                    break;
                case "Talaba":
                    sqlquerycommand = strtalaba;
                    Tsqlquerycommand = Tstrtalaba;
                    TMsqlquerycommand = TMstrtalaba;
                    TFsqlquerycommand = TFstrtalaba;

                    break;
                case "Tinandog":
                    sqlquerycommand = strtinandog;
                    Tsqlquerycommand = Tstrtinandog;
                    TMsqlquerycommand = TMstrtinandog;
                    TFsqlquerycommand = TFstrtinandog;

                    break;
                case "Villa Ibaba":
                    sqlquerycommand = strvillaibaba;
                    Tsqlquerycommand = Tstrvillaibaba;
                    TMsqlquerycommand = TMstrvillaibaba;
                    TFsqlquerycommand = TFstrvillaibaba;

                    break;
                case "Villa Ilaya":
                    sqlquerycommand = strvillailaya;
                    Tsqlquerycommand = Tstrvillailaya;
                    TMsqlquerycommand = TMstrvillailaya;
                    TFsqlquerycommand = TFstrvillailaya;

                    break;
                case "Zone I Poblacion":
                    sqlquerycommand = strzonei;
                    Tsqlquerycommand = Tstrzonei;
                    TMsqlquerycommand = TMstrzonei;
                    TFsqlquerycommand = TFstrzonei;

                    break;
                case "Zone II Poblacion":
                    sqlquerycommand = strzoneii;
                    Tsqlquerycommand = Tstrzoneii;
                    break;
                case "Zone III Poblacion":
                    sqlquerycommand = strzoneiii;
                    Tsqlquerycommand = Tstrzoneiii;
                    TMsqlquerycommand = TMstrzoneiii;
                    TFsqlquerycommand = TFstrzoneiii;

                    break;
                case "Zone IV Poblacion":
                    sqlquerycommand = strzoneiv;
                    Tsqlquerycommand = Tstrzoneiv;
                    TMsqlquerycommand = TMstrzoneiv;
                    TFsqlquerycommand = TFstrzoneiv;

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
                display_toddler.Text = reader["TODDLER"].ToString();
                display_child.Text = reader["CHILD"].ToString();
                display_adult.Text = reader["ADULT"].ToString();
                display_seniorcitizen.Text = reader["SENIOR CITIZEN"].ToString();
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

        private void totalmale()
        {
            conditionalbranches();
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(TMsqlquerycommand, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                display_total_male.Text = reader["TOTAL MALE"].ToString();
            }
            conn.Close();
        }

        private void totalfemale()
        {
            conditionalbranches();
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(TFsqlquerycommand, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                display_total_female.Text = reader["TOTAL FEMALE"].ToString();
            }
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

                //SHOW TOTAL MALE
                totalmale();

                //SHOW TOTAL FEMALE
                totalfemale();
            }
        }
    }
}
