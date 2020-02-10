var app1 = angular.module('app', ['ngRoute']);

app1.controller('MyController', function ($scope) {

    $scope.isVisible = false;

    $scope.openTable = function() {
        $scope.isVisible = true;
    }
});
