angular.module("SpaApp.Controllers")
    .controller("NavController", function ($scope) {
        $scope.brandName = "Lunch-N-Learn";
        $scope.menuItems = [
            { title: "Groups", url: "/Groups" },
            { title: "Events", url: "/Events" },
            { title: "Places", url: "/Places" }
        ]
    });