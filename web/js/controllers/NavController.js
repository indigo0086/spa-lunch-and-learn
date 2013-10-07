angular.module("SpaApp.Controllers")
    .controller("NavController", ["$scope", "userName", function ($scope, userName) {
        $scope.isCollapsed = true;
        $scope.userName = userName;
        $scope.brandName = "Lunch-N-Learn";
        $scope.menuItems = [
            { title: "Groups", url: "#/Groups" },
            { title: "Events", url: "#/Events" },
            { title: "Places", url: "#/Places" }
        ]
    }]);