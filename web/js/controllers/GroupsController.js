angular.module("SpaApp.Controllers")
    .controller("GroupsController", function($scope, $location, Groups) {
        $scope.groups = Groups.query();
        $scope.goToGroup = function(id){
            var link = "Groups/" + id;
            $location.path(link);
        }
    });
