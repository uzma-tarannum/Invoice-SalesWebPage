//(function () {
//    alert('ihhh')
//    app.controller('Invoice', function ($scope, $http) {
//        $scope.Invoice = new object();

//        var init = function () {
//            GetProducts();
//        };
//        init();

//        function GetProducts() {
//            $http.get('Invoice/GetAllProducts')
//                .then(function (response) {
//                    var data = response.data;
//                    $scope.ProductList
//                });
//        }
//    })
//}).call(angular)


$(document).ready(function () {
    onLoadCategories();
    onLoadProductBrands();
})
function onLoadCategories() {
    $.ajax({
        type: 'Get',
        url: 'GetAllCategories',
        success: function (res) {
            $("#CategoryCode").append($('<option value>- Select - </option>'))
            $.each(res, function (i, val) {
                
                $("#CategoryCode").append($('<option value>- Select - </option>').val(val.id).html(val.name));
            })

        }
    })
}

function onLoadProductBrands() {
    $.ajax({
        type: 'Get',
        url: 'GetallBrands',
        success: function (res) {
            $("#BrandCode").append($('<option value>- Select - </option>'))
            $.each(res, function (i, val) {
                debugger
                $("#BrandCode").append($('<option value>- Select - </option>').val(val.id).html(val.name));
            })

        }
    })
}