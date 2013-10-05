angular.module("SpaApp.Services", []);
angular.module("SpaApp.Controllers", ["SpaApp.Services"]);

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