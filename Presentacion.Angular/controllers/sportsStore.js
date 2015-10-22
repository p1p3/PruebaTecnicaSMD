angular.module("sportsStore")
.controller("sportsStoreCtrl", function ($scope) {
    $scope.data = {products:[{name:"Producto #1",description:"A product",category:"Category #1",price:100},
                             {name:"Producto #2",description:"A product",category:"Category #1",price:110},
                             {name:"Producto #3",description:"A product",category:"Category #2",price:210},
                             {name:"Producto #4",description:"A product",category:"Category #3",price:202}]};

});