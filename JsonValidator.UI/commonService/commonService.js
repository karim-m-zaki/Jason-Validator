(function () {
    'use strict'
    angular.module('commonService',
        ['ngResource'])
        .constant('appSettings', {
            serverPath: 'http://localhost:51125/api/'
        });
})();