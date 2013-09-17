angular.module("SpaApp.Controllers", []);

angular.module("SpaApp", ["SpaApp.Controllers"])
    .config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: "views/main.html",
                controller: "MainController"
            })
            .otherwise({ redirectTo: '/' });
    });