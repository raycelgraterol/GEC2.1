﻿//codigo para guardar en base de datos Fire Base

var message = "";
var db;

var dataremittances1 = new Array();
var dataremittances2 = new Array();
var dataremittances3 = new Array();
var dataremittances4 = new Array();
var dataremittances5 = new Array();
var dataremittances6 = new Array();
var dataremittances7 = new Array();
var dataremittances8 = new Array();
var dataremittances9 = new Array();
var dataremittances10 = new Array();
var dataremittances11 = new Array();
var dataremittances12 = new Array();
var dataremittances13 = new Array();

var colection = "Remesas";
var idremittances = "";


function myselectfilterContry() {

    var contryF2 = document.getElementById("filtroPais").checked;

    var containerLook = document.getElementById("contenedorBusqueda");

    if (contryF2) {

        containerLook.innerHTML = `
                                <span class="input-group-prepend">
                                  <button type="button" name="botonBuscar" id="botonBuscar" class="btn btn-primary" onclick="look()">
                                    <i class="fa fa-search"></i> Search
                                  </button>
                                </span>
                                <select class="form-control" name="buscaRemesa" id="buscaRemesa">
                                    <option>COLOMBIA</option>
                                    <option>CHILE</option>
                                    <option>ECUADOR</option>
                                    <option>PANAMA</option>
                                    <option>PERU</option>
                                    <option>R. DOMINICANA</option>
                                    <option>MEXICO</option>
                                    <option>ARGENTINA</option>
                                    <option>ESPAÑA</option>
                                </select>

                            `;

    }
    
}

function myselectfilterDate(){

    var myDateF2 = document.getElementById("filtrofecha").checked;

    var containerLook = document.getElementById("contenedorBusqueda");

    if (myDateF2) {

        containerLook.innerHTML = `
                                <span class="input-group-prepend">
                                  <button type="button" name="botonBuscar" id="botonBuscar" class="btn btn-primary" onclick="look()">
                                    <i class="fa fa-search"></i> Search
                                  </button>
                                </span>

                                    <input type="text" disabled value="Remesas desde:" class="form-control" />
                                <div class="form-group">
                                  <input id="midatepicker" type="date" name="midatepicker" class="form-control" />
                                </div>

                                  <input type="text" disabled value="Hasta:" class="form-control fechaFinal" />
                                <div class="form-group">
                                  <input id="otroDia" type="date" name="otroDia" class="form-control" />
                                </div>
                                <input hidden type="text"/>
                            `;

    }
}


function validate(amountBtc, remittancesAmount, remittanceRates, ratesSoldsBtc, insertDate) {


    if (amountBtc == "" || remittancesAmount == "" || remittanceRates == "" || ratesSoldsBtc == "" || insertDate == "") {

        return message = "Porfavor no dejar ningun recuadro vacio.";
    }
    else {
        return message = "";
    }

}


function saveRemittances() {

    var rodeBtcV = document.getElementById("cantidadBtc").value;
    var rodeRemittancesV = document.getElementById("montoRemesas").value;
    var remittancesRatesV = document.getElementById("tasasRemesas").value;
    var rateSoldsBtcV = document.getElementById("tasasVentasBtc").value;


    var rodeBtc = parseFloat(document.getElementById("cantidadBtc").value);
    var rodeRemittances = parseFloat(document.getElementById("montoRemesas").value);
    var remittancesRates = parseFloat(document.getElementById("tasasRemesas").value);
    var rateSoldsBtc = parseFloat(document.getElementById("tasasVentasBtc").value);

    var insertDate = document.getElementById("meteFecha").value;
    var myContry = document.getElementById("pais").value;


    if (validate(rodeBtcV, rodeRemittancesV, remittancesRatesV, rateSoldsBtcV, insertDate) == "") {

        var contactCheck = document.getElementById("contacto").checked;
        var f = new Date();
        var profitC = 0;
        var profitE = 0;
        var profitGEC = 0;

        var myDay = insertDate[8] + insertDate[9];
        var myMount = insertDate[5] + insertDate[6];
        var myYear = insertDate[0] + insertDate[1] + insertDate[2] + insertDate[3];

        var fechaActual = myDay + "/" + myMount + "/" + myYear;


        var fullTotaly = (rodeBtc * rateSoldsBtc).toFixed(2);
        var entryAmount = (remittancesRates * rodeRemittances).toFixed(2);

        var profitcompany = (fullTotaly - entryAmount).toFixed(2); // ganancia para despues dependiente del contacto

        if (contactCheck) {

            profitC = (profitcompany * 0.2).toFixed(2);
            profitE = (profitcompany * 0.3).toFixed(2);
            profitGEC = (profitcompany * 0.5).toFixed(2);



        } else {

            profitC = 0;
            profitE = (profitcompany * 0.4).toFixed(2);
            profitGEC = (profitcompany * 0.6).toFixed(2);

        }
        //var gananciaNeta = (rodeBtc + rodeRemittances + rateSoldsBtc + remittancesRates);

        document.getElementById("montoTotal").value = fullTotaly;
        document.getElementById("gananciaC").value = profitC;
        document.getElementById("gananciaE").value = profitE;
        document.getElementById("gananciaGEC").value = profitGEC;
        document.getElementById("montoEntrega").value = entryAmount;
        document.getElementById("gananciaNeta").value = profitcompany;


        if (idremittances != "") {

            updateRemittances(idremittances);

        }
        else {
            addFirebase(db, colection, fullTotaly, contactCheck, profitC, profitE, profitGEC, entryAmount, profitcompany, fechaActual, myContry, rodeBtc, rodeRemittances, remittancesRates, rateSoldsBtc);
        }


    }
    else {
        var msnDiv = document.getElementById("mensajeError");
        msnDiv.innerHTML = `<div class="alert alert-danger">${validate(rodeBtcV, rodeRemittancesV, remittancesRatesV, rateSoldsBtcV)}</div>`;
        setTimeout(function () { msnDiv.innerHTML = `<div class=""></div>`; }, 3000);
    }


}

function Cancelremittances() {

    document.getElementById("cantidadBtc").value = "";
    document.getElementById("montoRemesas").value = "";
    document.getElementById("tasasRemesas").value = "";
    document.getElementById("tasasVentasBtc").value = "";

    document.getElementById("montoTotal").value = "";
    document.getElementById("gananciaC").value = "";
    document.getElementById("gananciaE").value = "";
    document.getElementById("gananciaGEC").value = "";
    document.getElementById("montoEntrega").value = "";
    document.getElementById("gananciaNeta").value = "";

    jk = 0;
    idremittances = "";
    msnDiv.innerHTML = "";

}

function getRemittances() {

    var remittancesTable = document.getElementById("datosTabla");


    var i = 0;

    db.collection(colection).orderBy("fecha", "desc").limit(8).onSnapshot((querySnapshot) => {
        remittancesTable.innerHTML = "";

        getTable(querySnapshot, remittancesTable, i);

    });

}

function updateRemittances(id) {

    var f = new Date();
    var nowDay = document.getElementById("meteFecha").value;

    var myDay = nowDay[8] + nowDay[9];
    var myMount = nowDay[5] + nowDay[6];
    var myYear = nowDay[0] + nowDay[1] + nowDay[2] + nowDay[3];

    var fechaActual = myDay + "/" + myMount + "/" + myYear;

    var rodeBtc = parseFloat(document.getElementById("cantidadBtc").value);
    var rodeRemittances = parseFloat(document.getElementById("montoRemesas").value);
    var remittancesRates = parseFloat(document.getElementById("tasasRemesas").value);
    var rateSoldsBtc = parseFloat(document.getElementById("tasasVentasBtc").value);

    var totalyPriceDB = document.getElementById("montoTotal").value;
    var contactCheckBD = document.getElementById("contacto").checked;
    var profitCBD = document.getElementById("gananciaC").value;
    var profitEDB = document.getElementById("gananciaE").value;
    var profitGECDB = document.getElementById("gananciaGEC").value;
    var entryAmountDB = document.getElementById("montoEntrega").value;
    var priceNtDB = document.getElementById("gananciaNeta").value;
    var myDate = fechaActual;
    var myContry = document.getElementById("pais").value;

    firebaseUpdate(colection, id, totalyPriceDB, contactCheckBD, profitCBD, profitEDB, profitGECDB, entryAmountDB, priceNtDB, myDate, myContry, rodeBtc, rodeRemittances, remittancesRates, rateSoldsBtc);
    console.log(id);
}

function saveDataId(id, n) {

    document.getElementById("contacto").checked = dataremittances1[n];
    document.getElementById("gananciaC").value = dataremittances2[n];
    document.getElementById("gananciaE").value = dataremittances3[n];
    document.getElementById("gananciaGEC").value = dataremittances4[n];
    document.getElementById("montoEntrega").value = dataremittances5[n];
    document.getElementById("gananciaNeta").value = dataremittances6[n];
    document.getElementById("montoTotal").value = dataremittances7[n];
    document.getElementById("pais").value = dataremittances8[n];
    document.getElementById("cantidadBtc").value = dataremittances9[n];
    document.getElementById("montoRemesas").value = dataremittances10[n];
    document.getElementById("tasasRemesas").value = dataremittances11[n];
    document.getElementById("tasasVentasBtc").value = dataremittances12[n];

    var fechaActual = dataremittances13[n];
    document.getElementById("meteFecha").value = fechaActual[6] + fechaActual[7] + fechaActual[8] + fechaActual[9] + "-" + fechaActual[3] + fechaActual[4] + "-" + fechaActual[0] + fechaActual[1];

    idremittances = id;
}

function look() {

    var myDateF = document.getElementById("filtrofecha").checked;
    var contryF = document.getElementById("filtroPais").checked;
    var countOfDate = "";
    var search = "";
    numberDoc = 0;

    var filter = "";

    if (myDateF) {

        var calendario = document.getElementById("midatepicker").value;
        var calendario2 = document.getElementById("otroDia").value;

        var d = calendario[8] + calendario[9];
        var d2 = calendario2[8] + calendario2[9];

        var nMes1 = parseInt(calendario[5] + calendario[6]);
        var nMes2 = parseInt(calendario2[5] + calendario2[6]);

        var otroDia = parseInt(d2);
        var dia = parseInt(d);
        var mes = calendario[5] + calendario[6];
        var mes2 = calendario2[5] + calendario2[6];
        var year = calendario[0] + calendario[1] + calendario[2] + calendario[3];

        var vueltasMes = nMes2 - nMes1;

        var meses = 0;

        if (vueltasMes == 0) {

            var vueltasDias = otroDia - dia;

        } else {

            var vueltasDias = 31 - dia;
            
        }

        
        p = 0;
        jk = 0;

        //alert(calendario + "  calendario 2 " + calendario2);
        //alert("dia: " + dia + "mes: " + mes + "year: " + year + "otroDia: " + otroDia);
    } else {
        search = document.getElementById("buscaRemesa").value;
    }
 
    var remittancesTable = document.getElementById("datosTabla");
    var errFilter = document.getElementById("errorFiltro");

    if (myDateF) {
        filter = "fecha";
    }
    else if (contryF) {
        filter = "pais";
    }
    else {
        filter = "montoTotalDB"
    }


    if (filter != "") {

        if (filter == "fecha") { 

            for (var l = 0; l <= vueltasMes; l++) {

                remittancesTable.innerHTML = "";

                for (var i = 0; i < vueltasDias + 1; i++) {

                    dia = parseInt(dia);
                    diaTotal = dia + i;

                    if (l == 0) {

                        
                    } else {

                        dia = 1;
                        diaTotal = dia + i;
                    }

                    remittancesTable.innerHTML = "";

                    if (diaTotal < 10) {
                        var fullDate = "0" + diaTotal + "/" + mes + "/" + year;
                    } else {
                        var fullDate = diaTotal + "/" + mes + "/" + year;
                    }

                    db.collection(colection).where(filter, "==", fullDate).limit(8)
                        .get()
                        .then(function (querySnapshot) {

                            if (getTable(querySnapshot, remittancesTable, jk) == (vueltasDias + 1)) {

                                if (numberDoc == 0) {

                                    errFilter.innerHTML = `<div class="alert alert-danger" id="errorFiltro">Ingreso algun dato Incorrecto</div>`;
                                    setTimeout(function () { errFilter.innerHTML = `<div class=""></div>`; getRemittances(); }, 3000);

                                }

                            }
                            else {
                                errFilter.innerHTML = `<div id="errorFiltro"></div>`;
                            }

                        })
                        .catch(function (error) {
                            console.log("Error getting documents: ", error);
                        });

                }

                if (vueltasMes != 0) {

                    i = 0;
                    vueltasDias = otroDia;
                    var o = parseInt(mes);
                    meses = parseInt(o + 1);

                    if (meses < 10) {
                        mes = "0" + meses;

                    } else {
                        mes = "" + meses;
                    }

                }

            }

            

        } else {

            db.collection(colection).where(filter, "==", search.toUpperCase()).limit(8)
                .get()
                .then(function (querySnapshot) {
                    remittancesTable.innerHTML = "";



                    if (getTable(querySnapshot, remittancesTable, i) == 0) {
                        errFilter.innerHTML = `<div class="alert alert-danger" id="errorFiltro">Ingreso algun dato Incorrecto</div>`;
                        setTimeout(function () { errFilter.innerHTML = `<div class=""></div>`; getRemittances(); }, 3000);

                    }
                    else {
                        errFilter.innerHTML = `<div id="errorFiltro"></div>`;
                    }

                })
                .catch(function (error) {
                    console.log("Error getting documents: ", error);
                });

        }
    }

}

function deleteRemittances(id) {

    var eliminar = confirm("¿Seguro que desea ELIMINAR la Remesa?");

    if (eliminar) {
        deleteFirebase(db, colection, id);
    } else {

    }

}


