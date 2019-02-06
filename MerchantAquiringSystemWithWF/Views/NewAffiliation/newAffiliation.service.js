(function () {
    'use strict';

    angular
        .module('map')
        .service('newAffiliationService', newAffiliationService);

    newAffiliationService.$inject = ['$http', 'GetRequestList'];

    function newAffiliationService($http,GetRequestList) {
        this.getRequestList = getRequestList;

        function getRequestList() {

            return $http.get(GetRequestList);
        }
    }
})();