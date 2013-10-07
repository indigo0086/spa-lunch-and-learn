angular.module("SpaApp.Services", ["ngResource"]);
angular.module("SpaApp.Controllers", ["SpaApp.Services"]);

var app = angular.module("SpaApp", ["ngRoute", "SpaApp.Controllers"]);

//constants for username
app.constant("userId", "1");
app.constant("userName", "MonsterMash");

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "views/main.html",
            controller: "MainController"
        })
        .when("/Groups", {
            templateUrl: "views/groups.html",
            controller: "GroupsController"
        })
        .when("/Groups/:groupId", {
            templateUrl: "views/groupdetail.html",
            controller: "GroupDetailController"
        })
        .otherwise({ redirectTo: "/" });
});