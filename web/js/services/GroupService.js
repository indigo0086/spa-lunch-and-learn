var module = angular.module("SpaApp.Services");

module.factory("Groups", function ($resource, $location) {
    return $resource("http://" + $location.host() + ":port/Groups", { port: ":8080" })
});

module.factory("Group", function ($resource, $location) {
    return $resource("http://" + $location.host() + ":port/Groups/:id", { port: ":8080", id: "@id"})
});