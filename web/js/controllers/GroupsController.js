angular.module("SpaApp.Controllers")
    .controller("GroupsController", function($scope, Groups) {
        $scope.groups = Groups.query();
    });
