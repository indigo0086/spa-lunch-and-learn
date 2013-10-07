angular.module("SpaApp.Controllers")
    .controller("GroupDetailController", function($scope, $routeParams, Group) {
       $scope.group = Group.query($routeParams.groupId);
    });