﻿using System;
using System.Data;
using System.Data.OracleClient;

/// <summary>
/// Summary description for admin
/// </summary>
/// 
namespace ASTROLOGY.classesoracle
{
    public class admin : orclconnection
    {
        #region Admin
        public admin()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion
       
        #region GET NATAL FILTERS
        public DataSet GetNatalFilters(string tablename, string keystringval, string logicval,string Id, string flag)
        {
            string str = "";
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                #region EDIT Flag
                if (flag == "EDIT")
                {
                    if (tablename == "HOUSE_POSITIPON")
                    {
                        str = "SELECT CODE,NAME,DESCRIPTION,HOUSE,PLANET,RASHI,'' AS LAGNA_RASHI,ASC_DEGREE,DESCCLOB,ASCENDENT,CONSTELLATION,DEGREE_FROM,DEGREE_TO,CHART_NO,ASPECTING_PLANET,BOOK,PAGE_NO,LORD_OF_HOUSE,ASPECTING_HOUSE,KEY_STRING,NUMBER_OF_PLANETS,EXPLANATION,CHECKED,UNIQUE_ID,FORM_ID,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "HOUSE_POSITIPON_COMB")
                    {
                        str = "SELECT '' AS PLANET,'' AS HOUSE,'' AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESC_CLOB AS DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY DESCRIPTION DESC";
                    }
                    else if (tablename == "PLANET_ASPECT")
                    {
                        str = "SELECT LORD_OF_HOUSE2,LORD,RASHI,HOUSE,DESCRIPTION,DESCCLOB,LORD_OF_HOUSE,CATEGERY,RASHI_OF_LAGNA AS LAGNA_RASHI,WITH_LORD,IN_LORD,PLANET,ASTRO_CAT,BOOK,KEY_STRING,HOUSES,RASHI_ASPECT,NUMBER_OF_PLANETS,CHECKED,EXPLANATION,PAGE_NO,CHART_NO,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "EDM")
                    {
                        str = "SELECT LAGNA_RASHI,RASHI,HOUSE,PLANET,LONGITUDE_IN_THE_SIGN_FROM,LONGITUDE_IN_THE_SIGN_TO,LORD_OF_HOUSE,CATEGERY,BOOK,PAGE_NO,DESCCLOB,DESCRIPTION,KEY_STRING,CHECKED,NUMBER_OF_PLANETS,EXPLANATION,CHART_NO,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "BENIFICS_MALIFICS_ASPECT")
                    {
                        str = "SELECT PLANET,HOUSE,LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANET_ASPECT_PLANET")
                    {
                        str = "SELECT PLANET,HOUSE,LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANETFROMPLANET")
                    {
                        str = "SELECT PLANET,HOUSE,RASHI_OF_LAGNA AS LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "COMBUSTION_DEGREE")
                    {
                        str = "SELECT PLANET,RASHI,HOUSE,LAGNA_RASHI,DESCRIPTION,DESCCLOB,EXPLANATION,BOOK,PAGE_NO,CHECKED,COMBINATION,CHART_NO,KEY_STRING,NUMBER_OF_PLANETS,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "QUADRAPED_COMBINATION")
                    {
                        str = "SELECT QUADRAPED_PLANET AS PLANET,'' AS HOUSE,QUADRAPED_RASHI AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "MULTIPLE_COMBINATIONS")
                    {
                        str = "SELECT '' AS PLANET,HOUSE,RASHI,LAGNA_RASHI,LORD_OF_HOUSE,LORD,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                    else
                    {
                        str = "SELECT * from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                }
                #endregion

                #region GET_USING_ID Flag
                if (flag == "GET_USING_ID")
                {
                    if (tablename == "HOUSE_POSITIPON")
                    {
                        str = "SELECT CODE,NAME,DESCRIPTION,HOUSE,PLANET,RASHI,'' AS LAGNA_RASHI,ASC_DEGREE,DESCCLOB,ASCENDENT,CONSTELLATION,DEGREE_FROM,DEGREE_TO,CHART_NO,ASPECTING_PLANET,BOOK,PAGE_NO,LORD_OF_HOUSE,ASPECTING_HOUSE,KEY_STRING,NUMBER_OF_PLANETS,EXPLANATION,CHECKED,UNIQUE_ID,FORM_ID,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "HOUSE_POSITIPON_COMB")
                    {
                        str = "SELECT '' AS PLANET,'' AS HOUSE,'' AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESC_CLOB AS DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANET_ASPECT")
                    {
                        str = "SELECT LORD_OF_HOUSE2,LORD,RASHI,HOUSE,DESCRIPTION,DESCCLOB,LORD_OF_HOUSE,CATEGERY,RASHI_OF_LAGNA AS LAGNA_RASHI,WITH_LORD,IN_LORD,PLANET,ASTRO_CAT,BOOK,KEY_STRING,HOUSES,RASHI_ASPECT,NUMBER_OF_PLANETS,CHECKED,EXPLANATION,PAGE_NO,CHART_NO,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "EDM")
                    {
                        str = "SELECT LAGNA_RASHI,RASHI,HOUSE,PLANET,LONGITUDE_IN_THE_SIGN_FROM,LONGITUDE_IN_THE_SIGN_TO,LORD_OF_HOUSE,CATEGERY,BOOK,PAGE_NO,DESCCLOB,DESCRIPTION,KEY_STRING,CHECKED,NUMBER_OF_PLANETS,EXPLANATION,CHART_NO,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "BENIFICS_MALIFICS_ASPECT")
                    {
                        str = "SELECT PLANET,HOUSE,LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANET_ASPECT_PLANET")
                    {
                        str = "SELECT PLANET,HOUSE,LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANETFROMPLANET")
                    {
                        str = "SELECT PLANET,HOUSE,RASHI_OF_LAGNA AS LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "COMBUSTION_DEGREE")
                    {
                        str = "SELECT PLANET,RASHI,HOUSE,LAGNA_RASHI,DESCRIPTION,DESCCLOB,EXPLANATION,BOOK,PAGE_NO,CHECKED,COMBINATION,CHART_NO,KEY_STRING,NUMBER_OF_PLANETS,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "QUADRAPED_COMBINATION")
                    {
                        str = "SELECT QUADRAPED_PLANET AS PLANET,'' AS HOUSE,QUADRAPED_RASHI AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "MULTIPLE_COMBINATIONS")
                    {
                        str = "SELECT '' AS PLANET,HOUSE,RASHI,LAGNA_RASHI,LORD_OF_HOUSE,LORD,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "REMEDIAL_COMB")
                    {
                        str = "SELECT '' AS PLANET,'' AS HOUSE,'' AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,CHECKED,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if(tablename == "LAGNA_MST")
                    {
                        str = "SELECT NULL AS CODE,NAME,LOGIC AS DESCRIPTION,HOUSE,PLANET,RASHI,NULL AS LAGNA_RASHI,NULL AS ASC_DEGREE,PREDICTIVE AS DESCCLOB,NULL AS ASCENDENT,NULL AS CONSTELLATION,";
                        str += " NULL AS DEGREE_FROM,NULL AS DEGREE_TO,NULL AS CHART_NO,NULL AS ASPECTING_PLANET,BOOK_NAME AS BOOK,PAGE_NO,NULL AS LORD_OF_HOUSE,NULL AS ASPECTING_HOUSE,";
                        str += "KEY_STRING,NULL AS NUMBER_OF_PLANETS,NULL AS EXPLANATION,CHECKED,UNIQUE_ID,NULL AS FORM_ID,NULL AS TO_DATE,NULL AS COMBINATION,";
                        str += "PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,MAPPING_CATEGORY,ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "IMPORTANT_PLANET_MST")
                    {
                        str = "SELECT NULL AS CODE,NAME,LOGIC AS DESCRIPTION,HOUSE,PLANET,RASHI,NULL AS LAGNA_RASHI,NULL AS ASC_DEGREE,PREDICTIVE AS DESCCLOB,NULL AS ASCENDENT,NULL AS CONSTELLATION,";
                        str += " NULL AS DEGREE_FROM,NULL AS DEGREE_TO,NULL AS CHART_NO,NULL AS ASPECTING_PLANET,BOOK_NAME AS BOOK,PAGE_NO,NULL AS LORD_OF_HOUSE,NULL AS ASPECTING_HOUSE,";
                        str += "KEY_STRING,NULL AS NUMBER_OF_PLANETS,NULL AS EXPLANATION,CHECKED,UNIQUE_ID,NULL AS FORM_ID,NULL AS TO_DATE,NULL AS COMBINATION,";
                        str += "PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "YOGA_PREDICTIVE")
                    {
                        str = "SELECT NULL AS CODE,DESCRIPTION,HOUSE,PLANET,RASHI,NULL AS LAGNA_RASHI,NULL AS ASC_DEGREE,DESCCLOB,NULL AS ASCENDENT,NULL AS CONSTELLATION,";
                        str += " NULL AS DEGREE_FROM,NULL AS DEGREE_TO,NULL AS CHART_NO,NULL AS ASPECTING_PLANET,NULL AS BOOK,PAGE_NO,NULL AS LORD_OF_HOUSE,NULL AS ASPECTING_HOUSE,";
                        str += "KEY_STRING,NULL AS NUMBER_OF_PLANETS,NULL AS EXPLANATION,CHECKED,UNIQUE_ID,NULL AS FORM_ID,NULL AS TO_DATE,NULL AS COMBINATION,";
                        str += "PREDICTIVE_TYPE,AUTO_ID,REMEDIAL,STATUS,PRIORITY,NULL AS MAPPING_CATEGORY,NULL AS ISMAPPED from " + tablename + " where AUTO_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else
                    {
                        str = "SELECT * from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                }
                #endregion

                #region GET Flag
                if (flag == "GET")
                {
                    if (keystringval != "" && logicval == "")
                    {
                        if (tablename == "HOUSE_POSITIPON_COMB")
                        {
                            str = "SELECT dbms_lob.substr(desc_clob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION,PREDICTIVE_TYPE,AUTO_ID,TO_CHAR(CRTD_DATE, 'DD-Mon-YYYY HH:MI AM') as CRTD_DATE,REMEDIAL from " + tablename + " where upper(key_string) like '%" + keystringval.ToUpper() + "%' ORDER BY AUTO_ID DESC";
                        }
                        else
                        {
                            str = "SELECT dbms_lob.substr(descclob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION,PREDICTIVE_TYPE,AUTO_ID,TO_CHAR(CRTD_DATE, 'DD-Mon-YYYY HH:MI AM') as CRTD_DATE,REMEDIAL from " + tablename + " where upper(key_string) like '%" + keystringval.ToUpper() + "%' ORDER BY AUTO_ID DESC";
                        }
                    }
                    else if (logicval != "" && keystringval == "")
                    {
                        if (tablename == "HOUSE_POSITIPON_COMB")
                        {
                            str = "SELECT dbms_lob.substr(desc_clob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION,PREDICTIVE_TYPE,AUTO_ID,TO_CHAR(CRTD_DATE, 'DD-Mon-YYYY HH:MI AM') as CRTD_DATE,REMEDIAL from " + tablename + " where upper(DESCRIPTION) like '%" + logicval.ToUpper() + "%' ORDER BY AUTO_ID DESC";
                        }
                        else
                        {
                            str = "SELECT dbms_lob.substr(descclob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION,PREDICTIVE_TYPE,AUTO_ID,TO_CHAR(CRTD_DATE, 'DD-Mon-YYYY HH:MI AM') as CRTD_DATE,REMEDIAL from " + tablename + " where upper(DESCRIPTION) like '%" + logicval.ToUpper() + "%' ORDER BY AUTO_ID DESC";
                        }
                    }
                    else
                    {
                        if (tablename == "HOUSE_POSITIPON_COMB")
                        {
                            str = "SELECT dbms_lob.substr(desc_clob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION,PREDICTIVE_TYPE,AUTO_ID,TO_CHAR(CRTD_DATE, 'DD-Mon-YYYY HH:MI AM') as CRTD_DATE,REMEDIAL from " + tablename + " ORDER BY AUTO_ID DESC";
                        }
                        else
                        {
                            str = "SELECT dbms_lob.substr(descclob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION,PREDICTIVE_TYPE,AUTO_ID,TO_CHAR(CRTD_DATE, 'DD-Mon-YYYY HH:MI AM') as CRTD_DATE,REMEDIAL from " + tablename + " ORDER BY AUTO_ID DESC";
                        }
                    }
                }
                #endregion

                #region GET_USING_UNIQUE_ID Flag
                if (flag == "GET_USING_UNIQUE_ID")
                {
                    if (tablename == "HOUSE_POSITIPON")
                    {
                        str = "SELECT CODE,NAME,DESCRIPTION,HOUSE,PLANET,RASHI,'' AS LAGNA_RASHI,ASC_DEGREE,DESCCLOB,ASCENDENT,CONSTELLATION,DEGREE_FROM,DEGREE_TO,CHART_NO,ASPECTING_PLANET,BOOK,PAGE_NO,LORD_OF_HOUSE,ASPECTING_HOUSE,KEY_STRING,NUMBER_OF_PLANETS,EXPLANATION,CHECKED,UNIQUE_ID,FORM_ID,TO_DATE,NAME AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "HOUSE_POSITIPON_COMB")
                    {
                        str = "SELECT '' AS PLANET,'' AS HOUSE,'' AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESC_CLOB AS DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,NAME AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANET_ASPECT")
                    {
                        str = "SELECT LORD_OF_HOUSE2,LORD,RASHI,HOUSE,DESCRIPTION,DESCCLOB,LORD_OF_HOUSE,CATEGERY,RASHI_OF_LAGNA AS LAGNA_RASHI,WITH_LORD,IN_LORD,PLANET,ASTRO_CAT,BOOK,KEY_STRING,HOUSES,RASHI_ASPECT,NUMBER_OF_PLANETS,CHECKED,EXPLANATION,PAGE_NO,CHART_NO,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "EDM")
                    {
                        str = "SELECT LAGNA_RASHI,RASHI,HOUSE,PLANET,LONGITUDE_IN_THE_SIGN_FROM,LONGITUDE_IN_THE_SIGN_TO,LORD_OF_HOUSE,CATEGERY,BOOK,PAGE_NO,DESCCLOB,DESCRIPTION,KEY_STRING,CHECKED,NUMBER_OF_PLANETS,EXPLANATION,CHART_NO,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,'' AS COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "BENIFICS_MALIFICS_ASPECT")
                    {
                        str = "SELECT PLANET,HOUSE,LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANET_ASPECT_PLANET")
                    {
                        str = "SELECT PLANET,HOUSE,LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "PLANETFROMPLANET")
                    {
                        str = "SELECT PLANET,HOUSE,RASHI_OF_LAGNA AS LAGNA_RASHI,'' AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "COMBUSTION_DEGREE")
                    {
                        str = "SELECT PLANET,RASHI,HOUSE,LAGNA_RASHI,DESCRIPTION,DESCCLOB,EXPLANATION,BOOK,PAGE_NO,CHECKED,COMBINATION,CHART_NO,KEY_STRING,NUMBER_OF_PLANETS,UNIQUE_ID,FORM_ID,PROPERTY_CODE,CATEGORY,TO_DATE,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "QUADRAPED_COMBINATION")
                    {
                        str = "SELECT QUADRAPED_PLANET AS PLANET,'' AS HOUSE,QUADRAPED_RASHI AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "MULTIPLE_COMBINATIONS")
                    {
                        str = "SELECT '' AS PLANET,HOUSE,RASHI,LAGNA_RASHI,LORD_OF_HOUSE,LORD,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "REMEDIAL_COMB")
                    {
                        str = "SELECT '' AS PLANET,'' AS HOUSE,'' AS RASHI,'' AS LAGNA_RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID,COMBINATION,PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "LAGNA_MST")
                    {
                        str = "SELECT NULL AS CODE,NAME,LOGIC AS DESCRIPTION,HOUSE,PLANET,RASHI,NULL AS LAGNA_RASHI,NULL AS ASC_DEGREE,PREDICTIVE AS DESCCLOB,NULL AS ASCENDENT,NULL AS CONSTELLATION,";
                        str += " NULL AS DEGREE_FROM,NULL AS DEGREE_TO,NULL AS CHART_NO,NULL AS ASPECTING_PLANET,BOOK_NAME AS BOOK,PAGE_NO,NULL AS LORD_OF_HOUSE,NULL AS ASPECTING_HOUSE,";
                        str += "KEY_STRING,NULL AS NUMBER_OF_PLANETS,NULL AS EXPLANATION,CHECKED,UNIQUE_ID,NULL AS FORM_ID,NULL AS TO_DATE,NULL AS COMBINATION,";
                        str += "PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "IMPORTANT_PLANET_MST")
                    {
                        str = "SELECT NULL AS CODE,NAME,LOGIC AS DESCRIPTION,HOUSE,PLANET,RASHI,NULL AS LAGNA_RASHI,NULL AS ASC_DEGREE,PREDICTIVE AS DESCCLOB,NULL AS ASCENDENT,NULL AS CONSTELLATION,";
                        str += " NULL AS DEGREE_FROM,NULL AS DEGREE_TO,NULL AS CHART_NO,NULL AS ASPECTING_PLANET,BOOK_NAME AS BOOK,PAGE_NO,NULL AS LORD_OF_HOUSE,NULL AS ASPECTING_HOUSE,";
                        str += "KEY_STRING,NULL AS NUMBER_OF_PLANETS,NULL AS EXPLANATION,CHECKED,UNIQUE_ID,NULL AS FORM_ID,NULL AS TO_DATE,NULL AS COMBINATION,";
                        str += "PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else if (tablename == "YOGA_PREDICTIVE")
                    {
                        str = "SELECT NULL AS CODE,DESCRIPTION,HOUSE,PLANET,RASHI,NULL AS LAGNA_RASHI,NULL AS ASC_DEGREE,DESCCLOB,NULL AS ASCENDENT,NULL AS CONSTELLATION,";
                        str += " NULL AS DEGREE_FROM,NULL AS DEGREE_TO,NULL AS CHART_NO,NULL AS ASPECTING_PLANET,NULL AS BOOK,PAGE_NO,NULL AS LORD_OF_HOUSE,NULL AS ASPECTING_HOUSE,";
                        str += "KEY_STRING,NULL AS NUMBER_OF_PLANETS,NULL AS EXPLANATION,CHECKED,UNIQUE_ID,NULL AS FORM_ID,NULL AS TO_DATE,NULL AS COMBINATION,";
                        str += "PREDICTIVE_TYPE,AUTO_ID,REMEDIAL from " + tablename + " where UNIQUE_ID='" + Id + "' ORDER BY AUTO_ID DESC";
                    }
                    else
                    {
                        str = "SELECT * from " + tablename + " where key_string like '%" + keystringval + "%' and DESCRIPTION like '%" + logicval + "%' ORDER BY AUTO_ID DESC";
                    }
                }
                #endregion

                OracleDataAdapter odt = new OracleDataAdapter(str, con);
                odt.Fill(ds);
            }
            catch (Exception ex)
            {
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        #endregion

        #region GET CATEGORY AND QUESTIONS
        public DataSet GetCategoryAndQuestions(string keystring,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                string str = "",keystringpart="";
                if (keystring.IndexOf(",") > -1)
                {
                    string[] splString = keystring.Split(',');
                    if (splString.Length>1)
                    {
                        for (int s = 0; s < splString.Length;s++ )
                        {
                            if (s > 0)
                            {
                                keystringpart = keystringpart + "," + "'" + splString[s] + "'";
                            }
                            else
                            {
                                keystringpart = "'" + splString[s] + "'";
                            }
                        }
                        keystring = keystringpart;
                    }
                    str = "SELECT DISTINCT FINAL_CATEGERY,QUESTION FROM PREDICTIVE_CATEGERY WHERE CATEGERY IN(" + keystring + ")";
                }
                else if (keystring=="")
                {
                    str = "SELECT DISTINCT FINAL_CATEGERY,QUESTION FROM PREDICTIVE_CATEGERY WHERE CATEGERY IN('" + keystring + "')";
                }
                else
                {
                    str = "SELECT DISTINCT FINAL_CATEGERY,QUESTION FROM PREDICTIVE_CATEGERY WHERE ((UPPER (CATEGERY) LIKE UPPER ('" + keystring + "') || '%') OR ('" + keystring + "' IS NULL))";
                }
                OracleDataAdapter odt = new OracleDataAdapter(str, con);
                odt.Fill(ds);
            }
            catch (Exception ex)
            {
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        #endregion

        #region GETNATAL FILTER LOGIC
        public DataSet GetNatal_Filter_Logic(string tablename, string srchval, string flag)
        {
            string str = "";
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                if (flag == "KEYSTRING")
                {
                    str = "select distinct KEY_STRING from " + tablename + " order by KEY_STRING asc";
                }
                if (flag == "LOGIC")
                {
                    str = "select distinct DESCRIPTION from " + tablename + " order by DESCRIPTION asc";
                }
                //if (keystringval != "")
                //{
                //    if (tablename == "BENIFICS_MALIFICS_ASPECT")
                //    {
                //        str = "SELECT PLANET,HOUSE,LAGNA_RASHI AS RASHI,DESCRIPTION,KEY_STRING,DESCCLOB,UNIQUE_ID,BOOK,PAGE_NO,FORM_ID from " + tablename + " where key_string like '%" + keystringval + "%' ORDER BY DESCRIPTION asc";
                //    }
                //    else
                //    {
                //        str = "SELECT * from " + tablename + " where key_string like '%" + keystringval + "%' ORDER BY DESCRIPTION asc";
                //    }
                //}
                //else
                //{
                //    str = "SELECT dbms_lob.substr(descclob,4000,1) as DESCCLOB,DESCRIPTION,KEY_STRING,BOOK,CHECKED,PAGE_NO,UNIQUE_ID,FORM_ID,dbms_lob.substr(EXPLANATION,4000,1) as EXPLANATION from " + tablename + " ORDER BY DESCRIPTION asc";
                //}
                OracleDataAdapter odt = new OracleDataAdapter(str, con);
                odt.Fill(ds);
            }
            catch (Exception ex)
            {
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        #endregion

        #region INSERT NATAL PREDICTIVES
        public DataSet Insert_Natal_Predictives(string houseval, string planetval, string rashival, string filterval, string descval, string nameval, string chartval, string bookval, string pageval, string uniqueval, string detailval, string remedialval,string tablename, string flag, string housevalnew, string planetvalnew, string rashivalnew, string filtervalnew, string descvalnew, string namevalnew, string chartvalnew, string predictivenew,string remedialnew, string uniqueidval, string combination, string lagnarashival, string predictivetypeval,int AutoId,string NatalCategories,string IsChecked, string Status,string UserId,string Priority)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_SAVE_NATALPREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 20);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = houseval;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 20);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planetval;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_rashi", OracleType.VarChar, 20);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = rashival;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 500);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = filterval;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = descval;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_name", OracleType.VarChar, 500);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = nameval;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chart", OracleType.VarChar, 10);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = chartval;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = bookval;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_page", OracleType.VarChar, 20);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = pageval;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_unique", OracleType.VarChar, 50);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = uniqueval;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_detail", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = detailval;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_remedial", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = remedialval;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_tablename", OracleType.VarChar, 100);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = tablename;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_flag", OracleType.VarChar, 50);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = flag;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_house_new", OracleType.VarChar, 20);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = housevalnew;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_planet_new", OracleType.VarChar, 20);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = planetvalnew;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_rashi_new", OracleType.VarChar, 20);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = rashivalnew;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_filter_new", OracleType.VarChar, 500);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = filtervalnew;
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("p_description_new", OracleType.VarChar, 4000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = descvalnew;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_name_new", OracleType.VarChar, 500);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = namevalnew;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("p_chart_new", OracleType.VarChar, 10);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = chartvalnew;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("p_detail_new", OracleType.VarChar, 4000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = predictivenew;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("p_remedial_new", OracleType.VarChar, 4000);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = remedialnew;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("p_uniqueid_new", OracleType.VarChar, 500);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = uniqueidval;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("p_combination", OracleType.VarChar, 4000);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = combination;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("p_lagna_rashi", OracleType.VarChar, 50);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = lagnarashival;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("p_predictive_type", OracleType.Char, 1);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = predictivetypeval;
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("p_autoid", OracleType.Int32);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = AutoId;
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("p_natal_category", OracleType.VarChar, 2000);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = NatalCategories;
                orclcmd.Parameters.Add(prm29);

                OracleParameter prm30 = new OracleParameter("p_checked", OracleType.VarChar, 1);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = IsChecked;
                orclcmd.Parameters.Add(prm30);

                OracleParameter prm31 = new OracleParameter("p_status", OracleType.Char, 1);
                prm31.Direction = ParameterDirection.Input;
                prm31.Value = Status;
                orclcmd.Parameters.Add(prm31);

                OracleParameter prm32 = new OracleParameter("p_userid", OracleType.VarChar, 100);
                prm32.Direction = ParameterDirection.Input;
                prm32.Value = UserId;
                orclcmd.Parameters.Add(prm32);

                OracleParameter prm33 = new OracleParameter("p_priority", OracleType.VarChar, 10);
                prm33.Direction = ParameterDirection.Input;
                prm33.Value = Priority;
                orclcmd.Parameters.Add(prm33);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region INSERT NATAL PREDICTIVES CAT
        public DataSet Insert_Natal_Predictives_Cat(string CatName, string QuesVal, string filterval, string descval, string tablename, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SAVE_NATALPREDICTIVE_CAT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_categoryname", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = CatName;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_ques", OracleType.VarChar, 500);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = QuesVal;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_filter_new", OracleType.VarChar, 500);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = filterval;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_description_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = descval;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_tablename", OracleType.VarChar, 50);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = tablename;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_flag", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET NATAL SEARCH PREDICTIVES
        public DataSet Get_Natal_Search_Predictives(string txtsrch, string delival, string TableName, string KeystringVal, string LogicVal, string PredictiveTypeVal, string PredictiveForVal, string Status, string IsChecked,string SortColumn,string SortOrder, string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_NATAL_DATA_SEARCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptxt", OracleType.VarChar, 500);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = txtsrch;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pdelim", OracleType.VarChar, 1);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = delival;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ptable", OracleType.VarChar, 500);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = TableName;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pkeystring", OracleType.VarChar, 500);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = KeystringVal;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("plogic", OracleType.VarChar, 500);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = LogicVal;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("ptype", OracleType.VarChar, 200);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PredictiveTypeVal;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pfor", OracleType.VarChar, 200);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = PredictiveForVal;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pstatus", OracleType.Char, 1);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Status;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pchecked", OracleType.Char, 1);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = IsChecked;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("psortcolumn", OracleType.VarChar, 100);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = SortColumn;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("psortorder", OracleType.VarChar, 10);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = SortOrder;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra", OracleType.VarChar, 500);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = extra;
                orclcmd.Parameters.Add(prm12);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET NATAL KEYSTRING FILTER
        public DataSet Get_Natal_Keystring_Filter(string keystringval, string filterlogicval, string TableName, string Delimiterval, string flag1, string flag2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("SP_GET_NATAL_KEYSTRING_FILTER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkeystringtxt", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = keystringval;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pfiltertxt", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = filterlogicval;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ptable", OracleType.VarChar, 500);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = TableName;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelim", OracleType.VarChar, 1);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Delimiterval;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pflag1", OracleType.VarChar, 500);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag1;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pflag2", OracleType.VarChar, 500);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag2;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region CHECK LOGIN DETAILS
        public DataSet CheckLoginDetails(string Flag, string LoginID, string Password)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_CHECK_LOGIN_ADMIN", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("LOGINID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = LoginID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("PASSWORDVAL", OracleType.VarChar, 500);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Password;
                orclcmd.Parameters.Add(prm3);
                orclcmd.Parameters.Add("POUT1", OracleType.Cursor);
                orclcmd.Parameters["POUT1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("POUT2", OracleType.Cursor);
                orclcmd.Parameters["POUT2"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE USER
        public DataSet ManageUser(string Flag , string ID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_USER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
               throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region ADD UPDATE USER
        public DataSet AddUpdateUser(string Flag , string USERID , string NAME ,  string EMAILID , string PHONENO , string PHOTO, string STATUS, string ADDRESS , 
                                   string CITY, string STATE , string COUNTRY , string GROUP_ID , string MODIFY_BY , string LoginID  , string Password , string IsSuperAdmin)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_UPDATE_USER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2= new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = USERID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_NAME", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = NAME;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_EMAILID", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = EMAILID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_PHONENO", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = PHONENO;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_PHOTO", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PHOTO;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = STATUS;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_ADDRESS", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = ADDRESS;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_CITY", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = CITY;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_STATE", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = STATE;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_COUNTRY", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = COUNTRY;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_GROUP_ID", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = GROUP_ID;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_MODIFY_BY", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = MODIFY_BY;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("P_LOGIN_ID", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = LoginID;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("P_PASSWORD", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = Password;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("P_ISSUPERADMIN", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = IsSuperAdmin;
                orclcmd.Parameters.Add(prm16);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE ASTROLOGER
        public DataSet AddUpdateAstrologer(string Flag, string AstrologerID, string Name, string LoginID, string Photo, string Experience, string Equcation, string PhoneNo, string EmailID, string AlternateNo,
                                            string ExperIn, string Achivements, string SmallDesc, string FullDesc, string CurrentlyAvaliable, string Gender, string Address, string City, string State,
                                            string Country, string ZipCode, string Status, string SpeakeInLanguage, string GroupID, string Rating, string ModifyBy,
                                            string Password)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_UPDATE_ASTROLOGER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_astrologerid", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = AstrologerID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_name", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Name;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_loginid", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = LoginID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_photo", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Photo;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_experience", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Experience;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_education", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Equcation;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_phoneno", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PhoneNo;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_emailid", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = EmailID;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_alternate_no", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = AlternateNo;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_expert_in", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = ExperIn;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_achievements", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Achivements;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_small_desc", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = SmallDesc;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_full_desc", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = FullDesc;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_currently_available", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = CurrentlyAvaliable;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_gender", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = Gender;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_address", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = Address;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_city", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = City;
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("p_state", OracleType.VarChar);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = State;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_country", OracleType.VarChar);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = Country;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("p_zipcode", OracleType.VarChar);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = ZipCode;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("p_status", OracleType.VarChar);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = Status;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("p_speak_in_language", OracleType.VarChar);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = SpeakeInLanguage;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("p_group_id", OracleType.VarChar);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = GroupID;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("p_rating", OracleType.VarChar);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = Rating;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("p_modify_by", OracleType.VarChar);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = ModifyBy;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("p_password", OracleType.VarChar);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = Password;
                orclcmd.Parameters.Add(prm27);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet ManageAstrologer(string Flag, string ID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_ASTROLOGER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ASTROLOGER_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        public DataSet MapCustomerAstrologer(string Flag, string AstrologerID, string CustomerID, string Name, string CustomerNo, string Gender, string Dob, string Tob, string City, string State, string Country, string Slot, string CreatedBy, string CallDuration, string AppointmentDate)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_CUSTOMER_MAPPING", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ASTROLOGER_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = AstrologerID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_CUSTOMER_ID", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CustomerID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_CUSTOMER_NAME", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Name;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_CUSTOMER_NO", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = CustomerNo;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_GENDER", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Gender;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_DOB", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Dob;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_TOB", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Tob;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_CITY", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = City;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_STATE", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = State;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_COUNTRY", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Country;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_SLOT", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Slot;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_CREATED_BY", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = CreatedBy;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("P_CALL_DURATION", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = CallDuration;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("P_APPOINTMENT_DATE", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = AppointmentDate;
                orclcmd.Parameters.Add(prm15);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        public DataSet ManageMapingDetails(string Flag, string ID, string AstrologerStatus, string Photo , string Ans1, string Ans2, string Ans3, string Ans4, string Ans5)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_CUSTOMER_MAPPING", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("AstrologerID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("AstrologerStatus", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = AstrologerStatus;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("Photo", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Photo;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("Ans1", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Ans1;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("Ans2", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Ans2;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("Ans3", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Ans3;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("Ans4", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Ans4;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("Ans5", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Ans5;
                orclcmd.Parameters.Add(prm9);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region ADD ALBUM CATEGORY
        public DataSet AddAlbumCategory(string Flag, string CatID , string CatName , string CatDesc , string Title , string MetaKeywords, string MetaDesc , string ModifyBy , string Status , string Priority , string GroupID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_ALBUM_CATEGORY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_CAT_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CatID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_CATEGORY_NAME", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CatName;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_CATEGORY_DESC", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = CatDesc;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_TITLE", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Title;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_META_KEYWORDS", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_META_DESCRIPTION", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = MetaDesc;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_modify_by", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = ModifyBy;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_GROUP_ID", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = GroupID;
                orclcmd.Parameters.Add(prm11);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE ALBUM CATEGORY
        public DataSet ManageAlbumCategory(string Flag, string CatID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_ALBUM_CATEGORY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CatID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CatID;
                orclcmd.Parameters.Add(prm2);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region ADD ALBUM
        public DataSet AddAlbum(string Flag, string AlbumID, string CatID, string AlbumName, string CoverImage, string Title, string MetaKeywords, string MetaDesc, string ModifyBy, string Priority, string GroupID , string AlbumURL)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_ALBUM", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ALBUM_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = AlbumID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_CAT_ID", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CatID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_ALBUM_NAME", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = AlbumName;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_COVER_IMG", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = CoverImage;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_TITLE", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Title;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_META_KEYWORDS", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_META_DESCRIPTION", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = MetaDesc;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_modify_by", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = ModifyBy;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_GROUP_ID", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = GroupID;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_ALBUM_URL", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = AlbumURL;
                orclcmd.Parameters.Add(prm12);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE ALBUM
        public DataSet ManageAlbum(string Flag, string AlbumID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_ALBUM", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("AlbumID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = AlbumID;
                orclcmd.Parameters.Add(prm2);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region ADD GALLERY 
        public DataSet AddGallery(string Flag, string GalleryID, string Headline, string AlbumID, string Image, string Priority, string GroupID , string ImageDescription)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_GALLERY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_GALL_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GalleryID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_HEADLINE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Headline;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_ALBUMID", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = AlbumID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_IMAGE", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Image;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Priority;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_GROUP_ID", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = GroupID;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_DESCRIPTION", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = ImageDescription;
                orclcmd.Parameters.Add(prm8);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region ADD BLOG
        public DataSet AddBlogs(string Flag, string BlogID, string Title, string SubTitle, string Desc,  string MetaKeywords, string MetaDesc, 
            string Image, string  Active , string Modifyby,  string Priority, string Summary ,string WrittenBy, string GroupID ,string BlogURL , string Heading)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_BLOG", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_BLOG_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = BlogID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_TITLE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Title;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_SUB_TITLE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = SubTitle;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_DESCRIPTION", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Desc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_META_KEYWORDS", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_META_DESCRIPTION", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = MetaDesc;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_IMAGE", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Image;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_ACTIVE", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Active;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_modify_by", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Modifyby;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_PRIORITY", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Priority;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_SUMMARY", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Summary;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_WRITTEN_BY", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = WrittenBy;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14= new OracleParameter("P_GROUP_ID", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = GroupID;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("P_BLOG_URL", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = BlogURL;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("P_HEADLINE", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = Heading;
                orclcmd.Parameters.Add(prm16);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        #endregion

        #region GET BLOGS 
        public DataSet ManageBlog(string Flag, string BlogID , string Title , string Active)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_BLOGS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("blogid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BlogID;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("groupid", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = "";
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("flag", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Flag;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_TITLE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Title;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5= new OracleParameter("P_ACTIVE", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Active;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GetDashboardDetails

        public DataSet GetDashboardDetails(string Flag, string UserName, string FromDate, string ToDate, string SearchBy , string SortColumn , string SortOrder)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_DASHBOARD_DETAILS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERNAME", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UserName;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FROMDATE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = FromDate;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("TODATE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ToDate;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("SEARCHBY", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = SearchBy;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("SORTCOLUMN", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = SortColumn.ToUpper();
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("SORTORDER", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = SortOrder.ToUpper();
                orclcmd.Parameters.Add(prm7);

                orclcmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                orclcmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET ASHTAKOOT PREDICTIVE
        public DataSet GetAshtakootPredictive(string Flag , string ID , string GirlConstellation , string BoyConstellation)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_ASHTAKOOT_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GIRLCONSTELLATION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = GirlConstellation;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("BOYCONSTELLATION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = BoyConstellation;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE NADI PREDICTIVE
        public DataSet UpdateNadiPredictive(string Flag, string ID , string Nadi , string Defination , string IsMatch , string IsMatchException , string Predictive , 
            string Reminidal , string ExpertOpeinion , string Priority , string Status , string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_NADI_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_NADI", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Nadi;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Defination;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_ISMATCH", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = IsMatch;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_ISMATCH_EXCEPTION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = IsMatchException;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Predictive;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Reminidal;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = ExpertOpeinion;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Checked;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Status;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = UserID;
                orclcmd.Parameters.Add(prm13);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE BHAKOOT PREDICTIVE
        public DataSet UpdateBhakootPredictive(string Flag, string ID, string Defination, string Predictive, 
            string Reminidal, string ExpertOpeinion , string Priority , string Status , string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_BHAKOOT_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);
                
                OracleParameter prm3 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Defination;
                orclcmd.Parameters.Add(prm3);
                
                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Reminidal;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertOpeinion;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE GANA PREDICTIVE
        public DataSet UpdateGanaPredictive(string Flag, string ID, string Defination, string Predictive,string Remidial ,
             string ExpertComment, string Priority , string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_GANA_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Defination;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);



                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        
        #region UPDATE GRAHAMAITRI PREDICTIVE
        public DataSet UpdateGrahamaitriPredictive(string Flag, string ID, string Defination, string Predictive,string Remidial ,
             string ExpertComment, string Priority, string Status, string Checked, string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_GRAHAMAITRI_PREDIC", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Defination;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);



                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE YONI PREDICTIVE
        public DataSet UpdateYoniPredictive(string Flag, string ID, string Defination, string Predictive,string Remidial ,
             string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_YONI_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Defination;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE VASYA PREDICTIVE
        public DataSet UpdateVasyaPredictive(string Flag, string ID, string Defination, string Predictive, string Remidial,
             string ExpertComment, string Priority, string Status, string Checked ,string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_VASYA_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Defination;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE VARNA PREDICTIVE
        public DataSet UpdateVarnaPredictive(string Flag, string ID, string Predictive , string Defination, string Remidial,
             string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_VARNA_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Predictive;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Defination;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE TARA PREDICTIVE
        public DataSet UpdateTaraPredictive(string Flag, string ID, string Defination, string Predictive ,
            string Remidial,
             string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_TARA_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Defination;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region SAVE NEWS LETTER
        public DataSet SaveNewsLetter(string Flag, string ID, string Subject, string Headline , string Description , string Image , string ModifyBy , string GroupID , string Status)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_NEWSLETTER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_SUBJECT", OracleType.NVarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Subject;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_HEADLINE", OracleType.NVarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Headline;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_DESCRIPTION", OracleType.NClob);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Description;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_IMAGE", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Image;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_MODIFY_BY", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ModifyBy;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_GROUP_ID", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = GroupID;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET NEWS LETTER
        public DataSet GetNewsLetter(string Flag, string SearchBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_NEWSLETTER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_SEARCHBY", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = SearchBy;
                orclcmd.Parameters.Add(prm2);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE VARNA PREDICTIVE
        public DataSet UpdateEkaNakashtraDosha(string Flag, string ID, string Defination, string Predictive, string Remidial,
             string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_EKA_NAKASHTRA_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Predictive;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Defination;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE KAAL SARPA
        public DataSet UpdateKaalSarpa(string Flag, string ID, string Defination, string Predictive, string Remidial,
             string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_KAAL_SARPA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Predictive;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Remidial;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Defination;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE NAKASHTRA DOSHA PREDICTIVE
        public DataSet UpdateNakashtraDosha(string Flag, string ID, string Predictive, string Remedial , string Defination, string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_NAKASHTRA_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Predictive;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Remedial;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Defination;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);



                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    
        #region UPDATE VADHA VAINASIKA
        public DataSet UpdateVadhaVainsika(string Flag, string ID, string Predictive , string Definition ,string Remedial, string ExpertComment, 
                                           string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_VADHA_VAINASIKA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Predictive;
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Definition;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remedial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE VADHA NAKASHTRA27TH DOSHA
        public DataSet UpdateNakashtra27thDosha(string Flag, string ID, string Predictive, string Definition, string Remedial, string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_NAKASHTRA27TH_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Predictive;
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("P_DEFINITION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Definition;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remedial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ExpertComment;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE ASTROLOGER PRICE
        public DataSet ManageAstrologerPrice(string Flag, string ID, string AstrologerID, string NoOfMinutes, string PriceINR, string DiscountINR, 
            string FinalPriceINR, string PriceUSD, string DiscountUSD, string FinalPriceUSD, string Status, string CreatedBy , string PaymentFor , string NoOfQuestionss )
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_ASTROLOGER_PRICE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_astrologerid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = AstrologerID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_no_of_minutes", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = NoOfMinutes;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_price_inr", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = PriceINR;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_discount_inr", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = DiscountINR;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_final_price_inr", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = FinalPriceINR;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_price_usd", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = FinalPriceUSD;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_discount_usd", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = DiscountUSD;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_final_price_usd", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = FinalPriceUSD;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_status", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Status;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_createdby", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = CreatedBy;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_payment_for", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = PaymentFor;
                orclcmd.Parameters.Add(prm13);


                OracleParameter prm14 = new OracleParameter("p_no_of_questions", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = NoOfQuestionss;
                orclcmd.Parameters.Add(prm14);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE POOJA CATEGORY
        public DataSet ManageProductCategory(string Flag, string ID, string Name, string ShortDesc, string FullDesc, 
                                 string Status, string Priority, string Title, string MetaKeywords, string MetaDesc, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {


                con.Open();
                orclcmd = GetCommand("AST_MANAGE_PRODUCT_CATEGORY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_category_name", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Name;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_short_desc", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ShortDesc;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_full_desc", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = FullDesc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_status", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Status;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_priority", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_title", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Title;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_meta_keywords", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_meta_description", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = MetaDesc;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_created_by", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = CreatedBy;
                orclcmd.Parameters.Add(prm11);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        
        #region MANAGE PRODUCT 
        public DataSet ManageProduct(string Flag, string ID, string ProductCode, string ProductCategoryId, string ProductType, string ProductName,
                                    string ProductURL, string ProductPurpose, string ProductDimension, string ProductWeight , string ProductColor,
                                    string SmallImage, string LargeImage,  string ShortDesc, string FullDesc, string ProductRating, string ProductMaterial, string Instock ,
                                     string Status, string Priority, string Title, string MetaKeywords, string MetaDesc, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_PRODUCT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                                  
                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_product_code", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = ProductCode;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_product_category_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ProductCategoryId;
                orclcmd.Parameters.Add(prm4);
                
                OracleParameter prm5 = new OracleParameter("p_product_type", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = ProductType;
                orclcmd.Parameters.Add(prm5);
               
                OracleParameter prm6 = new OracleParameter("p_product_name", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ProductName;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_product_url", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ProductURL;
                orclcmd.Parameters.Add(prm7);


                


                OracleParameter prm8 = new OracleParameter("p_product_purpose", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = ProductPurpose;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_product_dimension", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = ProductDimension;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_product_weight", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = ProductWeight;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_product_color", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = ProductColor;
                orclcmd.Parameters.Add(prm11);
                
                OracleParameter prm12 = new OracleParameter("p_small_image", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = SmallImage;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_large_image", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = LargeImage;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_short_desc", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = ShortDesc;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_full_desc", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = FullDesc;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_product_rating", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = ProductRating;
                orclcmd.Parameters.Add(prm16);
                
                OracleParameter prm17 = new OracleParameter("p_product_material", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = ProductMaterial;
                orclcmd.Parameters.Add(prm17);
                
                OracleParameter prm18 = new OracleParameter("p_instock", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = Instock;
                orclcmd.Parameters.Add(prm18);
                
                OracleParameter prm19 = new OracleParameter("p_status", OracleType.VarChar);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = Status;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_priority", OracleType.VarChar);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = Priority;
                orclcmd.Parameters.Add(prm20);
                
                OracleParameter prm21 = new OracleParameter("p_title", OracleType.VarChar);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = Title;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("p_meta_keywords", OracleType.VarChar);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("p_meta_description", OracleType.VarChar);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = MetaDesc;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("p_created_by", OracleType.VarChar);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = CreatedBy;
                orclcmd.Parameters.Add(prm24);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE PRODUCT PRICE
        public DataSet ManageProductPrice(string Flag, string ID, string ProductID, string ProductDimension, string ProductWeight, string PriceINR,
                    string DiscountINR, string FinalPriceINR, string PriceUSD, string DiscountUSD, string FinalPriceUSD, string Priority, string Status, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {


                con.Open();
                orclcmd = GetCommand("AST_MANAGE_PRODUCT_PRICE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_productid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = ProductID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_product_dimension", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ProductDimension;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_product_weight", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = ProductWeight;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_price_inr", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PriceINR;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_discount_inr", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = DiscountINR;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_final_price_inr", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = FinalPriceINR;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_price_usd", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = PriceUSD;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_discount_usd", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = DiscountUSD;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_final_price_usd", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = FinalPriceUSD;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_priority", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Priority;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_status", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = Priority;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_createdby", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = CreatedBy;
                orclcmd.Parameters.Add(prm14);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE POOJA CATEGORY
        public DataSet ManagePoojaCategory(string Flag, string ID, string Name, string ShortDesc, string FullDesc,
                                 string Status, string Priority, string Title, string MetaKeywords, string MetaDesc, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {


                con.Open();
                orclcmd = GetCommand("AST_MANAGE_POOJA_CATEGORY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_category_name", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Name;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_short_desc", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ShortDesc;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_full_desc", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = FullDesc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_status", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Status;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_priority", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Priority;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_title", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Title;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_meta_keywords", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_meta_description", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = MetaDesc;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_created_by", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = CreatedBy;
                orclcmd.Parameters.Add(prm11);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE PRODUCT 
        public DataSet ManagePooja(string Flag, string ID, string PoojaCode, string PoojaCategoryId, string PoojaType, string PoojaName,
                                    string PoojaURL, string PoojaPurpose, string PoojaDimension, string PoojaWeight, string PoojaColor,
                                    string SmallImage, string LargeImage, string ShortDesc, string FullDesc, string PoojaRating, string PoojaMaterial, string Instock,
                                     string Status, string Priority, string Title, string MetaKeywords, string MetaDesc, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_POOJA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_Pooja_code", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = PoojaCode;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_Pooja_category_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = PoojaCategoryId;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_Pooja_type", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = PoojaType;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_Pooja_name", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PoojaName;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_Pooja_url", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = PoojaURL;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_Pooja_purpose", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PoojaPurpose;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm11 = new OracleParameter("p_Pooja_color", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = PoojaColor;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_small_image", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = SmallImage;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_large_image", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = LargeImage;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_short_desc", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = ShortDesc;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_full_desc", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = FullDesc;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_Pooja_rating", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = PoojaRating;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm19 = new OracleParameter("p_status", OracleType.VarChar);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = Status;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_priority", OracleType.VarChar);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = Priority;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("p_title", OracleType.VarChar);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = Title;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("p_meta_keywords", OracleType.VarChar);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = MetaKeywords;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("p_meta_description", OracleType.VarChar);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = MetaDesc;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("p_created_by", OracleType.VarChar);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = CreatedBy;
                orclcmd.Parameters.Add(prm24);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MANAGE PRODUCT PRICE
        public DataSet ManagePoojaPrice(string Flag, string ID, string ProductID, string NoOFPandit, string PriceINR,
                    string DiscountINR, string FinalPriceINR, string PriceUSD, string DiscountUSD, string FinalPriceUSD, string Priority, string Status, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {


                con.Open();
                orclcmd = GetCommand("AST_MANAGE_POOJA_PRICE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_poojaid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = ProductID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_no_of_pandit", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = NoOFPandit;
                orclcmd.Parameters.Add(prm4);
                
                OracleParameter prm5 = new OracleParameter("p_price_inr", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = PriceINR;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_discount_inr", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = DiscountINR;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_final_price_inr", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = FinalPriceINR;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_price_usd", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PriceUSD;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_discount_usd", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = DiscountUSD;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_final_price_usd", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = FinalPriceUSD;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_priority", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Priority;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_status", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Status;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_createdby", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = CreatedBy;
                orclcmd.Parameters.Add(prm13);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE DASHAMSHA PREDICTIVE
        public DataSet UpdateDashamshaPredictive(string Flag, string ID, string Deity, string Direction , string RulingPlanet , string PrePredictive ,
        string Predictive, string PredictiveType, string Remidial, string PredictiveFlag,
             string ExpertComment, string Priority, string Status, string Checked, string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_DASHAMSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_DEITY", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Deity;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_DIRECTION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Direction;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_RULING_PLANET", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = RulingPlanet;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_PRE_PREDICTIVE", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PrePredictive;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Predictive;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_PREDICTIVE_TYPE", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PredictiveType;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Remidial;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_PREDICTIVE_FLAG", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = PredictiveFlag;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = ExpertComment;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = Checked;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = Status;
                orclcmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = UserID;
                orclcmd.Parameters.Add(prm15);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE DASHAMSHA PREDICTIVE
        public DataSet UpdateVaisheshikamshaPredictive(string Flag, string ID, string VargasAmsaName, string VargasGroupId, string VargasName, 
                              string PrePredictive,  string Predictive, string PredictiveType, string Remidial, string PredictiveFlag,
                              string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_VAISHESHIKAMSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_VARGAS_AMSA_NAME", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = VargasAmsaName;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_VARGAS_GROUP_ID", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = VargasGroupId;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_VARGAS_NAME", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = VargasName;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_PRE_PREDICTIVE", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PrePredictive;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Predictive;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_PREDICTIVE_TYPE", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PredictiveType;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Remidial;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_PREDICTIVE_FLAG", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = PredictiveFlag;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = ExpertComment;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = Checked;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = Status;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = UserID;
                orclcmd.Parameters.Add(prm15);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE MANGLIK PREDICTIVE
        public DataSet UpdateManglikDoshaPredictive(string Flag, string ID, string Questions, string Predictive, string Remidial, 
                                                      string ExpertComment, string Priority, string Status, string Checked, string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_MANGLIK_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_QUESTION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Questions;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Priority;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ExpertComment;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET MAX PRIORITY
        public DataSet GetMaxPriority(string Flag, string Table,string Field_1,string Field_2, string Field_3)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_MAXPRIORITY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_table", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Table;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_filed_1", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Field_1;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filed_2", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Field_2;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filed_3", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Field_3;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Get Dashboard Details New
        public DataSet GetDashboardDetailsNew(string Flag, string UserName, string FromDate, string ToDate, string SearchBy, string SortColumn, string SortOrder, string UserType, string Month)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_DASHBOARD_DETAILS_NEW", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERNAME", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UserName;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FROMDATE", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = FromDate;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("TODATE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ToDate;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("SEARCHBY", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = SearchBy;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("SORTCOLUMN", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = SortColumn.ToUpper();
                orclcmd.Parameters.Add(prm6);

                
                OracleParameter prm7 = new OracleParameter("SORTORDER", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = SortOrder;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("USERTYPE", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = UserType;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("MONTHNO", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Month;
                orclcmd.Parameters.Add(prm9);

                orclcmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                orclcmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region UPDATE MANGLIK PREDICTIVE
        public DataSet UpdateDoshaSamyaPredictive(string Flag, string ID, string Questions, string Predictive, string Remidial,
                                                      string ExpertComment, string Priority, string Status, string Checked , string UserID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_DOSHA_SAMYA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_QUESTION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Questions;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PREDICTIVE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Predictive;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_REMEDIAL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Remidial;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Priority;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_EXPERT_OPINION", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ExpertComment;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_CHECKED", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Checked;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_USERID", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = UserID;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET NATAL CATEGORY PREDICTIVE
        public DataSet Get_Category_Predictive(string tablename,string categoryid,string question,string keystringval, string filterlogicval, string delimiterval, string flag1, string flag2,string flag3)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("SP_GET_CATEGORY_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_table", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tablename;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_categoryId", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = categoryid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_question", OracleType.VarChar, 500);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = question;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_keystring", OracleType.VarChar, 500);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = keystringval;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter", OracleType.VarChar, 1000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = filterlogicval;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_delim", OracleType.VarChar, 10);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = delimiterval;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_flag1", OracleType.VarChar, 500);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = flag1;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_flag2", OracleType.VarChar, 500);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = flag2;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_flag3", OracleType.VarChar, 500);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = flag3;
                orclcmd.Parameters.Add(prm9);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    
        #region SAVE COMBINATION
        public DataSet SaveCombinatiom(string ActionFlag, string LogicID, string LogicDesc, string Logic, string Combination, 
                                       string Rashi, string Lord, string Planet, string House , string  Constellation , string DegreeFrom,
                                       string DegreeTo , string  MoveToRashi , string MoveToLord , string MoveToPlanet, string MoveToHouse , string MoveToConstellation , 
                                       string LagnaRashi ,string LagnaLord , string LagnaDegreeFrom  , string LagnaDegreeTo , string LagnaConstellation , string ChartNo ,
                                       string AscendantDegree , string CrtdBy,  string Checked , string Status , string Priority)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_COMBINATION", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("actionflag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = ActionFlag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_logic_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = LogicID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_logic_desc", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = LogicDesc;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_logic", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Logic;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_combination", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Combination;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_rashi", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Rashi;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_lord", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Lord;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_planet", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Planet;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_house", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = House;
                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_constellation", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Constellation;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_degree_from", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = DegreeFrom;
                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_degree_to", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = DegreeTo;
                orclcmd.Parameters.Add(prm12);


                OracleParameter prm13 = new OracleParameter("p_move_to_rashi", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = MoveToRashi;
                orclcmd.Parameters.Add(prm13);


                OracleParameter prm14 = new OracleParameter("p_move_to_lord", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value =MoveToLord;
                orclcmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("p_move_to_planet", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = MoveToPlanet;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_move_to_house", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = MoveToHouse;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_move_to_constellation", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = MoveToConstellation;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_lagna_rashi", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = LagnaRashi;
                orclcmd.Parameters.Add(prm18);
                 
                OracleParameter prm19 = new OracleParameter("p_lagna_lord", OracleType.VarChar);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = LagnaLord;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_lagna_degree_from", OracleType.VarChar);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = LagnaDegreeFrom;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("p_lagna_degree_to", OracleType.VarChar);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = LagnaDegreeTo;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("p_lagna_constellation", OracleType.VarChar);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = LagnaConstellation;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("p_chart_no", OracleType.VarChar);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value =ChartNo;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("p_ascendant_degree", OracleType.VarChar);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = AscendantDegree;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("p_crtd_by", OracleType.VarChar);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = CrtdBy;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("p_checked", OracleType.VarChar);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = Checked;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("p_status", OracleType.VarChar);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = Status;
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("p_priority", OracleType.VarChar);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = Priority;
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("p_ex1", OracleType.VarChar);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = "";
                orclcmd.Parameters.Add(prm29);

                OracleParameter prm30 = new OracleParameter("p_ex2", OracleType.VarChar);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = "";
                orclcmd.Parameters.Add(prm30);

                OracleParameter prm31 = new OracleParameter("p_ex3", OracleType.VarChar);
                prm31.Direction = ParameterDirection.Input;
                prm31.Value = "";
                orclcmd.Parameters.Add(prm31);

                OracleParameter prm32 = new OracleParameter("p_ex4", OracleType.VarChar);
                prm32.Direction = ParameterDirection.Input;
                prm32.Value = "";
                orclcmd.Parameters.Add(prm32);

                OracleParameter prm33 = new OracleParameter("p_ex5", OracleType.VarChar);
                prm33.Direction = ParameterDirection.Input;
                prm33.Value = "";
                orclcmd.Parameters.Add(prm33);

                OracleParameter prm34 = new OracleParameter("p_ex6", OracleType.VarChar);
                prm34.Direction = ParameterDirection.Input;
                prm34.Value = "";
                orclcmd.Parameters.Add(prm34);

                OracleParameter prm35 = new OracleParameter("p_ex7", OracleType.VarChar);
                prm35.Direction = ParameterDirection.Input;
                prm35.Value = "";
                orclcmd.Parameters.Add(prm35);

                OracleParameter prm36 = new OracleParameter("p_ex8", OracleType.VarChar);
                prm36.Direction = ParameterDirection.Input;
                prm36.Value = "";
                orclcmd.Parameters.Add(prm36);

                OracleParameter prm37 = new OracleParameter("p_ex9", OracleType.VarChar);
                prm37.Direction = ParameterDirection.Input;
                prm37.Value = "";
                orclcmd.Parameters.Add(prm37);

                OracleParameter prm38 = new OracleParameter("p_ex10", OracleType.VarChar);
                prm38.Direction = ParameterDirection.Input;
                prm38.Value = "";
                orclcmd.Parameters.Add(prm38);

                OracleParameter prm39 = new OracleParameter("p_flag", OracleType.VarChar);
                prm39.Direction = ParameterDirection.Input;
                prm39.Value = "";
                orclcmd.Parameters.Add(prm39);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET COMBINATION
        public DataSet GetCombination(string FLag, string Logicid, string Chartno , string Rashi , string House , string Planet , string Logicdesc)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_COMBINATION", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = FLag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_logic_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Logicid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_chartno", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Chartno;
                orclcmd.Parameters.Add(prm3);
            
                OracleParameter prm4 = new OracleParameter("p_rashi", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Rashi;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_house", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = House;
                orclcmd.Parameters.Add(prm5);
             
               OracleParameter prm6 = new OracleParameter("p_planet", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Planet;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_logicdesc", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Logicdesc;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_ex1", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_ex2", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_ex3", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_ex4", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_ex5", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Save Predictive
        public DataSet SavePredictive(string ActionFlag, string PredictiveID, string LogicDesc, string Logic, string Combination,
                                       string Predictive, string Remedial, string PredictiveType, string PredictiveFor, string PredictiveGroup, string PredictiveShow,
                                       string CategoryId, string CrtdBy, string Checked, string Status, string Priority,string LogicID , string UniqueID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_NATAL_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("actionflag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = ActionFlag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_predictive_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = PredictiveID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_logic_id", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = LogicID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_logic_desc", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = LogicDesc;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_logic", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Logic;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_combination", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Combination;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_predictive", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Predictive;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_remedial", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Remedial;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_predictive_type", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = PredictiveType;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_predictive_for", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = PredictiveFor;
                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_predictive_group", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value =PredictiveGroup;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_predictive_show", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = PredictiveShow;
                orclcmd.Parameters.Add(prm12);


                OracleParameter prm13 = new OracleParameter("p_category_id", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = CategoryId;
                orclcmd.Parameters.Add(prm13);

 
                OracleParameter prm14 = new OracleParameter("p_crtd_by", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = CrtdBy;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_checked", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = Checked;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_status", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = Status;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_priority", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = Priority;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_ex1", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = "";
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("p_ex2", OracleType.VarChar);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = "";
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_ex3", OracleType.VarChar);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = "";
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("p_ex4", OracleType.VarChar);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = "";
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("p_ex5", OracleType.VarChar);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = "";
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("p_ex6", OracleType.VarChar);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = "";
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("p_ex7", OracleType.VarChar);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = "";
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("p_ex8", OracleType.VarChar);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = "";
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("p_ex9", OracleType.VarChar);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = "";
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("p_ex10", OracleType.VarChar);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = "";
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("p_flag", OracleType.VarChar);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = "";
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("p_unique_id", OracleType.VarChar);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = UniqueID;
                orclcmd.Parameters.Add(prm29);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET COMBINATION
        public DataSet GetPredictive(string FLag, string Predictiveid, string Logic , string Checked , string Status)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = FLag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_predictive_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Predictiveid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_predictive", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Logic;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_checked", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Checked;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_status", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Status;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_ex1", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_ex2", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_ex3", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_ex4", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_ex5", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET ClientList
        public DataSet GetClientList(string FLag, string Name, string FromDate, string ToDate , string AstrologerID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_CLIENT_LIST", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = FLag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_name", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Name;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_fromdate", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = FromDate;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_todate", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ToDate;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_astrologerid", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = AstrologerID;
                orclcmd.Parameters.Add(prm5);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GET ClientList
        public DataSet SaveAstroReport(string Flag, string ClientId, string CategoryID, string AstrologerID , string Status, string Createdby)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_ASTRO_REPORT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_CLIENT_ID", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ClientId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_CATEGORY_ID", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CategoryID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_ASTROLOGER_ID", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = AstrologerID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_STATUS", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Status;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_MODIFY_BY", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Createdby;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

    }
}
