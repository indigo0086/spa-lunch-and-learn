"use strict"
var appConfig = {
  basePath: "web"
};

var mountFolder = function (connect, dir) {
  return connect.static(require('path').resolve(dir));
};

var LIVERELOAD_PORT = 35729;
var lrSnippet = require('connect-livereload')({ port: LIVERELOAD_PORT });


module.exports = function (grunt) {
  require("load-grunt-tasks")(grunt);

  grunt.initConfig({
    app: appConfig,
    connect: {
      options: {
        port: 9000,
        hostname: "localhost"
      },
      livereload: {
        options: {
          middleware: function (connect) {
            return [
              lrSnippet,
              mountFolder(connect, appConfig.basePath)
            ];
          }
        }
      }
    },

    open: {
      server: {
        url: "http://localhost:<%= connect.options.port %>"
      }
    },

    watch: {
      livereload: {
        options: {
          livereload: LIVERELOAD_PORT
        },
        files: [
          "<%=app.basePath%>/js/**/*.js",
          "<%=app.basePath%>/*.html",
          "<%=app.basePath%>/views/**/*.html"
        ]
      }
    }
  });

  grunt.registerTask("default", ["connect:livereload", "open", "watch"]);
};