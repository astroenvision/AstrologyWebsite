function SelectHi(grdid, obj, objlist) {

    if (document.getElementById("DataGrid1_ctl01_cb").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid1_ctl01_cb";
        for (j = 1; j <= document.getElementById("DataGrid1").rows.length; j++) {
            if (objlist == "cb") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid1_ctl" + str3 + "_cb1";
                }
                else {
                    str1 = "DataGrid1_ctl0" + str3 + "_cb1";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid1_ctl02_cb1";
        for (j = 1; j < document.getElementById("DataGrid1").rows.length; j++) {
            if (objlist == "cb") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid1_ctl" + str3 + "_cb1";
                }
                else {
                    str1 = "DataGrid1_ctl0" + str3 + "_cb1";
                }
            }
        }
        return false;
    }

}


function SelectHii(grdid, obj, objlist) {

    if (document.getElementById("DataGrid2_ctl01_cb").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid2_ctl01_cb";
        for (j = 1; j <= document.getElementById("DataGrid2").rows.length; j++) {
            if (objlist == "cb") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid2_ctl" + str3 + "_cb1";
                }
                else {
                    str1 = "DataGrid2_ctl0" + str3 + "_cb1";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid2_ctl02_cb1";
        for (j = 1; j < document.getElementById("DataGrid2").rows.length; j++) {
            if (objlist == "cb") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid2_ctl" + str3 + "_cb1";
                }
                else {
                    str1 = "DataGrid2_ctl0" + str3 + "_cb1";
                }
            }
        }
        return false;
    }

}



function SelectHiii(grdid, obj, objlist) {

    if (document.getElementById("DataGrid3_ctl01_cb3").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid3_ctl01_cb3";
        for (j = 1; j <= document.getElementById("DataGrid3").rows.length; j++) {
            if (objlist == "cb3") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid3_ctl" + str3 + "_cbx3";
                }
                else {
                    str1 = "DataGrid3_ctl0" + str3 + "_cbx3";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid3_ctl02_cbx3";
        for (j = 1; j < document.getElementById("DataGrid3").rows.length; j++) {
            if (objlist == "cb3") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid3_ctl" + str3 + "_cbx3";
                }
                else {
                    str1 = "DataGrid3_ctl0" + str3 + "_cbx3";
                }
            }
        }
        return false;
    }

}


function SelectH(grdid, obj, objlist) {

    if (document.getElementById("DataGrid4_ctl01_cb4").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid4_ctl01_cb4";
        for (j = 1; j <= document.getElementById("DataGrid4").rows.length; j++) {
            if (objlist == "cb4") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid4_ctl" + str3 + "_cbx4";
                }
                else {
                    str1 = "DataGrid4_ctl0" + str3 + "_cbx4";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid4_ctl02_cbx4";
        for (j = 1; j < document.getElementById("DataGrid4").rows.length; j++) {
            if (objlist == "cb4") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid4_ctl" + str3 + "_cbx4";
                }
                else {
                    str1 = "DataGrid4_ctl0" + str3 + "_cbx4";
                }
            }
        }
        return false;
    }

}


function Select7(grdid, obj, objlist) {

    if (document.getElementById("DataGrid7_ctl01_cb7").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid7_ctl01_cb7";
        for (j = 1; j <= document.getElementById("DataGrid7").rows.length; j++) {
            if (objlist == "cb7") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid7_ctl" + str3 + "_cbx7";
                }
                else {
                    str1 = "DataGrid7_ctl0" + str3 + "_cbx7";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid7_ctl02_cbx7";
        for (j = 1; j < document.getElementById("DataGrid7").rows.length; j++) {
            if (objlist == "cb7") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid7_ctl" + str3 + "_cbx7";
                }
                else {
                    str1 = "DataGrid7_ctl0" + str3 + "_cbx7";
                }
            }
        }
        return false;
    }

}



function Select10(grdid, obj, objlist) {

    if (document.getElementById("DataGrid10_ctl01_cb10").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid10_ctl01_cb10";
        for (j = 1; j <= document.getElementById("DataGrid10").rows.length; j++) {
            if (objlist == "cb10") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid10_ctl" + str3 + "_cbx10";
                }
                else {
                    str1 = "DataGrid10_ctl0" + str3 + "_cbx10";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid10_ctl02_cbx10";
        for (j = 1; j < document.getElementById("DataGrid10").rows.length; j++) {
            if (objlist == "cb10") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid10_ctl" + str3 + "_cbx10";
                }
                else {
                    str1 = "DataGrid10_ctl0" + str3 + "_cbx10";
                }
            }
        }
        return false;
    }

}


function Select12(grdid, obj, objlist) {

    if (document.getElementById("DataGrid12_ctl01_cb12").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid12_ctl01_cb12";
        for (j = 1; j <= document.getElementById("DataGrid12").rows.length; j++) {
            if (objlist == "cb12") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid12_ctl" + str3 + "_cbx12";
                }
                else {
                    str1 = "DataGrid12_ctl0" + str3 + "_cbx12";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid12_ctl02_cbx12";
        for (j = 1; j < document.getElementById("DataGrid12").rows.length; j++) {
            if (objlist == "cb12") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid12_ctl" + str3 + "_cbx12";
                }
                else {
                    str1 = "DataGrid12_ctl0" + str3 + "_cbx12";
                }
            }
        }
        return false;
    }

}



function Select16(grdid, obj, objlist) {

    if (document.getElementById("DataGrid16_ctl01_cb16").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid16_ctl01_cb16";
        for (j = 1; j <= document.getElementById("DataGrid16").rows.length; j++) {
            if (objlist == "cb16") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid16_ctl" + str3 + "_cbx16";
                }
                else {
                    str1 = "DataGrid16_ctl0" + str3 + "_cbx16";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid16_ctl02_cbx16";
        for (j = 1; j < document.getElementById("DataGrid16").rows.length; j++) {
            if (objlist == "cb16") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid16_ctl" + str3 + "_cbx16";
                }
                else {
                    str1 = "DataGrid16_ctl0" + str3 + "_cbx16";
                }
            }
        }
        return false;
    }

}