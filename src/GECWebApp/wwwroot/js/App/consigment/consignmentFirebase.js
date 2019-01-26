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
var dataremittances8 = new Array();

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
                                <input type="text" disabled value="Dia" class="form-control"/>
                                <select class="form-control" name="dia" id="dia">
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                    <option>7</option>
                                    <option>8</option>
                                    <option>9</option>
                                    <option>10</option>
                                    <option>11</option>
                                    <option>12</option>
                                    <option>13</option>
                                    <option>14</option>
                                    <option>15</option>
                                    <option>16</option>
                                    <option>17</option>
                                    <option>18</option>
                                    <option>19</option>
                                    <option>20</option>
                                    <option>21</option>
                                    <option>22</option>
                                    <option>23</option>
                                    <option>24</option>
                                    <option>25</option>
                                    <option>26</option>
                                    <option>27</option>
                                    <option>28</option>
                                    <option>29</option>
                                    <option>30</option>
                                    <option>31</option>
                                </select>
                                <input type="text" disabled value="Mes" class="form-control"/>
                                <select class="form-control" name="mes" id="mes">
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                    <option>7</option>
                                    <option>8</option>
                                    <option>9</option>
                                    <option>10</option>
                                    <option>11</option>
                                    <option>12</option>
                                </select>
                                <input type="text" disabled value="Año" class="form-control"/>
                                <select class="form-control" name="year" id="year">
                                    <option>2019</option>
                                    <option>2018</option>
                                    <option>2017</option>
                                    <option>2016</option>
                                    <option>2015</option>
                                    <option>2014</option>
                                    <option>2013</option>
                                    <option>2012</option>
                                    <option>2011</option>
                                    <option>2011</option>
                                    <option>2010</option>
                                    <option>209</option>
                                    <option>2008</option>
                                    <option>2007</option>
                                    <option>2006</option>
                                    <option>2005</option>
                                    <option>2004</option>
                                    <option>2003</option>
                                    <option>2002</option>
                                    <option>2001</option>
                                    <option>2000</option>
                                </select>
                                <input type="text" disabled value="Hasta" class="form-control" />
                                <select class="form-control" name="dia" id="otroDia">
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                    <option>7</option>
                                    <option>8</option>
                                    <option>9</option>
                                    <option>10</option>
                                    <option>11</option>
                                    <option>12</option>
                                    <option>13</option>
                                    <option>14</option>
                                    <option>15</option>
                                    <option>16</option>
                                    <option>17</option>
                                    <option>18</option>
                                    <option>19</option>
                                    <option>20</option>
                                    <option>21</option>
                                    <option>22</option>
                                    <option>23</option>
                                    <option>24</option>
                                    <option>25</option>
                                    <option>26</option>
                                    <option>27</option>
                                    <option>28</option>
                                    <option>29</option>
                                    <option>30</option>
                                    <option>31</option>
                                </select>
                                <input type="text" hidden  name="buscaRemesa" id="buscaRemesa" class="form-control" placeholder="18/1/2019" />

                            `;

    }

}


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
    var nowDay = f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear();

    var totalyPriceDB = document.getElementById("montoTotal").value;
    var contactCheckBD = document.getElementById("contacto").checked;
    var profitCBD = document.getElementById("gananciaC").value;
    var profitEDB = document.getElementById("gananciaE").value;
    var profitGECDB = document.getElementById("gananciaGEC").value;
    var entryAmountDB = document.getElementById("montoEntrega").value;
    var priceNtDB = document.getElementById("gananciaNeta").value;
    var myDate = nowDay;
    var myContry = document.getElementById("pais").value;

    firebaseUpdate(colection, id, totalyPriceDB, contactCheckBD, profitCBD, profitEDB, profitGECDB, entryAmountDB, priceNtDB, myDate, myContry);
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

        var dia = document.getElementById("dia").value;
        var mes = document.getElementById("mes").value;
        var year = document.getElementById("year").value;
        var otroDia = document.getElementById("otroDia").value;

        var vueltasDias = otroDia - dia;
        p = 0;
        jk = 0;


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

            for (var i = 0; i < vueltasDias+1; i++) {

                dia = parseInt(dia);
                diaTotal = dia + i;
                var fullDate = diaTotal + "/" + mes + "/" + year;

                remittancesTable.innerHTML = "";

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


