angular.module("SpaApp.Services")
    .factory("Stats", function($resource, $location){
        return $resource("http://" + $location.host() + ":port/Stats", { port: ":8080" })
    });