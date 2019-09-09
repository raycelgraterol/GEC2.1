// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    console.log("Ejecucion inicial : " + new Date());
    exeEach();
});


setInterval(function () {
    console.log("Ejecucion : " + new Date());
    exeEach();
}, 15 * 60 * 1000);


function exeEach() {
    setTimeout(function () { exchangeRates.getSellAd(); }, 150 * 1000);
    setTimeout(function () { $("#refreshCO").trigger("click"); }, 1 * 1000);
    setTimeout(function () { $("#refreshPE").trigger("click"); }, 15 * 1000);
    setTimeout(function () { $("#refreshPEU").trigger("click"); }, 30 * 1000);
    setTimeout(function () { $("#refreshDO").trigger("click"); }, 45 * 1000);
    setTimeout(function () { $("#refreshCL").trigger("click"); }, 60 * 1000);
    setTimeout(function () { $("#refreshMX").trigger("click"); }, 75 * 1000);
    setTimeout(function () { $("#refreshPA").trigger("click"); }, 90 * 1000);
    setTimeout(function () { $("#refreshEC").trigger("click"); }, 105 * 1000);
    setTimeout(function () { $("#refreshES").trigger("click"); }, 120 * 1000);
    setTimeout(function () { $("#refreshAR").trigger("click"); }, 135 * 1000);
}


var exchangeRates = (function () {

    function getSellAd() {
        $.get("api/ExchangeRate/1", function (data) {
            $("#minAmountAbout").empty();
            $("#maxAmountAbout").empty();
            //Set
            $("#minAmountAbout").html(data.sellVe);
            $("#maxAmountAbout").html(data.sellVeHigh);
        });
    }

    function showCountryRate(countryCode, paymentMethod, currency, gain, idShow, isColombia = false) {
        var data = { "countryCode": countryCode, "paymentMethod": paymentMethod, "currency": currency, "gain": gain, "isColombia": isColombia };
        $("#" + idShow + "Loader").show();
        $.ajax({
            url: "api/ExchangeRate",
            type: 'POST',
            data: data,
            dataType: 'html',
            cache: false,
            success: function (data) {
                if (data !== "") {
                    var myObj = JSON.parse(data);
                    $("#" + idShow).html(myObj.rateFormat);
                    $("#" + idShow + "G").html(myObj.rateFormatGain);
                    $("#" + idShow + "H").html(myObj.rateFormatHigh);
                    $("#" + idShow + "Loader").hide();
                }
            }
        }).fail(function (data) {

        });
    }



    function clearSession() {
        $.get("api/ExchangeRate", function (data) {
            alert("Session clear." + data);
        });
    }

    function hideGain() {
        $(".rate-gain").hide();
        $(".showRate").hide();
        $(".showGain").show();
    }

    function showGain() {
        $(".rate-gain").show();
        $(".showRate").show();
        $(".showGain").hide();
    }


    return {
        getSellAd: getSellAd,
        showCountryRate: showCountryRate,
        clearSession: clearSession,
        hideGain: hideGain,
        showGain: showGain
    };
})();