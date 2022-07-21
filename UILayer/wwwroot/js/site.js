$(document).ready(function () {
    $.ajax({
        url: 'User/ProductListByName',
        type: 'get',
        success: function (data) {
            console.log(data)
            $('#searchid').autocomplete({
                source:data
            })
        }
    })
});
