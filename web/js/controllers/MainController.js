angular.module("SpaApp.Controllers")
    .controller("MainController", function ($scope, Stats) {
        $scope.stats = Stats.get();
    });
