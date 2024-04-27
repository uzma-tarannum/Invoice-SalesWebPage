$(document).ready(function () {
    onLoadCutomerCategories();
    onLoadCustomerArea();
})
function onLoadCutomerCategories() {
    $.ajax({
        type: 'Get',
        url: 'GetAllCustomerCategory',
        success: function (res) {
            $("#CustomerCategoryCode").append($('<option value>- Select - </option>'))
            $.each(res, function (i, val) {

                $("#CustomerCategoryCode").append($('<option value>- Select - </option>').val(val.id).html(val.name));
            })

        }
    })
}

function onLoadCustomerArea() {
    $.ajax({
        type: 'Get',
        url: 'GetAllCustomerArea',
        success: function (res) {
            $("#AreaCode").append($('<option value>- Select - </option>'))
            $.each(res, function (i, val) {
                debugger
                $("#AreaCode").append($('<option value>- Select - </option>').val(val.id).html(val.name));
            })

        }
    })
}