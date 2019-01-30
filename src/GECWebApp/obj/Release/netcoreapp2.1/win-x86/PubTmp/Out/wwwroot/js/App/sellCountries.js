// Write your JavaScript code.

var sellCountries = (function () {

    function showSellValues() {
        var data = $("form#SearchSell").serialize()
        $.ajax({
            url: '/ManagementChange/SearchSell',
            type: 'POST',
            data: data,
            cache: false,
            success: function (data) {
                if (data !== "") {
                    $("#sellResult").empty();
                    $("#sellResult").html(data);
                }
            }
        }).fail(function (data) {

        });
    }
    
    function clearSession() {
        alert("Test");
    }

    return {
        showSellValues: showSellValues,
        clearSession: clearSession
    };
})();