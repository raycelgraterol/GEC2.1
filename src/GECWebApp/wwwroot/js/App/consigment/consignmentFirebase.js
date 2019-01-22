//codigo para guardar en base de datos Fire Base

var message = "";
var db;

var dataremittances1 = new Array();
var dataremittances2 = new Array();
var dataremittances3 = new Array();
var dataremittances4 = new Array();
var dataremittances5 = new Array();
var dataremittances6 = new Array();
var dataremittances7 = new Array();

var colection = "Remesas";
var idremittances = "";



function validate(amountBtc, remittancesAmount, remittanceRates, ratesSoldsBtc) {

    if (amountBtc == "" || remittancesAmount == "" || remittanceRates == "" || ratesSoldsBtc == "") {

        return message = "Porfavor no dejar ningun recuadro vacio.";
    }
    else {
        return message = "";
    }

}


function saveRemittances() {

    var rodeBtc = parseFloat(document.getElementById("cantidadBtc").value);
    var rodeRemittances = parseFloat(document.getElementById("montoRemesas").value);
    var remittancesRates = parseFloat(document.getElementById("tasasRemesas").value);
    var rateSoldsBtc = parseFloat(document.getElementById("tasasVentasBtc").value);
    var myContry = document.getElementById("pais").value;


    if (validate(rodeBtc, rodeRemittances, remittancesRates, rateSoldsBtc) == "") {

        var contactCheck = document.getElementById("contacto").checked;
        var f = new Date();
        var profitC = 0;
        var profitE = 0;
        var profitGEC = 0;
        var fechaActual = f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear();


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
            addFirebase(db, colection, fullTotaly, contactCheck, profitC, profitE, profitGEC, entryAmount, profitcompany, fechaActual, myContry);
        }


    }
    else {
        var msnDiv = document.getElementById("mensajeError");
        msnDiv.innerHTML = `<div class="alert alert-danger">${validate(rodeBtc, rodeRemittances, remittancesRates, rateSoldsBtc)}</div>`
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

    msnDiv.innerHTML = "";

}

function getRemittances() {

    var remittancesTable = document.getElementById("datosTabla");


    var i = 0;

    db.collection(colection).limit(5).onSnapshot((querySnapshot) => {
        remittancesTable.innerHTML = "";

        getTable(querySnapshot, remittancesTable, i);

    });

}

function updateRemittances(id) {

    var f = new Date();
    var nowDay = f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear();

    var totalyPriceDB = document.getElementById("montoTotal").value;
    var contactCheckBD = document.getElementById("contacto").checked;
    var profitCBD = document.getElementById("gananciaC").value;
    var profitEDB = document.getElementById("gananciaE").value;
    var profitGECDB = document.getElementById("gananciaGEC").value;
    var entryAmountDB = document.getElementById("montoEntrega").value;
    var priceNtDB = document.getElementById("gananciaNeta").value;
    var myDate = nowDay;

    firebaseUpdate(colection, id, totalyPriceDB, contactCheckBD, profitCBD, profitEDB, profitGECDB, entryAmountDB, priceNtDB, myDate);
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

    idremittances = id;
}

function look() {

    var myDateF = document.getElementById("filtrofecha").checked;
    var contryF = document.getElementById("filtroPais").checked;
    var amountF = "";
    var filter = "";

    var search = document.getElementById("buscaRemesa").value;
    var remittancesTable = document.getElementById("datosTabla");
    var i = 0;

    var errFilter = document.getElementById("errorFiltro");
    var existErr = null;

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

        db.collection(colection).where(filter, "==", search.toUpperCase()).limit(5)
            .get()
            .then(function (querySnapshot) {
                remittancesTable.innerHTML = "";



                if (getTable(querySnapshot, remittancesTable, i) == null) {
                    errFilter.innerHTML = `<div class="alert alert-danger" id="errorFiltro">Ingreso algun dato Incorrecto</div>`;
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


