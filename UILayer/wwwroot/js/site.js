$(document).ready(function () {
    $.ajax({
        url: 'product/ProductListByName',
        dataType: 'Json',
        success: function (data) {
                $("#tags").autocomplete({
                    source: data
                });
            
        }
    })
    /*$("#searchid").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: 'product/ProductListByName',
                headers: {
                    "RequestVerificationToken":
                        $('input[name="__RequestVerificationToken"]').val()
                },
                data: { "term": request.term },
                dataType: "json",
                success: function (data) {
                    console.log(data)
                    response($.map(data, function (item) {
                        return item;
                    }))
                },
                error: function (xhr, textStatus, error) {
                    alert(xhr.statusText);
                },
                failure: function (response) {
                    alert("failure " + response.responseText);
                }
            });
        },
        minLength: 2
    });*/
});
