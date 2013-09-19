angular.module("SpaApp.Controllers", []);

angular.module("SpaApp", ["ngRoute", "SpaApp.Controllers"])
    .config(function ($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "views/main.html",
                controller: "MainController"
            })
            .when("/Groups", {
                templateUrl: "views/groups.html",
                controller: "GroupsController"
            })
            .otherwise({ redirectTo: "/" });
    });