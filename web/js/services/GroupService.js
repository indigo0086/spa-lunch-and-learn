var module = angular.module("SpaApp.Services", ["ngResource"]);

module.factory("Groups", function ($resource, $http, $location) {
//    return $http.success("http://localhost:port/Groups", { port: ":8080"});
    $http.defaults.useXDomain = true;
    return $resource("http://" + $location.host() + ":port/Groups", { port: ":8080" })
});

module.factory("Group", function ($http) {
    return $http.success("http://localhost:port/Groups/:id/:name", { port: ":8080", id: "@id", name: "@name"})
});