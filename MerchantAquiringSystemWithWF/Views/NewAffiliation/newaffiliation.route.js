(function () {
    'use strict';
    angular
       .module('map')
       .config(routerConfig);

    function routerConfig($stateProvider, $urlRouterProvider) {

        $stateProvider
            .state('create', {
                url: '/create',
                component: 'createComponent'
            }).state('index', {
                url: '/index',
                component: 'indexComponent'
               
            })


        $urlRouterProvider.otherwise('/index');
    }




})();